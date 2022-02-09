using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace fustinonispostamente
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * @fn  private void button2_Click(object sender, EventArgs e)
         *
         * @brief   control all your user registration
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void button2_Click(object sender, EventArgs e)
        {
            Utente utente = new Utente();// object declaration 
            string dis = System.IO.File.ReadAllText("utente.json");//leggere file utente.json
            string[] biciv = dis.Split('\n');//splitta in array i si
           
            
            //find the username and check the password if is correct open form2
            for (int m = 0; m < biciv.Length - 1; m++)//lettura ogni oggetto 
            {
                utente = JsonSerializer.Deserialize<Utente>(biciv[m]);
                if(utente.Mail==textBox1.Text)
                {
                    if (utente.Password == textBox2.Text)
                    {
                        label3.Text = "login avvenuto con successo";
                        button1.BackColor = Color.Green;
                        System.IO.File.AppendAllText("log.json", "\n"+"utente:" + utente.Mail + " |");
                        var f2 = new Form2();
                        f2.ShowDialog();
                       
                        
                        this.Close();

                        break;
                    }
                    else
                    {
                        label3.Text = "Errore: password sbagliata";
                        button1.BackColor = Color.Red;
                    }

                }
                else
                {

                    label3.Text = "Errore: utente non trovato";
                    button1.BackColor = Color.Red;
                }

            }





            
        }

        /**
         * @fn  private void Register_Click(object sender, EventArgs e)
         *
         * @brief   open the registrarion form (used on button register)
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void Register_Click(object sender, EventArgs e)
        {
            var f2 = new Register();
            f2.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
