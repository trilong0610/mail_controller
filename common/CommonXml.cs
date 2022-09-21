using MailController.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
 

namespace MailController.xml
{
    internal class CommonXml
    {
        private XDocument xmldoc;
        private string URL_XML_FILE = @"..\..\xml\Account.xml";
        public List<ModelAccount> getAccounts()
        {
            // load xml file
            xmldoc = XDocument.Load(URL_XML_FILE);
            var data = xmldoc.Descendants("Account").Select(p => new ModelAccount
            {
                id = Int32.Parse(p.Element("id").Value),
                username = p.Element("username").Value,
                password = p.Element("password").Value,
                
            }).OrderBy(p => p.id).ToList();

            return data;
        }

        public void addAccount(string username, string password)
        {
            var currentAccounts = getAccounts();
            int id = Int32.Parse(currentAccounts.Last().id.ToString()) + 1;
            string timeStamp = currentAccounts.Count +  DateTime.Now.ToString("mmssff");
            XElement emp = new XElement("Account",
                new XElement("id", id),
                new XElement("username", username),
                new XElement("password", password)
                );
            xmldoc.Root.Add(emp);
            xmldoc.Save(URL_XML_FILE);
        }

        public void updateAccount(string id,string username, string password)
        {
            XElement emp = xmldoc.Descendants("Account").FirstOrDefault(p => p.Element("id").Value == id);
            if (emp != null)
            {
                emp.Element("username").Value = username;
                emp.Element("password").Value = password;
                xmldoc.Save(URL_XML_FILE);
            }
        }

        public void deleteAccount(string id)
        {
            XElement emp = xmldoc.Descendants("Account").FirstOrDefault(p => p.Element("id").Value == id);
            if (emp != null)
            {
                emp.Remove();
                xmldoc.Save(URL_XML_FILE);
                
            }
        }


    }
}
