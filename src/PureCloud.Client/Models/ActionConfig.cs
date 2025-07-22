using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ActionConfig
{
    /// <summary>
    /// Optional 1-60 second timeout enforced on the execution or test of this action. This setting is invalid for Custom Authentication Actions.
    /// </summary>
    /// <value>Optional 1-60 second timeout enforced on the execution or test of this action. This setting is invalid for Custom Authentication Actions.</value>
    public int? TimeoutSeconds { get; set; }

    /// <summary>
    /// Configuration of outbound request.
    /// </summary>
    /// <value>Configuration of outbound request.</value>
    public RequestConfig Request { get; set; }

    /// <summary>
    /// Configuration of response processing.
    /// </summary>
    /// <value>Configuration of response processing.</value>
    public ResponseConfig Response { get; set; }
}
