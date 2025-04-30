using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// BulkError
/// </summary>
[DataContract]
public partial class BulkError : IEquatable<BulkError>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkError" /> class.
    /// </summary>
    /// <param name="Message">Error message of the bulk operation result..</param>
    /// <param name="Code">Error code of the bulk operation result..</param>
    public BulkError(string Message = null, string Code = null)
    {
        this.Message = Message;
        this.Code = Code;

    }



    /// <summary>
    /// Error message of the bulk operation result.
    /// </summary>
    /// <value>Error message of the bulk operation result.</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Error code of the bulk operation result.
    /// </summary>
    /// <value>Error code of the bulk operation result.</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkError {\n");

        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
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
        return this.Equals(obj as BulkError);
    }

    /// <summary>
    /// Returns true if BulkError instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkError to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkError other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Message == other.Message ||
                this.Message != null &&
                this.Message.Equals(other.Message)
            ) &&
            (
                this.Code == other.Code ||
                this.Code != null &&
                this.Code.Equals(other.Code)
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
            if (this.Message != null)
            {
                hash = hash * 59 + this.Message.GetHashCode();
            }

            if (this.Code != null)
            {
                hash = hash * 59 + this.Code.GetHashCode();
            }

            return hash;
        }
    }
}
