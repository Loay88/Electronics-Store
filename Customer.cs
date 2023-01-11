using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{
    internal class Customer : Person
    {
        public string CustomerID { get; set; }
        public string Password { get; set; }
        public string address { get; set; }
        public double balance { get;private set; }

        public Customer(string n, string g, int a,string id,string pw,string ad,double bal) : base(n,g,a)
        {
            CustomerID = id;
            Password = pw;
            address = ad;
            balance = bal;
        }
        public override string GetData()
        {
            return "Username: "+CustomerID+"\nName: " + Name + "\nGender: " + gender + "\nAge: " + age + "\nAddress: " + address + "\nAccount balance: " + balance + "EGP\n";

        }

    }
}
