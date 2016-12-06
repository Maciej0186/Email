using NUnit.Framework;

namespace Email
{
    [TestFixture]
    class Test
    {
        Settings sett = new Settings();

        [Test]
        public void Runnning()
        {
            int a = 10;
            Assert.AreEqual(10, a);
        }
    }
}
