using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Analytics;

namespace PureCloud.Client.Models;

public sealed class AnalyticsConversationWithoutAttributesMultiGetResponse
{
    /// <summary>
    /// Gets or Sets Conversations
    /// </summary>
    public IEnumerable<AnalyticsConversationWithoutAttributes> Conversations { get; set; }
}
