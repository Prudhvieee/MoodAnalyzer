using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest_UC_3
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
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyzer.AnalyzeMood();
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        [DataRow(null)]
        public void GivenIAmInHappyMood_shouldReturnHappy(string message)
        {
            //Arrange
            string expectedValue = "Mood should not be null";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyzer.AnalyzeMood();
            //Assert
            Assert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        public void GivenEmptyMood_ShouldThrowMoodCannotBeEmpty()
        {
            try
            {
                ///Arrange
                string message = "";
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                ///Act
                string mood = moodAnalyzer.AnalyzeMood();
            }
            catch(MoodAnalyzerCustomException exception)
            {
                ///Assert
                Assert.AreEqual("Mood should not be empty", exception.Message);
            }
        }
        [TestMethod]
        [DataRow(null)]
        public void GivenNullMood_ShouldThrowMoodCannotBeNull(string message)
        {
            try
            {
                ///Arrange
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                ///Act
                string mood = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerCustomException exception)
            {
                ///Assert
                Assert.AreEqual("Mood should not be null", exception.Message);
            }
        }
    }
}
