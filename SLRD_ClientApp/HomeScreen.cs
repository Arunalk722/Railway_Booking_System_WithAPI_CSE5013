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
        public void messageController(string text, string code, string className, string docId)
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
        }
    }
}
