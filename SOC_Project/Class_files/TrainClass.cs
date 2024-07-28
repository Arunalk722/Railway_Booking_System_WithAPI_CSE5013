namespace SOC_Project.Class_files
{
    public class TrainClass
    {
    }
    public class MakeTrainList
    {
        public string Token { get; set; }
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class TrainList
    {
        public int SCode { get; set; }
        public int TrainId { get; set; }
        public string TrainName { get; set; }
        public bool IsActive { get; set; }

    }
}
