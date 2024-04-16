using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiOPO_lab3_app;

namespace TiOPO_lab3_tests
{
    [TestClass]
    public class QuizTest
    {
        [TestMethod]
        public void ClassExists()
        {
            Quiz quiz = new Quiz();
            Assert.IsNotNull(quiz);
        }

        [TestMethod]
        public void Questions_PropertyExists()
        {
            Type t = typeof(Quiz);
            var method = t.GetProperty("Questions");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void GetQuestionsMethod_Exists()
        {
            Type type = typeof(Quiz);
            var method = type.GetMethod("GetQuestions");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void StartMethod_Exists()
        {
            Type type = typeof(Quiz);
            var method = type.GetMethod("Start");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void StartMethod_Error_EmptyQuestions()
        {
            StreamWriter streamWriter = new StreamWriter("data.json");
            streamWriter.WriteLine("");

            Quiz quiz = new();
            Assert.Equals(-1, quiz.Start());
        }
    }
}