using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestMetrics
/// </summary>

public partial class ContestMetrics : IEquatable<ContestMetrics>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContestMetrics" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContestMetrics() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestMetrics" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object. (required).</param>
    /// <param name="Name">Name.</param>
    /// <param name="Weight">The Contest Metrics weight, allowed values are 1-100 (required).</param>
    /// <param name="MinimumQualifier">The Contest Metrics minimum qualifier. Min value is 0, no Max value (required).</param>
    public ContestMetrics(string Id = null, string Name = null, int? Weight = null, int? MinimumQualifier = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Weight = Weight;
        this.MinimumQualifier = MinimumQualifier;

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
    /// The Contest Metrics weight, allowed values are 1-100
    /// </summary>
    /// <value>The Contest Metrics weight, allowed values are 1-100</value>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }



    /// <summary>
    /// The Contest Metrics minimum qualifier. Min value is 0, no Max value
    /// </summary>
    /// <value>The Contest Metrics minimum qualifier. Min value is 0, no Max value</value>
    [JsonPropertyName("minimumQualifier")]
    public int? MinimumQualifier { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestMetrics {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  MinimumQualifier: ").Append(MinimumQualifier).Append("\n");
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
        return Equals(obj as ContestMetrics);
    }

    /// <summary>
    /// Returns true if ContestMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestMetrics other)
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
                Weight == other.Weight ||
                Weight != null &&
                Weight.Equals(other.Weight)
            ) &&
            (
                MinimumQualifier == other.MinimumQualifier ||
                MinimumQualifier != null &&
                MinimumQualifier.Equals(other.MinimumQualifier)
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

            if (Weight != null)
            {
                hash = hash * 59 + Weight.GetHashCode();
            }

            if (MinimumQualifier != null)
            {
                hash = hash * 59 + MinimumQualifier.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
