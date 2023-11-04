using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Final:Exam
    {
        TFQuestion tfquestion=new TFQuestion();
        MCQOneAnswer mcqoneanswer = new MCQOneAnswer();
        public Final(double Time, int NumberOfQuestion) : base(Time ,NumberOfQuestion) 
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

                Console.Write($"Please Enter The Type Of Question Number({counter}) 1) for True OR False || 2 for MCQ:");
                int i = protect.CheckTFin(Console.ReadLine());
                Console.Clear();
                if (i == 1)
                {
                   
                   
                    tfquestion.CreateQuestion();
                }

                else if (i == 2)
                {
                   
                   
                    mcqoneanswer.CreateQuestion();
                }
               
                NumberOfQuestion -= 1;
                counter++;
                Console.Clear();

            }while(NumberOfQuestion!=0);
        }


        public override void ShowExam(Stopwatch sw)
        {
       
            if(tfquestion is not null)
            {
                tfquestion.ShowQuestion();   
            }

            if(mcqoneanswer is not null)
            {
                mcqoneanswer.ShowQuestion();
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

            if(tfquestion is not null) {
                tfquestion.ShowQuestionAnswers();
            }
          if(mcqoneanswer is not null)
            {
                mcqoneanswer.ShowQuestionAnswers();
            }

        }



    }
}
