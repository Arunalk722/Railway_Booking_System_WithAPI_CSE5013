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
    public partial class TicketMarking : Form
    {
        public HomeScreen hcs;
        public TicketMarking(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }

        private void TicketMarking_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getTrainDetails();
        }

        private async void getTrainDetails()
        {
            try
            {
                string url = $"/BookingConfirm?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}&bookingID={Convert.ToInt64(txtTktNo.Text)}";
                string responseBody = await APICalling.GetMethodCalling(url);              
                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        if (Convert.ToInt16(root.GetProperty("sCode").GetInt16()) == 200)
                        {
                            hcs.messageController("Ticket Marking successful", "S");
                        }
                        else
                        {
                            hcs.messageController("Error in Ticket marking", "I");
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
