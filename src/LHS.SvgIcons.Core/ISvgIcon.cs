namespace LHS.SvgIcons.Core;

public interface ISvgIcon
{
    string SvgContent { get; set;  }

    string? Width { get; set; }

    string? Height { get; set; }

    string? Class { get; }

    string? Fill { get; set; }

    string? Stroke { get; set; }

    string? StrokeWidth { get; set; }

    string? StrokeLineCap { get; }

    string? StrokeLineJoin { get; }

    string? ViewBox { get; set; }
}