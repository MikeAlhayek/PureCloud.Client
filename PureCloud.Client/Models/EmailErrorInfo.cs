using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailErrorInfo
/// </summary>
[DataContract]
public partial class EmailErrorInfo : IEquatable<EmailErrorInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailErrorInfo" /> class.
    /// </summary>
    public EmailErrorInfo()
    {

    }



    /// <summary>
    /// Error Message
    /// </summary>
    /// <value>Error Message</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; private set; }



    /// <summary>
    /// Error Code
    /// </summary>
    /// <value>Error Code</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailErrorInfo {\n");

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
        return Equals(obj as EmailErrorInfo);
    }

    /// <summary>
    /// Returns true if EmailErrorInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailErrorInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailErrorInfo other)
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

            return hash;
        }
    }
}
