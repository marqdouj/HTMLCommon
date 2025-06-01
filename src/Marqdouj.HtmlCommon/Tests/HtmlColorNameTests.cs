using Marqdouj.HtmlCommon;

namespace Tests
{
    [TestClass]
    public sealed class HtmlColorNameTests
    {
        [TestMethod]
        public void HtmlColorName_ToHex_AllNamesCovered()
        {
            // Arrange
            var names = Enum.GetValues(typeof(HtmlColorName)).Cast<HtmlColorName>().ToList();

            foreach (var name in names)
            {
                // Act
                var hex = name.ToHex(); //Will throw exception if the name is not supported in ToHex

                // Assert
                Assert.IsTrue(hex.StartsWith('#'), $"Hex for {name} should start with # but was {hex}"); // Fixed CA1866
                Assert.AreEqual(7, hex.Length, $"Hex for {name} should be 7 characters long but was {hex.Length} characters");
            }
        }
    }
}
