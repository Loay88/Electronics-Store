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
    public partial class FormA : Form
    {
        Accessories[] Acc = { new Accessories(100, "Dark Blue", "Samsung A32"), new Accessories(75, "Black", "Redmi Note 10 Pro")
        ,new Accessories(75, "Red and black", "Samsung A52S"),new Accessories(150, "Light Blue", "Iphone13"),
         new Accessories(100, "White", "Type C"), new Accessories(75, "Black", "Micro USB"),
         new Accessories(200, "White", "IphonecCharger"), new Accessories(300, "White", "Fast charging Type C"),
        new Accessories(75, "Black", "Samsung A32"), new Accessories(50, "Green", "Redmi Note 10 Pro")
        ,new Accessories(75, "Red", "Samsung A52S"),new Accessories(100, "Blue", "Iphone13"),
         new Accessories(2000, "Phantom violet", "Galaxy buds"), new Accessories(400, "Black", "Mi earbuds")
        ,new Accessories(250, "white", "Samsung"),new Accessories(3500, "White", "AirPods Pro")};
        public FormA()
        {
            InitializeComponent();
            label15.Text = Acc[0].GetData();
            label14.Text = Acc[1].GetData();
            label13.Text = Acc[2].GetData();
            label12.Text = Acc[3].GetData();
        }

        private void FormA_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormL l = new FormL();
            l.Show();
            this.Hide();
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
            this.Hide();
            m.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Yellow;
            label9.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label15.Text = Acc[0].GetData();
            label14.Text = Acc[1].GetData();
            label13.Text = Acc[2].GetData();
            label12.Text = Acc[3].GetData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/Covers/a32.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/Covers/redmi.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/Covers/a52s.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/Covers/i13.jpg";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
            label9.BackColor = Color.Yellow;
            label8.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label15.Text = Acc[4].GetData();
            label14.Text = Acc[5].GetData();
            label13.Text = Acc[6].GetData();
            label12.Text = Acc[7].GetData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/chargers/typec.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/chargers/micro.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/chargers/iphone.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/chargers/fast charger.jpg";

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label8.BackColor = Color.Yellow;
            label10.BackColor = Color.Transparent;
            label15.Text = Acc[8].ScreenData();
            label14.Text = Acc[9].ScreenData();
            label13.Text = Acc[10].ScreenData();
            label12.Text = Acc[11].ScreenData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/Screen Savers/a32.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/Screen Savers/redmi.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/Screen Savers/a52s.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/Screen Savers/i13.jpg";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label10.BackColor = Color.Yellow;
            label15.Text = Acc[12].GetData();
            label14.Text = Acc[13].GetData();
            label13.Text = Acc[14].GetData();
            label12.Text = Acc[15].GetData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/earphones/buds.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/earphones/mi.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/earphones/samsung.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Acc/earphones/airpods.jpg";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormG ge = new FormG();
            ge.Show();
            this.Hide();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
