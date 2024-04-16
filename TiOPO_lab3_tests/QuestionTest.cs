using TiOPO_lab3_app;
using System.Reflection;

namespace TiOPO_lab3_tests
{
    [TestClass]
    public class QuestionTest
    {
        [TestMethod]
        public void ClassExists()
        {
            Question question = new Question();
            Assert.IsNotNull(question);
        }

        [TestMethod]
        public void ShowMethodExists()
        {
            Type t = typeof(Question);
            var method = t.GetMethod("Show");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void RequestAnswerMethodExists()
        {
            Type t = typeof(Question);
            var method = t.GetMethod("RequestAnswer");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void RateAnswerMethodExists()
        {
            Type t = typeof(Question);
            var method = t.GetMethod("RateAnswer");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void CorrectAnswerNumber_PropertyExists()
        {
            Type t = typeof(Question);
            var method = t.GetProperty("CorrectAnswerNumber");
            Assert.IsNotNull(method);
        }

        [TestMethod]
        public void RateAnswerMethod_RatesCorrectlyWrongAnswer()
        {
            int CorrectAnswerNumber = 1;

            Question question = new Question() { CorrectAnswerNumber = CorrectAnswerNumber };
            Assert.AreEqual(0, question.RateAnswer(5));
        }

        [TestMethod]
        public void RateAnswerMethod_RatesCorrectlyRightAnswer()
        {
            int CorrectAnswerNumber = 1;

            Question question = new Question() { CorrectAnswerNumber = CorrectAnswerNumber };
            Assert.AreEqual(1, question.RateAnswer(1));
        }
    }
}