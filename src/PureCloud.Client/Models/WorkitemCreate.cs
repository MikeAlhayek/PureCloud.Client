namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemCreate
/// </summary>
public sealed class WorkitemCreate
{
    /// <summary>
    /// The name of the Workitem. Valid length between 3 and 256 characters.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The priority of the Workitem. The valid range is between -25,000,000 and 25,000,000.
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// The description of the Workitem. Maximum length of 512 characters.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The ID of Workbin that contains the Workitem.
    /// </summary>
    public string WorkbinId { get; set; }

    /// <summary>
    /// The ID of the Status of the Workitem.
    /// </summary>
    public string StatusId { get; set; }
}