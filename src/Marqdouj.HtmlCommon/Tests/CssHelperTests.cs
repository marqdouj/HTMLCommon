using Marqdouj.HtmlCommon;

namespace Tests
{
    [TestClass]
    public sealed class CssHelperTests
    {
        [TestMethod]
        public void ToCssId_ValidGuid_ReturnsValidCssId()
        {
            // Arrange
            var guid = Guid.NewGuid();
            var prefix = "g_"; // Valid prefix
            // Act
            var cssId = guid.ToCssId(prefix);
            // Assert
            Assert.IsTrue(cssId.StartsWith(prefix), $"CSS ID should start with {prefix} but was {cssId}");
            Assert.IsTrue(cssId.Length > prefix.Length, "CSS ID should be longer than the prefix.");
        }

        [TestMethod]
        public void ToCssId_EmptyGuid_ThrowsArgumentException() 
        {
            // Arrange
            var guid = Guid.Empty;
            var prefix = "g_";
            // Act
            Assert.ThrowsExactly<ArgumentException>(() => guid.ToCssId(prefix));
        }

        [TestMethod]
        public void ToCssId_InvalidPrefix_ThrowsArgumentException()
        {
            // Arrange
            var guid = Guid.NewGuid();
            var invalidPrefix = "1_invalid_prefix"; // Invalid prefix (starts with a number)
            // Act
            Assert.ThrowsExactly<ArgumentException>(() => guid.ToCssId(invalidPrefix));
        }
    }
}
