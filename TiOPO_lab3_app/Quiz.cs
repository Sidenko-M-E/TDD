using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TiOPO_lab3_app
{
    public class Quiz
    {
        public List<Question>? Questions {  get; set; }
        public int Score { get; set; }
        public int RemainedAnswersNumber { get; set; }

        public List<Question>? GetQuestions()
        {
            try
            {
                StreamReader reader = new("data.json");
                var json = reader.ReadToEnd();
                reader.Close();
                return JsonConvert.DeserializeObject<List<Question>>(json);
            }
            catch
            {
                return null;
            }
        }

        public void AskQuestion()
        {
            Random rnd = new();
            int QuestionIndex = rnd.Next(Questions.Count);

            if (Questions[QuestionIndex].Show())
            {
                RemainedAnswersNumber--;
                Score += Questions[QuestionIndex].RateAnswer(Questions[QuestionIndex].RequestAnswer());
            }    
            Questions.RemoveAt(QuestionIndex);
        }

        public int Start()
        {
            Questions = GetQuestions();

            if (Questions is null)
            {
                Console.WriteLine("Ошибка загрузки вопросов.");
                return -1;
            }

            if (Questions.Count < 5)
            {
                Console.WriteLine("Ошибка загрузки вопросов.");
                return -2;
            }

            return 0;
        }
    }
}
