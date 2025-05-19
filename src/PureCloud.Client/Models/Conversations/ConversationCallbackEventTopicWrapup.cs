using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationCallbackEventTopicWrapup
{
    /// <summary>
    /// The user configured wrap up code name.
    /// </summary>
    /// <value>The user configured wrap up code name.</value>
    public string Code { get; set; }

    /// <summary>
    /// Text entered by the agent to describe the call or disposition.
    /// </summary>
    /// <value>Text entered by the agent to describe the call or disposition.</value>
    public string Notes { get; set; }

    /// <summary>
    /// List of tags selected by the agent to describe the call or disposition.
    /// </summary>
    /// <value>List of tags selected by the agent to describe the call or disposition.</value>
    public IEnumerable<string> Tags { get; set; }

    /// <summary>
    /// The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally
    /// </summary>
    /// <value>The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally</value>
    public long? DurationSeconds { get; set; }

    /// <summary>
    /// The timestamp when the wrapup was finished.
    /// </summary>
    /// <value>The timestamp when the wrapup was finished.</value>
    public DateTime? EndTime { get; set; }
}
