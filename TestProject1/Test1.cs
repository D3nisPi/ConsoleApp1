using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        private Calculator _calculator = new Calculator();
        [TestMethod]
        public void TestMethod1()
        {
            int actualResult = _calculator.Add(5, 3);
            int expectedResult = 8;
 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int actualResult = _calculator.Add(5, 4);
            int expectedResult = 9;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int actualResult = _calculator.Add(5, 5);
            int expectedResult = 10;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int actualResult = _calculator.Add(6, 1);
            int expectedResult = 7;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
