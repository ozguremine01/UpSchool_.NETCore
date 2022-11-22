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
    public class EFAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public List<Announcement> ContainA()
        {
            using (var context = new Context())
            {
                var values = context.Announcements.Where(x => x.AnnouncementTitle.Contains("a")).ToList();
                return values;
            }
        }
    }
}
