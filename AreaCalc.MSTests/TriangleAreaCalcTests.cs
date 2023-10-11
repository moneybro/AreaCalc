namespace AreaCalc.MSTests
{
    [TestClass]
    public class TriangleAreaCalcTests
    {
        [TestMethod]
        public void Calc_Test()
        {
            //Arrage
            double a = 16;
            double b = 16;
            double c = 28;
            double expected = 108.44353;

            //Act
            var res = TriangleArea.Calc(a,b,c);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}