using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }

        Answer[] answer;
   
     
        public Question()
        {
         
        }
        public Question(string Header ,string Body , double Mark, Answer[] answer )
        {
            this.Header = Header;
            this.Body = Body;
            this.Mark = Mark;
            this.answer = answer;
            
           
        }

        public abstract void CreateQuestion( );
        
        public abstract void ShowQuestion( );
        
        public abstract void ShowQuestionAnswers(  );

        
   

        
    }
}
