using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class RBI 
    { 
        public virtual void calculateInterest(int principle,float rate,int time)
        {
            Console.WriteLine("Interest of RBI = " + (principle * rate * time) / 100);
        }
    }
    class HDFC:RBI
    {
        public override void calculateInterest(int principle, float rate, int time)
        {
            Console.WriteLine("Interest of HDFC = " + (principle * rate * time) / 100);
        }
    }
    class SBI:RBI
    {
        public override void calculateInterest(int principle, float rate, int time)
        {
            Console.WriteLine("Interest of SBI = " + (principle * rate * time) / 100);
        }
    }
    class ICICI:RBI
    {
        public override void calculateInterest(int principle, float rate, int time)
        {
            Console.WriteLine("Interest of ICICI = " + (principle * rate * time) / 100);
        }
    }
    internal class Lab_4_3
    {
        public void run()
        {
            RBI rbi = new RBI();
            RBI hdfc = new HDFC();
            RBI sbi = new SBI();
            RBI icici = new ICICI();
            Console.Write("Enter principle of RBI : ");
            int p1 = int.Parse(Console.ReadLine());
            Console.Write("Enter rate of interest of RBI : ");
            float r1 = float.Parse(Console.ReadLine());
            Console.Write("Enter time period of RBI : ");
            int t1 = int.Parse(Console.ReadLine());
            rbi.calculateInterest(p1, r1, t1);
            Console.Write("Enter principle of HDFC : ");
            int p2 = int.Parse(Console.ReadLine());
            Console.Write("Enter rate of interest of HDFC : ");
            float r2 = float.Parse(Console.ReadLine());
            Console.Write("Enter time period of HDFC : ");
            int t2 = int.Parse(Console.ReadLine());
            hdfc.calculateInterest(p2, r2, t2);
            Console.Write("Enter principle of SBI : ");
            int p3 = int.Parse(Console.ReadLine());
            Console.Write("Enter rate of interest of SBI : ");
            float r3 = float.Parse(Console.ReadLine());
            Console.Write("Enter time period of SBI : ");
            int t3 = int.Parse(Console.ReadLine());
            sbi.calculateInterest(p3, r3, t3);
            Console.Write("Enter principle of ICICI : ");
            int p4 = int.Parse(Console.ReadLine());
            Console.Write("Enter rate of interest of ICICI : ");
            float r4 = float.Parse(Console.ReadLine());
            Console.Write("Enter time period of ICICI : ");
            int t4 = int.Parse(Console.ReadLine());
            icici.calculateInterest(p4, r4, t4);

        }
    }
}
