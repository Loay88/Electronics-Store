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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text1.Text =="Loay" && text2.Text=="8800" )
            {
                Form1 h = new Form1(text1.Text);
                h.Show();
                this.Hide();
            }
            else if (text1.Text == "Sobhyz" && text2.Text == "0000")
            {
                Form1 h = new Form1(text1.Text);
                h.Show();
                this.Hide();
            }
            else
            {
                label4.Visible = true;
            }


        }
    }
}
