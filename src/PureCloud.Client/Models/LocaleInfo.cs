using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class LocaleInfo
{
    /// <summary>
    /// Error details for the flow version, if any.
    /// </summary>
    /// <value>Error details for the flow version, if any.</value>
    public FlowHealthErrorInfo ErrorInfo { get; set; }

    /// <summary>
    /// Info about given flow version.
    /// </summary>
    /// <value>Info about given flow version.</value>
    public LocaleFlowVersionInfo FlowVersionInfo { get; set; }
}
