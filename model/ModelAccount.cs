using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailController.model
{
    
    public class ModelAccount
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public ModelAccount(int id, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
        }
        public ModelAccount()
        {
            
        }

    }
}
