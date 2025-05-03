using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LicenseDefinition
/// </summary>

public partial class LicenseDefinition : IEquatable<LicenseDefinition>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LicenseDefinition" /> class.
    /// </summary>
    /// <param name="Description">Description.</param>
    /// <param name="Permissions">Permissions.</param>
    /// <param name="Prerequisites">Prerequisites.</param>
    /// <param name="Comprises">Comprises.</param>
    public LicenseDefinition(string Description = null, Permissions Permissions = null, List<AddressableLicenseDefinition> Prerequisites = null, List<LicenseDefinition> Comprises = null)
    {
        this.Description = Description;
        this.Permissions = Permissions;
        this.Prerequisites = Prerequisites;
        this.Comprises = Comprises;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [JsonPropertyName("permissions")]
    public Permissions Permissions { get; set; }



    /// <summary>
    /// Gets or Sets Prerequisites
    /// </summary>
    [JsonPropertyName("prerequisites")]
    public List<AddressableLicenseDefinition> Prerequisites { get; set; }



    /// <summary>
    /// Gets or Sets Comprises
    /// </summary>
    [JsonPropertyName("comprises")]
    public List<LicenseDefinition> Comprises { get; set; }



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
        sb.Append("class LicenseDefinition {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Permissions: ").Append(Permissions).Append("\n");
        sb.Append("  Prerequisites: ").Append(Prerequisites).Append("\n");
        sb.Append("  Comprises: ").Append(Comprises).Append("\n");
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
        return Equals(obj as LicenseDefinition);
    }

    /// <summary>
    /// Returns true if LicenseDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of LicenseDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LicenseDefinition other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Permissions == other.Permissions ||
                Permissions != null &&
                Permissions.Equals(other.Permissions)
            ) &&
            (
                Prerequisites == other.Prerequisites ||
                Prerequisites != null &&
                Prerequisites.SequenceEqual(other.Prerequisites)
            ) &&
            (
                Comprises == other.Comprises ||
                Comprises != null &&
                Comprises.SequenceEqual(other.Comprises)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Permissions != null)
            {
                hash = hash * 59 + Permissions.GetHashCode();
            }

            if (Prerequisites != null)
            {
                hash = hash * 59 + Prerequisites.GetHashCode();
            }

            if (Comprises != null)
            {
                hash = hash * 59 + Comprises.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
