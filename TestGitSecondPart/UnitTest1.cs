namespace TestGitSecondPart
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This check for merge");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}