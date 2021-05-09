using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesInformationSystem.Model.Model;
using EmployeesInformationSystem.Repository.Repository;

namespace EmployeesInformationSystem.BLL.BLL
{
    public class DistrictManager
    {
        DistrictRepository _districtRepository = new DistrictRepository();

        public bool Add(District _district)
        {
            return _districtRepository.Add(_district);
        }
        public bool Delete(District _district)
        {
            return _districtRepository.Delete(_district);
        }
        public bool Update(District _district)
        {
            return _districtRepository.Update(_district);
        }

        public List<District> GetAllDistricts()
        {
            return _districtRepository.GetAllDistricts();
        }
        public District GetByID(District District)
        {
            return _districtRepository.GetByID(District);
        }

    }
}
