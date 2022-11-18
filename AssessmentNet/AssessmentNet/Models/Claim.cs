namespace AssessmentNet.Models
{
    public class Claim
    { 
        public int Id { get; set; }
        public string descripcion { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }
        public int idVehicle { get; set; }
    }
}
