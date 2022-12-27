using System.ComponentModel.DataAnnotations;

namespace UpSchool_.NETCore.Models
{
    public class RoleViewModel
    {

        //[Required()]
        [Required(ErrorMessage = "Lütfen boş geçmeyeniz")]
        public string RoleName { get; set; }
    }
}
