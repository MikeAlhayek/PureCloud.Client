using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CopyAttachmentsRequest
/// </summary>

public partial class CopyAttachmentsRequest : IEquatable<CopyAttachmentsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CopyAttachmentsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CopyAttachmentsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CopyAttachmentsRequest" /> class.
    /// </summary>
    /// <param name="SourceMessage">A reference to the email message within the current conversation that owns the attachments to be copied (required).</param>
    /// <param name="Attachments">A list of attachments that will be copied from the source message to the current draft (required).</param>
    public CopyAttachmentsRequest(DomainEntityRef SourceMessage = null, List<Attachment> Attachments = null)
    {
        this.SourceMessage = SourceMessage;
        this.Attachments = Attachments;

    }



    /// <summary>
    /// A reference to the email message within the current conversation that owns the attachments to be copied
    /// </summary>
    /// <value>A reference to the email message within the current conversation that owns the attachments to be copied</value>
    [JsonPropertyName("sourceMessage")]
    public DomainEntityRef SourceMessage { get; set; }



    /// <summary>
    /// A list of attachments that will be copied from the source message to the current draft
    /// </summary>
    /// <value>A list of attachments that will be copied from the source message to the current draft</value>
    [JsonPropertyName("attachments")]
    public List<Attachment> Attachments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CopyAttachmentsRequest {\n");

        sb.Append("  SourceMessage: ").Append(SourceMessage).Append("\n");
        sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
        return Equals(obj as CopyAttachmentsRequest);
    }

    /// <summary>
    /// Returns true if CopyAttachmentsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CopyAttachmentsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CopyAttachmentsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SourceMessage == other.SourceMessage ||
                SourceMessage != null &&
                SourceMessage.Equals(other.SourceMessage)
            ) &&
            (
                Attachments == other.Attachments ||
                Attachments != null &&
                Attachments.SequenceEqual(other.Attachments)
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
            if (SourceMessage != null)
            {
                hash = hash * 59 + SourceMessage.GetHashCode();
            }

            if (Attachments != null)
            {
                hash = hash * 59 + Attachments.GetHashCode();
            }

            return hash;
        }
    }
}
