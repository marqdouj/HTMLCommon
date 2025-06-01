# HTMLCommon

## Release Notes
**8.0.0**
- Added `HtmlColorEnum` to represent HTML Named Colors.
  - Supports all 140 HTML colors based on [w3schools](https://www.w3schools.com/colors/colors_names.asp) and [w3.org](https://www.w3.org/TR/css-color-4/#named-colors).
  - Includes a `ToHex` extension method that returns the Html Hex string.
    - For example, `HtmlColorName.AliceBlue.ToHex()` returns `"#F0F8FF"`.
