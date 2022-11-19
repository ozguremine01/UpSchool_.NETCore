using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.BusinessLayer.Concrete
{
    public class EmployeeTaskDetailManager : IEmployeeTaskService
    {
        private readonly IEmployeeTaskService _employeeTaskService; 
        public List<EmployeeTask> GetEmployeeTaskByEmployee()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTask> GetEmployeeTaskById(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTask TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Emploee> TGetEmployeesByCategory()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTask> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(EmployeeTask t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EmployeeTask t)
        {
            throw new NotImplementedException();
        }
    }
}
