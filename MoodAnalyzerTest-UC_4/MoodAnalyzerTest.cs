using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzerTest_UC_4
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
            catch (MoodAnalyzerCustomException exception)
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
        /// <summary>
        /// Test Case 4.1 Given MoodAnalyserMain class should return MoodAnalyserMain object
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyzer("NULL");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        /// <summary>
        /// Test Case 4.2 Given Improper class name should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalyserException()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MoodAnalyzerProblem.sampleClass", "MoodAnalyzer");
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        ///<summary>
        /// Test Case 4.3 Given class when construcor not proper should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenClass_WhenConstructorNotProper_ShouldThrowMoodAnalyserException()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MoodAnalyzerProblem.MoodAnalyzer", "sampleClass");
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
        /// <summary>
        /// Test Case 5.1 Given MoodAnalyser when proper message pass to parameterized constructor then return Mood Analyser object
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyser_WhenProper_ReturnMoodAnalyseMainObject()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", "HAPPY");
            expected.Equals(obj);
        }

        // <summary>
        /// Test Case 5.2 Given Improper class name should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalyserException_UsingParameterizedConstructor()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.sampleClass", "MoodAnalyserMain", "HAPPY");
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        // <summary>
        /// Test Case 5.3 Given Improper construcort name should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenImproperConstructorName_ShouldThrowMoodAnalyserException_UsingParameterizedConstructor()
        {
            string expected = "Constructor is not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyserMain", "sampleClass", "HAPPY");
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
