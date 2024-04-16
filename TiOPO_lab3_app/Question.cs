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
            if (int.TryParse(Console.ReadLine(), System.Globalization.NumberStyles.Number, null, out int anwer_number))
                return anwer_number;
            else
                return -1;
        }

        public int RateAnswer(int answerNumber)
        {
            if (answerNumber == CorrectAnswerNumber)
            {
                Console.WriteLine("Вы ответили верно!\n");
                return 1;
            }
            else
            {
                Console.WriteLine("Вы ответили НЕ верно!");
                Console.WriteLine($"Правильный ответ - {CorrectAnswerNumber})\n");
                return 0;
            }
        }
    }
}
