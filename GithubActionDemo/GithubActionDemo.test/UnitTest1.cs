namespace GithubActionDemo.test
{
    public class Tests
    {
   
        [SetUp]
        public void Setup()
        {
     
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(1, 2, 3)]
        public void Add(int a, int b, int sum)
        {
            Assert.That(a+ b, Is.EqualTo(sum));
        } 
    } 
}