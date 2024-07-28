namespace SOC_Project.Class_files
{
    public class SeatClass
    {
    }
    public class TakedSeatList
    {
        public int sCode { get; set; }
        public int BookSeatNo { get; set; }
    }
    public class CheckLocationRBody
    {
        public string Token { get; set; }
        public int TrainID { get; set; }
        public int RouteID { get; set; }
        public DateOnly BookingDate { get; set; }
    }
}
