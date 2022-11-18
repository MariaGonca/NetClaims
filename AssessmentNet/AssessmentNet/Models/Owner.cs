using System.ComponentModel.DataAnnotations;

namespace AssessmentNet.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string driverLicense { get; set; }
    }
}
