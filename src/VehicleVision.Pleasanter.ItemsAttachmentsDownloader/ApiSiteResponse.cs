using System.Text.RegularExpressions;

internal sealed class ApiSiteResponse
{
    public SiteResponse Response { get; set; } = new SiteResponse();
}

internal sealed class SiteResponse
{
    public SiteData Data { get; set; } = new SiteData();
}

internal sealed class SiteData
{
    public string Title { get; set; }
    public string TitleFormated => Regex.Replace(Title ?? "", $"[{string.Join("", Path.GetInvalidFileNameChars())}]", "_");
    public SiteSiteSettings SiteSettings { get; set; } = new SiteSiteSettings();
}

internal sealed class SiteSiteSettings
{
    public List<SiteColumn> Columns { get; set; } = new List<SiteColumn>();
}

internal sealed class SiteColumn
{
    public string ColumnName { get; set; }
    public string LabelText { get; set; }
    public string LabelTextFormated => Regex.Replace(LabelText ?? "", $"[{string.Join("", Path.GetInvalidFileNameChars())}]", "_");
}
