using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRD_ClientApp.Class_flies
{
    public class CheckLocation
    {
        public string Token { get; set; }
        public int TrainID { get; set; }
        public int RouteID { get; set; }
        public DateOnly BookingDate { get; set; }
    }
}
