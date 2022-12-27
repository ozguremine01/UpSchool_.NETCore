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
    public class EFEmployeeTaskDetailDal : GenericRepository<EmployeeTaskDetail>, IEmployeeTaskDetailDal
    {
        //public void Delete(EmployeeTask t)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<EmployeeTask> GetEmployeeTaskByEmployee()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<EmployeeTask> GetEmployeeTaskById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public List<EmployeeTaskDetail> GetEmployeeTaskDetailById(int id)
        {
            using (var context = new Context())
            {
                return context.EmployeeTaskDetails.Where(x => x.EmployeeTaskDetailID == id).ToList();
            }
        }

        //public void Insert(EmployeeTask t)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(EmployeeTask t)
        //{
        //    throw new NotImplementedException();
        //}

        
    }
}
