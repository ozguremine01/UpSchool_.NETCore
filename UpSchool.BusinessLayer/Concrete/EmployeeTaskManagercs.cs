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
    public class EmployeeTaskManagercs : IGenericService<EmployeeTask>
    {
        DataAccessLayer.Abstract.IEmployeeTaskDetail _employeeTaskDal;

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
            return _employeeTaskDal.GetList();
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
