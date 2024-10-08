﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLRD_ClientApp.Class_flies
{
    internal class TrainRoutes
    {
    }
    public class TrainRoute
    {
        public string Token { get; set; }
        public int TrainId { get; set; }
        public string SourLocatin { get; set; }
        public string DestLocation { get; set; }
        public string SchaduleTime { get; set; }
        public int CreatedUser { get; set; }
        public bool IsActive { get; set; }
    }

    public class ListOfRoutes
    {
     //   public int SCode { get; set; }
        public int RouteId { get; set; }
        public int TrainID { get; set; }
        public string TrainName { get; set; }
        public string SourLocation { get; set; }
        public string DestLocation { get; set; }
        public string SchaduleTime { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public string StatusMessage {  get; set; }
     
    }


    public class RouteInfoWithTrainId
    {
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public int RouteId { get; set; }
        public string SourLocation { get; set; }
        public string DestLocation { get; set; }
        public string SchaduleTime { get; set; }
        public override string ToString()
        {
            return $"{SourLocation}-{DestLocation}{RouteId}:{TrainId}:{TrainName}:{SchaduleTime}";
        }
    }

}
