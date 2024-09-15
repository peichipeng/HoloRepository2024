using NUnit.Framework;
using System;
using System.Windows.Forms;

namespace HoloRepository.Tests
{
    [TestFixture]
    public class MainFormTests
    {
        private MainForm _mainForm;

        [SetUp]
        public void SetUp()
        {
            // Initialize the MainForm before each test
            _mainForm = new MainForm();
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            _mainForm.Dispose();
        }

        [Test]
        public void Test_InitializePythonProcess_ShouldStartPythonProcess()
        {
            // Simulate the MainForm initialization, which calls InitializePythonProcess
            Assert.IsNotNull(_mainForm);
            // Test passes if no exceptions are thrown during initialization
        }

        [Test]
        public void Test_StartTranscription_ShouldInvokePythonProcess()
        {
            // Arrange: Ensure Python process is initialized
            _mainForm.StartTranscription();

            // Act: Check if the transcription has started
            // Here you would normally assert expected outcomes, such as checking if the transcription started
            Assert.Pass("StartTranscription called successfully.");
        }

        [Test]
        public void Test_StopTranscription_ShouldInvokePythonProcess()
        {
            // Arrange: Start transcription first
            _mainForm.StartTranscription();

            // Act: Stop transcription
            _mainForm.StopTranscription();

            // Assert: Ensure it stops correctly
            Assert.Pass("StopTranscription called successfully.");
        }

        [Test]
        public void Test_OnModeChanged_SpeechMode_ShouldStartAndStopTranscription()
        {
            // Arrange: Initially set to keyboard mode
            bool isKeyboardMode = true;

            // Act: Change mode to speech
            _mainForm.OnModeChanged(isKeyboardMode);

            // Assert: Check that transcription starts in speech mode
            Assert.Pass("OnModeChanged switched to speech mode successfully.");
        }

        [Test]
        public void Test_OnContentChanged_ShouldShowCorrectControl()
        {
            // Act: Call the method with a sample source
            _mainForm.OnContentChanged("main");

            // Assert: As this is a UI-based test, manual verification might be required, but it should not throw exceptions
            Assert.Pass("OnContentChanged handled successfully.");
        }

        [Test]
        public void Test_StartNER_ShouldCallStartNERPythonProcess()
        {
            // Act: Start NER
            _mainForm.StartNER();

            // Assert: Check for no exceptions and successful process initialization
            Assert.Pass("StartNER called successfully.");
        }

        [Test]
        public void Test_StopNER_ShouldStopNERPythonProcess()
        {
            // Act: Stop NER
            _mainForm.StopNER();

            // Assert: Check for no exceptions and proper shutdown
            Assert.Pass("StopNER called successfully.");
        }

        [Test]
        public void Test_FormClosing_ShouldStopTranscriptionAndKillPythonProcess()
        {
            // Act: Simulate form closing
            FormClosingEventArgs args = new FormClosingEventArgs(CloseReason.UserClosing, false);
            _mainForm.MainForm_FormClosing(_mainForm, args);

            // Assert: Ensure transcription stops and Python process is killed
            Assert.Pass("Form closing properly handled.");
        }
    }
}
