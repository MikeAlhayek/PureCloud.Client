using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines the summaries of a conversation.
/// </summary>
[DataContract]
public partial class ConversationSummariesGetResponse : IEquatable<ConversationSummariesGetResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummariesGetResponse" /> class.
    /// </summary>
    /// <param name="Conversation">The conversation object..</param>
    /// <param name="Summary">The summary of the conversation..</param>
    /// <param name="SessionSummaries">All the summaries of the session..</param>
    public ConversationSummariesGetResponse(AddressableEntityRef Conversation = null, ConversationSummary Summary = null, List<ConversationSessionSummary> SessionSummaries = null)
    {
        this.Conversation = Conversation;
        this.Summary = Summary;
        this.SessionSummaries = SessionSummaries;

    }



    /// <summary>
    /// The conversation object.
    /// </summary>
    /// <value>The conversation object.</value>
    [DataMember(Name = "conversation", EmitDefaultValue = false)]
    public AddressableEntityRef Conversation { get; set; }



    /// <summary>
    /// The summary of the conversation.
    /// </summary>
    /// <value>The summary of the conversation.</value>
    [DataMember(Name = "summary", EmitDefaultValue = false)]
    public ConversationSummary Summary { get; set; }



    /// <summary>
    /// All the summaries of the session.
    /// </summary>
    /// <value>All the summaries of the session.</value>
    [DataMember(Name = "sessionSummaries", EmitDefaultValue = false)]
    public List<ConversationSessionSummary> SessionSummaries { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSummariesGetResponse {\n");

        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  Summary: ").Append(Summary).Append("\n");
        sb.Append("  SessionSummaries: ").Append(SessionSummaries).Append("\n");
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
        return Equals(obj as ConversationSummariesGetResponse);
    }

    /// <summary>
    /// Returns true if ConversationSummariesGetResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummariesGetResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummariesGetResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                Summary == other.Summary ||
                Summary != null &&
                Summary.Equals(other.Summary)
            ) &&
            (
                SessionSummaries == other.SessionSummaries ||
                SessionSummaries != null &&
                SessionSummaries.SequenceEqual(other.SessionSummaries)
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
            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (Summary != null)
            {
                hash = hash * 59 + Summary.GetHashCode();
            }

            if (SessionSummaries != null)
            {
                hash = hash * 59 + SessionSummaries.GetHashCode();
            }

            return hash;
        }
    }
}
