# HTML Common

The NuGet package can be found [here](https://www.nuget.org/packages/Marqdouj.HtmlCommon/)

## Current Features 
- HTML color name enum and extensions.
  - `HtmlColorNameCollection`. Useful as the Items source for Lists and Dropdowns, etc.
  Allows for optionally including an item with a 'null' value to the start of the list to represent 'none' or 'not selected'.
- CSS helper class.
  - Create unique CSS IDs using `Guid`.

## Release Notes
**8.0.2**
- Added `HtmlColorNameCollection`

**8.0.1**
- Added `CssHelper` class
  - Create unique CSS IDs using `Guid`
    - Example usage: `private readonly string cssId = Guid.NewGuid().ToCssId();`

**8.0.0**
- Added `HtmlColorName` Enum to represent HTML Named Colors.
  - Supports all 140 HTML colors based on [w3schools](https://www.w3schools.com/colors/colors_names.asp) and [w3.org](https://www.w3.org/TR/css-color-4/#named-colors).
  - Includes a `ToHex` extension method that returns the Html Hex string.
    - Example usage: `HtmlColorName.AliceBlue.ToHex()` returns `"#F0F8FF"`.
