using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesInformationSystem.Model.Model;
using EmployeesInformationSystem.Repository.Repository;

namespace EmployeesInformationSystem.BLL.BLL
{
    public class AddressManager
    {
        AddressRepository _addressRepository = new AddressRepository();
        public bool Add(Address address)
        {
            return _addressRepository.Add(address);
        }

        public bool Update(Address address)
        {
            return _addressRepository.Update(address);
        }

        public bool Delete(Address address)
        {
            return _addressRepository.Delete(address);
        }

        public List<Address> GetAllAddresses()
        {
            return _addressRepository.GetAllAddresses();
        }

        public Address GetById(Address address)
        {
            return _addressRepository.GetById(address);
        }
    }
}
