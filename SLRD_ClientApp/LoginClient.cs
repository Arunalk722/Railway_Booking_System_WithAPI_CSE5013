using SLRD_ClientApp.Properties;

namespace SLRD_ClientApp
{
    public partial class LoginClient : Form
    {
        public LoginClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }
    }
}
