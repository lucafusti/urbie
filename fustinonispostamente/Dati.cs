using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fustinonispostamente
{
    public partial class Dati : Form
    {
        double xk;
        double yk;
        string tk;
        int eta;
        string p;

        /**
         * @fn  public Dati(double x, double y, string t)
         *
         * @brief   Load the page from the veichles
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   x   The x coordinate.
         * @param   y   The y coordinate.
         * @param   t   A string to process.
         */

        public Dati(double x, double y, string t)

        {
            InitializeComponent();
            xk = x;
            yk = y;
            tk = t;
            if (t == "bike")//check if the selected veichles is bike 
            {
               
                pictureBox1.Image = Image.FromFile("bici1.jpg");//insert the image of bike
                eta = 16;//impost the minimum age for use this veicles at 16 
            }

            else if (t == "Ebike")
            {
                pictureBox1.Image = Image.FromFile("ebike1.png");//insert the image of Ebike
                eta = 16;//impost the minimum age for use this veicles at 16 
            }
            else if (t == "auto")
            {
                pictureBox1.Image = Image.FromFile("auto1.png");//insert the image of auto
                //shows the parameters that are fondamental  to use the car
                label3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label1.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label5.Visible = true;
                label8.Visible = true;
                eta = 18; ;//impost the minimum age for use this veicles at 18
                p = "B";//impost the minimum level of the driver license at B
            }

            else if (t == "monopattino")
            {
                
                pictureBox1.Image = Image.FromFile("monopattino1.jpg");//insert the image of monopattino
                eta = 16; //impost the minimum age for use this veicles at 16 
            }

            else if (t == "scooter")
            {
                pictureBox1.Image = Image.FromFile("scooter1.png");//insert the image of monopattino
                //shows the parameters that are fondamental  to use the scooter
                label3.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label1.Visible = true;
                label8.Visible = true;
                textBox1.Visible = true;
                eta = 14;//impost the minimum age for use this veicles at 14
                p = "A";//impost the minimum level of the driver license at A
            }
        }


        /**
         * @fn  private void checkBox2_CheckedChanged(object sender, EventArgs e)
         *
         * @brief   check that all parameters are correct insert and give you the possibility to choose the veichles opening the selsction form
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)// check that checkBox1 as been checked
            {
                if (textBox3.Text != "")// check that age as been insert
                {
                    int m = Int32.Parse(textBox3.Text);//transform the age in a in variable
                    if (m >= eta)
                    {
                        if (radioButton1.Visible == true)//check if the driver licence is request 
                        {
                            if ((radioButton1.Checked == true && radioButton1.Text == p) || (radioButton2.Checked == true && radioButton2.Text == p))//check if the driver licence is the same requested
                            {
                                if (textBox1.TextLength == 10)//check if driver licensecode has the correct lenght
                                {
                                    if (textBox2.Visible == true)//check if the credit card is request
                                    {
                                        if (textBox2.TextLength == 16)//check if credit card has the correct lenght
                                        {
                                            this.Hide();
                                            var f1 = new veicoliclass(xk, yk, tk);

                                            f1.ShowDialog();
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        this.Hide();
                                        var f1 = new veicoliclass(xk, yk, tk);

                                        f1.ShowDialog();
                                        this.Close();
                                    }

                                }
                            }
                        }
                        else
                        {
                            this.Hide();
                            var f1 = new veicoliclass(xk, yk, tk);

                            f1.ShowDialog();
                            this.Close();
                        }
                    }
                }



            }
        }

        /**
         * @fn  private void textBox1_MouseLeave(object sender, EventArgs e)
         *
         * @brief   check that all parameters are correct insert and give you the possibility to choose
         *          the veichles opening the selsction form
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        // 
        //do the same of the checkBox2_CheckedChanged function but on  mouse leave of drive licence code
   
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    if (textBox3.Text != "")
                    {
                        int m = Int32.Parse(textBox3.Text);
                        if (m >= eta)
                        {
                            if (radioButton1.Visible == true)
                            {
                                if ((radioButton1.Checked == true && radioButton1.Text == p) || (radioButton2.Checked == true && radioButton2.Text == p))
                                {
                                    if (textBox1.TextLength == 10)
                                    {
                                        if (textBox2.Visible == true)
                                        {
                                            if (textBox2.TextLength == 16)
                                            {
                                                this.Hide();
                                                var f1 = new veicoliclass(xk, yk, tk);

                                                f1.ShowDialog();
                                                this.Close();
                                            }
                                        }
                                        else
                                        {
                                            this.Hide();
                                            var f1 = new veicoliclass(xk, yk, tk);

                                            f1.ShowDialog();
                                            this.Close();
                                        }

                                    }
                                }
                            }
                            else
                            {
                                this.Hide();
                                var f1 = new veicoliclass(xk, yk, tk);

                                f1.ShowDialog();
                                this.Close();
                            }
                        }
                    }



                }
            }
        }


        /**
         * @fn  private void textBox2_MouseLeave(object sender, EventArgs e)
         *
         * @brief   check that all parameters are correct insert and give you the possibility to choose the veichles opening the selsction form
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //do the same of the checkBox2_CheckedChanged function but on  mouse leave of credict cards
        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox3.Text != "")
                {
                    int m = Int32.Parse(textBox3.Text);
                    if (m >= eta)
                    {
                        if (radioButton1.Visible == true)
                        {
                            if ((radioButton1.Checked == true && radioButton1.Text == p) || (radioButton2.Checked == true && radioButton2.Text == p))
                            {
                                if (textBox1.TextLength == 10)
                                {
                                    if (textBox2.Visible == true)
                                    {
                                        if (textBox2.TextLength == 16)
                                        {
                                            this.Hide();
                                            var f1 = new veicoliclass(xk, yk, tk);

                                            f1.ShowDialog();
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        this.Hide();

                                        var f1 = new veicoliclass(xk, yk, tk);

                                        f1.ShowDialog();
                                        this.Close();
                                    }

                                }
                            }
                        }
                        else
                        {
                            this.Hide();
                            var f1 = new veicoliclass(xk, yk, tk);

                            f1.ShowDialog();
                            this.Close();
                        }
                    }
                }



            }
        }
    



        /**
         * @fn  private void textBox3_MouseLeave_1(object sender, EventArgs e)
         *
         * @brief   check that all parameters are correct insert and give you the possibility to choose the veichles opening the selsction form
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //do the same of the checkBox2_CheckedChanged function but on  mouse leave of age 
        private void textBox3_MouseLeave_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox3.Text != "")
                {
                    int m = Int32.Parse(textBox3.Text);
                    if (m >= eta)
                    {
                        if (radioButton1.Visible == true)
                        {
                            if ((radioButton1.Checked == true && radioButton1.Text == p) || (radioButton2.Checked == true && radioButton2.Text == p))
                            {
                                if (textBox1.TextLength == 10)
                                {
                                    if (textBox2.Visible == true)
                                    {
                                        if (textBox2.TextLength == 16)
                                        {
                                            this.Hide();
                                            var f1 = new veicoliclass(xk, yk, tk);

                                            f1.ShowDialog();
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        this.Hide();
                                        var f1 = new veicoliclass(xk, yk, tk);

                                        f1.ShowDialog();
                                        this.Close();
                                    }

                                }
                            }
                        }
                        else
                        {
                            this.Hide();
                            var f1 = new veicoliclass(xk, yk, tk);

                            f1.ShowDialog();
                            this.Close();
                        }
                    }
                }



            }
        }

        /**
         * @fn  private void radioButton1_CheckedChanged(object sender, EventArgs e)
         *
         * @brief   check that all parameters are correct insert and give you the possibility to choose the veichles opening the selsction form
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //do the same of the checkBox2_CheckedChanged function but on check of drive licence type a
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox3.Text != "")
                {
                    int m = Int32.Parse(textBox3.Text);
                    if (m >= eta)
                    {
                        if (radioButton1.Visible == true)
                        {
                            if ((radioButton1.Checked == true && radioButton1.Text == p) || (radioButton2.Checked == true && radioButton2.Text == p))
                            {
                                if (textBox1.TextLength == 10)
                                {
                                    if (textBox2.Visible == true)
                                    {
                                        if (textBox2.TextLength == 16)
                                        {
                                            this.Hide();
                                            var f1 = new veicoliclass(xk, yk, tk);

                                            f1.ShowDialog();
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        this.Hide();

                                        var f1 = new veicoliclass(xk, yk, tk);

                                        f1.ShowDialog();
                                        this.Close();
                                    }

                                }
                            }
                        }
                        else
                        {
                            this.Hide();
                            var f1 = new veicoliclass(xk, yk, tk);

                            f1.ShowDialog();
                            this.Close();
                        }
                    }
                }



            }
        }

        /**
         * @fn  private void radioButton2_CheckedChanged(object sender, EventArgs e)
         *
         * @brief   check that all parameters are correct insert and give you the possibility to choose the veichles opening the selsction form
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //do the same of the checkBox2_CheckedChanged function but on check of drive licence type b
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox3.Text != "")
                {
                    int m = Int32.Parse(textBox3.Text);
                    if (m >= eta)
                    {
                        if (radioButton1.Visible == true)
                        {
                            if ((radioButton1.Checked == true && radioButton1.Text == p) || (radioButton2.Checked == true && radioButton2.Text == p))
                            {
                                if (textBox1.TextLength == 10)
                                {
                                    if (textBox2.Visible == true)
                                    {
                                        if (textBox2.TextLength == 16)
                                        {
                                            this.Hide();
                                            var f1 = new veicoliclass(xk, yk, tk);

                                            f1.ShowDialog();
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        this.Hide();

                                        var f1 = new veicoliclass(xk, yk, tk);

                                        f1.ShowDialog();
                                        this.Close();
                                    }

                                }
                            }
                        }
                        else
                        {
                            this.Hide();
                            var f1 = new veicoliclass(xk, yk, tk);

                            f1.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
