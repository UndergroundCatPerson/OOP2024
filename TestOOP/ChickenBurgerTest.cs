
using OOP2024;

namespace TestOOP
{
    [TestClass]
    public class ChickenBurgerTest
    {

        ChickenBurger cb = new ChickenBurger();

        [TestMethod]
        public void TestMethod1()
        {

            String expected = "Chicken";
            Assert.AreNotEqual(expected, cb.getPatty());
        }

         

       
    }
}