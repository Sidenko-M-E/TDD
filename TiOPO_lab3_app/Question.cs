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
            if (SourceFileName == null)
                return false;

            try
            {
                var sr = new StreamReader($"{SourceFileName}");

                if (Answers == null)
                    return false;

                if (Answers.Count == 0) 
                    return false;

                Console.WriteLine("Код с использованием паттерна.");
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine();
                for (int i = 0; i < Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {Answers[i]}");
                }
            }
            catch
            {
                return false;
            }

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
