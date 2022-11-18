namespace AssessmentNet.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string brand { get; set; }
        public string vin { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public int ownerId { get; set; }

    }
}
