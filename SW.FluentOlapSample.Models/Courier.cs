using SW.FluentOlap.AnalyticalNode;

namespace SW.FluentOlapSample.Models
{
    // Domain model
    public class Courier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public ContactInformation Contact { get; set; }
    }
}