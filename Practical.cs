using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{

    internal class Practical : Exam
    {
        MCQOneAnswer question1 = new MCQOneAnswer();
       

        public Practical(double Time, int NumberOfQuestion) : base(Time, NumberOfQuestion)
        {

        }


        public override void CreateExam(int NumberOfQuestion)
        {


            string Body;
            double Mark;
            string answer;
            int counter = 1;
            do
            {

                
                    question1.CreateQuestion();
                
                NumberOfQuestion -= 1;
                counter++;
                Console.Clear();

            } while (NumberOfQuestion != 0);
        }


        public override void ShowExam(Stopwatch sw)
        {

            if (question1 is not null)
            {
                question1.ShowQuestion();
            }

           

            Console.Clear();
            ShowAnswers();

            Console.WriteLine($"Your Exam Grade is {Exam.grade} from {Exam.total} ");
            
            if (sw.Elapsed.TotalMinutes >= Time)
            {
                Console.Write("You Have Taken More Than Exam Time  ");

            }

        }


        public override void ShowAnswers()
        {

            if (question1 is not null)
            {
                question1.ShowQuestionAnswers();
            }
           

        }

    }
}
