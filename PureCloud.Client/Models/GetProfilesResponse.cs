using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// GetProfilesResponse
/// </summary>
[DataContract]
public partial class GetProfilesResponse : IEquatable<GetProfilesResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetProfilesResponse" /> class.
    /// </summary>
    /// <param name="Total">Total.</param>
    /// <param name="Entities">Entities.</param>
    /// <param name="SelfUri">SelfUri.</param>
    public GetProfilesResponse(long? Total = null, List<PerformanceProfile> Entities = null, string SelfUri = null)
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
    public List<PerformanceProfile> Entities { get; set; }



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
        sb.Append("class GetProfilesResponse {\n");

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
        return Equals(obj as GetProfilesResponse);
    }

    /// <summary>
    /// Returns true if GetProfilesResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of GetProfilesResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GetProfilesResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
