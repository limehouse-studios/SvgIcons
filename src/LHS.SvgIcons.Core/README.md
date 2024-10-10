# LHS.SvgIcons.Core

LHS.SvgIcons was created to provide a simple way to provide the same set of Svg Icons to both legacy .net framework MVC projects and Blazor projects to assist in side by side migration without changing general UI elements.

## Core

Core provides a simple interface to create Svg icon sets that can then be used by either LHS.SvgIcons.Blazor or LHS.SvgIcons.Mvc.

## Creating An Icon Set

Here is an example to create an icon set:

```csharp
public static class ExampleIconSet {
    public static ISvgIcon Paperclip => new SvgIcon(SvgContent: "<path....", ViewBox:"0 0 24 24", ...);
}
```


## Usage

Depending on the project type, use either LHS.SvgIcons.Blazor or LHS.SvgIcons.Mvc to use the icon set.
