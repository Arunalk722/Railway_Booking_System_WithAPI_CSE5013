namespace SOC_Project.FunctionFiles
{
    public class StatusMessage
    {
        public  int SCode { get; set; }
        public  string SMessage { get; set;}
    }
    public class StatusMessageBooking
    {
        public int SCode { get; set; }
        public string SMessage { get; set; }
        public string TktNo {  get; set; } 
    }
}
