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
    public partial class FormL : Form
    {
        Product[] products = { new Laptop("Triton 500", 30000, "Acer Predator",12,"15.6 inch", 300,"16Gb","512Gb SSD", "RTX 2070 Super", "Intel core i7 10th gen", "Black")
            ,new Laptop("Inspiron 3000 15", 10000, "Dell",12,"15.6 inch", 60,"8Gb","1T HDD", "GTX 1060", "Intel core i3 10th gen", "Silver"),
            new Laptop("Alienware R5", 58000, "Dell",12,"15.6 inch", 300,"32Gb","", "NVidia 1070 OC", "Intel core i7 8th gen", "Black"),
            new Laptop("MacBook Pro", 26000, "Apple",18,"13 inch", 120,"8Gb","256Gb", "8 core GPU", "Apple m1 chip", "White")};
        public FormL()
        {
            InitializeComponent();
            pic.Visible = false;
            label7.Text = products[0].GetData();
            label8.Text = products[1].GetData();
            label9.Text = products[2].GetData();
            label10.Text = products[3].GetData();
        }
       
        private void FormL_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[0].GetData();
            Laptop l = products[0] as Laptop;
            label11.Text = l.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Laptops/triton.jpg";
            pic.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[1].GetData();
            Laptop l = products[1] as Laptop;
            label11.Text = l.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Laptops/inspiron.jpg";
            pic.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[2].GetData();
            Laptop l = products[2] as Laptop;
            label11.Text = l.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Laptops/r5.jpg";
            pic.Visible = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[3].GetData();
            Laptop l = products[3] as Laptop;
            label11.Text = l.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Laptops/macbook.jpg";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormM m = new FormM();
            m.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormA a = new FormA();
            a.Show();
            this.Hide();
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
            Laptop l = products[0] as Laptop;
            label11.Text = l.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Laptops/triton.jpg";
            pic.Visible = true;
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[2].GetData();
            Laptop l = products[2] as Laptop;
            label11.Text = l.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Laptops/r5.jpg";
            pic.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[1].GetData();
            Laptop l = products[1] as Laptop;
            label11.Text = l.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Laptops/inspiron.jpg";
            pic.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label6.Text = products[3].GetData();
            Laptop l = products[3] as Laptop;
            label11.Text = l.Specs();
            label6.Visible = true;
            label11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pic.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Laptops/macbook.jpg";
            pic.Visible = true;
        }
    }
}
