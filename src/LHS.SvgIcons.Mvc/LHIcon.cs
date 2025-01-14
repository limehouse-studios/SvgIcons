using System.Web.Mvc;
using LHS.SvgIcons.Core;

namespace LHS.SvgIcons.Mvc;

public static class LHIcon
{
    public static MvcHtmlString Render(ISvgIcon icon,  string? classes = null, string? width = null, string? height = null)
    {
        var svgBuilder = new TagBuilder("svg");
        svgBuilder.MergeAttribute("xmlns", "http://www.w3.org/2000/svg");

        if (!string.IsNullOrEmpty(icon.Width) && string.IsNullOrEmpty(width))
            svgBuilder.MergeAttribute("width", icon.Width);
        else if (!string.IsNullOrEmpty(width))
            svgBuilder.MergeAttribute("width", width);

        if (!string.IsNullOrEmpty(icon.Height) && string.IsNullOrEmpty(height))
            svgBuilder.MergeAttribute("height", icon.Height);
        else if (!string.IsNullOrEmpty(height))
            svgBuilder.MergeAttribute("height", height);

        if (!string.IsNullOrEmpty(classes) || !string.IsNullOrEmpty(icon.Class))
            svgBuilder.AddCssClass(string.Join(" ", classes, icon.Class));

        if (!string.IsNullOrEmpty(icon.Fill))
            svgBuilder.MergeAttribute("fill", icon.Fill);

        if (!string.IsNullOrEmpty(icon.Stroke))
            svgBuilder.MergeAttribute("stroke", icon.Stroke);

        if (!string.IsNullOrEmpty(icon.StrokeWidth))
            svgBuilder.MergeAttribute("stroke-width", icon.StrokeWidth);

        if (!string.IsNullOrEmpty(icon.StrokeLineCap))
            svgBuilder.MergeAttribute("stroke-linecap", icon.StrokeLineCap);

        if (!string.IsNullOrEmpty(icon.StrokeLineJoin))
            svgBuilder.MergeAttribute("stroke-linejoin", icon.StrokeLineJoin);

        if (!string.IsNullOrEmpty(icon.ViewBox))
            svgBuilder.MergeAttribute("viewBox", icon.ViewBox);

        svgBuilder.InnerHtml = icon.SvgContent;

        return new MvcHtmlString(svgBuilder.ToString());
    }
}