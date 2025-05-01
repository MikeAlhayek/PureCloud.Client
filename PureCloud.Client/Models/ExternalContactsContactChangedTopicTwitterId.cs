using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsContactChangedTopicTwitterId
/// </summary>
[DataContract]
public partial class ExternalContactsContactChangedTopicTwitterId : IEquatable<ExternalContactsContactChangedTopicTwitterId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicTwitterId" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="ScreenName">ScreenName.</param>
    /// <param name="Verified">Verified.</param>
    /// <param name="ProfileUrl">ProfileUrl.</param>
    public ExternalContactsContactChangedTopicTwitterId(string Id = null, string Name = null, string ScreenName = null, bool? Verified = null, string ProfileUrl = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.ScreenName = ScreenName;
        this.Verified = Verified;
        this.ProfileUrl = ProfileUrl;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets ScreenName
    /// </summary>
    [DataMember(Name = "screenName", EmitDefaultValue = false)]
    public string ScreenName { get; set; }



    /// <summary>
    /// Gets or Sets Verified
    /// </summary>
    [DataMember(Name = "verified", EmitDefaultValue = false)]
    public bool? Verified { get; set; }



    /// <summary>
    /// Gets or Sets ProfileUrl
    /// </summary>
    [DataMember(Name = "profileUrl", EmitDefaultValue = false)]
    public string ProfileUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsContactChangedTopicTwitterId {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ScreenName: ").Append(ScreenName).Append("\n");
        sb.Append("  Verified: ").Append(Verified).Append("\n");
        sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
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
        return Equals(obj as ExternalContactsContactChangedTopicTwitterId);
    }

    /// <summary>
    /// Returns true if ExternalContactsContactChangedTopicTwitterId instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsContactChangedTopicTwitterId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsContactChangedTopicTwitterId other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ScreenName == other.ScreenName ||
                ScreenName != null &&
                ScreenName.Equals(other.ScreenName)
            ) &&
            (
                Verified == other.Verified ||
                Verified != null &&
                Verified.Equals(other.Verified)
            ) &&
            (
                ProfileUrl == other.ProfileUrl ||
                ProfileUrl != null &&
                ProfileUrl.Equals(other.ProfileUrl)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ScreenName != null)
            {
                hash = hash * 59 + ScreenName.GetHashCode();
            }

            if (Verified != null)
            {
                hash = hash * 59 + Verified.GetHashCode();
            }

            if (ProfileUrl != null)
            {
                hash = hash * 59 + ProfileUrl.GetHashCode();
            }

            return hash;
        }
    }
}
