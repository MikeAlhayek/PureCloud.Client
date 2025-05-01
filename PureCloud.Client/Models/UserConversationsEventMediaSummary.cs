using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserConversationsEventMediaSummary
/// </summary>
[DataContract]
public partial class UserConversationsEventMediaSummary : IEquatable<UserConversationsEventMediaSummary>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserConversationsEventMediaSummary" /> class.
    /// </summary>
    /// <param name="ContactCenter">ContactCenter.</param>
    /// <param name="Enterprise">Enterprise.</param>
    public UserConversationsEventMediaSummary(UserConversationsEventMediaSummaryDetail ContactCenter = null, UserConversationsEventMediaSummaryDetail Enterprise = null)
    {
        this.ContactCenter = ContactCenter;
        this.Enterprise = Enterprise;

    }



    /// <summary>
    /// Gets or Sets ContactCenter
    /// </summary>
    [DataMember(Name = "contactCenter", EmitDefaultValue = false)]
    public UserConversationsEventMediaSummaryDetail ContactCenter { get; set; }



    /// <summary>
    /// Gets or Sets Enterprise
    /// </summary>
    [DataMember(Name = "enterprise", EmitDefaultValue = false)]
    public UserConversationsEventMediaSummaryDetail Enterprise { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserConversationsEventMediaSummary {\n");

        sb.Append("  ContactCenter: ").Append(ContactCenter).Append("\n");
        sb.Append("  Enterprise: ").Append(Enterprise).Append("\n");
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
        return Equals(obj as UserConversationsEventMediaSummary);
    }

    /// <summary>
    /// Returns true if UserConversationsEventMediaSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of UserConversationsEventMediaSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserConversationsEventMediaSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContactCenter == other.ContactCenter ||
                ContactCenter != null &&
                ContactCenter.Equals(other.ContactCenter)
            ) &&
            (
                Enterprise == other.Enterprise ||
                Enterprise != null &&
                Enterprise.Equals(other.Enterprise)
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
            if (ContactCenter != null)
            {
                hash = hash * 59 + ContactCenter.GetHashCode();
            }

            if (Enterprise != null)
            {
                hash = hash * 59 + Enterprise.GetHashCode();
            }

            return hash;
        }
    }
}
