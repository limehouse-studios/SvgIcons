namespace LHS.SvgIcons.Core;

public record SvgIcon(
    string SvgContent,
    string? Width = null,
    string? Height = null,
    string? Class = null,
    string? Fill = null,
    string? Stroke = null,
    string? StrokeWidth = null,
    string? StrokeLineCap = null,
    string? StrokeLineJoin = null,
    string? ViewBox = null) : ISvgIcon
{
    public string SvgContent { get; set; } = SvgContent;
    public string? Width { get; set; } = Width;
    public string? Height { get; set; } = Height;
    public string? Class { get; } = Class;
    public string? Fill { get; set; } = Fill;
    public string? Stroke { get; set; } = Stroke;
    public string? StrokeWidth { get; set; } = StrokeWidth;
    public string? StrokeLineCap { get; } = StrokeLineCap;
    public string? StrokeLineJoin { get; } = StrokeLineJoin;
    public string? ViewBox { get; set; } = ViewBox;
}