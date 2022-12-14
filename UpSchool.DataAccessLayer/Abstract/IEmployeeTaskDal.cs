using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.DataAccessLayer.Abstract
{
    public interface IEmployeeTaskDal: IGenericDal<EmployeeTask>
    {
        List<EmployeeTask> GetEmployeeTaskByEmployee();
        List<EmployeeTask> GetEmployeeTaskById(int id);
    }
}
