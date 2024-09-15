using NUnit.Framework;
using HoloRepository.AddCase;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HoloRepository.Tests
{
    [TestFixture]
    public class DonorInfoTests
    {
        private DonorInfo _donorInfo;

        [SetUp]
        public void Setup()
        {
            // Initialize DonorInfo for testing
            _donorInfo = new DonorInfo();
        }

        [Test]
        public void TestVoiceCommand_NERResultCommand()
        {
            // Prepare simulated NER result JSON string
            var nerResult = new Dictionary<string, string>
            {
                { "id", "12345" },
                { "age", "45" },
                { "dod", "01/01/2021" },
                { "cause_of_death", "Cardiac arrest" }
            };
            string nerResultJson = JsonConvert.SerializeObject(nerResult);

            // Simulate "NER Result" voice command
            _donorInfo.ProcessVoiceCommand($"NER Result: {nerResultJson}");

            // Assert that the UI fields are populated with the correct NER result values
            Assert.AreEqual("12345", _donorInfo.donorIdTxt.Text);
            Assert.AreEqual("45", _donorInfo.ageTxt.Text);
            Assert.AreEqual("01/01/2021", _donorInfo.dodTxt.Text);
            Assert.AreEqual("Cardiac arrest", _donorInfo.causeOfDeathTxt.Text);
        }

        [Test]
        public void TestProcessNERResult_WithValidNERData()
        {
            // Prepare valid NER result data
            var nerResult = new Dictionary<string, string>
            {
                { "id", "98765" },
                { "age", "67" },
                { "dod", "15/03/2022" },
                { "cause_of_death", "Stroke" }
            };

            // Process the NER result
            _donorInfo.ProcessNERResult(nerResult);

            // Verify that the fields are populated correctly
            Assert.AreEqual("98765", _donorInfo.donorIdTxt.Text);
            Assert.AreEqual("67", _donorInfo.ageTxt.Text);
            Assert.AreEqual("15/03/2022", _donorInfo.dodTxt.Text);
            Assert.AreEqual("Stroke", _donorInfo.causeOfDeathTxt.Text);
        }

        [Test]
        public void TestProcessNERResult_WithEmptyNERData()
        {
            // Prepare empty NER result data
            var nerResult = new Dictionary<string, string>
            {
                { "id", "" },
                { "age", "" },
                { "dod", "" },
                { "cause_of_death", "" }
            };

            // Process the NER result
            _donorInfo.ProcessNERResult(nerResult);

            // Verify that the fields are empty
            Assert.AreEqual("", _donorInfo.donorIdTxt.Text);
            Assert.AreEqual("", _donorInfo.ageTxt.Text);
            Assert.AreEqual("DD/MM/YYYY", _donorInfo.dodTxt.Text);
            Assert.AreEqual("", _donorInfo.causeOfDeathTxt.Text);
        }
    }
}
