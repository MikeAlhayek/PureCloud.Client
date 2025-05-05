using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssignmentError
/// </summary>

public partial class AssignmentError : IEquatable<AssignmentError>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AssignmentError" /> class.
    /// </summary>
    /// <param name="User">A user that is failed to be removed from the performance profile.</param>
    /// <param name="Message">Error message from membership assignment.</param>
    public AssignmentError(UserReference User = null, string Message = null)
    {
        this.User = User;
        this.Message = Message;

    }



    /// <summary>
    /// A user that is failed to be removed from the performance profile
    /// </summary>
    /// <value>A user that is failed to be removed from the performance profile</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// Error message from membership assignment
    /// </summary>
    /// <value>Error message from membership assignment</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssignmentError {\n");

        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as AssignmentError);
    }

    /// <summary>
    /// Returns true if AssignmentError instances are equal
    /// </summary>
    /// <param name="other">Instance of AssignmentError to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssignmentError other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            return hash;
        }
    }
}
