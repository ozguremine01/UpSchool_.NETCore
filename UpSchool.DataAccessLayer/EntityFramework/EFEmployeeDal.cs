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
    public class EFEmployeeDal : GenericRepository<Emploee>, IEmployee
    {
        public List<Emploee> GetEmploeesByCategory()
        {
            using (var context = new Context())
            {
                return context.Emploees.Include(x => x.Category).ToList();

            }
        }
    }
       
    }
}
