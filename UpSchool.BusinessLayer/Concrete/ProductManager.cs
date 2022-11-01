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
        IProduct _product;

        public ProductManager(IProduct product)
        {
           _product = product;
        }

        public void TDelete(Product t)
        {
            _product.Delete(t);
        }

        public Product TGetByID(int id)
        {
            return _product.GetByID(id);
        }

        public List<Product> TGetList()
        {
            return _product.GetList();
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
            _product.Insert(t);
        }

        public void TUpdate(Product t)
        {
             _product.Update(t);
        }

    }
}
