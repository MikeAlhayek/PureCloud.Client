using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeAttributionListing
/// </summary>

public partial class OutcomeAttributionListing : IEquatable<OutcomeAttributionListing>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeAttributionListing" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OutcomeAttributionListing() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeAttributionListing" /> class.
    /// </summary>
    /// <param name="Entities">Entities (required).</param>
    /// <param name="PercentFailedThreshold">Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100..</param>
    public OutcomeAttributionListing(List<OutcomeAttributionRequest> Entities = null, int? PercentFailedThreshold = null)
    {
        this.Entities = Entities;
        this.PercentFailedThreshold = PercentFailedThreshold;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<OutcomeAttributionRequest> Entities { get; set; }



    /// <summary>
    /// Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.
    /// </summary>
    /// <value>Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.</value>
    [JsonPropertyName("percentFailedThreshold")]
    public int? PercentFailedThreshold { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomeAttributionListing {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  PercentFailedThreshold: ").Append(PercentFailedThreshold).Append("\n");
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
        return Equals(obj as OutcomeAttributionListing);
    }

    /// <summary>
    /// Returns true if OutcomeAttributionListing instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeAttributionListing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeAttributionListing other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                PercentFailedThreshold == other.PercentFailedThreshold ||
                PercentFailedThreshold != null &&
                PercentFailedThreshold.Equals(other.PercentFailedThreshold)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (PercentFailedThreshold != null)
            {
                hash = hash * 59 + PercentFailedThreshold.GetHashCode();
            }

            return hash;
        }
    }
}
