using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsConversationAsyncQueryResponse
/// </summary>

public partial class AnalyticsConversationAsyncQueryResponse : IEquatable<AnalyticsConversationAsyncQueryResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsConversationAsyncQueryResponse" /> class.
    /// </summary>
    /// <param name="Conversations">Conversations.</param>
    /// <param name="Cursor">Optional cursor to indicate where to resume the results.</param>
    /// <param name="DataAvailabilityDate">Data available up to at least this datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public AnalyticsConversationAsyncQueryResponse(List<AnalyticsConversation> Conversations = null, string Cursor = null, DateTime? DataAvailabilityDate = null)
    {
        this.Conversations = Conversations;
        this.Cursor = Cursor;
        this.DataAvailabilityDate = DataAvailabilityDate;

    }



    /// <summary>
    /// Gets or Sets Conversations
    /// </summary>
    [JsonPropertyName("conversations")]
    public List<AnalyticsConversation> Conversations { get; set; }



    /// <summary>
    /// Optional cursor to indicate where to resume the results
    /// </summary>
    /// <value>Optional cursor to indicate where to resume the results</value>
    [JsonPropertyName("cursor")]
    public string Cursor { get; set; }



    /// <summary>
    /// Data available up to at least this datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Data available up to at least this datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dataAvailabilityDate")]
    public DateTime? DataAvailabilityDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsConversationAsyncQueryResponse {\n");

        sb.Append("  Conversations: ").Append(Conversations).Append("\n");
        sb.Append("  Cursor: ").Append(Cursor).Append("\n");
        sb.Append("  DataAvailabilityDate: ").Append(DataAvailabilityDate).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as AnalyticsConversationAsyncQueryResponse);
    }

    /// <summary>
    /// Returns true if AnalyticsConversationAsyncQueryResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsConversationAsyncQueryResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsConversationAsyncQueryResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversations == other.Conversations ||
                Conversations != null &&
                Conversations.SequenceEqual(other.Conversations)
            ) &&
            (
                Cursor == other.Cursor ||
                Cursor != null &&
                Cursor.Equals(other.Cursor)
            ) &&
            (
                DataAvailabilityDate == other.DataAvailabilityDate ||
                DataAvailabilityDate != null &&
                DataAvailabilityDate.Equals(other.DataAvailabilityDate)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Conversations != null)
            {
                hash = hash * 59 + Conversations.GetHashCode();
            }

            if (Cursor != null)
            {
                hash = hash * 59 + Cursor.GetHashCode();
            }

            if (DataAvailabilityDate != null)
            {
                hash = hash * 59 + DataAvailabilityDate.GetHashCode();
            }

            return hash;
        }
    }
}
