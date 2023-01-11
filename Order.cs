using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicsStore
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == ""
                    || textBox6.Text == "" || textBox7.Text == "")
                {
                    throw new Exception("Please complete your data!");
                }
                if(textBox1.Text.Length<11 || textBox2.Text.Length < 5 || 
                    (textBox3.Text.Length < 11 && (!textBox3.Text.Contains("@gmail.com") || !textBox3.Text.Contains("@yahoo.com") || !textBox3.Text.Contains("@hotmail.com")))
                    || textBox4.Text.Length < 11 || textBox5.Text.Length < 7
                    || textBox6.Text.Length < 5 || textBox7.Text.Length < 11)
                {
                    throw new Exception("Please complete your data!");
                }
                this.Hide();
                MessageBox.Show("Order Complete.\nThanks for visiting us :)");
            }
            catch (Exception exc)
            {
                label8.Text = exc.Message;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
