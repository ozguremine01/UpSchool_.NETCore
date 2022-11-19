using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.DataAccessLayer.Abstract
{
    public interface IEmployee : IGenericDal<Emploee>
    {
        List<Emploee> GetEmploeesByCategory();
        void ChangeEmployeeStatusToTrue(int id);
        void ChangeEmployeeStatusToFalse(int id); 
    }
}
