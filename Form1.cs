using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenny_s
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BasicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void PremiumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void UltraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void AirFreshenerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void FinalizeSelection_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
            double totalCost = 0.0;

            if (AirFreshenerCheckBox.Checked == true)
            {
                totalCost += 2.0;
            }
            if (VacuumCheckBox.Checked == true)
            {
                totalCost += 2.0;
            }
            if (WaxOnCheckBox.Checked == true)
            {
                totalCost += 5.0;
            }
            if (TireShineCheckBox.Checked == true)
            {
                totalCost += 5.0;
            }


        }

        public void TireShineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void VacuumCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void WaxOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void ReceiptTextBlockW_TextChanged(object sender, EventArgs e)
        {


        }

        public void ReceiptTextBlockA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
