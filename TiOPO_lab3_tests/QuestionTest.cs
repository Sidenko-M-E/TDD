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
    }
}