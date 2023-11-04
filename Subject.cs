using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Subject
    {

        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public Exam exam;


        public Subject(int SubjectID , string SubjectName)
        {
            this.SubjectID = SubjectID;
            this.SubjectName = SubjectName;
        }
        public void CreateExam()
        {
            double time=0;
            int number=0;
            Console.Write("Please enter the Type of Exam u wanna to create( 1 for practical and 2 for final) ");
             int i=protect.CheckTFin(Console.ReadLine());
            Console.Write("Please Enter the Time Of Exam in Minutes: ");
            time = protect.Checkd(Console.ReadLine());
            Console.Write("Please Enter the Number Of Questions You Wantes To Create: ");
            number = protect.Check(Console.ReadLine());
            if (i == 1)
            {
               
                exam = new Practical(time,number);
                

                 
            }

            else if (i == 2)
            {
               
                exam = new Final(time , number);

            }

            Console.Clear();
            exam.CreateExam(number);
        }

    }
}
