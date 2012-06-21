using NUnit.Framework;
using BinaryAcademia.Calc;
namespace BinaryAcademia.Calc.Tests
{
    [TestFixture]
    class Tests
    {   
        [Test]
        public void Should_Equale3_WhenAdd1To2()
        {
            var calc = new Calc();
            Assert.That(calc.Add(1,2),Is.EqualTo(3));
        }

        [Test]
        public void Should_Equale15_When3Multby5()
        {
            var calc = new Calc();
            Assert.That(calc.Multiplication(3,5),Is.EqualTo(15));
        }

        [Test]
        public void Slould_Equale5_WhenDo10Minus5()
        {
            var calc = new Calc();
            Assert.That(calc.Difference(10,5),Is.EqualTo(5));
        }

        [Test]
        public void Should_Equale5_When30DivBy6()
        {
            var calc = new Calc();
            Assert.That(calc.Division(30, 6), Is.EqualTo(5));
        }

        [Test]
        public void Should_BeNaN_WhenBEqualeZero()
        {
            var calc = new Calc();
            Assert.That(calc.Division(10, 0), Is.EqualTo(System.Double.NaN));
        }
    }
}
