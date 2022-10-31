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
    public class ProductManager:IProductService
    {
        IProductService _category;

        public ProductManager(IProductService category)
        {
            _category = category;
        }

        public void TDelete(Product t)
        {
            return _category.Delete(t);
        }

        public Category TGetByID(int id)
        {
            return _category.GetByID(t);
        }

        public List<Category> TGetList(Product t)
        {
            return _category.GetList(t);
        }

        public void TInsert(Product t)
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

        public void TUpdate(Product t)
        {
            return _category.Update(t);
        }

    }
}
