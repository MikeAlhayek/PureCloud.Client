using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValidationError
/// </summary>

public partial class ValidationError : IEquatable<ValidationError>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationError" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ValidationError() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationError" /> class.
    /// </summary>
    /// <param name="LineNumber">Line number for the error in CSV (required).</param>
    /// <param name="Message">Detail of the error in CSV (required).</param>
    public ValidationError(long? LineNumber = null, string Message = null)
    {
        this.LineNumber = LineNumber;
        this.Message = Message;

    }



    /// <summary>
    /// Line number for the error in CSV
    /// </summary>
    /// <value>Line number for the error in CSV</value>
    [JsonPropertyName("lineNumber")]
    public long? LineNumber { get; set; }



    /// <summary>
    /// Detail of the error in CSV
    /// </summary>
    /// <value>Detail of the error in CSV</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValidationError {\n");

        sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
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
        return Equals(obj as ValidationError);
    }

    /// <summary>
    /// Returns true if ValidationError instances are equal
    /// </summary>
    /// <param name="other">Instance of ValidationError to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValidationError other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LineNumber == other.LineNumber ||
                LineNumber != null &&
                LineNumber.Equals(other.LineNumber)
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
            if (LineNumber != null)
            {
                hash = hash * 59 + LineNumber.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            return hash;
        }
    }
}
