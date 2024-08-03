using SLRD_ClientApp.Class_flies;
using SLRD_ClientApp.Properties;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows.Forms;

namespace SLRD_ClientApp
{
    public partial class LoginClient : Form
    {
        HttpClient client = new HttpClient();
        public LoginClient()
        {
            InitializeComponent();
            InitializeHttpClient();
        }
        private void InitializeHttpClient()
        {
            client.BaseAddress = new Uri(SystemFuntion.ApiURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (createToken())
            {
                isLoginSuccesful();
            }
          
     
        }

        bool createToken()
        {
            WebTokenRequestModel request = new WebTokenRequestModel
            {
                userIP = "127.0.0.1",
                tokenKey = "424693eb479b9953",
                tokenHash = "0049dA87db8945aq",
                userName = "ExampleUserName",
                userGUID = Guid.NewGuid().ToString(),
                requestTime = DateTime.Now.AddDays(1),
            };
            return TokenCreat.CreateTokenKey(request);
        }
        async void isLoginSuccesful()
        {
            try
            {
                LoginClass user = new LoginClass
                {
                    Pwd=txtPwd.Text,
                    Token=SystemFuntion.Token,
                    UserName=txtUserName.Text,
                };               
                var response = await client.PostAsJsonAsync("/UserAuthLogin", user);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();             
                using (JsonDocument rep = JsonDocument.Parse(responseBody))
                {
                    JsonElement root = rep.RootElement;
                   
                  if(Convert.ToInt32(root.GetProperty("sCode").GetUInt32()) == 200)
                    {
                        SystemFuntion.Email = root.GetProperty("email").ToString();
                        SystemFuntion.UserName = root.GetProperty("userName").ToString();
                       SystemFuntion.UserId = Convert.ToInt32(root.GetProperty("userId").GetUInt32());
                        SystemFuntion.UserRole = root.GetProperty("userRole").ToString();
                        SystemFuntion.UserRoleID = Convert.ToInt32(root.GetProperty("userRoleID").GetUInt32());


                        HomeScreen homeScreen = new HomeScreen();
                        homeScreen.Show();
                        this.Hide();
                    }
                    else
                    {

                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               

            }
        
        }

    }


    
}
