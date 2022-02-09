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
    public partial class veicoliclass : Form
    {
        int conta = 0;
        int k = 0;
        string veicolo;
        string id;
 
        List<veicolo> V = new List<veicolo>();// create the polymorphism list of veichles

        /**
         * @fn  public veicoliclass(double x,double y, string t)
         *
         * @brief  when we open this form, it creates the right interface with the user depending on the chosen vehicle
         *
         * @author  Fustinoni
         * @date    09/02/2022
         *
         * @param   x   The x coordinate.
         * @param   y   The y coordinate.
         * @param   t   A string to process.
         */

        public veicoliclass(double x,double y, string t)
        {
            InitializeComponent();
            veicolo = t;
            
            // 
            ////////////////////////bike
            if (t == "bike")
            {
                Bici bike = new Bici(); //create the bike object 
                string dis = System.IO.File.ReadAllText("bici.json"); //reads the bike file and inserts it into the string dis
                string[] biciv = dis.Split('\n');//divides the string by inserting in each cell of the array an "object"
                for (int m = 0; m < biciv.Length - 1; m++)
                {
                    bike = JsonSerializer.Deserialize<Bici>(biciv[m]);//trasform the cell of the array in a bike object

                    if (bike.Longitudine == x && bike.Latitudine == y)//ceck if is in our place
                    {
                        k = k + 1;
                        V.Add(bike);//add  the object to our general list of object 
                    }

                }
                /////////////////create the interface for the bike 
                id = V[0].Identificativo;
                label1.Text = "bici N: 1"; 

                if (V[0].Marca== "Bianchi")
                {
                    pictureBox3.Image = Image.FromFile("bianchi.png");
                }
                else
                {
                    pictureBox3.Image = Image.FromFile("mobike.png");
                }
                pictureBox4.Image = Image.FromFile("casco.png");
                if (V[0].opsional1==true)
                {
                    pictureBox4.BackColor = Color.Green;
                }
                else
                {
                    pictureBox4.BackColor = Color.Red;
                }
                pictureBox5.Image = Image.FromFile("seggiolino.png");
                if (V[0].opsional2==true)
                {
                    pictureBox5.BackColor = Color.Green;
                }
                else
                {
                    pictureBox5.BackColor = Color.Red;
                }
                if (V[0].dim=='L')
                {
                    pictureBox6.Image = Image.FromFile("L.jpg");
                }
                else if (V[0].dim == 'S')
                {
                    pictureBox6.Image = Image.FromFile("s.jpg");
                }
                else if (V[0].dim == 'M')
                {
                    pictureBox6.Image = Image.FromFile("m.jpg");
                }
                pictureBox7.Image = Image.FromFile("chiave.png");
                if (V[conta].Stato == 1)
                {
                    pictureBox7.BackColor = Color.Red;
                }
                else if (V[conta].Stato == 2)
                {
                    pictureBox7.BackColor = Color.Yellow;
                }
                else if (V[conta].Stato == 3)
                {
                    pictureBox7.BackColor = Color.Green;
                }

                label7.Text = "costo sblocco:" + V[conta].cSblocco+ " €";
                label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                label9.Text = "costo orario:" + V[conta].cOra + "  €";
                label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";


            }
            ///////////////ebike
            else if (t=="Ebike")
            {
                
                    Ebike bike = new Ebike();//create the bike object 
                string dis = System.IO.File.ReadAllText("ebike.json");//reads the Ebike file and inserts it into the string dis
                string[] biciv = dis.Split('\n');//divides the string by inserting in each cell of the array an "object"
                for (int m = 0; m < biciv.Length - 1; m++)
                    {
                        bike = JsonSerializer.Deserialize<Ebike>(biciv[m]);//trasform the cell of the array in a Ebike object
                    if (bike.Longitudine == x && bike.Latitudine == y)//ceck if is in our place
                    {
                            k = k + 1;
                            V.Add(bike);//add  the object to our general list of object 
                    }

                    }
                /////////////////create the interface for the Ebike 
                id = V[0].Identificativo;
                label1.Text = "Ebike N: 1";
                    if (V[0].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchi.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("mobike.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[0].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[0].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[0].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[0].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[0].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    pictureBox7.Image = Image.FromFile("chiave.png");
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }
                if (V[conta].Batteria > 90)
                {
                    pictureBox8.Image = Image.FromFile("100.jpg");
                }
                else if (V[conta].Batteria > 50)
                {
                    pictureBox8.Image = Image.FromFile("50.jpg");
                }
                else if (V[conta].Batteria > 0)
                {
                    pictureBox8.Image = Image.FromFile("0.jpg");
                }
                else if (V[conta].Batteria == 0)
                {
                    pictureBox8.Image = Image.FromFile("00.jpg");
                }
                label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
            }
            //////////////////auto
            else if(t=="auto")
                {
                    auto bike = new auto();//create the bike object 
                string dis = System.IO.File.ReadAllText("auto.json");//reads the auto file and inserts it into the string dis
                string[] biciv = dis.Split('\n');//divides the string by inserting in each cell of the array an "object"
                for (int m = 0; m < biciv.Length - 1; m++)
                    {
                        bike = JsonSerializer.Deserialize<auto>(biciv[m]);//trasform the cell of the array in a auto object
                    if (bike.Longitudine == x && bike.Latitudine == y)//ceck if is in our place
                    {
                            k = k + 1;
                            V.Add(bike);//add  the object to our general list of object 
                    }

                    }
                /////////////////create the interface for the auto 
                id = V[0].Identificativo;
                label1.Text = "auto N: 1";
                    if (V[0].Marca=="Fiat")
                    {
                        pictureBox3.Image = Image.FromFile("Fiat.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Kia.png");
                    }
                    pictureBox4.Image = Image.FromFile("chiave.png");
                    if (V[conta].Stato == 1)
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox4.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                if (V[conta].Batteria > 90)
                {
                    pictureBox5.Image = Image.FromFile("100.jpg");
                }
                else if (V[conta].Batteria > 50)
                {
                    pictureBox5.Image = Image.FromFile("50.jpg");
                }
                else if (V[conta].Batteria > 0)
                {
                    pictureBox5.Image = Image.FromFile("0.jpg");
                }
                else if (V[conta].Batteria == 0)
                {
                    pictureBox5.Image = Image.FromFile("00.jpg");
                }
                label4.Text = "Targa " + V[0].Targa;

                
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";


                }
            
            /////////////////monopattino
            if (t == "monopattino")
            {
                Monopattino bike = new Monopattino();//create the bike object 
                string dis = System.IO.File.ReadAllText("monopattino.json");//reads the monopattino file and inserts it into the string dis
                string[] biciv = dis.Split('\n');//divides the string by inserting in each cell of the array an "object"
                for (int m = 0; m < biciv.Length - 1; m++)
                {
                    bike = JsonSerializer.Deserialize<Monopattino>(biciv[m]);//trasform the cell of the array in a monopattino object
                    if (bike.Longitudine == x && bike.Latitudine == y)//ceck if is in our place
                    {
                        k = k + 1;
                        V.Add(bike);//add  the object to our general list of object 
                    }

                }
                /////////////////create the interface for the monopattino 
                id = V[0].Identificativo;
                label1.Text = "Monopattino N: 1";
                if (V[0].Marca == "Ducati")
                {
                    pictureBox3.Image = Image.FromFile("ducati.png");
                }
                else
                {
                    pictureBox3.Image = Image.FromFile("monopattino.png");
                }
                pictureBox4.Image = Image.FromFile("audio.png");
                if (V[0].opsional1 == true)
                {
                    pictureBox4.BackColor = Color.Green;
                }
                else
                {
                    pictureBox4.BackColor = Color.Red;
                }
                pictureBox5.Image = Image.FromFile("chiave.png");
                if (V[conta].Stato == 1)
                {
                    pictureBox5.BackColor = Color.Red;
                }
                else if (V[conta].Stato == 2)
                {
                    pictureBox5.BackColor = Color.Yellow;
                }
                else if (V[conta].Stato == 3)
                {
                    pictureBox5.BackColor = Color.Green;
                }
                if (V[conta].Batteria > 90)
                {
                    pictureBox6.Image = Image.FromFile("100.jpg");
                }
                else if (V[conta].Batteria > 50)
                {
                    pictureBox6.Image = Image.FromFile("50.jpg");
                }
                else if (V[conta].Batteria > 0)
                {
                    pictureBox6.Image = Image.FromFile("0.jpg");
                }
                else if (V[conta].Batteria == 0)
                {
                    pictureBox6.Image = Image.FromFile("00.jpg");
                }



                label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                label9.Text = "costo orario:" + V[conta].cOra + " €";
                label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";


            }
            //////////scooter
            if (t == "scooter")
            {
                motorinoE bike = new motorinoE();//create the bike object 
                string dis = System.IO.File.ReadAllText("motorino.json");//reads the scooter file and inserts it into the string dis
                string[] biciv = dis.Split('\n');//divides the string by inserting in each cell of the array an "object"
                for (int m = 0; m < biciv.Length - 1; m++)
                {
                    bike = JsonSerializer.Deserialize<motorinoE>(biciv[m]);//trasform the cell of the array in a scooter object
                    if (bike.Longitudine == x && bike.Latitudine == y)//ceck if is in our place
                    {
                        k = k + 1;
                        V.Add(bike);//add  the object to our general list of object 
                    }

                }
                /////////////////create the interface for the scooter  
                id = V[0].Identificativo;
                label1.Text = "Scooter N: 1";
                if (V[conta].Marca == "Aprilia")
                {
                    pictureBox3.Image = Image.FromFile("aprilia.png");
                }
                else
                {
                    pictureBox3.Image = Image.FromFile("honda.png");
                }
                pictureBox4.Image = Image.FromFile("radio.png");
                if (V[conta].opsional1 == true)
                {
                    pictureBox4.BackColor = Color.Green;
                }
                else
                {
                    pictureBox4.BackColor = Color.Red;
                }
                pictureBox5.Image = Image.FromFile("chiave.png");
                if (V[conta].Stato == 1)
                {
                    pictureBox5.BackColor = Color.Red;
                }
                else if (V[conta].Stato == 2)
                {
                    pictureBox5.BackColor = Color.Yellow;
                }
                else if (V[conta].Stato == 3)
                {
                    pictureBox5.BackColor = Color.Green;
                }
                if (V[conta].Batteria > 90)
                {
                    pictureBox6.Image = Image.FromFile("100.jpg");
                }
                else if (V[conta].Batteria > 50)
                {
                    pictureBox6.Image = Image.FromFile("50.jpg");
                }
                else if (V[conta].Batteria > 0)
                {
                    pictureBox6.Image = Image.FromFile("0.jpg");
                }
                else if (V[conta].Batteria == 0)
                {
                    pictureBox6.Image = Image.FromFile("00.jpg");
                }
                label4.Text = "Targa: " + V[0].Targa;


                label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                label9.Text = "costo orario:" + V[conta].cOra + " €";
                label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";


            }
        }

        private void veicoliclass_Load(object sender, EventArgs e)
        {

        }

        /**
         * @fn  private void pictureBox2_Click(object sender, EventArgs e)
         *
         * @brief   on click of back arrow selects the previous item inside the vehicle view
         *
         * @author  Fustinoni
         * @date    09/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /////////bike
            if (veicolo=="bike")
            {
                if (conta > 0)
                {
                    conta = conta - 1;//decreases the counter
                    id = V[conta].Identificativo;//select the item at couter 
                    /////////////////create the correct interface
                    label1.Text = "bici N: " + (conta + 1);


                    if (V[conta].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchi.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("mobike.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[conta].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[conta].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[conta].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[conta].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }


                    label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }

                else////if the count is 0 
                {   conta = k-1;//bring the counter to the last element 
                    id = V[conta].Identificativo;//selects the item
                    /////////////////create the correct interface 
                    label1.Text = "bici N: " + (conta+1);
                    if (V[conta].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchi.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("mobike.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[conta].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[conta].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[conta].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[conta].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }


                    label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }
            }

            //////////////////////////////////////////////////////////////ebike
            // does the same things as when the vehicle is bike but creates the interface for Ebike
            else if (veicolo == "Ebike")
            {
                if (conta > 0)
                {
                    conta = conta - 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Ebike N: " + (conta + 1);
                    if (V[conta].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchie.jpg");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Rockrider.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[conta].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[conta].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[conta].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[conta].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria>90)
                    {
                        pictureBox8.Image = Image.FromFile("100.jpg");
                    }
                    else if(V[conta].Batteria > 50)
                    {
                        pictureBox8.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox8.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox8.Image = Image.FromFile("00.jpg");
                    }


                    label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }
                else
                {
                    conta = k - 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Ebike N: " + (conta + 1);
                    if (V[conta].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchie.jpg");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Rockrider.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[conta].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[conta].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[conta].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[conta].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox8.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox8.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox8.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox8.Image = Image.FromFile("00.jpg");
                    }


                    label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }
            }
            ////////////////////////////auto
            //  does the same things as when the vehicle is bike but creates the interface for auto
            if (veicolo == "auto")
            {
                if (conta > 0)
                {
                    conta = conta - 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Auto N: " + (conta + 1);
                    if (V[conta].Marca == "Fiat")
                    {
                        pictureBox3.Image = Image.FromFile("Fiat.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Kia.png");
                    }
                   
                    if (V[conta].Stato == 1)
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox4.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox5.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox5.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox5.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox5.Image = Image.FromFile("00.jpg");
                    }
                    label4.Text = "Targa: " + V[conta].Targa;


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }
                else
                {
                    conta = k - 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Auto N: " + (conta + 1);
                    if (V[conta].Marca == "Fiat")
                    {
                        pictureBox3.Image = Image.FromFile("Fiat.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Kia.png");
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox4.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox5.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox5.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox5.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox5.Image = Image.FromFile("00.jpg");
                    }
                    label4.Text = "Targa: " + V[conta].Targa;


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }
            }
            ////////////////////monopattino
            //   does the same things as when the vehicle is bike but creates the interface for monopattino
            else if (veicolo == "monopattino")
            {
                if (conta > 0)
                {
                    conta = conta - 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Monopattino N: " + (conta + 1);
                    if (V[conta].Marca == "Ducati")
                    {
                        pictureBox3.Image = Image.FromFile("ducati.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("monopattino.png");
                    }
                    
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
               
                    if (V[conta].Stato == 1)
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox5.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox6.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox6.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox6.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox6.Image = Image.FromFile("00.jpg");
                    }


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }
                else
                {
                    conta = k - 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Monopattino N: " + (conta + 1);
                    if (V[conta].Marca == "Ducati")
                    {
                        pictureBox3.Image = Image.FromFile("ducati.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("monopattino.png");
                    }

                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox5.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox6.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox6.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox6.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox6.Image = Image.FromFile("00.jpg");
                    }


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }
            }

            ///////////////scooter
            //    does the same things as when the vehicle is bike but creates the interface for monopattino
            else if (veicolo == "scooter")
            {
                if (conta > 0)
                {
                    conta = conta - 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Scooter N: " + (conta + 1);
                    if (V[conta].Marca == "Aprilia")
                    {
                        pictureBox3.Image = Image.FromFile("aprilia.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("honda.png");
                    }
                   
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
        
                    if (V[conta].Stato == 1)
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox5.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox6.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox6.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox6.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox6.Image = Image.FromFile("00.jpg");
                    }
                    label4.Text = "Targa: " + V[conta].Targa;


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";

                }
                else
                {
                    conta = k - 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Scooter N: " + (conta + 1);
                    if (V[conta].Marca == "Aprilia")
                    {
                        pictureBox3.Image = Image.FromFile("aprilia.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("honda.png");
                    }

                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox5.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox6.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox6.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox6.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox6.Image = Image.FromFile("00.jpg");
                    }
                    label4.Text = "Targa: " + V[conta].Targa;


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                }
            }
        }

        /**
         * @fn  private void pictureBox1_Click(object sender, EventArgs e)
         *
         * @brief   on click of the forward arrow selects the next item within the vehicle view
         *          
         *
         * @author  Fustinoni
         * @date    09/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //do the same thing of the function pictureBox2_Click but increment the items
            // 
            //////////////bike
            if (veicolo == "bike")
            {
                if (conta < k - 1)//if is not last 
                {

                    conta = conta + 1;//increment the counter 
                    label1.Text = "bici N: " + (conta + 1);
                    if (V[conta].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchi.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("mobike.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[conta].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[conta].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[conta].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[conta].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }


                    // label2.Text = B[conta].Tipologia;
                    label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";
                    id = V[conta].Identificativo;


                }
                else//if is last 
                {
                    
                    conta = 0;//bring the couter to 0 so the first element
                    id = V[conta].Identificativo;
                    label1.Text = "bici N: " + (conta + 1);
                    if (V[conta].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchi.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("mobike.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[conta].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[conta].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[conta].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[conta].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }


                    label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";

                }
            }
            /////////////////////////////ebike
            else if(veicolo == "Ebike")
            {
                if (conta < k - 1)
                {

                    conta = conta + 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Ebike N: " + (conta + 1);
                    if (V[conta].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchie.jpg");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Rockrider.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[conta].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[conta].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[conta].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[conta].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox8.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox8.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox8.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox8.Image = Image.FromFile("00.jpg");
                    }


                    label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";


                }
                else
                {
                    conta = 0;
                    id = V[conta].Identificativo;
                    label1.Text = "Ebike N: " + (conta + 1);
                    if (V[conta].Marca == "Bianchi")
                    {
                        pictureBox3.Image = Image.FromFile("bianchie.jpg");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Rockrider.png");
                    }
                    pictureBox4.Image = Image.FromFile("casco.png");
                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    pictureBox5.Image = Image.FromFile("seggiolino.png");
                    if (V[conta].opsional2 == true)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    if (V[conta].dim == 'L')
                    {
                        pictureBox6.Image = Image.FromFile("L.jpg");
                    }
                    else if (V[conta].dim == 'S')
                    {
                        pictureBox6.Image = Image.FromFile("s.jpg");
                    }
                    else if (V[conta].dim == 'M')
                    {
                        pictureBox6.Image = Image.FromFile("m.jpg");
                    }
                    if (V[conta].Stato == 1)
                    {
                        pictureBox7.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox7.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox7.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox8.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox8.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox8.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox8.Image = Image.FromFile("00.jpg");
                    }


                    label7.Text = "costo sblocco:" + V[conta].cSblocco + " €";
                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";

                }
            }
            ///////////////////////auto
            else if (veicolo == "auto")
            {
                if (conta < k - 1)
                {
                    conta = conta + 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Auto N: " + (conta + 1);
                    if (V[conta].Marca == "Fiat")
                    {
                        pictureBox3.Image = Image.FromFile("Fiat.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Kia.png");
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox4.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox5.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox5.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox5.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox5.Image = Image.FromFile("00.jpg");
                    }
                    label4.Text = "Targa: " + V[conta].Targa;


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";


                }
                else
                {
                    conta = 0;
                    id = V[conta].Identificativo;
                    label1.Text = "Auto N: " + (conta + 1);
                    if (V[conta].Marca == "Fiat")
                    {
                        pictureBox3.Image = Image.FromFile("Fiat.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("Kia.png");
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox4.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox4.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox5.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox5.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox5.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox5.Image = Image.FromFile("00.jpg");
                    }
                    label4.Text = "Targa: " + V[conta].Targa;


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";

                }
            }
            ////////////////monopattino
            /// 
             else if (veicolo == "monopattino")
            {
                if (conta < k - 1)
                {
                    conta = conta + 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Monopattino N: " + (conta + 1);
                    if (V[conta].Marca == "Ducati")
                    {
                        pictureBox3.Image = Image.FromFile("ducati.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("monopattino.png");
                    }

                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox5.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox6.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox6.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox6.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox6.Image = Image.FromFile("00.jpg");
                    }


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";


                }
                else
                {
                    conta = 0;
                    id = V[conta].Identificativo;
                    label1.Text = "Monopattino N: " + (conta + 1);
                    if (V[conta].Marca == "Ducati")
                    {
                        pictureBox3.Image = Image.FromFile("ducati.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("monopattino.png");
                    }

                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox5.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox6.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox6.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox6.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox6.Image = Image.FromFile("00.jpg");
                    }


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";

                }
            }
            /////////////////scooter
            else if (veicolo == "scooter")
            {
                if (conta < k - 1)
                {
                    conta = conta + 1;
                    id = V[conta].Identificativo;
                    label1.Text = "Scooter N: " + (conta + 1);
                    if (V[conta].Marca == "Aprilia")
                    {
                        pictureBox3.Image = Image.FromFile("aprilia.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("honda.png");
                    }

                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox5.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox6.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox6.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox6.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox6.Image = Image.FromFile("00.jpg");
                    }
                    label4.Text = "Targa: " + V[conta].Targa;


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";


                }
                else
                {
                    conta = 0;
                    id = V[conta].Identificativo;
                    label1.Text = "Scooter N: " + (conta + 1);
                    if (V[conta].Marca == "Aprilia")
                    {
                        pictureBox3.Image = Image.FromFile("aprilia.png");
                    }
                    else
                    {
                        pictureBox3.Image = Image.FromFile("honda.png");
                    }

                    if (V[conta].opsional1 == true)
                    {
                        pictureBox4.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBox4.BackColor = Color.Red;
                    }

                    if (V[conta].Stato == 1)
                    {
                        pictureBox5.BackColor = Color.Red;
                    }
                    else if (V[conta].Stato == 2)
                    {
                        pictureBox5.BackColor = Color.Yellow;
                    }
                    else if (V[conta].Stato == 3)
                    {
                        pictureBox5.BackColor = Color.Green;
                    }
                    if (V[conta].Batteria > 90)
                    {
                        pictureBox6.Image = Image.FromFile("100.jpg");
                    }
                    else if (V[conta].Batteria > 50)
                    {
                        pictureBox6.Image = Image.FromFile("50.jpg");
                    }
                    else if (V[conta].Batteria > 0)
                    {
                        pictureBox6.Image = Image.FromFile("0.jpg");
                    }
                    else if (V[conta].Batteria == 0)
                    {
                        pictureBox6.Image = Image.FromFile("00.jpg");
                       
                    }
                    label4.Text = "Targa" + V[conta].Targa;


                    label8.Text = "costo minuto:" + V[conta].CostoMinuto + " €";
                    label9.Text = "costo orario:" + V[conta].cOra + " €";
                    label10.Text = "costo giornaliero:" + V[conta].cGiorno + " €";

                }
            }
        }
           
        

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.AppendAllText("log.json", "veicolo "+ veicolo +" |"+" identificativo "+V[conta].Identificativo + " |");// write on the logs file the choice of the vehicle made
            DateTime localDate = DateTime.Now;//take the current data 
            System.IO.File.AppendAllText("log.json", "ora prelievo" + localDate + " |");//write the current data on file log
            this.Hide();
            var f2 = new viaggio(veicolo,id);
            f2.ShowDialog();//open the travel form 
            this.Close();
            //B[conta]
        }
    }
}
