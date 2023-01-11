using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{
    abstract class Person
    {
        public string Name { get; set; }  
        public string gender { get; set; }
        public int age { get; set; }
        public Person(string n , string g , int a)
        {
            Name = n;
            gender = g;
            age = a;
        }
        public abstract string GetData();
    }
}
