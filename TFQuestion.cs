using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TFQuestion:Question
    {
        
        TFQuestion[] q=new TFQuestion[100];

       
        public static int counter { get; set; }

        Answer[] answer=new Answer[100]; 

        static TFQuestion()
        {
            counter = 0;
        }
        public TFQuestion()
        {
              
        }
        public TFQuestion(string Header, string Body, double Mark,Answer[] answer) : base(Header, Body, Mark,answer)
        {
          
        }

        
        public override void CreateQuestion()
        {
            string Body;
            double Mark;
            int answer_num;
            string answerText ;

            Console.WriteLine("True | False Question");
            Console.WriteLine("Please Enter The Body Of Question");
            Body = protect.check(Console.ReadLine());
            Console.WriteLine("Please Enter The Mark Of Question:");
            Mark = protect.Checkd(Console.ReadLine());
            Console.WriteLine("Please Enter The Right Answer Of Question (1 for True and 2 for False):");
            answer_num = protect.CheckTFin(Console.ReadLine());
           
            answerText= answer_num==1? "True":"false";

            answer[counter]=new Answer(answer_num, answerText);
            Exam.total += Mark;
            q[counter]=  new TFQuestion("True | False Question", Body, Mark, answer);
            
            counter++;
        }
     
    
        public override void ShowQuestionAnswers()
        {
           if(q is not null)
            {
                for(int i = 0; i < q.Length; i++)
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
                        Console.WriteLine("1.True                  2.False");
                        Console.WriteLine("---------------------------------------");
                        ans = protect.Check(Console.ReadLine());
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
