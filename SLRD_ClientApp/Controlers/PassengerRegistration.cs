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

namespace SLRD_ClientApp.Controlers
{
    public partial class PassengerRegistration : Form
    {
        public HomeScreen hcs;
        public PassengerRegistration(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }

        private void MakePassengers_Load(object sender, EventArgs e)
        {

        }
    }
}
