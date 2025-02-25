namespace TestGitSecondPart
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("New line is added again");
            Console.WriteLine("New author and email");
            Console.WriteLine("3-rd line is added again 2");
            Console.WriteLine("3-rd line is added ag231ain 2");
            Console.WriteLine("dsd");
            Console.WriteLine("This is third branch");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}