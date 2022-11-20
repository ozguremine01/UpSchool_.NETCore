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
    public class EmployeeTaskManagercs : IEmployeeTaskService
    {
        private readonly IEmployeeTaskDal _employeeTaskDal;

        public EmployeeTaskManagercs(IEmployeeTaskDal employeeTaskDal)
        {
            _employeeTaskDal = employeeTaskDal;
        }

        public List<EmployeeTask> TGetEmployeeTaskByEmployee()
        {
            return _employeeTaskDal.GetEmployeeTaskByEmployee();
        }

        public List<EmployeeTask> TGetEmployeeTaskById(int id)
        {
            return _employeeTaskDal.GetEmployeeTaskById(id);
        }

        public void TDelete(EmployeeTask t)
        {
            _employeeTaskDal.Delete(t);
        }

        public EmployeeTask TGetByID(int id)
        {
            return _employeeTaskDal.GetByID(id);
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
            _employeeTaskDal.Insert(t);
        }

        public void TUpdate(EmployeeTask t)
        {
            _employeeTaskDal.Update(t);
        }
    }
}
