using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRD_ClientApp.Class_flies
{
    public class BookingDetails
    {
        public int BookingID { get; set; }
        public int TraindID { get; set; }
        public int RouteID { get; set; }
        public string PassengerNIC { get; set; }
        public string PasengerName { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public int RouteCount { get; set; }
        public string FullName { get; set; }
        public DateTime BookDate { get; set; }
        public int BookSeatNo { get; set; }
        public string TrainName { get; set; }
        public string SourLocation { get; set; }
        public string DestLocation { get; set; }
        public TimeSpan SchaduleTime { get; set; }
        public DateTime BookRecordTime { get; set; }
        public bool BookingIsActive { get; set; }
        public bool IsTraveled { get; set; }
        public bool PassengerIsActive { get; set; }
        public bool TrainIsActive { get; set; }
        public DateTime TrainCreatedDate { get; set; }
        public string TrainCreatedUser { get; set; }
        public DateTime RouteCreatedDate { get; set; }
        public bool RouteIsActive { get; set; }
       public  string StatusMessage { get; set; }
    }
}
