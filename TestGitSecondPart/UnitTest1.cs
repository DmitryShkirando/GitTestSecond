namespace TestGitSecondPart
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("New line is added again");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}