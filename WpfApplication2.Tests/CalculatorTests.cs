using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WpfApplication2.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void isSumOf10And20Returned30()
        {
            Calculator calculator = new Calculator();

            int sum = calculator.Sum(10, 20);

            Assert.AreEqual(sum, 30);
        }

        [TestMethod]
        public void isSumOf0And23Retutned23()
        {
            Calculator calculator = new Calculator();

            int sum = calculator.Sum(0, 23);

            Assert.AreEqual(sum, 23);
        }

        [TestMethod]
        public void isSumOf0And0Returned0()
        {
            Calculator calculator = new Calculator();

            int sum = calculator.Sum(0, 0);

            Assert.AreEqual(sum, 0);
        }

        [TestMethod]
        public void isMultOf5And30Returned150()
        {
            Calculator calculator = new Calculator();

            int mult = calculator.Mult(5, 30);

            Assert.AreEqual(mult, 150);
        }

        [TestMethod]
        public void isMult0AndAnythingReturned0()
        {
            Calculator calculator = new Calculator();

            int mult = calculator.Mult(0, 20);

            Assert.AreEqual(0, mult);
        }

        [TestMethod]
        public void isMult0And0Returned0()
        {
            Calculator calculator = new Calculator();

            int mult = calculator.Mult(0, 0);

            Assert.AreEqual(0, mult);
        }
		
		[TestMethod]
		public void isMult0And10Returned0()
		{
			Calculator calculator = new Calculator();
			
			int mult = calculator.Mult(0, 10);
			
			Assert.AreEqual(0, mult);
		}
    }
}
