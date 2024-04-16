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
        public void Score_PropertyExists()
        {
            Type t = typeof(Quiz);
            var method = t.GetProperty("Score");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void RemainedAnswersNumber_PropertyExists()
        {
            Type t = typeof(Quiz);
            var method = t.GetProperty("RemainedAnswersNumber");
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
        public void AskQuestionMethod_Exists()
        {
            Type type = typeof(Quiz);
            var method = type.GetMethod("AskQuestion");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void AskQuestionMethod_DeleteQuestionAfterCall()
        {
            Quiz quiz = new Quiz() { Score = 0, Questions = [new Question() {}], RemainedAnswersNumber = 1 };
            quiz.AskQuestion();

            Assert.AreEqual(0, quiz.Questions.Count);
        }

        [TestMethod]
        public void AskQuestionMethod_WontChangeRemainedAnswersNumberAfterFalseCall()
        {
            Quiz quiz = new Quiz() { Score = 0, Questions = [new Question() { }], RemainedAnswersNumber = 1 };
            quiz.AskQuestion();
            Assert.AreEqual(1, quiz.RemainedAnswersNumber);
        }

        [TestMethod]
        public void AskQuestionMethod_WillChangeRemainedAnswersNumberAfterSuccessfullCall()
        {
            Quiz quiz = new Quiz() { Score = 0, Questions = [new Question() { CorrectAnswerNumber = 1, Answers = ["",""], SourceFileName="existed_file.txt" }], RemainedAnswersNumber = 1 };
            quiz.AskQuestion();
            Assert.AreEqual(0, quiz.RemainedAnswersNumber);
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
            streamWriter.Close();

            Quiz quiz = new();
            Assert.AreEqual(-1, quiz.Start());
        }

        [TestMethod]
        public void StartMethod_Error_NotEnoughQuestions()
        {
            List<Question> list = 
            [
                new Question(),
                new Question(),

            ];
            StreamWriter streamWriter = new StreamWriter("data.json");
            streamWriter.WriteLine(JsonConvert.SerializeObject(list));
            streamWriter.Close();

            Quiz quiz = new();
            Assert.AreEqual(-2, quiz.Start());
        }
    }
}