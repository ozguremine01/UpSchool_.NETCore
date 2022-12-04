using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.DataAccessLayer.Concrete
{
    //: DbContext    IdentityDbContext
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        //Daha önce DbContext'ten kalıtım alınmıştı. Şimdi IdentityDbContext'den alındı.
        //Identity işlemi için
        //NormalizedName -> indekslemek için -> Hepsi büyük harfle yazılır. büyük küçük harfle uğraşmamak için
        //guide yada uniq öğren
        //Veritabanında şifreler hashlenerek tutulur.
        //Access değeri default olarak -> 5'tir. LockoutEnd -> Tekrar deneme yapabileceğin süre Lockout -> yanlış şifre girildiğinde hesap blokesi. 
        //JWT 'ye bak.
        //Authentication'a bak
        //Sosyal medya hesaplarıyla
        //DBFirst projesi
        //Repository design patternla geliştirilen projeyi tamamla
        //Sadece identity kütüphanesiyle kullanılacak uygulama yap -> Mesajlaşma uygulaması

        //Repository design pattern kullanarak proje yap.

        //Identity kütüphanesinde özelleştirmeler yapılacak o yüzden tekrar DBContext'ten miras alındı.
        //: IdentityDbContext<AppUser, AppRole,int>



        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Emploee> Emploees { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        
        public DbSet<EmployeeTaskDetail> EmployeeTaskDetails { get; set; } 
        public DbSet<Message> Messages { get; set; } 
        public DbSet<Announcement> Announcements { get; set; } 
        public DbSet<Supplier> Suppliers { get; set; } 
        public DbSet<Contact> Contacts { get; set; } 

        //override

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=*******;database=DbCoreCRM1; integrated security=true");

        }
    }
            
        
}
