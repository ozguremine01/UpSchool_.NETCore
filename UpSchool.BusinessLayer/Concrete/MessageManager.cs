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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Emploee> TGetEmployeesByCategory()
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
