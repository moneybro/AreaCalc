namespace AreaCalc.MSTests
{
    [TestClass]
    public class CircleAreaCalcTests
    {
        [TestMethod]
        public void Calc_onlyRadius_Test()
        {
            //Arrage
            double r = 1;
            double expected = 3.14159265;

            //Act
            var res = CircleArea.Calc(r);

            //Assert
            Assert.AreEqual(expected, res);
        }
        [TestMethod]
        public void Calc_RadiusAndAccuracy_Test()
        {
            //Arrage
            double r = 1;
            double expected1 = 3.1;
            double expected2 = 3.14;
            double expected3 = 3.142;
            double expected4 = 3.1416;
            double expected5 = 3.14159;

            //Act
            var res1 = CircleArea.Calc(r, 1);
            var res2 = CircleArea.Calc(r, 2);
            var res3 = CircleArea.Calc(r, 3);
            var res4 = CircleArea.Calc(r, 4);
            var res5 = CircleArea.Calc(r, 5);

            //Assert
            Assert.AreEqual(expected1, res1);
            Assert.AreEqual(expected2, res2);
            Assert.AreEqual(expected3, res3);
            Assert.AreEqual(expected4, res4);
            Assert.AreEqual(expected5, res5);
        }

        #region string params
        [TestMethod]
        public void Calc_stringParams_onlyRadius_Test()
        {
            //Arrage
            string r = "1";
            double expected = 3.14159265;

            //Act
            var res = CircleArea.Calc(r);

            //Assert
            Assert.AreEqual(expected, res);
        }


        [TestMethod]
        public void Calc_stringParams_RadiusAndAccuracy_Test()
        {
            //Arrage
            string r = "1 , 0000000";
            double expected1 = 3.1;
            double expected2 = 3.14;
            double expected3 = 3.142;
            double expected4 = 3.1416;
            double expected5 = 3.14159;

            //Act
            var res1 = CircleArea.Calc(r, "1");
            var res2 = CircleArea.Calc(r, "2");
            var res3 = CircleArea.Calc(r, "3");
            var res4 = CircleArea.Calc(r, "4");
            var res5 = CircleArea.Calc(r, "5");

            //Assert
            Assert.AreEqual(expected1, res1);
            Assert.AreEqual(expected2, res2);
            Assert.AreEqual(expected3, res3);
            Assert.AreEqual(expected4, res4);
            Assert.AreEqual(expected5, res5);
        }
        #endregion
    }
}