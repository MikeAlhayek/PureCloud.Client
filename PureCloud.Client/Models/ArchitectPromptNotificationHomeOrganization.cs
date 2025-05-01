using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectPromptNotificationHomeOrganization
/// </summary>
[DataContract]
public partial class ArchitectPromptNotificationHomeOrganization : IEquatable<ArchitectPromptNotificationHomeOrganization>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectPromptNotificationHomeOrganization" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="ThirdPartyOrgName">ThirdPartyOrgName.</param>
    public ArchitectPromptNotificationHomeOrganization(string Id = null, string Name = null, string ThirdPartyOrgName = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.ThirdPartyOrgName = ThirdPartyOrgName;

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
    /// Gets or Sets ThirdPartyOrgName
    /// </summary>
    [DataMember(Name = "thirdPartyOrgName", EmitDefaultValue = false)]
    public string ThirdPartyOrgName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectPromptNotificationHomeOrganization {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ThirdPartyOrgName: ").Append(ThirdPartyOrgName).Append("\n");
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
        return Equals(obj as ArchitectPromptNotificationHomeOrganization);
    }

    /// <summary>
    /// Returns true if ArchitectPromptNotificationHomeOrganization instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectPromptNotificationHomeOrganization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectPromptNotificationHomeOrganization other)
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
                ThirdPartyOrgName == other.ThirdPartyOrgName ||
                ThirdPartyOrgName != null &&
                ThirdPartyOrgName.Equals(other.ThirdPartyOrgName)
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

            if (ThirdPartyOrgName != null)
            {
                hash = hash * 59 + ThirdPartyOrgName.GetHashCode();
            }

            return hash;
        }
    }
}
