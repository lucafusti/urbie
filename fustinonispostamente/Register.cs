using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace fustinonispostamente
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        /**
         * @fn  private void button1_Click(object sender, EventArgs e)
         *
         * @brief   on click we check the information and we register the user 
         *          if all is correct close this form and open the login form 
         *          else show the error
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void button1_Click(object sender, EventArgs e)
        {
            //registra 
            if (textBox1.Text != "")//check that the name isn't empty
            {
                if (textBox2.Text != "")//check that the mail isn't empty
                {
                    if (textBox3.TextLength ==16)//check that the fiscal code isn't empty and have the correct lenght
                    {
                        Utente utente = new Utente();//create the user object
                        utente.Mail = textBox1.Text;//insert in the object the mail
                        utente.Password = textBox2.Text;//insert in the object the password


                        string jsonString = JsonSerializer.Serialize(utente);//serialize the object in a string
                        jsonString += "\n";
                        System.IO.File.AppendAllText("utente.json", jsonString);//write on the file 
                        Console.WriteLine(jsonString);
    

                        textBox1.Text = null;
                        textBox2.Text = null;


                        button1.BackColor = Color.Green;
                       this.Hide();
                        var f2 = new Login();
                        f2.ShowDialog();
                        this.Close();


                    }
                    else
                    {
                        button1.BackColor = Color.Red;
                        label1.Text = "errore:campo codice fiscale non valido";
                    }
                }
                else
                {
                    button1.BackColor = Color.Red;
                    label1.Text = "errore:campo CAP non valido";
                }
            }
            else
            {
                button1.BackColor = Color.Red;
                label1.Text = "errore:campo codice fiscale non valido";
            }





            


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
