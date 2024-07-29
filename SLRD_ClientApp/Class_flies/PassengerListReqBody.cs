using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRD_ClientApp.Class_flies
{
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
