using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DynamicGroupQueryPreview
{
    /// <summary>
    /// Number of Users that match the DynamicGroupQuery
    /// </summary>
    /// <value>Number of Users that match the DynamicGroupQuery</value>
    public int? UserCount { get; set; }
}
