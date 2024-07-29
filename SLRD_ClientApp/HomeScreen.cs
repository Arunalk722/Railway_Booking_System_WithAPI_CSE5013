using SLRD_ClientApp.Controlers;
using SLRD_ClientApp.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLRD_ClientApp.Properties
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        public void messageController(string text, string code)
        {
            code = code.ToUpper();
            if (code == "S")
            {
                errprvErrorMessage.Clear();
                errprvInfoMessage.Clear();
                lblMessage.Text = text;
                lblMessage.ForeColor = Color.Green;
                errprvSuccessMessage.SetError(lblMessage, text);
                errprvSuccessMessage.SetIconAlignment(lblMessage, ErrorIconAlignment.MiddleRight);
                //     LogWritter.messageLog(text, className, docId, "Notification");
            }
            else if (code == "I")
            {

                errprvSuccessMessage.Clear();
                errprvErrorMessage.Clear();
                lblMessage.Text = text;
                lblMessage.ForeColor = Color.Blue;
                errprvInfoMessage.SetError(lblMessage, text);
                errprvInfoMessage.SetIconAlignment(lblMessage, ErrorIconAlignment.MiddleRight);
                //  LogWritter.messageLog(text, className, docId, "Info");
            }
            else if (code == "E")
            {
                errprvSuccessMessage.Clear();
                errprvInfoMessage.Clear();
                lblMessage.Text = text;
                lblMessage.ForeColor = Color.Red;
                errprvErrorMessage.SetError(lblMessage, text);
                errprvErrorMessage.SetIconAlignment(lblMessage, ErrorIconAlignment.MiddleRight);
                //   LogWritter.messageLog(text, className, docId, "Error");

            }

        }
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            messageController($"{SystemFuntion.UserName} {SystemFuntion.UserId} {SystemFuntion.UserRoleID} {SystemFuntion.Email}", "S");
        }

        private void makeTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeTrain makeTrain = new MakeTrain(this, 0);
            makeTrain.MdiParent = this;
            makeTrain.Show();
        }

        private void makeRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeRoute frm = new MakeRoute(this, 0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void passengerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassengerRegistration frm = new PassengerRegistration(this, "0");
            frm.MdiParent = this;
            frm.Show();
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeBooking frm = new MakeBooking(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void bookingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfBookingInformation frm = new ListOfBookingInformation(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void trainReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfTrainReport frm = new ListOfTrainReport(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void routeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfRoute frm = new ListOfRoute(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void markTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketMarking  ticketMarking = new TicketMarking(this);
            ticketMarking.MdiParent = this;
            ticketMarking.Show();
        }
    }
}
