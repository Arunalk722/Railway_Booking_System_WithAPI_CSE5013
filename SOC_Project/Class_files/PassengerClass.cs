namespace SOC_Project.Class_files
{
    public class PassengerClass
    {
    }
    public class PassengerListReqBody
    {
        public string Token { get; set; }
        public string NIC { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }

    }

    public class ListOfPassengers
    {
        public int SCode { get; set; }
        public string NIC { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public int RouteCount { get; set; }
        required public bool IsActive { get; set; }

    }
}
