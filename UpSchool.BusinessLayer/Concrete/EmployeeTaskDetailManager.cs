using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.BusinessLayer.Abstract;
using UpSchool.DataAccessLayer.Abstract;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.BusinessLayer.Concrete
{
    public class EmployeeTaskDetailManager : IEmployeeTaskDetailService
    {
        private readonly IEmployeeTaskDetailDal _employee;

        public EmployeeTaskDetailManager(IEmployeeTaskDetailDal employee)
        {
            _employee = employee;
        }

        public void TDelete(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }

        public EmployeeTaskDetail TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Emploee> TGetEmployeesByCategory()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeTaskDetail> TGetEmployeeTaskDetailById(int id)
        {
            return _employee.GetEmployeeTaskDetailById(id);
        }

        public List<EmployeeTaskDetail> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(EmployeeTaskDetail t)
        {
            throw new NotImplementedException();
        }
    }
}
