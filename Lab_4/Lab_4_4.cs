using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Hospital
    {
        public virtual void HospitalDetails(int beds,String specialization)
        {
            Console.WriteLine("No. of beds : "+beds+"\n Specialization : "+specialization);
        }
    }
    class Apollo: Hospital
    {
        public override void HospitalDetails(int beds, string specialization)
        {
            Console.WriteLine("Apollo : ");
            Console.WriteLine("No. of beds : " + beds + "\n Specialization : " + specialization);
        }
    }
    class Wockhardt:Hospital
    {
        public override void HospitalDetails(int beds, string specialization)
        {
            Console.WriteLine("Wockhardt : ");
            Console.WriteLine("No. of beds : " + beds + "\n Specialization : " + specialization);
        }
    }
    class Gokul_Speciallity:Hospital
    {
        public override void HospitalDetails(int beds, string specialization)
        {
            Console.WriteLine("Gokul_Speciality : ");
            Console.WriteLine("No. of beds : " + beds + "\n Specialization : " + specialization);
        }
    }
    internal class Lab_4_4
    {
        public void run()
        {
            Hospital Apollo = new Apollo();
            Hospital Wockhardt = new Wockhardt();
            Hospital Gokul_Speciality = new Gokul_Speciallity();
            Console.Write("Enter no. of beds in Apollo : ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Specialization of Apollo : ");
            String s1 = Console.ReadLine();
            Apollo.HospitalDetails(b1, s1);
            Console.Write("Enter no. of beds in Wockhardt : ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Specialization of Wockhardt : ");
            String s2 = Console.ReadLine();
            Wockhardt.HospitalDetails(b2, s2);
            Console.Write("Enter no. of beds in Gokul_Speciality : ");
            int b3 = int.Parse(Console.ReadLine());
            Console.Write("Enter Specialization of Gokul_speciality : ");
            String s3 = Console.ReadLine();
            Gokul_Speciality.HospitalDetails(b3, s3);
        }
    }
}
