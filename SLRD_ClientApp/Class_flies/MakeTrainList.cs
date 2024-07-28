using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRD_ClientApp.Class_flies
{
    internal class MakeTrainList
    {
        public string Token { get; set; }
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class TrainDetails
    {
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public bool IsActive { get; set; }
        public string StatusMessage { get; set; } 
    }
    public class TrainInfo
    {
        public int TrainId { get; set; }
        public string TrainName { get; set; }

        public override string ToString()
        {
            return $"{TrainId}::{TrainName}";
        }
    }

}
