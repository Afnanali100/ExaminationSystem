using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Exam
    {
        
        public  double Time { get; set; }

        public  int NumberOfQuestion { get; set; }

        public static double grade;

        public static double total;

        public static int num;

        public Exam(double Time , int NumberOfQuestion)
        {
            this.Time = Time;
            this.NumberOfQuestion = NumberOfQuestion;
            grade = 0;
            num = 1;
        }


        public abstract  void CreateExam(int NumberOfQuestion);

        
       
        
        public abstract void ShowExam(Stopwatch sw);
        public abstract void ShowAnswers();


    }
}
