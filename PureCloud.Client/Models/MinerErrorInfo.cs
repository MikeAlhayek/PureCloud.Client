using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MinerErrorInfo
/// </summary>

public partial class MinerErrorInfo : IEquatable<MinerErrorInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MinerErrorInfo" /> class.
    /// </summary>
    /// <param name="Message">Message.</param>
    /// <param name="Code">Code.</param>
    /// <param name="MessageWithParams">Error message with params included..</param>
    /// <param name="MessageParams">Map of variables and params for the error message..</param>
    public MinerErrorInfo(string Message = null, string Code = null, string MessageWithParams = null, Dictionary<string, object> MessageParams = null)
    {
        this.Message = Message;
        this.Code = Code;
        this.MessageWithParams = MessageWithParams;
        this.MessageParams = MessageParams;

    }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// Error message with params included.
    /// </summary>
    /// <value>Error message with params included.</value>
    [JsonPropertyName("messageWithParams")]
    public string MessageWithParams { get; set; }



    /// <summary>
    /// Map of variables and params for the error message.
    /// </summary>
    /// <value>Map of variables and params for the error message.</value>
    [JsonPropertyName("messageParams")]
    public Dictionary<string, object> MessageParams { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MinerErrorInfo {\n");

        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
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
        return Equals(obj as MinerErrorInfo);
    }

    /// <summary>
    /// Returns true if MinerErrorInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of MinerErrorInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MinerErrorInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
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
            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
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
