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
    }
}