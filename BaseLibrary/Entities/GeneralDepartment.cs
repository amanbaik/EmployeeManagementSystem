

namespace BaseLibrary.Entities
{
    public class GeneralDepartment : BaseEntity
    {
        //One to many relationship withDepartment
        public List<Department>? Departments { get; set; }
    }
}
