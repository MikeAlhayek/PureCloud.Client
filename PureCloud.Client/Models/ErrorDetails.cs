using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ErrorDetails
/// </summary>
[DataContract]
public partial class ErrorDetails : IEquatable<ErrorDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ErrorDetails" /> class.
    /// </summary>
    /// <param name="Status">Status.</param>
    /// <param name="Message">Message.</param>
    /// <param name="MessageWithParams">MessageWithParams.</param>
    /// <param name="MessageParams">MessageParams.</param>
    /// <param name="Code">Code.</param>
    /// <param name="ContextId">ContextId.</param>
    /// <param name="Nested">Nested.</param>
    /// <param name="Details">Details.</param>
    public ErrorDetails(int? Status = null, string Message = null, string MessageWithParams = null, Dictionary<string, string> MessageParams = null, string Code = null, string ContextId = null, ErrorDetails Nested = null, string Details = null)
    {
        this.Status = Status;
        this.Message = Message;
        this.MessageWithParams = MessageWithParams;
        this.MessageParams = MessageParams;
        this.Code = Code;
        this.ContextId = ContextId;
        this.Nested = Nested;
        this.Details = Details;

    }



    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public int? Status { get; set; }



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
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }



    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    [DataMember(Name = "contextId", EmitDefaultValue = false)]
    public string ContextId { get; set; }



    /// <summary>
    /// Gets or Sets Nested
    /// </summary>
    [DataMember(Name = "nested", EmitDefaultValue = false)]
    public ErrorDetails Nested { get; set; }



    /// <summary>
    /// Gets or Sets Details
    /// </summary>
    [DataMember(Name = "details", EmitDefaultValue = false)]
    public string Details { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ErrorDetails {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  MessageWithParams: ").Append(MessageWithParams).Append("\n");
        sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  Nested: ").Append(Nested).Append("\n");
        sb.Append("  Details: ").Append(Details).Append("\n");
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
        return Equals(obj as ErrorDetails);
    }

    /// <summary>
    /// Returns true if ErrorDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of ErrorDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ErrorDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            ) &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                Nested == other.Nested ||
                Nested != null &&
                Nested.Equals(other.Nested)
            ) &&
            (
                Details == other.Details ||
                Details != null &&
                Details.Equals(other.Details)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
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

            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (Nested != null)
            {
                hash = hash * 59 + Nested.GetHashCode();
            }

            if (Details != null)
            {
                hash = hash * 59 + Details.GetHashCode();
            }

            return hash;
        }
    }
}
