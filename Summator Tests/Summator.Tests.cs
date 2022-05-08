using NUnit.Framework;

namespace Summator.Tests

{
    public class Tests
    {
        [Test]

        public void Test_Sum_TwoPositiveNumbers()
        {
            int expected = Summator.Sum(new int[] { 5, 7 });
            int actual= 12;
            Assert.That (expected == actual);
                   
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            int expected = Summator.Sum(new int[] { 7 });
            int actual = 7;
            Assert.That(expected == actual);

        }
        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            int expected = Summator.Sum(new int[] { -16,-7 });
            int actual = -23;
            Assert.That(expected == actual);

        }

        [Test]
        public void Test_Sum_NegativeAndPositive()
        {
            int expected = Summator.Sum(new int[] { -16,25, -7 });
            int actual = 2;
            Assert.That(expected == actual);

        }
        [Test]
        public void Test_Avrage_TwoNumsInt()
        {
            int expected = Summator.Averag(new int[] {3,5});
            int actual = 4;
            Assert.That(expected == actual);

        }

        [Test]
        public void Test_Avrage_ThreeNumsInt()
        {
            int expected = Summator.Averag(new int[] { 3,5,4 });
            int actual = 4;
            Assert.That(expected == actual);

        }
        [Test]
        public void Test_Avrage_TwoNumsDouble()
        {
            double expected = Summator.Averag(new int [] { 4, 5 });
            double actual = 4;
            Assert.That(expected == actual);

        }
        [Test]
        public void Test_Avrage_Zero()
        {
            int expected = Summator.Averag(new int[] { 0 });
            int actual = 0;
            Assert.That(expected == actual);

        }


    }




}