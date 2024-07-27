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

namespace SLRD_ClientApp.Report
{
    public partial class ListOfTrainReport : Form
    {
        public HomeScreen hcs;
        public ListOfTrainReport(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }

        private void ListOfTrainReport_Load(object sender, EventArgs e)
        {

        }
    }
}
