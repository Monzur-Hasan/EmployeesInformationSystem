using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesInformationSystem.Model.Model
{
    public class District
    {
        public District()
        {
            Employees = new List<Employee>();
        }
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}