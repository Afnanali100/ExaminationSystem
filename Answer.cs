using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Answer
    {
        public int AnswerID { get; set; }

        public string AnswerText { get; set; }


        public Answer()
        {
            
        }
        public Answer(int AnswerID, string AnswerText)
        {
            this.AnswerID = AnswerID;
            this.AnswerText = AnswerText;
        }

    


    }
}
