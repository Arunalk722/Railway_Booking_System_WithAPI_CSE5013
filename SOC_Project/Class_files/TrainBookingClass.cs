namespace SOC_Project.Class_files
{
    public class TrainBookingClass
    {
    }
    public class TraingBookingReqBody
    {
        public string Token { get; set; }
        public int TrainID { get; set; }
        public int RouteID { get; set; }
        public string NIC { get; set; }
        public string PasengerName { get; set; }
        public DateOnly BookDate { get; set; }
        public int BookSeatNo { get; set; }
    }
    public class TraingBookingList
    {
        public int BookingID { get; set; }
        public int SCode { get; set; }
        public int TrainID { get; set; }
        public int RouteID { get; set; }
        public string NIC { get; set; }
        public string PasengerName { get; set; }
        public DateOnly BookDate { get; set; }
        public int BookSeatNo { get; set; }
    }
}
