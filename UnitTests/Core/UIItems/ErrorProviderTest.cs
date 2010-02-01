using NUnit.Framework;
using White.Core.UIItems.ListBoxItems;
using White.UnitTests.Core.Testing;

namespace White.Core.UIItems
{
    [TestFixture, WinFormCategory]
    public class ErrorProviderTest : ControlsActionTest
    {
        [Test, Ignore]
        public void HasError()
        {
            window.Get<Button>("showError").Click();
            var comboBox = window.Get<ComboBox>("komboBox");
            Assert.AreEqual("The name is wrong", comboBox.ErrorProviderMessage(window));
        }
    }
}