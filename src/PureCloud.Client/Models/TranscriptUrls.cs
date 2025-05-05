using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptUrls
/// </summary>

public partial class TranscriptUrls : IEquatable<TranscriptUrls>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptUrls" /> class.
    /// </summary>
    /// <param name="Conversation">The Conversation Reference.</param>
    /// <param name="CommunicationId">The Communication ID.</param>
    /// <param name="Urls">List of Transcript URLs.</param>
    public TranscriptUrls(AddressableEntityRef Conversation = null, string CommunicationId = null, List<SegmentUrl> Urls = null)
    {
        this.Conversation = Conversation;
        this.CommunicationId = CommunicationId;
        this.Urls = Urls;

    }



    /// <summary>
    /// The Conversation Reference
    /// </summary>
    /// <value>The Conversation Reference</value>
    [JsonPropertyName("conversation")]
    public AddressableEntityRef Conversation { get; set; }



    /// <summary>
    /// The Communication ID
    /// </summary>
    /// <value>The Communication ID</value>
    [JsonPropertyName("communicationId")]
    public string CommunicationId { get; set; }



    /// <summary>
    /// List of Transcript URLs
    /// </summary>
    /// <value>List of Transcript URLs</value>
    [JsonPropertyName("urls")]
    public List<SegmentUrl> Urls { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptUrls {\n");

        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  Urls: ").Append(Urls).Append("\n");
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
        return Equals(obj as TranscriptUrls);
    }

    /// <summary>
    /// Returns true if TranscriptUrls instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptUrls to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptUrls other)
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
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                Urls == other.Urls ||
                Urls != null &&
                Urls.SequenceEqual(other.Urls)
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

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (Urls != null)
            {
                hash = hash * 59 + Urls.GetHashCode();
            }

            return hash;
        }
    }
}
