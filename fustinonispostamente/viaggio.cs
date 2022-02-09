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
    public partial class viaggio : Form
    {
        int minuti=0;
        int ore = 0;
        Bici bike = new Bici();
        Ebike ebike = new Ebike();
        auto Auto = new auto();
        Monopattino monopattino = new Monopattino();
        motorinoE MotorinoE = new motorinoE();
        float prezzo = 0;
        int giorni = 0;
        string v;
        float costom;
        float costoh;
        float costog;
        string id;
        float batt=-1;
        int pos;
        int k;
        string img;

        /**
         * @fn  public viaggio(string veicolo, string identificatico)
         *
         * @brief   creates the right interface for the chosen vehicle
         *
         * @author  Fustinoni
         * @date    09/02/2022
         *
         * @param   veicolo         The veicolo.
         * @param   identificatico  The identificatico.
         */

        public viaggio(string veicolo, string identificatico)
        {
 
            InitializeComponent();
            v = veicolo;
            id = identificatico;
            if (veicolo == "bike")
            {
                img = "bici.gif";
                pictureBox1.Image = Image.FromFile("bici.gif");
                pictureBox3.Visible = false;
                label12.Visible = false;
                label11.Visible = false;
                pictureBox2.Visible = false;
                string dis = System.IO.File.ReadAllText("bici.json");
                string[] biciv = dis.Split('\n');
                for (int x = 0; x < biciv.Length - 1; x++)
                {
                    bike = JsonSerializer.Deserialize<Bici>(biciv[x]);
                    if (bike.Identificativo==id)
                    {
                        pos = x;
                      
                    }
                }

                bike = JsonSerializer.Deserialize<Bici>(biciv[pos]);
                costom = bike.CostoMinuto;
                costoh = bike.cOra;
                costog = bike.cGiorno;
                prezzo = prezzo + bike.cSblocco;
            }
           else if (veicolo == "Ebike")
            {
                img = "ebike.gif";
                pictureBox1.Image = Image.FromFile("ebike.gif");
               
                string dis = System.IO.File.ReadAllText("ebike.json");
                string[] biciv = dis.Split('\n');
                for (int x = 0; x < biciv.Length - 1; x++)
                {
                    ebike = JsonSerializer.Deserialize<Ebike>(biciv[x]);
                    if (ebike.Identificativo == id)
                    {
                        pos = x;
                        batt = ebike.Batteria;
                    }
                }
                
                costom = ebike.CostoMinuto;
                costoh = ebike.cOra;
                costog = ebike.cGiorno;
                prezzo = prezzo + ebike.cSblocco;
            }
            else if (veicolo == "auto")
            {
                pictureBox1.Image = Image.FromFile("auto.gif");
                img = "auto.gif";
                string dis = System.IO.File.ReadAllText("auto.json");
                string[] biciv = dis.Split('\n');
                for (int x = 0; x < biciv.Length - 1; x++)
                {
                    Auto = JsonSerializer.Deserialize<auto>(biciv[x]);
                    if (Auto.Identificativo == id)
                    {
                        pos = x;
                        batt = Auto.Batteria;
                    }
                }
                
                costom = Auto.CostoMinuto;
                costoh = Auto.cOra;
                costog = Auto.cGiorno;
            }
            else if (veicolo == "monopattino")
            {
                pictureBox1.Image = Image.FromFile("monopattino.gif");
                img = "monopattino.gif";
                string dis = System.IO.File.ReadAllText("monopattino.json");
                string[] biciv = dis.Split('\n');
                for (int x = 0; x < biciv.Length - 1; x++)
                {
                    monopattino = JsonSerializer.Deserialize<Monopattino>(biciv[x]);
                    if (monopattino.Identificativo == id)
                    {
                        pos = x;
                        batt = monopattino.Batteria;
                    }
                }
                
                costom = monopattino.CostoMinuto;
                costoh = monopattino.CostoMinuto * 60;
                costog = monopattino.cGiorno;
            }
            else if (veicolo == "scooter")
            {
                pictureBox1.Image = Image.FromFile("scooter.gif");
                img = "scooter.gif";
                string dis = System.IO.File.ReadAllText("motorino.json");
                string[] biciv = dis.Split('\n');
                for (int x = 0; x < biciv.Length - 1; x++)
                {
                    MotorinoE = JsonSerializer.Deserialize<motorinoE>(biciv[x]);
                    if (MotorinoE.Identificativo == id)
                    {
                        pos = x;
                        batt = MotorinoE.Batteria;
                    }
                }
                
                costom = MotorinoE.CostoMinuto;
                costoh = MotorinoE.cOra;
                costog = MotorinoE.cGiorno;
            }
        }
        private void viaggio_Load(object sender, EventArgs e)
        {

        }

        /**
         * @fn  private void timer1_Tick(object sender, EventArgs e)
         *
         * @brief   calculate the cost of the ride and the capacity of battery on passing the time
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void timer1_Tick(object sender, EventArgs e)
        {
            minuti = minuti + 1;
          
            prezzo = prezzo + costom;
            if (minuti==60)
            {
                ore = ore + 1;
                minuti = 0;
                prezzo = prezzo - (costom * 60);
                prezzo = prezzo + costoh;

            }
            if(ore==24)
            {
                ore = 0;
                giorni = giorni + 1;
                prezzo = prezzo - (costoh * 24);
                prezzo = prezzo + costog;
            }

            label1.Text = minuti.ToString();
            label2.Text = ore.ToString();
            label3.Text = giorni.ToString();
            label9.Text = "importo:" + prezzo.ToString() + " €";
            if(batt!=-1)
            {  if (minuti % 5 == 0)
            {
                batt = batt - 1;
                if (batt < 20)
                {
                    if (k == 0)
                    { pictureBox3.BackColor = Color.Red; k = 1; }
                    else
                    { pictureBox3.BackColor = Color.Transparent; k = 0; }
                }
                else
                { pictureBox3.BackColor = Color.Transparent; }

            }
          
            if (batt > 90)
            {

                pictureBox2.Image = Image.FromFile("100.jpg");
            }
            else if (batt > 50)
            {
                pictureBox2.Image = Image.FromFile("50.jpg");
            }
            else if (batt >0)
            {
                pictureBox2.Image = Image.FromFile("0.jpg");
                
            }
            else if (batt == 0)
            {
                timer1.Enabled=false;
               
                pictureBox3.BackColor = Color.Red;
                pictureBox1.Image = Image.FromFile("spina.gif");
                pictureBox2.Image = Image.FromFile("00.jpg");
            }
            }
           
        }

        /**
         * @fn  private void button1_Click(object sender, EventArgs e)
         *
         * @brief   save in log.json all the movements of the vehicles, where they have been take and where they have been left, who used it,when and how much they spent.
         *          after that it opens the form that permit you to deposit the vehicle
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            System.IO.File.AppendAllText("log.json", "conto"+ prezzo+ " |");
            this.Hide();
            var f1 = new Deposita(v,pos,batt);
            f1.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int p=0;

        /**
         * @fn  private void pictureBox3_Click(object sender, EventArgs e)
         *
         * @brief  if you need to recharge the bike you press the picture. The cost stop and when you need to restart it you you press it again
         *         
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (p==0)
            {
                pictureBox3.Image = Image.FromFile(img);
                pictureBox1.Image = Image.FromFile("ricarica.jpg");
                label12.Text = "ripartiamo?!";
                timer1.Enabled = false;
                timer2.Enabled = true;
                p = 1;
            }
            else
            {
                pictureBox3.Image = Image.FromFile("distributore.png");
                pictureBox1.Image = Image.FromFile(img); 
                    label12.Text = "fermati e ricarica?!";
                timer1.Enabled = true;
                timer2.Enabled = false;
                p = 0;
            }
           


        }

        /**
         * @fn  private void timer2_Tick(object sender, EventArgs e)
         *
         * @brief  start when you stop to recharge and calculate the battery charge 
         *
         * @author  Fustinoni
         * @date    09/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void timer2_Tick(object sender, EventArgs e)
        {
            batt = batt + 1;
            if (batt > 90)
            {
                pictureBox3.BackColor = Color.Green;
                pictureBox2.Image = Image.FromFile("100.jpg");
            }
            else if (batt > 50)
            {
                pictureBox3.BackColor = Color.Yellow;
                pictureBox2.Image = Image.FromFile("50.jpg");
            }
            else if (batt > 0)
            {
                pictureBox3.BackColor = Color.Red;
                pictureBox2.Image = Image.FromFile("0.jpg");
            }
           
        }
    }
}
