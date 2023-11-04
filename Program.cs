using System.Diagnostics;

namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject(10, "c#");
            sub.CreateExam();
            

            Console.WriteLine("Do You Want To Start The Exam (y | n)");

            string s= protect.check(Console.ReadLine());
            if(s == "y")
            {
                Stopwatch  sw = new Stopwatch();
                sw.Start();
                sub.exam.ShowExam(sw);
                Console.WriteLine($"The Elpased Time = {sw.Elapsed}");

               
            }


        }
    }
}