using System;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Rose
    {
        public string Rname, Rdescription, Rheight, Rcircumference;
        public int Ramount;

        public Rose(string RName, string RDescription, string RHeight, string RCircumference, int RAmount)
        {
            Rname = RName;
            Rdescription = RDescription;
            Rheight = RHeight;
            Rcircumference = RCircumference;
            Ramount = RAmount;
        }
        public void Datarose1()
        {
            Console.WriteLine("ดอกกุหลาบสีขาว", this.Rname);
            Console.WriteLine("สวยงามมาก", this.Rdescription);
            Console.WriteLine("2", this.Ramount);
            Console.WriteLine("10.5 cm", this.Rheight);
            Console.WriteLine("6 cm", this.Rcircumference);
        }
        public void Datarose2()
        {
            Console.WriteLine("ดอกกุหลาบสีแดง", this.Rname);
            Console.WriteLine("สวยงามมาก", this.Rdescription);
            Console.WriteLine("2", this.Ramount);
            Console.WriteLine("10.5 cm", this.Rheight);
            Console.WriteLine("6 cm", this.Rcircumference);
        }
    }
    class Sunflower
    {
        public string Sname, Sdescription, Sheight, Scircumference;
        public int Samount;
        public Sunflower(string SName, string SDescription, string SHeight, string SCircumference, int SAmount)
        {
            Sname = SName;
            Sdescription = SDescription;
            Sheight = SHeight;
            Scircumference = SCircumference;
            Samount = SAmount;
        }
        public void DataSunflower1()
        {
            Console.WriteLine("ดอกทานตะวันเล็ก", this.Sname);
            Console.WriteLine("สวยงาม", this.Sdescription);
            Console.WriteLine("1", this.Samount);
            Console.WriteLine("2.0 cm", this.Sheight);
            Console.WriteLine("2.0 cm", this.Scircumference);
        }
        public void DataSunflower2()
        {
            Console.WriteLine("ดอกทานตะวันขนาดใหญ่", this.Sname);
            Console.WriteLine("สวยงาม", this.Sdescription);
            Console.WriteLine("1", this.Samount);
            Console.WriteLine("2.0 cm", this.Sheight);
            Console.WriteLine("2.0 cm", this.Scircumference);
        }
    }
}
© 2021 GitHub, Inc.