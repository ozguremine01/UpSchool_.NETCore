using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.BusinessLayer.Abstract
{
    public interface IEmployeeTaskService : IGenericService<EmployeeTask>
    {
        List<EmployeeTask> GetEmployeeTaskByEmployee();
        List<EmployeeTask> GetEmployeeTaskById(int id);
    }
}
