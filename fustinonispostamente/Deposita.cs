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
    public partial class Deposita : Form
    {
        string veicolo;
        int posizione;
        float batteria;
        public Deposita(string v,int pos,float batt)
        {
            batteria = batt;
            veicolo = v;
            posizione = pos;
            InitializeComponent();
 
        }

        private void Deposita_Load(object sender, EventArgs e)
        {

        }

        /**
         * @fn  private void pictureBox2_Click(object sender, EventArgs e)
         *
         * @brief   on click it set the veichles position where you left it
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (veicolo == "bike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "ospedale" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Bici bici = new Bici();
                string dis = System.IO.File.ReadAllText("bici.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Bici>(biciv[posizione]);
                bici.Longitudine = 45.68650;
                bici.Latitudine = 9.63379;
                if (posizione == 0)
                {
                    
                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("bici.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("bici.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("bici.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("bici.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("bici.json", rimpiazza);
                        }
                    }

                }


            }
            
            else if (veicolo == "Ebike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "ospedale" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Ebike bici = new Ebike();
                string dis = System.IO.File.ReadAllText("ebike.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Ebike>(biciv[posizione]);
                bici.Longitudine = 45.68650;
                bici.Latitudine = 9.63379;
                bici.Batteria = batteria;
                if (posizione == 0)
                {
                    
                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("ebike.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("ebike.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("ebike.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("ebike.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("ebike.json", rimpiazza);
                        }
                    }

                }

            }
            else if (veicolo == "auto")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "ospedale" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                auto bici = new auto();
                string dis = System.IO.File.ReadAllText("auto.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<auto>(biciv[posizione]);
                bici.Longitudine = 45.68650;
                bici.Latitudine = 9.63379;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("auto.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("auto.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("auto.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("auto.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("auto.json", rimpiazza);
                        }
                    }

                }
            }
            else if (veicolo == "monopattino")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "ospedale" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Monopattino bici = new Monopattino();
                string dis = System.IO.File.ReadAllText("monopattino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Monopattino>(biciv[posizione]);
                bici.Longitudine = 45.68650;
                bici.Latitudine = 9.63379;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("monopattino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("monopattino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("monopattino.json", rimpiazza);
                        }
                    }

                }


            }
            else if (veicolo == "scooter")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "ospedale" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                motorinoE bici = new motorinoE();
                string dis = System.IO.File.ReadAllText("motorino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<motorinoE>(biciv[posizione]);
                bici.Longitudine = 45.68650;
                bici.Latitudine = 9.63379;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("motorino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("motorino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("motorino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("motorino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("motorino.json", rimpiazza);
                        }
                    }

                }


            }
            var f2 = new riepilogo();
            f2.ShowDialog();
            this.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (veicolo == "bike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "colle aperto" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Bici bici = new Bici();
                string dis = System.IO.File.ReadAllText("bici.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Bici>(biciv[posizione]);
                bici.Longitudine = 45.70639;
                bici.Latitudine = 9.65907;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("bici.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("bici.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("bici.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("bici.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("bici.json", rimpiazza);
                        }
                    }

                }


            }

            else if (veicolo == "Ebike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "colle aperto" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Ebike bici = new Ebike();
                string dis = System.IO.File.ReadAllText("ebike.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Ebike>(biciv[posizione]);
                bici.Longitudine = 45.70639;
                bici.Latitudine = 9.65907;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("ebike.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("ebike.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("ebike.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("ebike.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("ebike.json", rimpiazza);
                        }
                    }

                }

            }
            else if (veicolo == "auto")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "colle aperto" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                auto bici = new auto();
                string dis = System.IO.File.ReadAllText("auto.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<auto>(biciv[posizione]);
                bici.Longitudine = 45.70639;
                bici.Latitudine = 9.65907;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("auto.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("auto.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("auto.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("auto.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("auto.json", rimpiazza);
                        }
                    }

                }
            }
            else if (veicolo == "monopattino")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "colle aperto" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Monopattino bici = new Monopattino();
                string dis = System.IO.File.ReadAllText("monopattino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Monopattino>(biciv[posizione]);
                bici.Longitudine = 45.70639;
                bici.Latitudine = 9.65907;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("monopattino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("monopattino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("monopattino.json", rimpiazza);
                        }
                    }

                }


            }
            else if (veicolo == "scooter")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "colle aperto" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                motorinoE bici = new motorinoE();
                string dis = System.IO.File.ReadAllText("motorino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<motorinoE>(biciv[posizione]);
                bici.Longitudine = 45.70639;
                bici.Latitudine = 9.65907;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("motorino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("motorino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("motorino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("motorino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("motorino.json", rimpiazza);
                        }
                    }

                }


            }
            var f2 = new riepilogo();
            f2.ShowDialog();
            this.Close();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (veicolo == "bike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stadio" + " |");
                
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Bici bici = new Bici();
                string dis = System.IO.File.ReadAllText("bici.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Bici>(biciv[posizione]);
                bici.Longitudine = 45.70833;
                bici.Latitudine = 9.67991;
               
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("bici.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("bici.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("bici.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("bici.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("bici.json", rimpiazza);
                        }
                    }

                }


            }

            else if (veicolo == "Ebike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stadio" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Ebike bici = new Ebike();
                string dis = System.IO.File.ReadAllText("ebike.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Ebike>(biciv[posizione]);
                bici.Longitudine = 45.70833;
                bici.Latitudine = 9.67991;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("ebike.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("ebike.json", biciv[x]);
                    }

                }
                else
                {
                    System.IO.File.AppendAllText("log.json", "depositato a:" + "stadio" + " |");
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("ebike.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("ebike.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("ebike.json", rimpiazza);
                        }
                    }

                }

            }
            else if (veicolo == "auto")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stadio" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                auto bici = new auto();
                string dis = System.IO.File.ReadAllText("auto.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<auto>(biciv[posizione]);
                bici.Longitudine = 45.70833;
                bici.Latitudine = 9.67991;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("auto.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("auto.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("auto.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("auto.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("auto.json", rimpiazza);
                        }
                    }

                }
            }
            else if (veicolo == "monopattino")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stadio" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Monopattino bici = new Monopattino();
                string dis = System.IO.File.ReadAllText("monopattino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Monopattino>(biciv[posizione]);
                bici.Longitudine = 45.70833;
                bici.Latitudine = 9.67991;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("monopattino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("monopattino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("monopattino.json", rimpiazza);
                        }
                    }

                }


            }
            else if (veicolo == "scooter")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stadio" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                motorinoE bici = new motorinoE();
                string dis = System.IO.File.ReadAllText("motorino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<motorinoE>(biciv[posizione]);
                bici.Longitudine = 45.70833;
                bici.Latitudine = 9.67991;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("motorino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("motorino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("motorino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("motorino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("motorino.json", rimpiazza);
                        }
                    }

                }


            }
            var f2 = new riepilogo();
            f2.ShowDialog();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (veicolo == "bike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stazione" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Bici bici = new Bici();
                string dis = System.IO.File.ReadAllText("bici.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Bici>(biciv[posizione]);
                bici.Longitudine = 45.69169;
                bici.Latitudine = 9.67578;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("bici.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("bici.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("bici.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("bici.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("bici.json", rimpiazza);
                        }
                    }

                }


            }

            else if (veicolo == "Ebike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stazione" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Ebike bici = new Ebike();
                string dis = System.IO.File.ReadAllText("ebike.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Ebike>(biciv[posizione]);
                bici.Longitudine = 45.69169;
                bici.Latitudine = 9.67578;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("ebike.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("ebike.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("ebike.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("ebike.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("ebike.json", rimpiazza);
                        }
                    }

                }

            }
            else if (veicolo == "auto")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stazione" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                auto bici = new auto();
                string dis = System.IO.File.ReadAllText("auto.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<auto>(biciv[posizione]);
                bici.Longitudine = 45.69169;
                bici.Latitudine = 9.67578;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("auto.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("auto.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("auto.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("auto.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("auto.json", rimpiazza);
                        }
                    }

                }
            }
            else if (veicolo == "monopattino")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stazione" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Monopattino bici = new Monopattino();
                string dis = System.IO.File.ReadAllText("monopattino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Monopattino>(biciv[posizione]);
                bici.Longitudine = 45.69169;
                bici.Latitudine = 9.67578;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("monopattino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("monopattino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("monopattino.json", rimpiazza);
                        }
                    }

                }


            }
            else if (veicolo == "scooter")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "stazione" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                motorinoE bici = new motorinoE();
                string dis = System.IO.File.ReadAllText("motorino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<motorinoE>(biciv[posizione]);
                bici.Longitudine = 45.69169;
                bici.Latitudine = 9.67578;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("motorino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("motorino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("motorino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("motorino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("motorino.json", rimpiazza);
                        }
                    }

                }


            }
            var f2 = new riepilogo();
            f2.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (veicolo == "bike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "orio center" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Bici bici = new Bici();
                string dis = System.IO.File.ReadAllText("bici.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Bici>(biciv[posizione]);
                bici.Longitudine = 45.66413;
                bici.Latitudine = 9.69370;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("bici.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("bici.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("bici.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("bici.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("bici.json", rimpiazza);
                        }
                    }

                }


            }

            else if (veicolo == "Ebike")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "orio center" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Ebike bici = new Ebike();
                string dis = System.IO.File.ReadAllText("ebike.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Ebike>(biciv[posizione]);
                bici.Longitudine = 45.66413;
                bici.Latitudine = 9.69370;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("ebike.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("ebike.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("ebike.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("ebike.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("ebike.json", rimpiazza);
                        }
                    }

                }

            }
            else if (veicolo == "auto")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "orio center" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                auto bici = new auto();
                string dis = System.IO.File.ReadAllText("auto.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<auto>(biciv[posizione]);
                bici.Longitudine = 45.66413;
                bici.Latitudine = 9.69370;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("auto.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("auto.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("auto.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("auto.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("auto.json", rimpiazza);
                        }
                    }

                }
            }
            else if (veicolo == "monopattino")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "orio center" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                Monopattino bici = new Monopattino();
                string dis = System.IO.File.ReadAllText("monopattino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<Monopattino>(biciv[posizione]);
                bici.Longitudine = 45.66413;
                bici.Latitudine = 9.69370;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("monopattino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("monopattino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("monopattino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("monopattino.json", rimpiazza);
                        }
                    }

                }


            }
            else if (veicolo == "scooter")
            {
                System.IO.File.AppendAllText("log.json", "depositato a:" + "orio center" + " |");
                DateTime localDate = DateTime.Now;
                System.IO.File.AppendAllText("log.json", "ora deposito" + localDate + " |");
                motorinoE bici = new motorinoE();
                string dis = System.IO.File.ReadAllText("motorino.json");
                string[] biciv = dis.Split('\n');
                bici = JsonSerializer.Deserialize<motorinoE>(biciv[posizione]);
                bici.Longitudine = 45.66413;
                bici.Latitudine = 9.69370;
                bici.Batteria = batteria;
                if (posizione == 0)
                {

                    string rimpiazza = JsonSerializer.Serialize(bici);
                    rimpiazza += "\n";
                    System.IO.File.WriteAllText("motorino.json", rimpiazza);
                    for (int x = 1; x < biciv.Length - 1; x++)
                    {
                        biciv[x] += "\n";
                        System.IO.File.AppendAllText("motorino.json", biciv[x]);
                    }

                }
                else
                {
                    biciv[0] += "\n";
                    System.IO.File.WriteAllText("motorino.json", biciv[0]);

                    for (int x = 1; x < biciv.Length - 1; x++)
                    {

                        if (x != posizione)
                        {
                            biciv[x] += "\n";
                            System.IO.File.AppendAllText("motorino.json", biciv[x]);
                        }
                        else
                        {
                            string rimpiazza = JsonSerializer.Serialize(bici);
                            rimpiazza += "\n";
                            System.IO.File.AppendAllText("motorino.json", rimpiazza);
                        }
                    }

                }


            }
            this.Hide();
            var f2 = new riepilogo();
            f2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
