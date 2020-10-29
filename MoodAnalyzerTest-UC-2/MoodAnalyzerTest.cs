using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class MoodAnalyzerTest
    {
        [TestMethod]
        public void GivenIAmInSadMood_ShouldReturnSAD()
        {
            //Arrange
            string message = "I am in sad mood.";
            string expectedValue = "SAD";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        [DataRow(null)]
        public void GivenIAmInHappyMood_shouldReturnHappy(string message)
        {
            //Arrange
            string expectedValue = "HAPPY";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyzer.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
