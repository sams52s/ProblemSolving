using Microsoft.VisualStudio.TestTools.UnitTesting;
using LittleExercise1;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace LittleExercise1Tests
{
    [TestFixture]
    public static class ProblemSolvingTest
    {
        [Test]
        
        public static void NIsBiggerThenM()
        {
            var result = Util.Processing(1024, 19, 2, 6);

            Assert.That(result, Is.EqualTo(1100));

        }
        [Test]
        public static void MIsBiggerThenN()
        {
            var result = Util.Processing(19, 1024, 2, 6);

            Assert.That(result, Is.EqualTo(4099));

        }
        [Test]
        public static void iIsBiggerThenj()
        {
            var result = Util.Processing(1024, 19, 6, 2);

            Assert.That(result, Is.EqualTo(1216));

        }
        [Test]
        public static void iIsZero()
        {
            var result = Util.Processing(1024, 19, 0, 2);

            Assert.That(result, Is.EqualTo(1043));

        }
        [Test]
        public static void iAndjIsZero()
        {
            var result = Util.Processing(1024, 19, 0, 0);

            Assert.That(result, Is.EqualTo(1043));

        }
        [Test]
        public static void jIsZero()
        {
            var result = Util.Processing(1024, 19, 2, 0);

            Assert.That(result, Is.EqualTo(1100));

        }
    }
}