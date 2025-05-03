using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuSetTimeOffLimitValuesRequest
/// </summary>

public partial class BuSetTimeOffLimitValuesRequest : IEquatable<BuSetTimeOffLimitValuesRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuSetTimeOffLimitValuesRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuSetTimeOffLimitValuesRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuSetTimeOffLimitValuesRequest" /> class.
    /// </summary>
    /// <param name="Values">Values.</param>
    /// <param name="Metadata">Version metadata for the time-off limit (required).</param>
    public BuSetTimeOffLimitValuesRequest(List<BuTimeOffLimitRange> Values = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Values = Values;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [JsonPropertyName("values")]
    public List<BuTimeOffLimitRange> Values { get; set; }



    /// <summary>
    /// Version metadata for the time-off limit
    /// </summary>
    /// <value>Version metadata for the time-off limit</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuSetTimeOffLimitValuesRequest {\n");

        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as BuSetTimeOffLimitValuesRequest);
    }

    /// <summary>
    /// Returns true if BuSetTimeOffLimitValuesRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuSetTimeOffLimitValuesRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuSetTimeOffLimitValuesRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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
            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
