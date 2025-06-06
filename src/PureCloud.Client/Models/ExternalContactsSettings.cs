using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsSettings
/// </summary>

public partial class ExternalContactsSettings : IEquatable<ExternalContactsSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsSettings" /> class.
    /// </summary>
    /// <param name="ManuallyAssignDivisionsToInteractions">ManuallyAssignDivisionsToInteractions.</param>
    /// <param name="ManuallyAssignDivisionsToContacts">ManuallyAssignDivisionsToContacts.</param>
    public ExternalContactsSettings(bool? ManuallyAssignDivisionsToInteractions = null, bool? ManuallyAssignDivisionsToContacts = null)
    {
        this.ManuallyAssignDivisionsToInteractions = ManuallyAssignDivisionsToInteractions;
        this.ManuallyAssignDivisionsToContacts = ManuallyAssignDivisionsToContacts;

    }



    /// <summary>
    /// Gets or Sets ManuallyAssignDivisionsToInteractions
    /// </summary>
    [JsonPropertyName("manuallyAssignDivisionsToInteractions")]
    public bool? ManuallyAssignDivisionsToInteractions { get; set; }



    /// <summary>
    /// Gets or Sets ManuallyAssignDivisionsToContacts
    /// </summary>
    [JsonPropertyName("manuallyAssignDivisionsToContacts")]
    public bool? ManuallyAssignDivisionsToContacts { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsSettings {\n");

        sb.Append("  ManuallyAssignDivisionsToInteractions: ").Append(ManuallyAssignDivisionsToInteractions).Append("\n");
        sb.Append("  ManuallyAssignDivisionsToContacts: ").Append(ManuallyAssignDivisionsToContacts).Append("\n");
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
        return Equals(obj as ExternalContactsSettings);
    }

    /// <summary>
    /// Returns true if ExternalContactsSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManuallyAssignDivisionsToInteractions == other.ManuallyAssignDivisionsToInteractions ||
                ManuallyAssignDivisionsToInteractions != null &&
                ManuallyAssignDivisionsToInteractions.Equals(other.ManuallyAssignDivisionsToInteractions)
            ) &&
            (
                ManuallyAssignDivisionsToContacts == other.ManuallyAssignDivisionsToContacts ||
                ManuallyAssignDivisionsToContacts != null &&
                ManuallyAssignDivisionsToContacts.Equals(other.ManuallyAssignDivisionsToContacts)
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
            if (ManuallyAssignDivisionsToInteractions != null)
            {
                hash = hash * 59 + ManuallyAssignDivisionsToInteractions.GetHashCode();
            }

            if (ManuallyAssignDivisionsToContacts != null)
            {
                hash = hash * 59 + ManuallyAssignDivisionsToContacts.GetHashCode();
            }

            return hash;
        }
    }
}
