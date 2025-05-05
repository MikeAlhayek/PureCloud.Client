using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TaskManagementErrorDetails
/// </summary>

public partial class TaskManagementErrorDetails : IEquatable<TaskManagementErrorDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TaskManagementErrorDetails" /> class.
    /// </summary>
    /// <param name="Code">System defined error code for the error..</param>
    /// <param name="Message">Error message..</param>
    public TaskManagementErrorDetails(string Code = null, string Message = null)
    {
        this.Code = Code;
        this.Message = Message;

    }



    /// <summary>
    /// System defined error code for the error.
    /// </summary>
    /// <value>System defined error code for the error.</value>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// Error message.
    /// </summary>
    /// <value>Error message.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TaskManagementErrorDetails {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
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
        return Equals(obj as TaskManagementErrorDetails);
    }

    /// <summary>
    /// Returns true if TaskManagementErrorDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of TaskManagementErrorDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TaskManagementErrorDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            return hash;
        }
    }
}
