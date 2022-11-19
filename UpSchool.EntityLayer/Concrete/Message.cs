using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpSchool.EntityLayer.Concrete
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
        public string ReceiverName { get; set; }
        public string RecevierMail { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public DateTime Date { get; set; }
    }
}
