using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MCQOneAnswer:Question
    {
        MCQOneAnswer[] q=new MCQOneAnswer[100];
        string[] options;
        Answer[] answer=new Answer[100];
        public  int counter { get; set; }

       
        public MCQOneAnswer()
        {
            
        }
        public MCQOneAnswer(string Header, string Body, double Mark,Answer[] answer, string[] options) : base(Header, Body, Mark,answer)
        {

            this.options=options;
            counter = 0;
        }
        
        public override void CreateQuestion()
        {
            string Body;
            double Mark;
            int answer_num;
            string answerText;

            Console.WriteLine("Choose One Answer");
            Console.WriteLine("Please Enter The Body Of Question");
            Body =protect.check(Console.ReadLine());
            Console.WriteLine("Please Enter The Mark Of Question:");
            Mark = protect.Checkd(Console.ReadLine());
            Console.WriteLine("The choices of the Question:");

            options = new string[3];
            for(int i = 1; i <= 3; i++)
            {
                Console.Write($"Please Enter The Choice Number{i} :");
                options[i - 1] = protect.check(Console.ReadLine());
            }
            Console.WriteLine("Please Spicify The Right Choice Of Question:");
            answer_num = protect.CheckMCQin(Console.ReadLine());
           
            answerText = options[answer_num-1];
            answer[counter]=new Answer(answer_num, answerText);
            Exam.total += Mark;
            q[counter]= new MCQOneAnswer("Choose One Answer", Body, Mark,answer ,options);

          
         counter++;
            
        }
       
        public override void ShowQuestionAnswers()
        {
            if (q is not null)
            {
                for ( int i = 0; i < q.Length; i++)
                {
                    if (q[i] is not null)
                    {
                        Console.WriteLine($"Q{Exam.num}) {q[i].Body} : {answer[i].AnswerText} ");
                        Exam.num++;
                    }
                    else
                        break;
                }
            }
        }


        public override void ShowQuestion()
        {
           
            int ans;
            if (q is not null)
            {
              
                for (int i = 0; i < q.Length; i++)
                {
                    if (q[i] is not null)
                    {
                        Console.WriteLine($"{q[i].Header}       Mark({q[i].Mark}) ");
                        Console.WriteLine($"{q[i].Body}");
                        for(int j = 0; j < options.Length; j++)
                        {
                            Console.Write($"{j+1}. {q[i].options[j]}        \t");
                        }
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------");
                     ans=protect.Check(Console.ReadLine());
                        if (ans == answer[i].AnswerID)
                           Exam.grade += q[i].Mark;
                    }
                    else
                        break;
                }



            }
        }




    }
}
