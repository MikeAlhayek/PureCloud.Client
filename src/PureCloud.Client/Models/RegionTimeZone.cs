using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RegionTimeZone
/// </summary>

public partial class RegionTimeZone : IEquatable<RegionTimeZone>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RegionTimeZone" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Offset">Offset.</param>
    /// <param name="CanonicalId">Canonical identifier for this time zone, if applicable.</param>
    public RegionTimeZone(string Name = null, long? Offset = null, string CanonicalId = null)
    {
        this.Name = Name;
        this.Offset = Offset;
        this.CanonicalId = CanonicalId;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Offset
    /// </summary>
    [JsonPropertyName("offset")]
    public long? Offset { get; set; }



    /// <summary>
    /// Canonical identifier for this time zone, if applicable
    /// </summary>
    /// <value>Canonical identifier for this time zone, if applicable</value>
    [JsonPropertyName("canonicalId")]
    public string CanonicalId { get; set; }



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
        sb.Append("class RegionTimeZone {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Offset: ").Append(Offset).Append("\n");
        sb.Append("  CanonicalId: ").Append(CanonicalId).Append("\n");
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
        return Equals(obj as RegionTimeZone);
    }

    /// <summary>
    /// Returns true if RegionTimeZone instances are equal
    /// </summary>
    /// <param name="other">Instance of RegionTimeZone to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RegionTimeZone other)
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
                Offset == other.Offset ||
                Offset != null &&
                Offset.Equals(other.Offset)
            ) &&
            (
                CanonicalId == other.CanonicalId ||
                CanonicalId != null &&
                CanonicalId.Equals(other.CanonicalId)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Offset != null)
            {
                hash = hash * 59 + Offset.GetHashCode();
            }

            if (CanonicalId != null)
            {
                hash = hash * 59 + CanonicalId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
