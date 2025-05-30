using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PredictorWorkloadBalancing
/// </summary>

public partial class PredictorWorkloadBalancing : IEquatable<PredictorWorkloadBalancing>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorWorkloadBalancing" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PredictorWorkloadBalancing() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorWorkloadBalancing" /> class.
    /// </summary>
    /// <param name="Enabled">Flag to activate and deactivate workload balancing. (required).</param>
    /// <param name="MinimumOccupancy">Desired minimum occupancy threshold of agents. Must be between 0 and 100..</param>
    /// <param name="MaximumOccupancy">Desired maximum occupancy threshold of agents. Must be between 0 and 100..</param>
    public PredictorWorkloadBalancing(bool? Enabled = null, int? MinimumOccupancy = null, int? MaximumOccupancy = null)
    {
        this.Enabled = Enabled;
        this.MinimumOccupancy = MinimumOccupancy;
        this.MaximumOccupancy = MaximumOccupancy;

    }



    /// <summary>
    /// Flag to activate and deactivate workload balancing.
    /// </summary>
    /// <value>Flag to activate and deactivate workload balancing.</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Desired minimum occupancy threshold of agents. Must be between 0 and 100.
    /// </summary>
    /// <value>Desired minimum occupancy threshold of agents. Must be between 0 and 100.</value>
    [JsonPropertyName("minimumOccupancy")]
    public int? MinimumOccupancy { get; set; }



    /// <summary>
    /// Desired maximum occupancy threshold of agents. Must be between 0 and 100.
    /// </summary>
    /// <value>Desired maximum occupancy threshold of agents. Must be between 0 and 100.</value>
    [JsonPropertyName("maximumOccupancy")]
    public int? MaximumOccupancy { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictorWorkloadBalancing {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  MinimumOccupancy: ").Append(MinimumOccupancy).Append("\n");
        sb.Append("  MaximumOccupancy: ").Append(MaximumOccupancy).Append("\n");
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
        return Equals(obj as PredictorWorkloadBalancing);
    }

    /// <summary>
    /// Returns true if PredictorWorkloadBalancing instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictorWorkloadBalancing to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictorWorkloadBalancing other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                MinimumOccupancy == other.MinimumOccupancy ||
                MinimumOccupancy != null &&
                MinimumOccupancy.Equals(other.MinimumOccupancy)
            ) &&
            (
                MaximumOccupancy == other.MaximumOccupancy ||
                MaximumOccupancy != null &&
                MaximumOccupancy.Equals(other.MaximumOccupancy)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (MinimumOccupancy != null)
            {
                hash = hash * 59 + MinimumOccupancy.GetHashCode();
            }

            if (MaximumOccupancy != null)
            {
                hash = hash * 59 + MaximumOccupancy.GetHashCode();
            }

            return hash;
        }
    }
}
