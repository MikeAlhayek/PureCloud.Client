using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InvalidAssignment
/// </summary>

public partial class InvalidAssignment : IEquatable<InvalidAssignment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidAssignment" /> class.
    /// </summary>
    /// <param name="User">Invalid user for validation.</param>
    /// <param name="Message">The reason for the invalid input for validation.</param>
    public InvalidAssignment(UserReference User = null, string Message = null)
    {
        this.User = User;
        this.Message = Message;

    }



    /// <summary>
    /// Invalid user for validation
    /// </summary>
    /// <value>Invalid user for validation</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The reason for the invalid input for validation
    /// </summary>
    /// <value>The reason for the invalid input for validation</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InvalidAssignment {\n");

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
        return Equals(obj as InvalidAssignment);
    }

    /// <summary>
    /// Returns true if InvalidAssignment instances are equal
    /// </summary>
    /// <param name="other">Instance of InvalidAssignment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InvalidAssignment other)
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
