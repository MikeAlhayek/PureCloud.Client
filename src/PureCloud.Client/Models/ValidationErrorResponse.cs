using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValidationErrorResponse
/// </summary>

public partial class ValidationErrorResponse : IEquatable<ValidationErrorResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidationErrorResponse" /> class.
    /// </summary>
    /// <param name="Message">Message string of the validation error..</param>
    /// <param name="ErrorType">Type of validation errror..</param>
    /// <param name="Arguments">Map of argument names to corresponding values. Used for localization..</param>
    public ValidationErrorResponse(string Message = null, string ErrorType = null, Dictionary<string, string> Arguments = null)
    {
        this.Message = Message;
        this.ErrorType = ErrorType;
        this.Arguments = Arguments;

    }



    /// <summary>
    /// Message string of the validation error.
    /// </summary>
    /// <value>Message string of the validation error.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Type of validation errror.
    /// </summary>
    /// <value>Type of validation errror.</value>
    [JsonPropertyName("errorType")]
    public string ErrorType { get; set; }



    /// <summary>
    /// Map of argument names to corresponding values. Used for localization.
    /// </summary>
    /// <value>Map of argument names to corresponding values. Used for localization.</value>
    [JsonPropertyName("arguments")]
    public Dictionary<string, string> Arguments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValidationErrorResponse {\n");

        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
        sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
        return Equals(obj as ValidationErrorResponse);
    }

    /// <summary>
    /// Returns true if ValidationErrorResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ValidationErrorResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValidationErrorResponse other)
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
                ErrorType == other.ErrorType ||
                ErrorType != null &&
                ErrorType.Equals(other.ErrorType)
            ) &&
            (
                Arguments == other.Arguments ||
                Arguments != null &&
                Arguments.SequenceEqual(other.Arguments)
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

            if (ErrorType != null)
            {
                hash = hash * 59 + ErrorType.GetHashCode();
            }

            if (Arguments != null)
            {
                hash = hash * 59 + Arguments.GetHashCode();
            }

            return hash;
        }
    }
}
