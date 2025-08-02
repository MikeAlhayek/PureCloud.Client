namespace PureCloud.Client.Models;

/// <summary>
/// WorkbinChangeListing
/// </summary>
public sealed class WorkbinChangeListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<WorkitemsChangeWorkbinDelta> Entities { get; set; }

    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    public string NextUri { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    public string PreviousUri { get; set; }

    /// <summary>
    /// Gets or Sets After
    /// </summary>
    public string After { get; set; }
}
