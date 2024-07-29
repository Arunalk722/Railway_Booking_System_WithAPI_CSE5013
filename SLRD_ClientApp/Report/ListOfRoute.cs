using SLRD_ClientApp.Class_flies;
using SLRD_ClientApp.Controlers;
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

namespace SLRD_ClientApp.Report
{
    public partial class ListOfRoute : Form
    {
        public HomeScreen hcs;
        public ListOfRoute(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }

        private void ListOfRoute_Load(object sender, EventArgs e)
        {
            CallAPI();
        }
        private async Task CallAPI()
        {
            try
            {
                string url = $"/ViewAllRoute?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}";
                var responseBody = await APICalling.GetMethodCalling(url);

                if (responseBody != null)
                {
                    var trainRouteList = JsonSerializer.Deserialize<List<ListOfRoutes>>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (trainRouteList != null)
                    {
                        foreach (var routes in trainRouteList)
                        {
                            routes.StatusMessage = routes.IsActive ? "Route Active" : "Route Not Active";
                        }
                        SetupDataGridView();
                        dataGridView1.DataSource = trainRouteList;
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
                DataPropertyName = "RouteId",
                HeaderText = "Route ID"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrainID",
                HeaderText = "Train Id"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrainName",
                HeaderText = "Train Name"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SourLocation",
                HeaderText = "Start Location"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DestLocation",
                HeaderText = "Destination"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SchaduleTime",
                HeaderText = "Time"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserName",
                HeaderText = "Create User"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusMessage",
                HeaderText = "StatusMessage"
            });
            var isActiveColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "IsActive",
                HeaderText = "Is Active"
            };
            dataGridView1.Columns.Add(isActiveColumn);

            // Hiding the "Is Active" column
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
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
                        MakeRoute frm = new MakeRoute(hcs, Convert.ToInt32(dataGridViewRow.Cells[0].Value.ToString()));
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