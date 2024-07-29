using SLRD_ClientApp.Class_flies;
using SLRD_ClientApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLRD_ClientApp.Controlers
{
    public partial class PassengerRegistration : Form
    {
        public HomeScreen hcs;
        public string NicNumber;
        public PassengerRegistration(HomeScreen home, string nic)
        {
            InitializeComponent();
            hcs = home;
            NicNumber = nic;
        }

        private void MakePassengers_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validate();
        }
        bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                return regex.IsMatch(email);
            }
            catch (Exception)
            {
                return false;
            }
        }
        void validate()
        {
            if (txtNic.Text.Length <= 9)
            {
                hcs.messageController("Please check NIC", "I");
            }
            else if (txtName.Text.Length <= 5)
            {
                hcs.messageController("Please check name", "I");

            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                hcs.messageController("Please check email address", "I");
            }
            else if (txtPhoneNo.Text.Length  <=9)
            {
                hcs.messageController("Please check phone number", "I");
            }
            else
            {
                insertData();
            }
        }
        async void insertData()
        {

            try
            {
                PassengerListReqBody make = new PassengerListReqBody
                {
                    Token = SystemFuntion.Token,
                    EmailAddress = txtEmail.Text,
                    FullName = txtName.Text,
                    NIC = txtNic.Text,
                    PhoneNo = txtPhoneNo.Text,
                };

                var responseBody = await APICalling.PostMethodCalling("/CreatePassenger", make);
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
                    hcs.messageController("An error occurred while creating the Passenger.", "E");
                }
            }
            catch (Exception ex) { }
        }

        private async void deletePassenger()
        {
            try
            {
                string url = $"/DeletePasssenger?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}&nic={txtNic.Text}";

                string responseBody = await APICalling.DeleteMethodCalling(url);

                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        if (Convert.ToInt16(root.GetProperty("sCode").GetInt16()) == 200)
                        {
                            txtEmail.Text = "";
                            txtName.Text = "";
                            txtNic.Text = "";
                            txtPhoneNo.Text = "";

                            hcs.messageController(root.GetProperty("sMessage").ToString(), "S");
                        }
                        else
                        {
                            hcs.messageController("Error Deleting Passenger", "I");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNic.Text.Length >= 9)
            {
                deletePassenger();
            }
        }
    }
}