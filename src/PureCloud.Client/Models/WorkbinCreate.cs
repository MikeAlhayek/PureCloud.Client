namespace PureCloud.Client.Models;

/// <summary>
/// WorkbinCreate
/// </summary>
public sealed class WorkbinCreate
{
    /// <summary>
    /// Workbin name. Valid length between 3 and 256 characters.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Workbin description. Maximum length of 512 characters.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The ID of the division the Workbin belongs to. Defaults to home division ID.
    /// </summary>
    public string DivisionId { get; set; }
}
