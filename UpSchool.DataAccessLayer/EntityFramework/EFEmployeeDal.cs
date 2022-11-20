using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.DataAccessLayer.Abstract;
using UpSchool.DataAccessLayer.Concrete;
using UpSchool.DataAccessLayer.Repository;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.DataAccessLayer.EntityFramework
{
    public class EFEmployeeDal : GenericRepository<Emploee>, IEmployeeDal
    {
        
        public void ChangeEmployeeStatusToFalse(int id)
        {
            using (var context = new Context())
            {
                var values = context.Emploees.Find(id);
                values.EmployeeStatus = false;
                context.SaveChanges();
            }
        }

        public void ChangeEmployeeStatusToTrue(int id)
        {
            using (var context = new Context())
            {
                var values = context.Emploees.Find(id);
                values.EmployeeStatus = true;
                context.SaveChanges();
            }
        }

        public List<Emploee> GetEmploeesByCategory()
        {
            using (var context = new Context())
            {
                return context.Emploees.Include(x => x.Category).ToList();

            }
        }
        
        
    }
}

