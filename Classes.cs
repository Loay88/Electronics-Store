using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStore
{
    abstract class Product
    {
        public int warranty { private set; get; }
        public string brand { private set; get; }
        public string model { private set; get; }
        public double price { private set; get; }
        public Product(string m, double p, string b, int w) { model = m; price = p; brand = b; warranty = w; }

        public Product() { }
        public virtual string GetData()
        {
            return "Brand: "+ brand+ "\nModel: " + model + "\nPrice: " + price + "EGP\nWarranty: " + warranty +" months\n" ;
        }
        public abstract string Specs();
    }
    class mobile:Product
    {
        public string Size { private set; get; }
        public string ram { private set; get; }
        public string memory { private set; get; }
        public string camera { private set; get; }
        public string Color { private set; get; }
        public string battery { private set; get; }
        public mobile(string m, double p,string b, int w ,string s,string r,string mem, string cam,string c,string bat) : base(m, p,b,w) {
            Size = s;
            ram = r;
            memory = mem;
            camera = cam;
            Color = c;
            battery = bat;
        }
        public mobile() { }
        public override string GetData()
        {
            return base.GetData();
        }
        public override string Specs()
        {
            return "Size: " + Size + "\nRam: " + ram +"\nInternal Memory: "+memory+ "\nCamera: " + camera + "\nColor: " + Color + "\nBattery: "+battery+"\n";
        }
    }
    class Accessories : mobile
    {
        public double priceA { private set; get; }
        public string colorA { private set; get; }
        public string typeA { private set; get; }
        public Accessories(double p , string c, string t){ priceA = p;colorA = c;  typeA = t;}
        public override string GetData(){return "Model: " + typeA + "\nColor: " + colorA + "\nPrice: " + priceA + "EGP\n"; }
        public string ScreenData() { return "Model: " + typeA  + "\nPrice: " + priceA + "EGP\n"; }
    }
    class Laptop : Product
    {
        public string sizeL { private set; get; }
        public int screenL { private set; get; }
        public string ram { private set; get; }
        public string hard { private set; get; }
        public string gpu { private set; get; }
        public string cpu { private set; get; }
        public string colorL { private set; get; }

        public Laptop(string m, double p, string b, int w,string sizel,int sl,string r,string h,string g, string c,string co) : base(m, p, b, w) 
        {
            sizeL = sizel;
            screenL = sl;
            ram = r;
            hard = h;
            gpu = g;
            cpu = c;
            colorL = co;
        }
        public Laptop() { }
        public override string GetData()
        {
            return base.GetData();
        }
        public override string Specs(){ return "Size: " + sizeL + "\nScreen: " + screenL + " Hz\nRAM: " + ram + "\nGPU: " + gpu + "\nCPU: " + cpu + "\nColor: " + colorL;}
    }
    
    class Gears:Laptop
    {
        public double priceG { private set; get; }
        public string colorG { private set; get; }
        public string typeG { private set; get; }
        public string modelG { private set; get; }
        public Gears(double pg , string cg , string tg , string mg) { priceG = pg; colorG = cg;typeG = tg;modelG = mg; }
        public override string GetData()
        {
            return "Model: " + modelG +"\nType: "+typeG+ "\nColor: " + colorG + "\nPrice: " + priceG + "EGP\n";
        }
    }

}
