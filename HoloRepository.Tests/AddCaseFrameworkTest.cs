using NUnit.Framework;
using HoloRepository.AddCase;
using System;
using System.Windows.Forms;

namespace HoloRepository.Tests
{
    [TestFixture]
    public class AddCaseFrameworkTests
    {
        private AddCaseFramework _addCaseFramework;

        [SetUp]
        public void Setup()
        {
            _addCaseFramework = new AddCaseFramework("home", "addCase");
        }

        [TearDown]
        public void TearDown()
        {
            if (_addCaseFramework != null && !_addCaseFramework.IsDisposed)
            {
                _addCaseFramework.Dispose();
            }
        }

        [Test]
        public void TestVoiceCommand_SaveCommand()
        {
            var nextButton = new Button { Text = "Save" };
            _addCaseFramework.Controls.Add(nextButton);
            _addCaseFramework.ProcessVoiceCommand("save");
            Assert.AreEqual("Save", nextButton.Text);
        }

        [Test]
        public void TestVoiceCommand_NextCommand()
        {
            var nextButton = new Button { Text = "Next" };
            _addCaseFramework.Controls.Add(nextButton);
            _addCaseFramework.ProcessVoiceCommand("next");
            Assert.AreEqual("Next", nextButton.Text);
        }

        [Test]
        public void TestVoiceCommand_InvalidCommand()
        {
            _addCaseFramework.ProcessVoiceCommand("invalid command");
            Assert.IsNull(_addCaseFramework._currentPopup);
        }
    }
}
