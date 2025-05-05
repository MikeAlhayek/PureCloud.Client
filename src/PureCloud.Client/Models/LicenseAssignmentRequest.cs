using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LicenseAssignmentRequest
/// </summary>

public partial class LicenseAssignmentRequest : IEquatable<LicenseAssignmentRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseAssignmentRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LicenseAssignmentRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseAssignmentRequest" /> class.
    /// </summary>
    /// <param name="LicenseId">The id of the license to assign/unassign. (required).</param>
    /// <param name="UserIdsAdd">The ids of users to assign this license to. (required).</param>
    /// <param name="UserIdsRemove">The ids of users to unassign this license from. (required).</param>
    public LicenseAssignmentRequest(string LicenseId = null, List<string> UserIdsAdd = null, List<string> UserIdsRemove = null)
    {
        this.LicenseId = LicenseId;
        this.UserIdsAdd = UserIdsAdd;
        this.UserIdsRemove = UserIdsRemove;

    }



    /// <summary>
    /// The id of the license to assign/unassign.
    /// </summary>
    /// <value>The id of the license to assign/unassign.</value>
    [JsonPropertyName("licenseId")]
    public string LicenseId { get; set; }



    /// <summary>
    /// The ids of users to assign this license to.
    /// </summary>
    /// <value>The ids of users to assign this license to.</value>
    [JsonPropertyName("userIdsAdd")]
    public List<string> UserIdsAdd { get; set; }



    /// <summary>
    /// The ids of users to unassign this license from.
    /// </summary>
    /// <value>The ids of users to unassign this license from.</value>
    [JsonPropertyName("userIdsRemove")]
    public List<string> UserIdsRemove { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LicenseAssignmentRequest {\n");

        sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
        sb.Append("  UserIdsAdd: ").Append(UserIdsAdd).Append("\n");
        sb.Append("  UserIdsRemove: ").Append(UserIdsRemove).Append("\n");
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
        return Equals(obj as LicenseAssignmentRequest);
    }

    /// <summary>
    /// Returns true if LicenseAssignmentRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of LicenseAssignmentRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LicenseAssignmentRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LicenseId == other.LicenseId ||
                LicenseId != null &&
                LicenseId.Equals(other.LicenseId)
            ) &&
            (
                UserIdsAdd == other.UserIdsAdd ||
                UserIdsAdd != null &&
                UserIdsAdd.SequenceEqual(other.UserIdsAdd)
            ) &&
            (
                UserIdsRemove == other.UserIdsRemove ||
                UserIdsRemove != null &&
                UserIdsRemove.SequenceEqual(other.UserIdsRemove)
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
            if (LicenseId != null)
            {
                hash = hash * 59 + LicenseId.GetHashCode();
            }

            if (UserIdsAdd != null)
            {
                hash = hash * 59 + UserIdsAdd.GetHashCode();
            }

            if (UserIdsRemove != null)
            {
                hash = hash * 59 + UserIdsRemove.GetHashCode();
            }

            return hash;
        }
    }
}
