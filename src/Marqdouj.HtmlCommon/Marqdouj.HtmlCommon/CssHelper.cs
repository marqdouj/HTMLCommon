namespace Marqdouj.HtmlCommon
{
    public static class CssHelper
    {
        /// <summary>  
        /// Creates a CSS id from a Guid.  
        /// </summary>  
        /// <param name="guid"><see cref="Guid"/></param>  
        /// <param name="prefix">
        /// Guid might start with a number so to be safe prefix the id with a letter; "g_" is the default.
        /// <see cref="https://developer.mozilla.org/en-US/docs/Web/CSS/ident"/>
        /// <see cref="https://www.w3.org/TR/CSS21/syndata.html#value-def-identifier"/>"/>
        /// </param>  
        /// <param name="format">Default is "D" <see cref="Guid.ToString()"/></param>
        /// <returns>
        /// Exception if <paramref name="guid"/> is empty; otherwise a string that can be used as a CSS id.
        /// Exception if <paramref name="prefix"/> is null, empty or does not start with a letter.
        /// </returns>  
        public static string ToCssId(this Guid guid, string prefix = "g_", string format = "")
        {
            if (guid == Guid.Empty)
                throw new ArgumentException("Guid cannot be empty.", nameof(guid));

            if (string.IsNullOrWhiteSpace(prefix) || !char.IsLetter(prefix[0]))
                throw new ArgumentException("Prefix must start with a letter.", nameof(prefix));

            return $"{prefix}{guid.ToString(format)}";
        }
    }
}
