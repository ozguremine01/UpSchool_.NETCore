using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchool.DataAccessLayer.Abstract
{
    public interface IGenericService<T>
    {
        /// <summary>
        /// Veri ekleme
        /// </summary>
        /// <param name="t"></param>
        void TInsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
