using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class VoicemailMessagesTopicVoicemailCopyRecord
{
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public VoicemailMessagesTopicOwner User { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    public VoicemailMessagesTopicOwner Group { get; set; }
}
