using NUnit.Framework;
using System;

namespace lab1._1.Tests
{
    [TestFixture]
    public class Class1Tests
    {
        [Test]
        public void 义耱Zap()
        {
            double[] array = new double[10];
            Class1.zap(array);

            foreach (var element in array)
            {
                Assert.That(element, Is.GreaterThanOrEqualTo(-100).And.LessThanOrEqualTo(110));
            }
        }

        [Test]
        public void 义耱SumAft()
        {
            double[] array = { 1.5, 2.5, -3.5, 4.5, 5.5 };
            double result = Class1.sumaft(array);

            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void 义耱CountStr()
        {
            int[,] matrix = {
                { 1, 2, 34, 44, 52, 61, 75, 86, 92, 10 },
                { 2, 2, 3, 43, 53, 62, 7, 85, 93, 1 },
                { 3, 2, 33, 4, 54, 6, 0, 84, 94, 12 },
                { 1, 2, 35, 4, 55, 6, 75, 8, 96, 13 },
                { 4, 28, 36, 4, 56, 62, 71, 8, 97, 15 },
                { 51, 24, 37, 0, 57, 63, 72, 82, 98, 15 },
                { 41, 23, 38, 45, 58, 65, 73, 81, 99, 10 },
                { 15, 22, 39, 45, 59, 66, 74, 83, 90, 17 },
                { 17, 21, 30, 40, 5, 0, 76, 89, 9, 18 },
                { 15, 24, 31, 49, 5, 68, 77, 80, 9, 10 }
            };
            int result = Class1.countstr(matrix);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void 义耱ZapMat()
        {
            int[,] matrix = new int[10, 10];
            Class1.zapmat(matrix);

            foreach (var element in matrix)
            {
                Assert.That(element, Is.GreaterThanOrEqualTo(-3).And.LessThanOrEqualTo(1));
            }
        }

        [Test]
        public void 义耱NumOfCol()
        {
            int[,] matrix = {
                { 1, 2, 34, 44, 52, 61, 75, 86, 92, 10 },
                { 2, 2, 3, 43, 53, 62, 7, 85, 93, 1 },
                { 3, 2, 33, 4, 54, 6, 7, 84, 94, 12 },
                { 1, 2, 35, 4, 55, 6, 75, 8, 96, 13 },
                { 4, 28, 36, 4, 56, 62, 71, 8, 97, 15 },
                { 51, 24, 37, 43, 57, 63, 72, 82, 98, 15 },
                { 41, 23, 38, 45, 58, 65, 73, 81, 99, 10 },
                { 15, 22, 39, 45, 59, 66, 74, 83, 90, 17 },
                { 17, 21, 30, 40, 5, 67, 76, 89, 9, 18 },
                { 15, 24, 31, 49, 5, 68, 77, 80, 9, 10 }
            };

            int result = Class1.numofcol(matrix);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}