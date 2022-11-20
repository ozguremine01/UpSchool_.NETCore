using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchool.EntityLayer.Concrete
{
    public class EmployeeTask
    {
        [Key]
        public int EmployeeTaskID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        //public int EmployeeID { get; set; }
        //public Emploee Emploee { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public List<EmployeeTask> EmployeeTasks { get; set; }
    }
}
