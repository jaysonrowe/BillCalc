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
            string balance =
            (Convert.ToDecimal(balanceBox.Text) - Convert.ToDecimal(rentBox.Text) - Convert.ToDecimal(lightBox.Text) -
             Convert.ToDecimal(cableBox.Text) - Convert.ToDecimal(waterBox.Text) - Convert.ToDecimal(cellBox.Text) - Convert.ToDecimal(carBox1.Text) -
             Convert.ToDecimal(carBox2.Text) - Convert.ToDecimal(otherBox.Text)).ToString();
            MessageBox.Show("$" + balance);
        }
    }
}
