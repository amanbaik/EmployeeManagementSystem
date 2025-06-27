
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class Town : BaseEntity
    {
        // Many to one relationship with City
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
        public City? City { get; set; }
        public int CityId { get; set; }

        // One to many relationship with Employee
    }
}

