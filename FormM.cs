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
    public partial class FormM : Form
    {
        Product[] products = { new mobile("A32", 4700, "Samsung",12,"5 inch", "6 Gb","128Gb", "12 MP", "Black", "5000 mA")
            ,new mobile("A52S", 7000, "Samsung",12,"6.5 inch", "8 Gb","256Gb", "64 MP", "Awesome Mint", "4500 mA"),
            new mobile("Iphone13", 18000, "Apple",12,"6.1 inch", "8 Gb","256Gb", "12 MP4k", "White", "3240 mA"),
            new mobile("Redmi Note 10 Pro", 6444, "Xiaomi",12,"6.67 inch", "8 Gb","128Gb", "64 MP", "Gray", "4000 mA")};
        public FormM()
        {
            InitializeComponent();
            pic.Visible = false;
            label7.Text = products[0].GetData();
            label8.Text = products[1].GetData();
            label9.Text = products[2].GetData();
            label10.Text = products[3].GetData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[0].GetData();
            mobile m = products[0] as mobile;
            label11.Text = m.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Mobiles/a32.jpg";
            pic.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label6.Visible = false;
            label11.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pic.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[1].GetData();
            mobile m = products[1] as mobile;
            label11.Text = m.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Mobiles/a52s.jpg";
            pic.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[2].GetData();
            mobile m = products[2] as mobile;
            label11.Text = m.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Mobiles/i13.jpg";
            pic.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[3].GetData();
            mobile m = products[3] as mobile;
            label11.Text = m.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Mobiles/redmi.jpg";
            pic.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormL l = new FormL();
            l.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormA a = new FormA();
            a.Show();
            this.Hide();
        }

        private void FormM_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormG ge = new FormG();
            ge.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[0].GetData();
            mobile m = products[0] as mobile;
            label11.Text = m.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Mobiles/a32.jpg";
            pic.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[1].GetData();
            mobile m = products[1] as mobile;
            label11.Text = m.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Mobiles/a52s.jpg";
            pic.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[2].GetData();
            mobile m = products[2] as mobile;
            label11.Text = m.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Mobiles/i13.jpg";
            pic.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[3].GetData();
            mobile m = products[3] as mobile;
            label11.Text = m.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Mobiles/redmi.jpg";
            pic.Visible = true;
        }
    }
}
