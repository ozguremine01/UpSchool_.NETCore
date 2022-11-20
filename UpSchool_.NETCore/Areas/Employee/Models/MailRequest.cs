namespace UpSchool_.NETCore.Areas.Employee.Models
{
    public class MailRequest
    {
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string ReceiverMail { get; set; }
        public string MailSubject { get; set; }
        public string MailContent { get; set; }
    }
}
