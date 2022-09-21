using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
namespace MailController.model
{
     
    public class ModelMail
    {
        public int id { get; set; }
        public DateTime timeReceiver { get; set; }
        public string subject { get; set; }

        public string from { get; set; }

        public string to { get; set; }

        public string body { get; set; }

        public ModelMail(int id, DateTime timeReceiver, string subject, string from, string to, string body)
        {
            this.id = id;
            this.timeReceiver = timeReceiver;
            this.subject = subject;
            this.from = from;
            this.to = to;
            this.body = body;
        }

        public ModelMail()
        {
        }
    }
}
