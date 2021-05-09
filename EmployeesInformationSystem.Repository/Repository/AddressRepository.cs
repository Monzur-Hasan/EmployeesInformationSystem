using EmployeesInformationSystem.DatabaseContext.DatabaseContext;
using EmployeesInformationSystem.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesInformationSystem.Repository.Repository
{
    public class AddressRepository
    {
        EmployeeDbContext _dbContext = new EmployeeDbContext();
        public bool Add(Address address)
        {
            int isExecuted = 0;
            _dbContext.Addresses.Add(address);
            isExecuted = _dbContext.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(Address address)
        {
            int isExecuted = 0;
            _dbContext.Entry(address).State = EntityState.Modified;
            isExecuted = _dbContext.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(Address address)
        {
            int isExecuted = 0;
            Address aAddress = _dbContext.Addresses.FirstOrDefault(c => c.Id == address.Id);
            _dbContext.Addresses.Remove(aAddress);

            isExecuted = _dbContext.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public List<Address> GetAllAddresses()
        {
            return _dbContext.Addresses.ToList();
        }

        public Address GetById(Address address)
        {
           Address aAddress = _dbContext.Addresses.FirstOrDefault(c => c.Id == address.Id);
           return aAddress;
        }
    }
}
