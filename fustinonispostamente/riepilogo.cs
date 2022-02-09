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
    public partial class riepilogo : Form
    {
        public riepilogo()
        {
            InitializeComponent();
        }

        /**
         * @fn  private void riepilogo_Load(object sender, EventArgs e)
         *
         * @brief   it show all the information of your ride, reading them from the log file
         *
         * @author  Fustinoni
         * @date    26/01/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void riepilogo_Load(object sender, EventArgs e)
        {
            string dis = System.IO.File.ReadAllText("log.json");
            string[] biciv = dis.Split('\n');
            string[] app = biciv[biciv.Length-1].Split('|');

            label2.Text = app[0];
            label3.Text = app[1];
            label4.Text = app[2];
            label5.Text = app[3];
            label6.Text = app[4];
            label7.Text = app[5];
            label8.Text = app[6];
            label9.Text = app[7];



        }
    }
}
