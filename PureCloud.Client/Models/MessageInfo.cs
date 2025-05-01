using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessageInfo
/// </summary>
[DataContract]
public partial class MessageInfo : IEquatable<MessageInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessageInfo" /> class.
    /// </summary>
    /// <param name="LocalizableMessageCode">Key that can be used to localize the message..</param>
    /// <param name="Message">Description of the message..</param>
    /// <param name="MessageWithParams">Message with template fields for variable replacement..</param>
    /// <param name="MessageParams">Map with fields for variable replacement..</param>
    public MessageInfo(string LocalizableMessageCode = null, string Message = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null)
    {
        this.LocalizableMessageCode = LocalizableMessageCode;
        this.Message = Message;
        this.MessageWithParams = MessageWithParams;
        this.MessageParams = MessageParams;

    }



    /// <summary>
    /// Key that can be used to localize the message.
    /// </summary>
    /// <value>Key that can be used to localize the message.</value>
    [DataMember(Name = "localizableMessageCode", EmitDefaultValue = false)]
    public string LocalizableMessageCode { get; set; }



    /// <summary>
    /// Description of the message.
    /// </summary>
    /// <value>Description of the message.</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Message with template fields for variable replacement.
    /// </summary>
    /// <value>Message with template fields for variable replacement.</value>
    [DataMember(Name = "messageWithParams", EmitDefaultValue = false)]
    public string MessageWithParams { get; set; }



    /// <summary>
    /// Map with fields for variable replacement.
    /// </summary>
    /// <value>Map with fields for variable replacement.</value>
    [DataMember(Name = "messageParams", EmitDefaultValue = false)]
    public Dictionary<string, string> MessageParams { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessageInfo {\n");

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
        return Equals(obj as MessageInfo);
    }

    /// <summary>
    /// Returns true if MessageInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of MessageInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessageInfo other)
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
