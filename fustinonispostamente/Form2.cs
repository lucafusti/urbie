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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /**
         * @fn  private void pictureBox2_Click(object sender, EventArgs e)
         *
         * @brief   on click add in the logs file that the bike is removed at ospedale
         *          open the form to choose veichles passing the coordinates  
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ospedale
            System.IO.File.AppendAllText("log.json", "prelevato a: ospedale" + " |");//write on file 
            this.Hide();
            var f1 = new vDisp(45.68650, 9.63379);//open the form of veichles passing the coordinates 
            f1.ShowDialog();
            this.Close();
        }

        /**
         * @fn  private void pictureBox3_Click_1(object sender, EventArgs e)
         *
         * @brief   on click add in the logs file that the bike is removed at colle aperto
         *          open the form to choose veichles passing the coordinates
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //colle aperto
            System.IO.File.AppendAllText("log.json", "prelevato a: colle aperto" + " |");//write on file 
            this.Hide();
            var f1 = new vDisp(45.70639, 9.65907);//open the form of veichles passing the coordinates 
            f1.ShowDialog();
            this.Close();
        }

        /**
         * @fn  private void pictureBox4_Click_1(object sender, EventArgs e)
         *
         * @brief   on click add in the logs file that the bike is removed at stadio
         *          open the form to choose veichles passing the coordinates
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            //stadio
            System.IO.File.AppendAllText("log.json", "prelevato a: stadio" + " |");//write on file 
            this.Hide();
            var f1 = new vDisp(45.70833, 9.67991);//open the form of veichles passing the coordinates 
            f1.ShowDialog();
            this.Close();
        }

        /**
         * @fn  private void pictureBox5_Click(object sender, EventArgs e)
         *
         * @brief   on click add in the logs file that the bike is removed at stazione
         *          open the form to choose veichles passing the coordinates
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //stazione
            System.IO.File.AppendAllText("log.json", "prelevato a: stazione" + " |");//write on file 
            this.Hide();
            var f1 = new vDisp(45.69169, 9.67578);//open the form of veichles passing the coordinates 
            f1.ShowDialog();
            this.Close();
        }

        /**
         * @fn  private void pictureBox6_Click(object sender, EventArgs e)
         *
         * @brief   on click add in the logs file that the bike is removed at orio
         *          open the form to choose veichles passing the coordinates
         *
         * @author  Fustinoni
         * @date    02/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //orio
            System.IO.File.AppendAllText("log.json", "prelevato a: orio" + " |");//write on file 
            this.Hide();
            var f1 = new vDisp(45.66413, 9.69370);//open the form of veichles passing the coordinates 
            f1.ShowDialog();
            this.Close();
        }

    }
}
