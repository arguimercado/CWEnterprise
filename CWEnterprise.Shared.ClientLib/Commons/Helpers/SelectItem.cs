namespace CWEnterprise.Shared.ClientLib.Commons.Helpers;

public class SelectItem
{
    public string Text { get; set; } = "";
    public string Value { get; set; } = "";

    public string? Type { get; set; }

    public int HoldingValueInt { get; set; }
    public string? HoldingValueStr { get; set; }


    public bool IsSelected { get; set; } = false;
}
