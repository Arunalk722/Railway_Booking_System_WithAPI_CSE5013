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
    public partial class MakeRoute : Form
    {
        public HomeScreen hcs;
        public MakeRoute(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }

        private void MakeRoute_Load(object sender, EventArgs e)
        {

        }
    }
}
