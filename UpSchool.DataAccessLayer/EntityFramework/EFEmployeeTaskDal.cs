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
    public class EFEmployeeTaskDal:GenericRepository<EmployeeTask>, IEmployeeTaskDal
    {
        
public List<EmployeeTask> GetEmployeeTaskByEmployee()
        {
            using (var context = new Context())
            {
                //EmployeeTaskID
                var values = context.EmployeeTasks.Include(x=>x.EmployeeTaskID).ToList();
                return values;
            }
        }

        public List<EmployeeTask> GetEmployeeTaskById(int id)
        {
            using (var context = new Context())
            {
                var values = context.EmployeeTasks.Where(x => x.AppUser.Id == id).ToList();
                return values;
            }
        }
    }
}
