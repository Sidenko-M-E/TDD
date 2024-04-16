using TiOPO_lab3_app;

namespace TiOPO_lab3_tests
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void QuestionClassExists()
        {
            Question question = new Question();
            Assert.IsNotNull(question);
        }
    }
}