using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AnalyticsConversationAsyncQueryResponse
{
    /// <summary>
    /// Gets or Sets Conversations
    /// </summary>
    public IEnumerable<AnalyticsConversation> Conversations { get; set; }

    /// <summary>
    /// Optional cursor to indicate where to resume the results
    /// </summary>
    /// <value>Optional cursor to indicate where to resume the results</value>
    public string Cursor { get; set; }

    /// <summary>
    /// Data available up to at least this datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Data available up to at least this datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DataAvailabilityDate { get; set; }
}
