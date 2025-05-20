using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UserConversationsEventMediaSummary
{
    /// <summary>
    /// Gets or Sets ContactCenter
    /// </summary>
    public UserConversationsEventMediaSummaryDetail ContactCenter { get; set; }

    /// <summary>
    /// Gets or Sets Enterprise
    /// </summary>
    public UserConversationsEventMediaSummaryDetail Enterprise { get; set; }
}
