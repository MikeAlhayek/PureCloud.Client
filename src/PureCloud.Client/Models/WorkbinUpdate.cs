namespace PureCloud.Client.Models;

/// <summary>
/// WorkbinUpdate
/// </summary>
public sealed class WorkbinUpdate
{
    /// <summary>
    /// Workbin name. Valid length between 3 and 256 characters.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Workbin description. Maximum length of 512 characters.
    /// </summary>
    public string Description { get; set; }
}
