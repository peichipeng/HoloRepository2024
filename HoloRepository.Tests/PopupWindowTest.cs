using System.Reflection;
using NUnit.Framework;
using System.Windows.Forms;


namespace HoloRepository.Tests
{
    [TestFixture]
    public class PopupWindowTests
    {
        private PopupWindow _popupWindow;

        [SetUp]
        public void SetUp()
        {
            _popupWindow = new PopupWindow();
            _popupWindow.Show();
        }

        [TearDown]
        public void TearDown()
        {
            _popupWindow.Close();
        }

        [Test]
        public void TestButtonClick_YesButtonClick()
        {
            // Use reflection to access private PopupYesButton
            var yesButtonField = typeof(PopupWindow).GetField("PopupYesButton", BindingFlags.NonPublic | BindingFlags.Instance);
            var yesButton = (Button)yesButtonField.GetValue(_popupWindow);

            // Simulate a user clicking the "Yes" button
            yesButton.PerformClick();

            // Ensure the result is set to "Yes" and the form is closed
            Assert.AreEqual("Yes", _popupWindow.Result);
            Assert.IsFalse(_popupWindow.Visible);
        }

        [Test]
        public void TestButtonClick_NoButtonClick()
        {
            // Use reflection to access private PopupNoButton
            var noButtonField = typeof(PopupWindow).GetField("PopupNoButton", BindingFlags.NonPublic | BindingFlags.Instance);
            var noButton = (Button)noButtonField.GetValue(_popupWindow);

            // Simulate a user clicking the "No" button
            noButton.PerformClick();

            // Ensure the result is set to "No" and the form is closed
            Assert.AreEqual("No", _popupWindow.Result);
            Assert.IsFalse(_popupWindow.Visible);
        }
    }
}
