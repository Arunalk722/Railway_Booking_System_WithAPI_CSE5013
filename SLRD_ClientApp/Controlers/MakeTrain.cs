using SLRD_ClientApp.Class_flies;
using SLRD_ClientApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLRD_ClientApp.Controlers
{
    public partial class MakeTrain : Form
    {

        public HomeScreen hcs;
        public int trainId = 0;
        public MakeTrain(HomeScreen home, int id)
        {
            InitializeComponent();
            hcs = home;
            trainId = id;
        }
        private void MakeTrain_Load(object sender, EventArgs e)
        {
            if (trainId != 0)
            {
                txtTrainId.Text = trainId.ToString();
                getTrainDetails();
            }
        }
        private async void getTrainDetails()
        {
            try
            {
                string url = $"/ViewOneTrain?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}&TrainId={trainId}";
                string responseBody = await APICalling.GetMethodCalling(url);
                hcs.messageController(url, "S");
                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        if (Convert.ToInt16(root.GetProperty("sCode").GetInt16()) == 200)
                        {
                            txtTrainName.Text = root.GetProperty("trainName").ToString();
                            chkIsActive.Checked = Convert.ToBoolean(root.GetProperty("isActive").GetBoolean());
                            int trainIds = Convert.ToInt16(root.GetProperty("trainId").GetInt16());
                            txtTrainId.Text = trainIds.ToString();
                            trainId = trainIds;
                            hcs.messageController("Train Info finding successful", "S");
                        }
                        else
                        {
                            txtTrainId.Text = "";
                            txtTrainName.Text = "";
                            chkIsActive.Checked = false;
                            hcs.messageController("Error finding train result", "I");
                        }
                    }
                }
                else
                {
                    hcs.messageController("Error: No response from server.", "E");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
        async void insertTrain()
        {

            try
            {
                MakeTrainList make = new MakeTrainList
                {
                    Token = SystemFuntion.Token,
                    CreatedDate = DateTime.Now,
                    IsActive = chkIsActive.Checked,
                    TrainId = 0,
                    TrainName = txtTrainName.Text,
                };

                var responseBody = await APICalling.PostMethodCalling("/CreateTrain", make);
                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        int sCode = Convert.ToInt16(root.GetProperty("sCode").GetInt16());
                        hcs.messageController($"{root.GetProperty("sMessage").ToString()}", sCode == 200 ? "S" : "I");
                    }
                }
                else
                {
                    hcs.messageController("An error occurred while creating the train.", "E");
                }
            }
            catch (Exception ex) { }
        }
        async void updateTrain()
        {

            try
            {
                MakeTrainList make = new MakeTrainList
                {
                    Token = SystemFuntion.Token,
                    CreatedDate = DateTime.Now,
                    IsActive = chkIsActive.Checked,
                    TrainId = Convert.ToInt32(txtTrainId.Text),
                    TrainName = txtTrainName.Text,
                };

                var responseBody = await APICalling.PutMethodCalling("/UpdateTrain", make);
                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        int sCode = Convert.ToInt16(root.GetProperty("sCode").GetInt16());
                        hcs.messageController($"{root.GetProperty("sMessage").ToString()}", sCode == 200 ? "S" : "I");
                        if (sCode == 200)
                        {
                            txtTrainId.Text = "";
                            txtTrainName.Text = "";
                            trainId = 0;
                            chkIsActive.Checked = false;
                        }
                    }
                }
                else
                {
                    hcs.messageController("An error occurred while updating the train.", "E");
                }

            }
            catch (Exception ex)
            {
                hcs.messageController(ex.Message, "E");

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (trainId == 0)
            {
                if (txtTrainName.Text.Length > 2) {
                if (MessageBox.Show("do you confirm to insert new train", "Add new Train", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    insertTrain();
                }
                else
                {
                    hcs.messageController("not confirm to insert new train", "I");
                 }
                }
                else
                {
                    hcs.messageController("please provide valid name for train.", "I");
                }
            }
            else
            {
                if(int.TryParse(txtTrainId.Text,out int res)&&txtTrainName.Text.Length>2)
                {
                    if (MessageBox.Show($"do you confirm to update train Id {trainId}", "Add new Train", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        updateTrain();
                    }
                    else
                    {
                        hcs.messageController($"not confirm to  update train Id {trainId}", "I");
                    }
                }
                else
                {
                    hcs.messageController("please check train id and train name", "I");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTrainId.Text,out int res))
            {
                if (MessageBox.Show("You'd you like to remove selected train from database?", "Delete Train", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteTrain();
                }
                else
                {
                    hcs.messageController($"not confirm to  delete train Id {trainId}", "I");
                }
            }
            else { hcs.messageController("please check train id", "I"); }
        }
        private async void deleteTrain()
        {
            try
            {
                string url = $"/DeleteTrain?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}&TrainId={txtTrainId.Text}";

                string responseBody = await APICalling.DeleteMethodCalling(url);

                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        if (Convert.ToInt16(root.GetProperty("sCode").GetInt16()) == 200)
                        {
                            txtTrainId.Text = "";
                            txtTrainName.Text = "";
                            chkIsActive.Checked = false;
                           

                            hcs.messageController(root.GetProperty("sMessage").ToString(), "S");
                        }
                        else
                        {
                            hcs.messageController("Error Deleting train", "I");
                        }
                    }
                }
                else
                {
                    hcs.messageController("Error: No response from server.", "E");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
        private void txtTrainId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!int.TryParse(txtTrainId.Text,out int res))
                {
                    hcs.messageController("make sure train Id should be a number", "I");
                }
                else
                {
                    getTrainDetails();
                }
                e.Handled = true;
            }
        }
    }

}
