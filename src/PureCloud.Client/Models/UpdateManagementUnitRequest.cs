using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateManagementUnitRequest
/// </summary>

public partial class UpdateManagementUnitRequest : IEquatable<UpdateManagementUnitRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateManagementUnitRequest" /> class.
    /// </summary>
    /// <param name="Name">The new name of the management unit.</param>
    /// <param name="DivisionId">The new division id for the management unit.</param>
    /// <param name="Settings">Updated settings for the management unit.</param>
    public UpdateManagementUnitRequest(string Name = null, string DivisionId = null, ManagementUnitSettingsRequest Settings = null)
    {
        this.Name = Name;
        this.DivisionId = DivisionId;
        this.Settings = Settings;

    }



    /// <summary>
    /// The new name of the management unit
    /// </summary>
    /// <value>The new name of the management unit</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The new division id for the management unit
    /// </summary>
    /// <value>The new division id for the management unit</value>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }



    /// <summary>
    /// Updated settings for the management unit
    /// </summary>
    /// <value>Updated settings for the management unit</value>
    [JsonPropertyName("settings")]
    public ManagementUnitSettingsRequest Settings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateManagementUnitRequest {\n");

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
        return Equals(obj as UpdateManagementUnitRequest);
    }

    /// <summary>
    /// Returns true if UpdateManagementUnitRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateManagementUnitRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateManagementUnitRequest other)
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
