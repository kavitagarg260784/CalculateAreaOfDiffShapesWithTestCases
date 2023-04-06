using Utility;

namespace TestProject1
{
    public class Tests
    {
       
    
        
            Triangle T = new Triangle();
            Rectangle R = new Rectangle();
            Circle C = new Circle();
        

        [Test]
        [TestCase(10, 20, 200)]
        [TestCase(12.5, 20.2, 252.5)]
        [TestCase(15, 200, 3000)]

        public void TestMultipleScenariosForRectangle(double l,double w , double expectedarea)
        {


            var found = R.Area(l,w);
            //assert
            Assert.AreEqual(expectedarea, found, $"Expected response is {expectedarea} but got {found} for lenght{l} and width{w}");
            

        }

        [Test]
        [TestCase(10,  314)]
        [TestCase(12.5,491 )]
       

        public void TestMultipleScenariosForCircle(double Rad, double expectedarea)
        {


            var found = C.Area(Rad);
            //assert
            Assert.AreEqual(expectedarea, found, $"Expected response is {expectedarea} but got {found} for Radius{Rad}");


        }

        [Test]
        [TestCase(10, 20, 100)]
        [TestCase(12.5, 20.2, 126.25)]
       

        public void TestMultipleScenariosForTriangle(double h, double Bl, double expectedarea)
        {


            var found = T.Area(h, Bl);
            //assert
            Assert.AreEqual(expectedarea, found, $"Expected response is {expectedarea} but got {found} for height{h} and BaseLength{Bl}");


        }

    }
}