using SLRD_ClientApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLRD_ClientApp.Controlers
{
    public partial class MakeTrain : Form
    {
        static HttpClient client = new HttpClient();
        public HomeScreen hcs;
        public MakeTrain(HomeScreen home)
        {
            InitializeComponent();
            hcs = home;
            InitializeHttpClient();
        }

        private void MakeTrain_Load(object sender, EventArgs e)
        {

        }

        private void InitializeHttpClient()
        {
            client.BaseAddress = new Uri(SystemFuntion.ApiURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        async void insertTrain()
        {
           
            try
            {
                MakeTrainList make = new MakeTrainList
                {
                    Token=SystemFuntion.Token,
                    CreatedDate=DateTime.Now,
                    IsActive=true,
                    TrainId=0,
                    TrainName=txtTrainName.Text,
                };
                var response = await client.PostAsJsonAsync("/CreateTrain", make);
                response.EnsureSuccessStatusCode();
                var responseBody=await response.Content.ReadAsStringAsync();
                
                using (JsonDocument doc = JsonDocument.Parse(responseBody))
                {
                    JsonElement root = doc.RootElement;
                    string sMessage = root.GetProperty("sMessage").ToString();
                    MessageBox.Show($"{sMessage}");
                }
            }
            catch (Exception ex) { }
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertTrain();
        }
    }
    public class MakeTrainList
    {
        public string Token { get; set; }
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
