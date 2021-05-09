using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeesInformationSystem.DatabaseContext.DatabaseContext;
using EmployeesInformationSystem.Model.Model;

namespace EmployeesInformationSystem.Repository.Repository
{
    public class DistrictRepository
    {
        EmployeeDbContext _dbContext = new EmployeeDbContext();
        public bool Add(District district)
        {
            _dbContext.Districts.Add(district);
            int rowAffected = _dbContext.SaveChanges();
            if (rowAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(District district)
        {
            //Student std = db.Students.Where(c => c.ID == 1).FirstOrDefault();
            District dist = _dbContext.Districts.FirstOrDefault(c => c.Id== district.Id);
            _dbContext.Districts.Remove(dist);
            int rowAffected = _dbContext.SaveChanges();
            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }
        public bool Update(District district)
        {
            //Method 1
            //Student std = db.Students.Where(c => c.ID == student.ID).FirstOrDefault();
            //Student std = db.Students.FirstOrDefault(c => c.ID == student.ID);
            //if (student != null)
            //{
            //    student.Name = student.Name;
            //}

            //Method 2
            _dbContext.Entry(district).State = EntityState.Modified;

            int rowAffected = _dbContext.SaveChanges();
            if (rowAffected > 0)
            {
                return true;
            }
            return false;
        }

        public List<District> GetAllDistricts()
        {

            return _dbContext.Districts.ToList();
        }
        public District GetByID(District district)
        {

            //Student std = db.Students.Where(c => c.ID == student.ID).FirstOrDefault();
            District dst = _dbContext.Districts.FirstOrDefault(c => c.Id == district.Id);
            return dst;
        }
    }
}
