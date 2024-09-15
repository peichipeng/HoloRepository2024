using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HoloRepository.Tests
{
    [TestFixture]
    public class AddOrganSliceTests
    {
        private AddOrganSlice _addOrganSlice;

        [SetUp]
        public void SetUp()
        {
            // Initialize the AddOrganSlice form with necessary parameters
            _addOrganSlice = new AddOrganSlice(1, "Liver", 0, "Left");
            _addOrganSlice.Show(); // Make sure the form is visible for UI-related actions
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
            _addOrganSlice.Close();
        }

        [Test]
        public void TestProcessVoiceCommand_AddCommand_AfterSettingOrganSlice()
        {
            // Step 1: Use the public method to simulate selecting an organ slice
            _addOrganSlice.SetOrganSlice("sample_image_path");

            // Step 2: Simulate the "add" voice command
            _addOrganSlice.ProcessVoiceCommand("add");
            Assert.IsNotNull(_addOrganSlice.OrganSliceImagePath);
            Assert.AreEqual("sample_image_path", _addOrganSlice.OrganSliceImagePath);
        }

        [Test]
        public void TestProcessVoiceCommand_StartDescribing()
        {
            // Simulate "start describing" voice command
            _addOrganSlice.ProcessVoiceCommand("start describing");

            // Ensure the form is in the entering description state
            Assert.IsTrue(_addOrganSlice.isEntering);
        }

        [Test]
        public void TestProcessVoiceCommand_StopDescribing()
        {
            // Simulate "start describing" command
            _addOrganSlice.ProcessVoiceCommand("start describing");
            Assert.IsTrue(_addOrganSlice.isEntering);

            // Simulate "stop describing" command
            _addOrganSlice.ProcessVoiceCommand("stop describing");

            // Ensure the form is no longer in the entering description state
            Assert.IsFalse(_addOrganSlice.isEntering);
        }
    }
}
