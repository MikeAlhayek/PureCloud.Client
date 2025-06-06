using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkErrorDetail
/// </summary>

public partial class BulkErrorDetail : IEquatable<BulkErrorDetail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkErrorDetail" /> class.
    /// </summary>
    /// <param name="FieldName">The name of the field which experienced an error..</param>
    /// <param name="Value">The field value from the request which caused the error..</param>
    /// <param name="Message">A field-specific error message describing why this operation was rejected..</param>
    public BulkErrorDetail(string FieldName = null, string Value = null, string Message = null)
    {
        this.FieldName = FieldName;
        this.Value = Value;
        this.Message = Message;

    }



    /// <summary>
    /// The name of the field which experienced an error.
    /// </summary>
    /// <value>The name of the field which experienced an error.</value>
    [JsonPropertyName("fieldName")]
    public string FieldName { get; set; }



    /// <summary>
    /// The field value from the request which caused the error.
    /// </summary>
    /// <value>The field value from the request which caused the error.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// A field-specific error message describing why this operation was rejected.
    /// </summary>
    /// <value>A field-specific error message describing why this operation was rejected.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkErrorDetail {\n");

        sb.Append("  FieldName: ").Append(FieldName).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
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
        return Equals(obj as BulkErrorDetail);
    }

    /// <summary>
    /// Returns true if BulkErrorDetail instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkErrorDetail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkErrorDetail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FieldName == other.FieldName ||
                FieldName != null &&
                FieldName.Equals(other.FieldName)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
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
            if (FieldName != null)
            {
                hash = hash * 59 + FieldName.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            return hash;
        }
    }
}
