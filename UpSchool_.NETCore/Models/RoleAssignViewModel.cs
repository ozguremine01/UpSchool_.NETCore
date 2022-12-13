namespace UpSchool_.NETCore.Models
{
    public class RoleAssignViewModel
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        //Kullanıcının rolü var mı? Yok mu?
        public bool Exists { get; set; }
    }
}
