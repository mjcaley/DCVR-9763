using NUnit.Framework;


namespace HtmlAgilityTest.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void HtmlAgilityTestReturnsTrue()
        {
            var testData =
                "<html><head><title>Unit Test Document</title></head><body><p>Test paragraph</p></body></html>";
            var success = Program.HtmlAgilityTest(testData);

            Assert.IsTrue(success);
        }
    }
}
