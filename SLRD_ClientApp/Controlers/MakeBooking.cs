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
namespace SLRD_ClientApp.Controlers
{
    public partial class MakeBooking : Form
    {
        public HomeScreen hcs;
        static HttpClient client=new HttpClient();
        public MakeBooking(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
        }
        void callApi()
        {
            client.BaseAddress = new Uri("");
        }
        private void MakeBooking_Load(object sender, EventArgs e)
        {
            hcs.messageController("", "S");
            DisableSeat();
            EnableSeat(10);
            EnableSeat(5);
            EnableSeat(20);
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
          
            
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
        void EnableSeat(int seatNo)
        {
            if (seatNo == 1)
            {
                btnS1.Enabled = true;
            }
            if (seatNo == 2)
            {
                btnS2.Enabled = true;

            }
            if (seatNo == 3)
            {
                btnS3.Enabled = true;
            }
            if (seatNo == 4)
            {
                btnS4.Enabled = true;

            }
            if (seatNo == 5)
            {

                btnS5.Enabled = true;
            }
            if (seatNo == 6)
            {
                btnS6.Enabled = true;
            }
            if (seatNo == 7)
            {
                btnS7.Enabled = true;
            }
            if (seatNo == 8)
            {
                btnS8.Enabled = true;

            }
            if (seatNo == 9)
            {
                btnS9.Enabled = true;
            }
            if (seatNo == 10)
            {
                btnS10.Enabled = true;
            }
            if (seatNo == 11)
            {
                btnS11.Enabled = true;
            }
            if (seatNo == 12)
            {
                btnS12.Enabled = true;
            }
            if (seatNo == 13)
            {
                btnS13.Enabled = true;
            }
            if (seatNo == 14)
            {
                btnS14.Enabled = true;
            }
            if (seatNo == 15)
            {
                btnS15.Enabled = true;
            }
            if (seatNo == 16)
            {
                btnS16.Enabled = true;
            }
            if (seatNo == 17)
            {
                btnS17.Enabled = true;
            }
            if (seatNo == 18)
            {
                btnS18.Enabled = true;
            }
            if (seatNo == 19)
            {
                btnS19.Enabled = true;
            }
            if (seatNo == 20)
            {
                btnS20.Enabled = true;
            }
            if (seatNo == 21)
            {
                btnS21.Enabled = true;

            }

        }
    }
}
