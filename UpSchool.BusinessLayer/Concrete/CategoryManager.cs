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
    public class CategoryManager : ICategoryService
    {
        ICategory _category;

        public CategoryManager(ICategory category)
        {
            _category = category;
        }

        public void TDelete(Category t)
        {
           _category.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return _category.GetByID(id);
        }

        public List<Category> TGetList()
        //public List<Category> TGetList()
        {
            //return _category.GetList(t);
            return _category.GetList();
        }

        public void TInsert(Category t)
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

        public void TUpdate(Category t)
        {
            _category.Update(t);
        }
    }
}
