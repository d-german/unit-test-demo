using BusinessLogic;

namespace BusinessLogicTests
{
    public class MyBranchLogicTests
    {
        [Test]
        public void Test1()
        {
            var expected = true;
            var actual = MyBranchLogic.BranchLogic(true, true);  
            Assert.That(actual, Is.EqualTo(expected));  
        }

        [Test]
        public void Test2()
        {
            var expected = false;
            var actual = MyBranchLogic.BranchLogic(true, false);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(true, true, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        public void Tests(bool a, bool b, bool expected)
        {           
            var actual = MyBranchLogic.BranchLogic(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}