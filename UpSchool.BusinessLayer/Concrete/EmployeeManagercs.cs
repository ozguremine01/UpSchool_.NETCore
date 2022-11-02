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
    public class EmployeeManagercs:IEmployeeService
    {
        IEmployee _category;

        public EmployeeManagercs(IEmployee category)
        {
            _category = category;
        }

        public void Delete(Emploee t)
        {
            _category.Delete(t);
        }

        public Emploee GetByID(int id)
        {
            return _category.GetByID(id);
        }

        public List<Emploee> GetList()
        //public List<Category> TGetList()
        {
            //return _category.GetList(t);
            return _category.GetList();
        }

        public void Insert(Emploee t)
        {
            //if(t.CategoryName !=null && t.CategoryName.Length >=5 && t.CategoryDescription.StartsWith("A"))
            //{
            //    _category.Insert(t);
            //}
            //else
            //{

            //}
            _category.Insert(t);
        }

        public void Update(Emploee t)
        {
            _category.Update(t);
        }
    }
}
