using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
   static class protect
    {


        public static double Checkd(string? x)
        {
            double i;
            while (!double.TryParse(x, out i) || x == null)
            {
                Console.WriteLine("Please enter a vaild number : ");
                x = Console.ReadLine();


            } 

            return i;

        }

        public static int CheckTFin(string? x)
        {
            int i;
            while (!int.TryParse(x, out i) || x == null || (i<1) ||(i>2) )
            {
                Console.WriteLine("Please enter a vaild number  1 or 2 : ");
                x = Console.ReadLine();


            }

            return i;

        }


        public static int CheckMCQin(string? x)
        {
            int i;
            while (!int.TryParse(x, out i) || x == null || (i < 1) || (i > 3))
            {
                Console.WriteLine("Please enter a vaild number  1 or 2 or 3 : ");
                x = Console.ReadLine();


            }

            return i;

        }







        public static int Check(string? x)
        {
            int i;
            while (!int.TryParse(x, out i) || x == null)
            {
                Console.WriteLine("Please enter a vaild number : ");
                x= Console.ReadLine();


            }
             
            return i;
              
        }

       

        public static string check(string? x)
        {
            while (x =="")
            {
                Console.WriteLine("please enter a vaild input :");
                x= Console.ReadLine();
            } 

            return x;
        }








    }
}
