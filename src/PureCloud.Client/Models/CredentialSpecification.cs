using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Specifies the requirements for a credential that can be provided for configuring an integration
/// </summary>

public partial class CredentialSpecification : IEquatable<CredentialSpecification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CredentialSpecification" /> class.
    /// </summary>
    public CredentialSpecification()
    {

    }



    /// <summary>
    /// Indicates if the credential must be provided in order for the integration configuration to be valid.
    /// </summary>
    /// <value>Indicates if the credential must be provided in order for the integration configuration to be valid.</value>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }



    /// <summary>
    /// Title describing the usage for this credential.
    /// </summary>
    /// <value>Title describing the usage for this credential.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// List of acceptable credential types that can be provided for this credential.
    /// </summary>
    /// <value>List of acceptable credential types that can be provided for this credential.</value>
    [JsonPropertyName("credentialTypes")]
    public List<string> CredentialTypes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CredentialSpecification {\n");

        sb.Append("  Required: ").Append(Required).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  CredentialTypes: ").Append(CredentialTypes).Append("\n");
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
        return Equals(obj as CredentialSpecification);
    }

    /// <summary>
    /// Returns true if CredentialSpecification instances are equal
    /// </summary>
    /// <param name="other">Instance of CredentialSpecification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CredentialSpecification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Required == other.Required ||
                Required != null &&
                Required.Equals(other.Required)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                CredentialTypes == other.CredentialTypes ||
                CredentialTypes != null &&
                CredentialTypes.SequenceEqual(other.CredentialTypes)
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
            if (Required != null)
            {
                hash = hash * 59 + Required.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (CredentialTypes != null)
            {
                hash = hash * 59 + CredentialTypes.GetHashCode();
            }

            return hash;
        }
    }
}
