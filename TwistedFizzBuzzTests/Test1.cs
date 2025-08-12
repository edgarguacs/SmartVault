namespace TwistedFizzBuzzTests
{
    [TestClass]
    public class TwistedFizzBuzzTests
    {
        private StringWriter _stringWriter;

        [TestInitialize]
        public void Setup()
        {
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _stringWriter.Dispose();
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
        }

        [TestMethod]
        public void FizzBuzz_PrintsExpectedOutput()
        {
            TwistedFizzBuzz.FizzBuzz();
            var output = _stringWriter.ToString();
            Assert.IsTrue(output.Contains("FizzBuzz"));
            Assert.IsTrue(output.Contains("Fizz"));
            Assert.IsTrue(output.Contains("Buzz"));
            Assert.IsTrue(output.Contains("1"));
        }

        [TestMethod]
        public void WithARange_PrintsExpectedOutput()
        {
            TwistedFizzBuzz.FizzBuzz();
            var lines = _stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("14", lines[0]);
            Assert.AreEqual("FizzBuzz", lines[1]);
            Assert.AreEqual("16", lines[2]);
        }

        [TestMethod]
        public void NonSequential_PrintsExpectedOutput()
        {
            int[] input = { 3, 5, 15, 7 };
            TwistedFizzBuzz.FizzBuzz();
            var lines = _stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("Fizz", lines[0]);
            Assert.AreEqual("Buzz", lines[1]);
            Assert.AreEqual("FizzBuzz", lines[2]);
            Assert.AreEqual("7", lines[3]);
        }

        [TestMethod]
        public void AlternativeDivisors_PrintsExpectedOutput()
        {
            // x=2, y=3, z=5, length=6
            TwistedFizzBuzz.FizzBuzz();
            var lines = _stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("1", lines[0]);
            Assert.AreEqual("Poem", lines[1]);
            Assert.AreEqual("Writer", lines[2]);
            Assert.AreEqual("Poem", lines[3]);
            Assert.AreEqual("CollegeWriter", lines[4]);
            Assert.AreEqual("Poem", lines[5]);
        }

        [TestMethod]
        public void FizzBuzzBar_PrintsExpectedOutput()
        {
            TwistedFizzBuzz.FizzBuzz();
            var lines = _stringWriter.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual("Fizz", lines[0]); // i=0
            Assert.AreEqual("1", lines[1]);
            Assert.AreEqual("2", lines[2]);
            Assert.AreEqual("3", lines[3]);
            Assert.AreEqual("4", lines[4]);
            Assert.AreEqual("Fizz", lines[5]); // i=5
            Assert.AreEqual("Buzz", lines[9]); // i=9
            Assert.AreEqual("Bar", lines[27]); // i=27
        }
    }
}
