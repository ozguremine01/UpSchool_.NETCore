using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.DataAccessLayer.Abstract;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        //void ChangeEmployeeStatusToTrue(int id);
        //void ChangeEmployeeStatusToFalse(int id);
    }
}
