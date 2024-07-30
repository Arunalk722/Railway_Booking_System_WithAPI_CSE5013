using SLRD_ClientApp.Class_flies;
using SLRD_ClientApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLRD_ClientApp.Controlers
{
    public partial class MakeRoute : Form
    {
        public HomeScreen hcs;
        public int routeId;
        public MakeRoute(HomeScreen home, int id)
        {
            InitializeComponent();
            hcs = home;
            routeId = id;
        }

        private void MakeRoute_Load(object sender, EventArgs e)
        {
            if (routeId != 0)
            {
                txtRouteId.Text = routeId.ToString();
                getRouteDetails(routeId);
            }
            else
            {

                txtRouteId.Text = "";
            }
            _ = CallAPI();

        }

        private async Task CallAPI()
        {
            try
            {
                string url = $"/ViewAllTrain?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}";
                var responseBody = await APICalling.GetMethodCalling(url);

                if (responseBody != null)
                {
                    var trainList = JsonSerializer.Deserialize<List<TrainInfo>>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (trainList != null)
                    {
                        foreach (var train in trainList)
                        {
                            TrainInfo trainInfo = new TrainInfo
                            {
                                TrainId = train.TrainId,
                                TrainName = train.TrainName
                            };

                            cmbTrainName.Items.Add(trainInfo);
                        }
                    }
                }
                else
                {
                    hcs.messageController("Failed to get train information", "E");
                }
            }
            catch (HttpRequestException e)
            {
                hcs.messageController("Error: " + e.Message, "E");
            }
            catch (Exception ex)
            {
                hcs.messageController("An unexpected error occurred: " + ex.Message, "E");
            }
        }

        private void cmbTrainName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrainName.SelectedItem is TrainInfo selectedTrain)
            {
                int trainId = selectedTrain.TrainId;
                string trainName = selectedTrain.TrainName;
                lblTrainID.Text = trainId.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (routeId != 0)
            {
                if (txtDestination.Text.Length > 2 && txtSource.Text.Length > 2 && int.TryParse(lblTrainID.Text, out int resu))
                {
                    if (MessageBox.Show($"do you confirm to update train Route Id {routeId}", "update Train Route", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        updateRoute();
                    }
                    else
                    {
                        hcs.messageController($"not confirm to  update train Route Id {routeId}", "I");
                    }
                }
                else
                {
                    hcs.messageController("please check train id and train name", "I");
                }
            }
            else
            {
                if (txtDestination.Text.Length > 2 && txtSource.Text.Length > 2)
                {
                    if (MessageBox.Show("do you confirm to insert new route", "Add new route", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        insertRoute();
                    }
                    else
                    {
                        hcs.messageController("not confirm to insert new route", "I");
                    }
                }
                else
                {
                    hcs.messageController("please provide valid name for train.", "I");
                }
            }
        }

        private async void updateRoute()
        {
            try
            {

                TrainRoute make = new TrainRoute
                {
                    Token = SystemFuntion.Token,
                    CreatedUser = SystemFuntion.UserId,
                    DestLocation = txtDestination.Text,
                    SourLocatin = txtSource.Text,
                    SchaduleTime = dtSchaduleTime.Text,
                    TrainId = Convert.ToInt32(lblTrainID.Text),
                    IsActive = chkIsActive.Checked,
                };
                string callURL = $"/UpdateRoute?routeId={routeId}";
                var responseBody = await APICalling.PutMethodCalling(callURL, make);

                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        int sCode = root.GetProperty("sCode").GetInt16();
                        hcs.messageController($"{root.GetProperty("sMessage")}", sCode == 200 ? "S" : "I");
                        if (sCode == 200)
                        {
                            txtRouteId.Text = "";
                            txtDestination.Text = "";
                            txtSource.Text = "";
                            cmbTrainName.SelectedIndex = 0;
                            lblTrainID.Text = "";
                            chkIsActive.Checked = false;
                            routeId = 0;
                        }
                    }
                }
                else
                {
                    hcs.messageController("An error occurred while updating the train route.", "E");
                }
            }
            catch (Exception ex)
            {
                hcs.messageController(ex.Message, "E");
            }
        }


        private async void insertRoute()
        {
            try
            {
                TrainRoute make = new TrainRoute
                {
                    Token = SystemFuntion.Token,
                    CreatedUser = SystemFuntion.UserId,
                    DestLocation = txtDestination.Text,
                    SourLocatin = txtSource.Text,
                    SchaduleTime = dtSchaduleTime.Text,
                    TrainId = Convert.ToInt32(lblTrainID.Text),
                    IsActive = chkIsActive.Checked,
                };

                var responseBody = await APICalling.PostMethodCalling("/CreateRoute", make);
                MessageBox.Show(responseBody.ToString());
                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        int sCode = Convert.ToInt16(root.GetProperty("sCode").GetInt16());
                        hcs.messageController($"{root.GetProperty("sMessage").ToString()}", sCode == 200 ? "S" : "I");
                        if (sCode == 200)
                        {
                            txtDestination.Text = "";
                            txtSource.Text = "";
                            lblTrainID.Text = "";
                            chkIsActive.Checked = false;

                        }
                    }
                }
                else
                {
                    hcs.messageController("An error occurred while updating the train route.", "E");
                }

            }
            catch (Exception ex)
            {
                hcs.messageController(ex.Message, "E");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRouteId.Text, out int resu))
            {
                if (MessageBox.Show("You'd you like to remove selected train from database?", "Delete Train", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteTrain();
                }
                else
                {
                    hcs.messageController($"not confirm to  delete train Id {resu}", "I");
                }
            }
            else { hcs.messageController("please check train id", "I"); }
        }
        private async void deleteTrain()
        {
            try
            {
                string url = $"/DeleteRoute?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}&RouteId={routeId}";

                string responseBody = await APICalling.DeleteMethodCalling(url);

                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        if (Convert.ToInt16(root.GetProperty("sCode").GetInt16()) == 200)
                        {
                            txtRouteId.Text = "";
                            txtDestination.Text = "";
                            txtSource.Text = "";
                            cmbTrainName.SelectedIndex = 0;
                            lblTrainID.Text = "";
                            chkIsActive.Checked = false;
                            routeId = 0;
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

        private void txtRouteId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(int.TryParse(txtRouteId.Text, out routeId))
                {
                    getRouteDetails(routeId);
                }
                e.Handled = true;
            }
        }

        private async void getRouteDetails(int routeIds)
        {
            try
            {
                string url = $"/ViewOneRoute?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}&routeID={routeIds}";
                string responseBody = await APICalling.GetMethodCalling(url);
                hcs.messageController(url, "S");
                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        if (Convert.ToInt16(root.GetProperty("sCode").GetInt16()) == 200)
                        {               
                        
                            txtDestination.Text = root.GetProperty("destLocation").ToString();
                            txtSource.Text = root.GetProperty("sourLocation").ToString();
                            cmbTrainName.SelectedText = root.GetProperty("trainName").ToString();
                            lblTrainID.Text = root.GetProperty("trainID").ToString();
                            chkIsActive.Checked = Convert.ToBoolean(root.GetProperty("isActive").ToString());
                           
                            hcs.messageController("route Info finding successful", "S");
                        }
                        else
                        {
                            txtRouteId.Text = "";
                            txtDestination.Text = "";
                            txtSource.Text = "";
                            cmbTrainName.SelectedIndex = 0;
                            lblTrainID.Text = "";
                            chkIsActive.Checked = false;
                            routeId = 0;
                            hcs.messageController("Error finding route result", "I");
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
    }
}
