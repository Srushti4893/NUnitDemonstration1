using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration;
using NUnit.Framework.Legacy;


namespace TestClass
{
    public class TestClass
    {
        [TestFixture]
        public class TestClass1
        {


            [Test]

            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                int firstAngle = 80;
                int secondAngle = 90;
                int thirdAngle = 90;
               
                string expected = "The triangle is valid.";
               
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                ClassicAssert.AreEqual(expected,actual);
            }

        }
    }
}

















