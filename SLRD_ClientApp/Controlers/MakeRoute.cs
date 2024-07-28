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
         //   int trainIDOnly = Convert.ToInt16(txtRouteId.Text);
            if (routeId != 0)
            {
                if (txtDestination.Text.Length > 2 && txtSource.Text.Length > 2 && lblTrainID.Text.Length > 1)
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
                    SchaduleTime = DateTime.Now,
                    TrainId = Convert.ToInt32(lblTrainID.Text),
                    IsActive = chkIsActive.Checked,
                };

                var responseBody = await APICalling.PutMethodCalling($"/UpdateRoute?routeId={routeId}", make);

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
                    hcs.messageController("An error occurred while updating route train.", "E");
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
                    SchaduleTime = DateTime.Now,
                    TrainId = Convert.ToInt32(lblTrainID.Text),
                    IsActive = chkIsActive.Checked,
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
            insertRoute();
        }
    }
}
