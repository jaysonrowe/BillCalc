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

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            string balance =
            (Convert.ToDouble(balanceBox.Text) - Convert.ToDouble(rentBox.Text) - Convert.ToDouble(lightBox.Text) -
             Convert.ToDouble(cableBox.Text) - Convert.ToDouble(waterBox.Text) - Convert.ToDouble(cellBox.Text) - Convert.ToDouble(carBox1.Text) -
             Convert.ToDouble(carBox2.Text) - Convert.ToDouble(otherBox.Text)).ToString();
            MessageBox.Show("$" + balance);
        }
    }
}
