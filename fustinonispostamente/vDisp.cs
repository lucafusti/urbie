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
    
    public partial class vDisp : Form
    {
        double xk;
        double yk;

        /**
         * @fn  public vDisp(double x, double y)
         *
         * @brief   it shows how many vehicles there are in a determinate position
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   x   The x coordinate.
         * @param   y   The y coordinate.
         */

        public vDisp(double x, double y)
        {
            xk = x;
            yk = y;
            InitializeComponent();
            ///caricamento bici
            Bici bike = new Bici();//create a new bike object
            string dis = System.IO.File.ReadAllText("bici.json");//read all records in bici.json
            string[] biciv = dis.Split('\n');//insert them in an array
            int a = 0;
            for (int m = 0; m < biciv.Length - 1; m++)// for all the element in the array
            {
                bike = JsonSerializer.Deserialize<Bici>(biciv[m]);// deserialize the string and put it in object bike
                if(bike.Longitudine==x && bike.Latitudine==y)//check if coordinates are correct
                {
                    a = a + 1;//increment the number of vehicles in that location
                }

            }
            label6.Text ="veicoli disponibili: "+ a.ToString();//show in the form the number of vehicles 

            //do the same for all type of vehicles

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //ebike
            Ebike ebike = new Ebike();
            string dise = System.IO.File.ReadAllText("ebike.json");
            string[] bicive = dise.Split('\n');
            int b = 0;
            for (int m = 0; m < bicive.Length - 1; m++)
            {
                ebike = JsonSerializer.Deserialize<Ebike>(bicive[m]);
                if (ebike.Longitudine == x && ebike.Latitudine == y)
                {
                    b = b + 1;
                }

            }
            label7.Text = "veicoli disponibili: " + b.ToString();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // auto
            auto Auto = new auto();
            string disa = System.IO.File.ReadAllText("auto.json");
            string[] biciva = disa.Split('\n');
            int c = 0;
            for (int m = 0; m < biciva.Length - 1; m++)
            {
                Auto = JsonSerializer.Deserialize<auto>(biciva[m]);
                if (Auto.Longitudine == x && Auto.Latitudine == y)
                {
                    c = c + 1;
                }

            }
            label8.Text = "veicoli disponibili: " + c.ToString();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // monopattino
            Monopattino monopattino = new Monopattino();
            string dism = System.IO.File.ReadAllText("monopattino.json");
            string[] bicivm = dism.Split('\n');
            int d = 0;
            for (int m = 0; m < bicivm.Length - 1; m++)
            {
                monopattino = JsonSerializer.Deserialize<Monopattino>(bicivm[m]);
                if (monopattino.Longitudine == x && monopattino.Latitudine == y)
                {
                    d = d + 1;
                }

            }
            label9.Text = "veicoli disponibili: " + d.ToString();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // scooter
            motorinoE MotorinoE = new motorinoE();
            string disme = System.IO.File.ReadAllText("motorino.json");
            string[] bicivme = disme.Split('\n');
            int e = 0;
            for (int m = 0; m < bicivme.Length - 1; m++)
            {
                MotorinoE = JsonSerializer.Deserialize<motorinoE>(bicivme[m]);
                if (MotorinoE.Longitudine == x && MotorinoE.Latitudine == y)
                {
                    e = e + 1;
                }

            }
            label10.Text = "veicoli disponibili: " + e.ToString();
        }

        /**
         * @fn  private void pictureBox1_Click(object sender, EventArgs e)
         *
         * @brief   on click of the bike open the form to check if you are able to drive the bike
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Dati(xk, yk,"bike");
            f1.ShowDialog();
            this.Close();
        }

        /**
         * @fn  private void pictureBox2_Click(object sender, EventArgs e)
         *
         * @brief   on click of the ebike open the form to check if you are able to drive the ebike
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Dati(xk, yk, "Ebike");
            
            f1.ShowDialog();
            this.Close();
        }

        /**
         * @fn  private void pictureBox3_Click(object sender, EventArgs e)
         *
         * @brief   on click of the auto open the form to check if you are able to drive the auto
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Dati(xk, yk, "auto");
            f1.ShowDialog();
            this.Close();
        }

        /**
         * @fn  private void pictureBox5_Click(object sender, EventArgs e)
         *
         * @brief   on click of the monopattino open the form to check if you are able to drive the monopattino
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Dati(xk, yk, "monopattino");
            f1.ShowDialog();
            this.Close();
        }

        /**
         * @fn  private void pictureBox4_Click(object sender, EventArgs e)
         *
         * @brief   on click of the scooter open the form to check if you are able to drive the scooter
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new Dati(xk, yk, "scooter");
            f1.ShowDialog();
            this.Close();
        }
    }
}
