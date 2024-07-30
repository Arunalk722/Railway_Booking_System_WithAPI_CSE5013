using SLRD_ClientApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;
using SLRD_ClientApp.Class_flies;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Drawing.Printing;
namespace SLRD_ClientApp.Controlers
{
    public partial class MakeBooking : Form
    {
        public HomeScreen hcs;
        static HttpClient client = new HttpClient();
        public MakeBooking(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }
        string srcLoc;string destLoc;
        int setNo;
        string ticketNo;
        string bookTime;
        void callApi()
        {
            client.BaseAddress = new Uri("");
        }
        private void MakeBooking_Load(object sender, EventArgs e)
        {
            hcs.messageController("", "S");
            DisableSeat();
            EnableSeat(10);
            _ = dropDownList();
        }
        private async Task dropDownList()
        {
            try
            {
                string url = $"/ViewAllRoute?Token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}";
                var responseBody = await APICalling.GetMethodCalling(url);

                if (responseBody != null)
                {
                    var routeInfo = JsonSerializer.Deserialize<List<RouteInfoWithTrainId>>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (routeInfo != null)
                    {
                        foreach (var train in routeInfo)
                        {
                            RouteInfoWithTrainId trainInfo = new RouteInfoWithTrainId
                            {
                                RouteId = train.RouteId,
                                DestLocation = train.DestLocation,
                                SourLocation = train.SourLocation,
                                TrainId = train.TrainId,
                                TrainName = train.TrainName,
                                SchaduleTime=train.SchaduleTime,
                            };

                            cmbRoute.Items.Add(trainInfo);
                        }
                    }
                }
                else
                {
                    hcs.messageController("Failed to get route information", "E");
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
        private void cmbRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoute.SelectedItem is RouteInfoWithTrainId selectedRoute)
            {
                txtTrainName.Text = selectedRoute.TrainName;
                lblTrainId.Text = selectedRoute.TrainId.ToString();
                lblRouteId.Text = selectedRoute.RouteId.ToString();
                srcLoc = selectedRoute.SourLocation;
                destLoc = selectedRoute.DestLocation;
                bookTime = selectedRoute.SchaduleTime;
                _ = getSeatInfo();
            }
        }

        void DisableSeat()
        {
            btnS1.Enabled = false;
            btnS2.Enabled = false;
            btnS3.Enabled = false;
            btnS4.Enabled = false;
            btnS5.Enabled = false;
            btnS6.Enabled = false;
            btnS7.Enabled = false;
            btnS8.Enabled = false;
            btnS9.Enabled = false;
            btnS10.Enabled = false;
            btnS11.Enabled = false;
            btnS12.Enabled = false;
            btnS13.Enabled = false;
            btnS14.Enabled = false;
            btnS15.Enabled = false;
            btnS16.Enabled = false;
            btnS17.Enabled = false;
            btnS18.Enabled = false;
            btnS19.Enabled = false;
            btnS20.Enabled = false;
            btnS21.Enabled = false;
        }
        void enableAllSeats()
        {
            btnS1.Enabled = true;
            btnS2.Enabled = true;
            btnS3.Enabled = true;
            btnS4.Enabled = true;
            btnS5.Enabled = true;
            btnS6.Enabled = true;
            btnS7.Enabled = true;
            btnS8.Enabled = true;
            btnS9.Enabled = true;
            btnS10.Enabled = true;
            btnS11.Enabled = true;
            btnS12.Enabled = true;
            btnS13.Enabled = true;
            btnS14.Enabled = true;
            btnS15.Enabled = true;
            btnS16.Enabled = true;
            btnS17.Enabled = true;
            btnS18.Enabled = true;
            btnS19.Enabled = true;
            btnS20.Enabled = true;
            btnS21.Enabled = true;
        }
        void EnableSeat(int seatNo)
        {
            switch (seatNo)
            {
                case 1: btnS1.Enabled = false; break;
                case 2: btnS2.Enabled = false; break;
                case 3: btnS3.Enabled = false; break;
                case 4: btnS4.Enabled = false; break;
                case 5: btnS5.Enabled = false; break;
                case 6: btnS6.Enabled = false; break;
                case 7: btnS7.Enabled = false; break;
                case 8: btnS8.Enabled = false; break;
                case 9: btnS9.Enabled = false; break;
                case 10: btnS10.Enabled = false; break;
                case 11: btnS11.Enabled = false; break;
                case 12: btnS12.Enabled = false; break;
                case 13: btnS13.Enabled = false; break;
                case 14: btnS14.Enabled = false; break;
                case 15: btnS15.Enabled = false; break;
                case 16: btnS16.Enabled = false; break;
                case 17: btnS17.Enabled = false; break;
                case 18: btnS18.Enabled = false; break;
                case 19: btnS19.Enabled = false; break;
                case 20: btnS20.Enabled = false; break;
                case 21: btnS21.Enabled = false; break;
                default: hcs.messageController($"Unknown seat number: {seatNo}", "E"); break;
            }
        }

        void disableSeat(int seatNo)
        {
            switch (seatNo)
            {
                case 1: btnS1.Enabled = false; break;
                case 2: btnS2.Enabled = false; break;
                case 3: btnS3.Enabled = false; break;
                case 4: btnS4.Enabled = false; break;
                case 5: btnS5.Enabled = false; break;
                case 6: btnS6.Enabled = false; break;
                case 7: btnS7.Enabled = false; break;
                case 8: btnS8.Enabled = false; break;
                case 9: btnS9.Enabled = false; break;
                case 10: btnS10.Enabled = false; break;
                case 11: btnS11.Enabled = false; break;
                case 12: btnS12.Enabled = false; break;
                case 13: btnS13.Enabled = false; break;
                case 14: btnS14.Enabled = false; break;
                case 15: btnS15.Enabled = false; break;
                case 16: btnS16.Enabled = false; break;
                case 17: btnS17.Enabled = false; break;
                case 18: btnS18.Enabled = false; break;
                case 19: btnS19.Enabled = false; break;
                case 20: btnS20.Enabled = false; break;
                case 21: btnS21.Enabled = false; break;
                default: hcs.messageController($"Unknown seat number: {seatNo}", "E"); break;
            }
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            _ = getSeatInfo();
        }

        private void dtPickDate_ValueChanged(object sender, EventArgs e)
        {
            _ = getSeatInfo();
        }
        private async Task getSeatInfo()
        {
            try
            {
                DisableSeat();
                enableAllSeats();
                string url = $"/GetBookedSeatNo?Token={System.Web.HttpUtility.UrlEncode(SystemFuntion.Token)}&trainID={lblTrainId.Text}&routeID={lblRouteId.Text}&bookingDate={dtPickDate.Text}";
                var responseBody = await APICalling.GetMethodCalling(url);

                if (responseBody != null)
                {
                    groupBox3.Enabled = true;
                    var seatInfo = JsonSerializer.Deserialize<List<SeatNoListing>>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    if (seatInfo != null)
                    {
                        foreach (var seat in seatInfo)
                        {
                            EnableSeat(seat.BookSeatNo);
                        }
                    }
                    hcs.messageController("Already booked seats disable and other seat will enable", "S");
                }
                else
                {
                    hcs.messageController("Failed to get booking information", "E");
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

        private async void makeNewBooking(int sNumber)
        {
            try
            {
                TraingBookingReqBody make = new TraingBookingReqBody
                {
                    Token = SystemFuntion.Token,
                    BookDate = dtPickDate.Text,
                    BookSeatNo = sNumber,
                    NIC = txtNIC.Text,
                    PasengerName = txtName.Text,
                    RouteID = Convert.ToInt32(lblRouteId.Text),
                    TrainID = Convert.ToInt32(lblTrainId.Text),
                };

                var responseBody = await APICalling.PostMethodCalling("/MakeBooking", make);
                if (responseBody != null)
                {
                    using (JsonDocument doc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = doc.RootElement;
                        int sCode = Convert.ToInt16(root.GetProperty("sCode").GetInt16());
                        hcs.messageController($"{root.GetProperty("sMessage")}", sCode == 200 ? "S" : "I");
                        if (sCode == 200)
                        {
                            disableSeat(sNumber);
                            ticketNo = root.GetProperty("tktNo").ToString();
                            setNo= sNumber;
                            printPreviewDialog1.Document = printDocument1;
                            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("SIZE", 380, 300);
                            printPreviewDialog1.ShowDialog();
                        }
                    }
                }
                else
                {
                    hcs.messageController("An error occurred while making the booking.", "E");
                }

            }
            catch (Exception ex)
            {
                hcs.messageController(ex.Message, "E");

            }
        }
        void validateInput(int sNumber)
        {
            if (txtNIC.Text.Length < 10)
            {
                hcs.messageController("Please add NIC", "I");
            }
            else if (txtName.Text.Length < 5)
            {
                hcs.messageController("Please add Name", "I");
            }
            else if (!int.TryParse(lblRouteId.Text, out int res1))
            {
                hcs.messageController("Please select route", "I");
            }
            else if (!int.TryParse(lblTrainId.Text, out int res2))
            {
                hcs.messageController("Please select route", "I");

            }
            else
            {
                makeNewBooking(sNumber);
            }
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            validateInput(1);
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            validateInput(2);
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            validateInput(3);
        }
        private void btnS4_Click(object sender, EventArgs e)
        {
            validateInput(4);
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            validateInput(5);
        }

        private void btnS6_Click(object sender, EventArgs e)
        {
            validateInput(6);
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            validateInput(7);
        }

        private void btnS8_Click(object sender, EventArgs e)
        {
            validateInput(8);
        }

        private void btnS9_Click(object sender, EventArgs e)
        {
            validateInput(9);
        }

        private void btnS10_Click(object sender, EventArgs e)
        {
            validateInput(10);
        }

        private void btnS11_Click(object sender, EventArgs e)
        {
            validateInput(11);
        }

        private void btnS12_Click(object sender, EventArgs e)
        {
            validateInput(12);
        }

        private void btnS13_Click(object sender, EventArgs e)
        {
            validateInput(13);
        }

        private void btnS14_Click(object sender, EventArgs e)
        {
            validateInput(14);
        }

        private void btnS15_Click(object sender, EventArgs e)
        {
            validateInput(15);
        }

        private void btnS16_Click(object sender, EventArgs e)
        {
            validateInput(16);
        }

        private void btnS17_Click(object sender, EventArgs e)
        {
            validateInput(17);
        }

        private void btnS18_Click(object sender, EventArgs e)
        {
            validateInput(18);
        }

        private void btnS19_Click(object sender, EventArgs e)
        {
            validateInput(19);
        }

        private void btnS20_Click(object sender, EventArgs e)
        {
            validateInput(20);
        }

        private void btnS21_Click(object sender, EventArgs e)
        {
            validateInput(21);
        }

       


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                string fontName = "Arial";
                int headerFontSize = 14;
                int titleFontSize = 18;
                int bodyFontSize = 12;
                int footerFontSize = 10;              
                string currentTime = DateTime.Now.ToString();
                        

                // Ticket Header
                e.Graphics.DrawString("Train Ticket", new Font(fontName, titleFontSize, FontStyle.Bold), Brushes.Black, new PointF(10, 20)); // Adjusted Y position
                e.Graphics.DrawString($"Ticket No: {ticketNo}", new Font(fontName, headerFontSize, FontStyle.Regular), Brushes.Black, new PointF(10, 80));
                e.Graphics.DrawString($"Book Date: {dtPickDate.Text}", new Font(fontName, headerFontSize, FontStyle.Regular), Brushes.Black, new PointF(10, 100));
                e.Graphics.DrawString($"Book Time: {bookTime}", new Font(fontName, headerFontSize, FontStyle.Regular), Brushes.Black, new PointF(10, 120));               
                e.Graphics.DrawString($"Train: {txtTrainName.Text}", new Font(fontName, bodyFontSize, FontStyle.Regular), Brushes.Black, new PointF(10, 140));
                e.Graphics.DrawString($"Passenger: {txtName.Text}", new Font(fontName, bodyFontSize, FontStyle.Regular), Brushes.Black, new PointF(10, 160));
                e.Graphics.DrawString($"From: {srcLoc}", new Font(fontName, bodyFontSize, FontStyle.Regular), Brushes.Black, new PointF(10, 180));
                e.Graphics.DrawString($"To: {destLoc}", new Font(fontName, bodyFontSize, FontStyle.Regular), Brushes.Black, new PointF(10, 200));
                e.Graphics.DrawString($"Seat No: {setNo}", new Font(fontName, bodyFontSize, FontStyle.Regular), Brushes.Black, new PointF(10, 220));

                // QR Code Image
                Bitmap qrCode = TicketBarcodeCreator.GenerateCode128Barcode(ticketNo);
                if (qrCode != null)
                {
                    e.Graphics.DrawImage(qrCode, new Rectangle(200, 10, 150, 70));
                }

                // Footer
                e.Graphics.DrawString($"Thank you for traveling with us!\n{currentTime}", new Font(fontName, footerFontSize, FontStyle.Italic), Brushes.Black, new PointF(10, 240));
            }
            catch (Exception ex)
            {
                LogToText.ExceptionLog(ex);
            }
        }

    }
}
