using SLRD_ClientApp.Class_flies;
using SLRD_ClientApp.Controlers;
using SLRD_ClientApp.Properties;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLRD_ClientApp.Report
{
    public partial class ListOfTrainReport : Form
    {
        public HomeScreen hcs;

        public ListOfTrainReport(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }

        private void ListOfTrainReport_Load(object sender, EventArgs e)
        {
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
                    var trainList = JsonSerializer.Deserialize<List<TrainDetails>>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (trainList != null)
                    {
                        foreach (var train in trainList)
                        {
                            train.StatusMessage = train.IsActive ? "Train Active" : "Train Not Active";
                        }
                        SetupDataGridView();
                        dataGridView1.DataSource = trainList;
                        hcs.messageController("Train Info listing successful", "S");
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


        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrainId",
                HeaderText = "Train ID"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrainName",
                HeaderText = "Train Name"
            });
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "IsActive",
                HeaderText = "Is Active"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusMessage",
                HeaderText = "Status Message"
            });
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count >= 1)
            {
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                ToolStripMenuItem edit = new ToolStripMenuItem("Edit");
                contextMenu.Items.Add(edit);
                contextMenu.ItemClicked += new ToolStripItemClickedEventHandler(listBoxMenu_ItemClicked);
                dataGridView1.ContextMenuStrip = contextMenu;
            }
        }

        private void listBoxMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Text == "Edit")
                {
                    DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];

                    if (dataGridViewRow != null)
                    {
                        MakeTrain frm = new MakeTrain(hcs, Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString()));
                        frm.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
            }
        }
    }   
}
