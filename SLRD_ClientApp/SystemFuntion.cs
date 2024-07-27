using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRD_ClientApp
{
    internal class SystemFuntion
    {
        public static string ApiURL = "https://localhost:7121/";
        public static string Token = "SMd/TxSOGdDzRk6rT4G8WvQXvc4NQnbaQJTtk7MXZrrsxybAbpEm7MHK4r8VyAjwuVixBTjIPtwt2SKn1WtfywByqyW0uVMA0hGH/FbFT6zSB75KmZBjA0WcCnf3jP9PDO69It9Fr8DMZzRF9EgN70uGYRktrGNUxLjyUQc4wmSUF4CYQw0yikCQfO/c+sY5GA6EvRT+fTlT+7Hw0PSilxf/BDd242Mq0v7HZwI+WlnB2g7FQp/wLsvaiXcPbIrvNjJrCSbFOVJ+xMBm8+YRX/aMCDJYMIsjhlHCYAdo7PuNkKn8Ap7ethHCZFFTLR6P";


        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Email { get; set; }
        public static string UserRole { get; set; }
        public static int UserRoleID { get; set; }

    }
}
