using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserTimeOffRequestReference
/// </summary>

public partial class UserTimeOffRequestReference : IEquatable<UserTimeOffRequestReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UserTimeOffRequestReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserTimeOffRequestReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserTimeOffRequestReference" /> class.
    /// </summary>
    /// <param name="Id">The id of the time off request.</param>
    /// <param name="User">The ID of the user to whom the time off request applies (required).</param>
    public UserTimeOffRequestReference(string Id = null, UserReference User = null)
    {
        this.Id = Id;
        this.User = User;

    }



    /// <summary>
    /// The id of the time off request
    /// </summary>
    /// <value>The id of the time off request</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The ID of the user to whom the time off request applies
    /// </summary>
    /// <value>The ID of the user to whom the time off request applies</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserTimeOffRequestReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as UserTimeOffRequestReference);
    }

    /// <summary>
    /// Returns true if UserTimeOffRequestReference instances are equal
    /// </summary>
    /// <param name="other">Instance of UserTimeOffRequestReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserTimeOffRequestReference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
