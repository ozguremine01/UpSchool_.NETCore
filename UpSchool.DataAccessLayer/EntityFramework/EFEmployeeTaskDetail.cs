using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.DataAccessLayer.Abstract;
using UpSchool.DataAccessLayer.Repository;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.DataAccessLayer.EntityFramework
{
    public class EFEmployeeTaskDetail : GenericRepository<EmployeeTaskDetail>, IEmployeeTaskDetail
    {
        public void Delete(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTask> GetEmployeeTaskByEmployee()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTask> GetEmployeeTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public void Update(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        EmployeeTask IGenericDal<EmployeeTask>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<EmployeeTask> IGenericDal<EmployeeTask>.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
