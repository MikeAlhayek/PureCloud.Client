using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// OrganizationPresenceDefinitionEntityListing
/// </summary>
[DataContract]
public partial class OrganizationPresenceDefinitionEntityListing : IEquatable<OrganizationPresenceDefinitionEntityListing>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationPresenceDefinitionEntityListing" /> class.
    /// </summary>
    /// <param name="Total">Total.</param>
    /// <param name="Entities">Entities.</param>
    /// <param name="SelfUri">SelfUri.</param>
    public OrganizationPresenceDefinitionEntityListing(long? Total = null, List<OrganizationPresenceDefinition> Entities = null, string SelfUri = null)
    {
        this.Total = Total;
        this.Entities = Entities;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public long? Total { get; set; }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<OrganizationPresenceDefinition> Entities { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OrganizationPresenceDefinitionEntityListing {\n");

        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return this.Equals(obj as OrganizationPresenceDefinitionEntityListing);
    }

    /// <summary>
    /// Returns true if OrganizationPresenceDefinitionEntityListing instances are equal
    /// </summary>
    /// <param name="other">Instance of OrganizationPresenceDefinitionEntityListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OrganizationPresenceDefinitionEntityListing other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Total == other.Total ||
                this.Total != null &&
                this.Total.Equals(other.Total)
            ) &&
            (
                this.Entities == other.Entities ||
                this.Entities != null &&
                this.Entities.SequenceEqual(other.Entities)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Total != null)
            {
                hash = hash * 59 + this.Total.GetHashCode();
            }

            if (this.Entities != null)
            {
                hash = hash * 59 + this.Entities.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
