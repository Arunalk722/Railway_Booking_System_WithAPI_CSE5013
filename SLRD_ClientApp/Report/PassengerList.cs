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

namespace SLRD_ClientApp.Report
{
    public partial class PassengerList : Form
    {
        public HomeScreen hcs;
        public PassengerList(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }

        private void PassengerList_Load(object sender, EventArgs e)
        {
            _ = CallAPI();
        }
        private async Task CallAPI()
        {
            try
            {
                string url = $"/ViewAllPassengersList?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}";
                var responseBody = await APICalling.GetMethodCalling(url);

                if (responseBody != null)
                {
                    var datas = JsonSerializer.Deserialize<List<Passengers>>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (datas != null)
                    {
                        foreach (var dataRows in datas)
                        {
                            dataRows.StatusMessage = dataRows.IsActive ? "Passengers is Active" : "Passengers Not Active";
                        }
                        SetupDataGridView();
                        dataGridView1.DataSource = datas;
                        hcs.messageController("Passengers listing successful", "S");
                    }
                }
                else
                {
                    hcs.messageController("Failed to get Passengers information", "E");
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
                DataPropertyName = "NIC",
                HeaderText = "NIC"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Full Name"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PhoneNo",
                HeaderText = "Phone No"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EmailAddress",
                HeaderText = "Email Address"
            });
            var isActiveColumn = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "IsActive",
                HeaderText = "Is Active"
            };
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusMessage",
                HeaderText = "Status Message"
            });
            dataGridView1.Columns.Add(isActiveColumn);
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
        }
    }
}
