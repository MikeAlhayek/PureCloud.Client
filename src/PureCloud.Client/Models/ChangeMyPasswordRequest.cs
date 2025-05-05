using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChangeMyPasswordRequest
/// </summary>

public partial class ChangeMyPasswordRequest : IEquatable<ChangeMyPasswordRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeMyPasswordRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChangeMyPasswordRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeMyPasswordRequest" /> class.
    /// </summary>
    /// <param name="NewPassword">The new password (required).</param>
    /// <param name="OldPassword">Your current password (required).</param>
    public ChangeMyPasswordRequest(string NewPassword = null, string OldPassword = null)
    {
        this.NewPassword = NewPassword;
        this.OldPassword = OldPassword;

    }



    /// <summary>
    /// The new password
    /// </summary>
    /// <value>The new password</value>
    [JsonPropertyName("newPassword")]
    public string NewPassword { get; set; }



    /// <summary>
    /// Your current password
    /// </summary>
    /// <value>Your current password</value>
    [JsonPropertyName("oldPassword")]
    public string OldPassword { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChangeMyPasswordRequest {\n");

        sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
        sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
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
        return Equals(obj as ChangeMyPasswordRequest);
    }

    /// <summary>
    /// Returns true if ChangeMyPasswordRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ChangeMyPasswordRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChangeMyPasswordRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                NewPassword == other.NewPassword ||
                NewPassword != null &&
                NewPassword.Equals(other.NewPassword)
            ) &&
            (
                OldPassword == other.OldPassword ||
                OldPassword != null &&
                OldPassword.Equals(other.OldPassword)
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
            if (NewPassword != null)
            {
                hash = hash * 59 + NewPassword.GetHashCode();
            }

            if (OldPassword != null)
            {
                hash = hash * 59 + OldPassword.GetHashCode();
            }

            return hash;
        }
    }
}
