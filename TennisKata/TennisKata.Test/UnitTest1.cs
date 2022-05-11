using NUnit.Framework;
using TennisKata;

namespace TennisKata.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [TestCase(0, 0, "Love-Love")]
        [TestCase(1, 0, "Fifteen-Love")]
        [TestCase(2, 0, "Thirty-Love")]
        [TestCase(3, 0, "Forty-Love")]
        [TestCase(0, 1, "Love-Fifteen")]
        [TestCase(1, 1, "Fifteen-Fifteen")]
        [TestCase(2, 3, "Thirty-Forty")]
        [TestCase(3, 3, "Deuce")]
        [TestCase(4, 3, "Advantage for Federer")]
        [TestCase(3, 4, "Advantage for Nadal")]
        [TestCase(5, 5, "Deuce")]
        [TestCase(400, 400, "Deuce")]
        public void ValidPointsTest(int val1, int val2, string result)
        {
            Game myGame = new Game("Federer", "Nadal");
            string actualResult = myGame.ResultToString(val1, val2);
            Assert.AreEqual(result, actualResult);
        }

        [TestCase(4, -4)]
        [TestCase(-1, -5)]
        [TestCase(4, -4)]
        [TestCase(null, 2)]
        public void InvalidInput(int val1, int val2)
        {
            Game myGame = new Game("Federer", "Nadal");
            ;
            Assert.Throws(typeof(InvalidInputException), new TestDelegate (() => myGame.ResultToString(val1, val2) )  );
        }

        [TestCase(40, 1)]
        [TestCase(0, 5)]
        [TestCase(4, 1)]
        [TestCase(8, 6)]
        public void InvalidPoints(int val1, int val2)
        {
            Game myGame = new Game("Federer", "Nadal");
            Assert.Throws(typeof(ImpossibleGameException),new TestDelegate(() => myGame.ResultToString(val1, val2) ) );
        }

    }
}