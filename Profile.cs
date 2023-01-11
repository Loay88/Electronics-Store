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
    public partial class Profile : Form
    {
        Customer L = new Customer("Loay", "Male", 20, "Loay", "8800", "204 San Stefano st", 3500);
        Customer S = new Customer("Sobhy", "Male", 20, "Sobhyz", "0000", "199 Miami st", 50000);
        public Profile(string id)
        {
            InitializeComponent();
            if (id == L.CustomerID)
            {
                label1.Text = L.GetData();
            }
            else
                label1.Text = S.GetData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1();
            h.Show();
            this.Hide();
        }
    }
}
