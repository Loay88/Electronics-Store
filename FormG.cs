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
    public partial class FormG : Form
    {
        Gears[] g = { new Gears(600, "White", "Wireless","Logitech G305"), new Gears(400, "Black", "Wired","RedRagon m910")
        , new Gears(550, "Black", "Wired","HyperX Pulsefire FPS Pro"), new Gears(800, "Black", "Wired","Razer Viper Mini"),
          new Gears(2200, "Black RGB", "Wired","Logitech G Pro"), new Gears(1500, "Black RGB", "Wired","HyperX Alloy Origins "),
          new Gears(550, "White RGB", "Wired Gaming","Redragon k552"), new Gears(2800, "Black RGB", "Wired","Corsair K65"),
          new Gears(1500, "Black", "Wired","CoolerMaster MH751"), new Gears(2500, "Black & Red", "Wireless","HyperX cloud 2")
        , new Gears(2700, "Black", "Wired","Logitech G PRO X"), new Gears(420, "Pink", "Wired","ONIKUMA"),
          new Gears(6000, "Black", "27 Inch 144Hz","SAMSUNG  Odyssey G5"), new Gears(3200, "Black", " 24 inch 165Hz","Acer Nitro")
        , new Gears(3800, "Black", "23.6 Inch 165Hz","ASUS TUF "), new Gears(4500, "Black", " 24 Inch 144Hz","BenQ Zowie XL2411K")};
        public FormG()
        {
            InitializeComponent();
            label15.Text = g[0].GetData();
            label14.Text = g[1].GetData();
            label13.Text = g[2].GetData();
            label12.Text = g[3].GetData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/mouses/g305.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/mouses/m910.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/mouses/HyperX Pulsefire.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/mouses/viper.jpg";
        }

        private void FormG_Load(object sender, EventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
            label9.BackColor = Color.Yellow;
            label8.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label15.Text = g[4].GetData();
            label14.Text = g[5].GetData();
            label13.Text = g[6].GetData();
            label12.Text = g[7].GetData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Keyboards/Logitech G PRO Mechanical Gaming Keyboard.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Keyboards/allot.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Keyboards/k552.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Keyboards/k65.jpg";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Yellow;
            label9.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label15.Text = g[0].GetData();
            label14.Text = g[1].GetData();
            label13.Text = g[2].GetData();
            label12.Text = g[3].GetData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/mouses/g305.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/mouses/m910.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/mouses/HyperX Pulsefire.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/mouses/viper.jpg";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label8.BackColor = Color.Yellow;
            label10.BackColor = Color.Transparent;
            label15.Text = g[8].GetData();
            label14.Text = g[9].GetData();
            label13.Text = g[10].GetData(); 
            label12.Text = g[11].GetData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Headsets/mh751.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Headsets/HyperX Cloud 2.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Headsets/G ProX.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Headsets/zeus.jpg";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label10.BackColor = Color.Yellow;
            label15.Text = g[12].GetData();
            label14.Text =g[13].GetData();
            label13.Text = g[14].GetData();
            label12.Text = g[15].GetData();
            pic1.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Monitors/samsung.jpg";
            pic3.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Monitors/nitro.jpg";
            pic2.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Monitors/tuf.jpg";
            pic4.ImageLocation = "C:/Users/asobh/Desktop/project photos-20220118T163013Z-001/project photos/Geears/Monitors/zowie.jpg";
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

        private void label12_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
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
    }
}
