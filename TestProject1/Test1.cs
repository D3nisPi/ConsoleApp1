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
    }
}
