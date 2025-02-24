namespace TestGitSecondPart
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("New line is added");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}