using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fustinonispostamente
{
    class Utente
    {

        private string mail;
        private string password;
        private string codf;
        public Utente()
        {
            mail = "";
            password = "";

        }
        public Utente(string mail, string password,string codf)
        {
         
            this.mail = mail;
            this.password = password;
            this.codf = codf;
        }
        
        
        
        public string Mail
        {
            set
            {
                if (value is string)
                {
                    mail = value;
                }
            }
            get
            {
                return mail;
            }
        }
        public string Password
        {
            set
            {
                if (value is string)
                {
                    password = value;
                }
            }
            get
            {
                return password;
            }
        }
        public string Codf
        {
            set
            {
                if (value is string)
                {
                    codf = value;
                }
            }
            get
            {
                return codf;
            }
        }
    }
}
