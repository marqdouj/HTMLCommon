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

        [TestMethod]
        public void HtmlColorName_Collection_NullItem_True()
        {
            //Arrange
            var names = new HtmlColorNameCollection(true);
            var count = Enum.GetValues<HtmlColorName>().Length + 1;

            //Assert
            Assert.IsFalse(names.Items.First().Value.HasValue);
            Assert.AreEqual(count, names.Items.Count, $"Collection should contain {count} items but was {names.Items.Count} items");
        }

        [TestMethod]
        public void HtmlColorName_Collection_NullItem_False()
        {
            //Arrange
            var names = new HtmlColorNameCollection(false);
            var count = Enum.GetValues<HtmlColorName>().Length;

            //Assert
            Assert.IsTrue(names.Items.First().Value.HasValue);
            Assert.AreEqual(count, names.Items.Count, $"Collection should contain {count} items but was {names.Items.Count} items");
        }
    }
}
