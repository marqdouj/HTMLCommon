using System.Collections.ObjectModel;

namespace Marqdouj.HtmlCommon
{
    /// <summary>
    /// Represents a collection of <see cref="HtmlColorNameListItem"/>,
    /// optionally including an item with a 'null' value to the start of the list to represent 'none' or 'not selected'.
    /// This collection is useful as the Items source for Lists and Dropdowns, etc.
    /// </summary>
    public class HtmlColorNameCollection
    {
        private readonly List<HtmlColorNameListItem> items;

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlColorNameCollection"/> class, optionally including a null
        /// item.
        /// </summary>
        /// <remarks>The collection is populated with all values of the <see cref="HtmlColorName"/>
        /// enumeration, and optionally includes a null item. The resulting collection is read-only.</remarks>
        /// <param name="nullItem">A value indicating whether to include a null item in the collection.  If <see langword="true"/>, a null item
        /// is added at the beginning of the collection; otherwise, the collection contains only color names.</param>
        public HtmlColorNameCollection(bool nullItem = false)
        {
            items = [.. Enum.GetValues<HtmlColorName>().Select(e => new HtmlColorNameListItem(e)).OrderBy(o => o.Value)];

            if (nullItem)
                items.Insert(0, new HtmlColorNameListItem(null));

            Items = new ReadOnlyCollection<HtmlColorNameListItem>(items);
        }

        public ReadOnlyCollection<HtmlColorNameListItem> Items { get; }
    }

    /// <summary>
    /// Represents an item in a list of HTML color names, including its name, hexadecimal value, and associated
    /// enumeration value.
    /// </summary>
    /// <remarks>This class provides convenient access to the name and hexadecimal representation of an HTML
    /// color based on the <see cref="HtmlColorName"/> enumeration. If the <see cref="Value"/> is null, the  <see
    /// cref="Name"/> and <see cref="Hex"/> properties will also return null.</remarks>
    /// <param name="value"></param>
    public class HtmlColorNameListItem(HtmlColorName? value)
    {
        public HtmlColorName? Value { get; } = value;
        public string? Name => Value?.ToString();
        public string? Hex => Value?.ToHex();
    }
}
