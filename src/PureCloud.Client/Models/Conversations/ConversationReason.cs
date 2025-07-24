using System.Runtime.Serialization;
using System.Text;
using PureCloud.Client.Models.Conversations;

namespace PureCloud.Client.Models;

/// <summary>
/// Reasons for a failed message receipt.
/// </summary>
public sealed class ConversationReason
{
    // The reason code for the failed message receipt.
    public Code? Code { get; set; }

    // Description of the reason for the failed message receipt.
    public string Message { get; set; }
}
