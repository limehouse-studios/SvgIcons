using LHS.SvgIcons.Core;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace LHS.SvgIcons.Blazor;

public class LHIcon: ComponentBase
{
    [Parameter, EditorRequired]
    public ISvgIcon Icon { get; set; } = default!;

    [Parameter]
    public string? Class { get; set; }

    [Parameter]
    public string? Width { get; set; }

    [Parameter]
    public string? Height { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        int seq = 0;
        builder.OpenElement(seq++, "svg");
        builder.AddAttribute(seq++, "xmlns", "http://www.w3.org/2000/svg");

        if (!string.IsNullOrEmpty(Icon.Width) && string.IsNullOrEmpty(Width))
            builder.AddAttribute(seq++, "width", Icon.Width);
        else if (!string.IsNullOrEmpty(Width))
            builder.AddAttribute(seq++, "width", Width);

        if (!string.IsNullOrEmpty(Icon.Height) && string.IsNullOrEmpty(Height))
            builder.AddAttribute(seq++, "height", Icon.Height);
        else if (!string.IsNullOrEmpty(Height))
            builder.AddAttribute(seq++, "height", Height);

        if (!string.IsNullOrEmpty(Class) || !string.IsNullOrEmpty(Icon.Class))
            builder.AddAttribute(seq++, "class", $"{Class} {Icon.Class}");

        if (!string.IsNullOrEmpty(Icon.Fill))
            builder.AddAttribute(seq++, "fill", Icon.Fill);

        if (!string.IsNullOrEmpty(Icon.Stroke))
            builder.AddAttribute(seq++, "stroke", Icon.Stroke);

        if (!string.IsNullOrEmpty(Icon.StrokeWidth))
            builder.AddAttribute(seq++, "stroke-width", Icon.StrokeWidth);

        if (!string.IsNullOrEmpty(Icon.StrokeLineCap))
            builder.AddAttribute(seq++, "stroke-linecap", Icon.StrokeLineCap);

        if (!string.IsNullOrEmpty(Icon.StrokeLineJoin))
            builder.AddAttribute(seq++, "stroke-linejoin", Icon.StrokeLineJoin);

        if (!string.IsNullOrEmpty(Icon.ViewBox))
            builder.AddAttribute(seq++, "viewBox", Icon.ViewBox);

        builder.AddMarkupContent(seq, Icon.SvgContent);

        builder.CloseElement();
    }
}