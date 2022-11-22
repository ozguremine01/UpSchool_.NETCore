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
    
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcement;

        public AnnouncementManager(IAnnouncementDal announcement)
        {
            _announcement = announcement;
        }

        public void TDelete(Announcement t)
        {
            _announcement.Delete(t);
        }

        public Announcement TGetByID(int id)
        {
            return _announcement.GetByID(id);
        }

        public List<Emploee> TGetEmployeesByCategory()
        {
            throw new NotImplementedException();
        }

        public List<Announcement> TGetList()
        {
            return _announcement.GetList();
        }

        public void TInsert(Announcement t)
        {
            _announcement.Insert(t);
        }

        public void TUpdate(Announcement t)
        {
            _announcement.Update(t);
        }
    }
}
