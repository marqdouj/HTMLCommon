# HTML Common

The NuGet package can be found [here](https://www.nuget.org/packages/Marqdouj.HtmlCommon/)

## Demo
- A demo of this and some of my other NuGet packages can be found [here](https://github.com/marqdouj/BlazorSandbox)

## Current Features 
- HTML color name enum and extensions.
  - `HtmlColorNameCollection`. Useful as the Items source for Lists and Dropdowns, etc.
  Allows for optionally including an item with a 'null' value to the start of the list to represent 'none' or 'not selected'.
  - Check out the `ColorPicker` component in my [FluentUI](https://www.nuget.org/packages/Marqdouj.HtmlComponents.FluentUI/) NuGet package.
- CSS helper class.
  - Create unique CSS IDs using `Guid`.

## Release Notes
**8.0.4**
- Updated ReadMe

**8.0.3**
- `HtmlColorNameListItem` changes.
  - Name and Hex return value was changed from string? to string.
  - ToString() override now returns Name.

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
