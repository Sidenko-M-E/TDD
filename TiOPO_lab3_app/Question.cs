using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiOPO_lab3_app
{
    public class Question
    {
        public string SourceFileName { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerNumber {  get; set; }

        public bool Show()
        {
            //TODO: Text output for user

            if (SourceFileName == null)
                return false;

            return true;
        }

        public int RequestAnswer() 
        {
            //TODO: Add logic
            return 1;
        }

        public int RateAnswer(int answerNumber)
        {
            //TODO: Text output for user

            if (answerNumber == CorrectAnswerNumber)
                return 1;
            else
                return 0;
        }
    }
}
