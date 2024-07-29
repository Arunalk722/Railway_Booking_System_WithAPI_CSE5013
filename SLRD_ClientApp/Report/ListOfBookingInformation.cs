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
    public partial class ListOfBookingInformation : Form
    {
        public HomeScreen hcs;
        public ListOfBookingInformation(HomeScreen home)
        {
            InitializeComponent();
            home = hcs;
        }

        private void ListOfBookingInformation_Load(object sender, EventArgs e)
        {
            CallAPI();

        }
        private async Task CallAPI()
        {
            try
            {
                string url = $"/GetListOfBooking?token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}";
                var responseBody = await APICalling.GetMethodCalling(url);

                if (responseBody != null)
                {
                    var bookingLists = JsonSerializer.Deserialize<List<BookingDetails>>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (bookingLists != null)
                    {
                        foreach (var bookingDt in bookingLists)
                        {
                            bookingDt.StatusMessage = bookingDt.BookingIsActive ? "Booking Active" : "Booking Not Active";
                            bookingDt.TicketID = bookingDt.BookingID.ToString("D5");
                        }
                        SetupDataGridView();
                        dataGridView1.DataSource = bookingLists;
                        //  hcs.messageController("Train Info listing successful", "S");
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
            var bookingID = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "BookingID",
                HeaderText = "Booking ID"
            };
            dataGridView1.Columns.Add(bookingID);
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TicketID",
                HeaderText = "Ticket"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TraindID",
                HeaderText = "Traind ID"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RouteID",
                HeaderText = "Route ID"
            }); 
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PassengerNIC",
                HeaderText = "NIC"
            }); 
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PasengerName",
                HeaderText = "Pasenger Name"
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
           
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Full Name"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookDate",
                HeaderText = "Book Date"
            }); 
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookSeatNo",
                HeaderText = "Book Seat No"
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
                HeaderText = "Schadule Time"


            });
            var bookRecordTime = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "BookRecordTime",
                HeaderText = "BookRecord Time"
            };
            dataGridView1.Columns.Add(bookRecordTime);
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;



            var bookingIsActive = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "BookingIsActive",
                HeaderText = "BookingIsActive"
            };
            dataGridView1.Columns.Add(bookingIsActive);
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
          
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IsTraveled",
                HeaderText = "Is traveld"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PassengerIsActive",
                HeaderText = "PassengerIsActive"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrainIsActive",
                HeaderText = "TrainIsActive"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrainCreatedDate",
                HeaderText = "TrainCreatedDate"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TrainCreatedUser",
                HeaderText = "TrainCreatedUser"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RouteCreatedDate",
                HeaderText = "RouteCreatedDate"
            });


            var routeIsActive = new DataGridViewCheckBoxColumn
            {
                DataPropertyName = "RouteIsActive",
                HeaderText = "RouteIsActive"
            };
            dataGridView1.Columns.Add(routeIsActive);
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;
            
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusMessage",
                HeaderText = "Status Message"
            });
        }
    }
}