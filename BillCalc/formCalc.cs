using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillCalc
{
    public partial class formCalc : Form
    {
        public formCalc()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            string starting = balanceBox.Text;
            string rent = rentBox.Text;
            string lights = lightBox.Text;
            string cable = cableBox.Text;
            string water = waterBox.Text;
            string cell = cellBox.Text;
            string car1 = carBox1.Text;
            string car2 = carBox2.Text;
            string insurance = insBox.Text;
            string other = otherBox.Text;

            string balance = (
                Convert.ToDecimal(starting) -
                Convert.ToDecimal(rent) -
                Convert.ToDecimal(lights) -
                Convert.ToDecimal(cable) -
                Convert.ToDecimal(water) -
                Convert.ToDecimal(cell) -
                Convert.ToDecimal(car1) -
                Convert.ToDecimal(car2) - 
                Convert.ToDecimal(insurance) -
                Convert.ToDecimal(other)).ToString();

            MessageBox.Show("Remaining Balance: \n" + "$" + balance);

        }
    }
}
