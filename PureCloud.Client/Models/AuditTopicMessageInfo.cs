using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditTopicMessageInfo
/// </summary>
[DataContract]
public partial class AuditTopicMessageInfo : IEquatable<AuditTopicMessageInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditTopicMessageInfo" /> class.
    /// </summary>
    /// <param name="LocalizableMessageCode">LocalizableMessageCode.</param>
    /// <param name="Message">Message.</param>
    /// <param name="MessageWithParams">MessageWithParams.</param>
    /// <param name="MessageParams">MessageParams.</param>
    public AuditTopicMessageInfo(string LocalizableMessageCode = null, string Message = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null)
    {
        this.LocalizableMessageCode = LocalizableMessageCode;
        this.Message = Message;
        this.MessageWithParams = MessageWithParams;
        this.MessageParams = MessageParams;

    }



    /// <summary>
    /// Gets or Sets LocalizableMessageCode
    /// </summary>
    [DataMember(Name = "localizableMessageCode", EmitDefaultValue = false)]
    public string LocalizableMessageCode { get; set; }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets MessageWithParams
    /// </summary>
    [DataMember(Name = "messageWithParams", EmitDefaultValue = false)]
    public string MessageWithParams { get; set; }



    /// <summary>
    /// Gets or Sets MessageParams
    /// </summary>
    [DataMember(Name = "messageParams", EmitDefaultValue = false)]
    public Dictionary<string, string> MessageParams { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditTopicMessageInfo {\n");

        sb.Append("  LocalizableMessageCode: ").Append(LocalizableMessageCode).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
        sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
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
        return Equals(obj as AuditTopicMessageInfo);
    }

    /// <summary>
    /// Returns true if AuditTopicMessageInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditTopicMessageInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditTopicMessageInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LocalizableMessageCode == other.LocalizableMessageCode ||
                LocalizableMessageCode != null &&
                LocalizableMessageCode.Equals(other.LocalizableMessageCode)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                MessageWithParams == other.MessageWithParams ||
                MessageWithParams != null &&
                MessageWithParams.Equals(other.MessageWithParams)
            ) &&
            (
                MessageParams == other.MessageParams ||
                MessageParams != null &&
                MessageParams.SequenceEqual(other.MessageParams)
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
            if (LocalizableMessageCode != null)
            {
                hash = hash * 59 + LocalizableMessageCode.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (MessageWithParams != null)
            {
                hash = hash * 59 + MessageWithParams.GetHashCode();
            }

            if (MessageParams != null)
            {
                hash = hash * 59 + MessageParams.GetHashCode();
            }

            return hash;
        }
    }
}
