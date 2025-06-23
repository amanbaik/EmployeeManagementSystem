
namespace BaseLibrary.Entities
{
    public class Town : BaseEntity
    {
        // Many to one relationship with City
        public List<Employee>? Employees { get; set; }
        public City? City { get; set; }
        public int CityId { get; set; }

        // One to many relationship with Employee
    }
}

