using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CredentialType
/// </summary>

public partial class CredentialType : IEquatable<CredentialType>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CredentialType" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    public CredentialType(string Name = null)
    {
        this.Name = Name;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Properties describing credentials of this type.
    /// </summary>
    /// <value>Properties describing credentials of this type.</value>
    [JsonPropertyName("properties")]
    public object Properties { get; set; }



    /// <summary>
    /// Order in which properties should be displayed in the UI.
    /// </summary>
    /// <value>Order in which properties should be displayed in the UI.</value>
    [JsonPropertyName("displayOrder")]
    public List<string> DisplayOrder { get; set; }



    /// <summary>
    /// Properties that are required fields.
    /// </summary>
    /// <value>Properties that are required fields.</value>
    [JsonPropertyName("required")]
    public List<string> Required { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CredentialType {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
        sb.Append("  Required: ").Append(Required).Append("\n");
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
        return Equals(obj as CredentialType);
    }

    /// <summary>
    /// Returns true if CredentialType instances are equal
    /// </summary>
    /// <param name="other">Instance of CredentialType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CredentialType other)
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
                Properties == other.Properties ||
                Properties != null &&
                Properties.Equals(other.Properties)
            ) &&
            (
                DisplayOrder == other.DisplayOrder ||
                DisplayOrder != null &&
                DisplayOrder.SequenceEqual(other.DisplayOrder)
            ) &&
            (
                Required == other.Required ||
                Required != null &&
                Required.SequenceEqual(other.Required)
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

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (DisplayOrder != null)
            {
                hash = hash * 59 + DisplayOrder.GetHashCode();
            }

            if (Required != null)
            {
                hash = hash * 59 + Required.GetHashCode();
            }

            return hash;
        }
    }
}
