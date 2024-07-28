namespace SOC_Project.Class_files
{
    public class TrainRouteClass
    {
    }
    public class TrainRoute
    {
        public string Token { get; set; }
        public int TrainId { get; set; }
        public string SourLocatin { get; set; }
        public string DestLocation { get; set; }
        public DateTime SchaduleTime { get; set; }
        public int CreatedUser { get; set; }
        public bool IsActive { get; set; }
    }

    public class ListOfRoutes
    {
        public int SCode { get; set; }
        public int RouteId { get; set; }
        public int TrainID { get; set; }
        public string SourLocation { get; set; }
        public string DestLocation { get; set; }
        public string SchaduleTime { get; set; }
        public string UserName { get; set; }
        public bool IsActive { get; set; }
     
    }
}
