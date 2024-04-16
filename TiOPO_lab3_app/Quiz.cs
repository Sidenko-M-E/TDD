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
