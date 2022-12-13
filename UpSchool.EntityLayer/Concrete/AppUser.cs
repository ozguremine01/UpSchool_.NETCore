using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchool.EntityLayer.Concrete
{
    //ASP.Net Users tablosuna karşılık gelecek
    public class AppUser: IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }
        public string LoginCharacter { get; set; }
    }
}
