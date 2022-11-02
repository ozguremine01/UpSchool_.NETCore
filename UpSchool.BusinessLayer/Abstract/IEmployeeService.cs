using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.DataAccessLayer.Abstract;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.BusinessLayer.Abstract
{
    public class IEmployeeService : IGenericService<EntityLayer.Concrete.Emploee>
    {
        public void TDelete(Emploee t)
        {
            throw new NotImplementedException();
        }

        public Emploee TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Emploee> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Emploee t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Emploee t)
        {
            throw new NotImplementedException();
        }
        public List<Emploee> TGetEmploeeBy(Emploee t)
        {
            throw new NotImplementedException();
        }

        public object TGetEmploeeBy()
        {
            throw new NotImplementedException();
        }
    }
}
