using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkspaceCreate
{
    /// <summary>
    /// The workspace name
    /// </summary>
    /// <value>The workspace name</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Bucket
    /// </summary>
    public string Bucket { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }
}
