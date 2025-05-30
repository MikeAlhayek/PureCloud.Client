using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReverseWhitepagesLookupResult
/// </summary>

public partial class ReverseWhitepagesLookupResult : IEquatable<ReverseWhitepagesLookupResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReverseWhitepagesLookupResult" /> class.
    /// </summary>
    /// <param name="Contacts">Contacts.</param>
    /// <param name="ExternalOrganizations">ExternalOrganizations.</param>
    public ReverseWhitepagesLookupResult(List<ExternalContact> Contacts = null, List<ExternalOrganization> ExternalOrganizations = null)
    {
        this.Contacts = Contacts;
        this.ExternalOrganizations = ExternalOrganizations;

    }



    /// <summary>
    /// Gets or Sets Contacts
    /// </summary>
    [JsonPropertyName("contacts")]
    public List<ExternalContact> Contacts { get; set; }



    /// <summary>
    /// Gets or Sets ExternalOrganizations
    /// </summary>
    [JsonPropertyName("externalOrganizations")]
    public List<ExternalOrganization> ExternalOrganizations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReverseWhitepagesLookupResult {\n");

        sb.Append("  Contacts: ").Append(Contacts).Append("\n");
        sb.Append("  ExternalOrganizations: ").Append(ExternalOrganizations).Append("\n");
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
        return Equals(obj as ReverseWhitepagesLookupResult);
    }

    /// <summary>
    /// Returns true if ReverseWhitepagesLookupResult instances are equal
    /// </summary>
    /// <param name="other">Instance of ReverseWhitepagesLookupResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReverseWhitepagesLookupResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Contacts == other.Contacts ||
                Contacts != null &&
                Contacts.SequenceEqual(other.Contacts)
            ) &&
            (
                ExternalOrganizations == other.ExternalOrganizations ||
                ExternalOrganizations != null &&
                ExternalOrganizations.SequenceEqual(other.ExternalOrganizations)
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
            if (Contacts != null)
            {
                hash = hash * 59 + Contacts.GetHashCode();
            }

            if (ExternalOrganizations != null)
            {
                hash = hash * 59 + ExternalOrganizations.GetHashCode();
            }

            return hash;
        }
    }
}
