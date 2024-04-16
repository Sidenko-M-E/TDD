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
                return JsonConvert.DeserializeObject<List<Question>>(json);
            }
            catch
            {
                return null;
            }
        }

        public int Start()
        {
            return 0;
        }
    }
}
