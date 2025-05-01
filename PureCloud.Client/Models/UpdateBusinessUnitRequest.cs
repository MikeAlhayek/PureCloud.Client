using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateBusinessUnitRequest
/// </summary>
[DataContract]
public partial class UpdateBusinessUnitRequest : IEquatable<UpdateBusinessUnitRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateBusinessUnitRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the business unit.</param>
    /// <param name="DivisionId">The ID of the division to which the business unit should be moved.</param>
    /// <param name="Settings">Configuration for the business unit.</param>
    public UpdateBusinessUnitRequest(string Name = null, string DivisionId = null, UpdateBusinessUnitSettingsRequest Settings = null)
    {
        this.Name = Name;
        this.DivisionId = DivisionId;
        this.Settings = Settings;

    }



    /// <summary>
    /// The name of the business unit
    /// </summary>
    /// <value>The name of the business unit</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The ID of the division to which the business unit should be moved
    /// </summary>
    /// <value>The ID of the division to which the business unit should be moved</value>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }



    /// <summary>
    /// Configuration for the business unit
    /// </summary>
    /// <value>Configuration for the business unit</value>
    [DataMember(Name = "settings", EmitDefaultValue = false)]
    public UpdateBusinessUnitSettingsRequest Settings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateBusinessUnitRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
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
        return Equals(obj as UpdateBusinessUnitRequest);
    }

    /// <summary>
    /// Returns true if UpdateBusinessUnitRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateBusinessUnitRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateBusinessUnitRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                Settings == other.Settings ||
                Settings != null &&
                Settings.Equals(other.Settings)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            return hash;
        }
    }
}
