using ConsoleApp4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplicationOperations_12_4and4_1()
        {
            double a = 12.4;
            double b = 4;
            //очікуваний результат
            double expected = 49.6;
            //виклик метода
            Operations operations = new Operations();
            double actual = operations.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivisionOperations_12_4and4_1()
        {
            double a = 12.4;
            double b = 4;
            //очікуваний результат
            double expected = 3.1;
            //виклик метода
            Operations operations = new Operations();
            double actual = operations.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
