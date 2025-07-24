namespace PureCloud.Client.Models;

/// <summary>
/// Creating an exported script via Download Service
/// </summary>
public sealed class ExportScriptRequest
{
    /// <summary>
    /// The final file name (no extension) of the script download: &lt;fileName&gt;.script
    /// </summary>
    /// <value>The final file name (no extension) of the script download: &lt;fileName&gt;.script</value>
    public string FileName { get; set; }

    /// <summary>
    /// The UUID version of the script to be exported.  Defaults to the current editable version.
    /// </summary>
    /// <value>The UUID version of the script to be exported.  Defaults to the current editable version.</value>
    public string VersionId { get; set; }
}
