using System;
using System.Text.Json;
using System.Windows.Forms;

namespace fustinonispostamente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * @fn  private void Login_Click(object sender, EventArgs e)
         *
         * @brief   open the login form
         *
         * @author  Fustinoni
         * @date    09/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void Login_Click(object sender, EventArgs e)
        {
            var f1 = new Login();
            f1.ShowDialog();

        }

        /**
         * @fn  private void Register_Click(object sender, EventArgs e)
         *
         * @brief   open the register form
         *
         * @author  Fustinoni
         * @date    09/02/2022
         *
         * @param   sender  Source of the event.
         * @param   e       Event information.
         */

        private void Register_Click(object sender, EventArgs e)
        {
            var f2 = new Register();
            f2.ShowDialog();
        }
    }
}
