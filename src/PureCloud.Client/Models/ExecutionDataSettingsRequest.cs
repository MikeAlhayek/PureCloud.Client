using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExecutionDataSettingsRequest
{
    /// <summary>
    /// whether or not the setting is enabled.
    /// </summary>
    /// <value>whether or not the setting is enabled.</value>
    public bool? Enabled { get; set; }
}
