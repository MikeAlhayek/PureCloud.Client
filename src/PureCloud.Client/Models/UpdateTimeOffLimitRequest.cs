using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateTimeOffLimitRequest
/// </summary>

public partial class UpdateTimeOffLimitRequest : IEquatable<UpdateTimeOffLimitRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateTimeOffLimitRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateTimeOffLimitRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateTimeOffLimitRequest" /> class.
    /// </summary>
    /// <param name="DefaultLimitMinutes">The default time off limit value in minutes per granularity.</param>
    /// <param name="Metadata">Version metadata for the time off limit (required).</param>
    public UpdateTimeOffLimitRequest(int? DefaultLimitMinutes = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.DefaultLimitMinutes = DefaultLimitMinutes;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The default time off limit value in minutes per granularity
    /// </summary>
    /// <value>The default time off limit value in minutes per granularity</value>
    [JsonPropertyName("defaultLimitMinutes")]
    public int? DefaultLimitMinutes { get; set; }



    /// <summary>
    /// Version metadata for the time off limit
    /// </summary>
    /// <value>Version metadata for the time off limit</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateTimeOffLimitRequest {\n");

        sb.Append("  DefaultLimitMinutes: ").Append(DefaultLimitMinutes).Append("\n");
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
        return Equals(obj as UpdateTimeOffLimitRequest);
    }

    /// <summary>
    /// Returns true if UpdateTimeOffLimitRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateTimeOffLimitRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateTimeOffLimitRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DefaultLimitMinutes == other.DefaultLimitMinutes ||
                DefaultLimitMinutes != null &&
                DefaultLimitMinutes.Equals(other.DefaultLimitMinutes)
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
            if (DefaultLimitMinutes != null)
            {
                hash = hash * 59 + DefaultLimitMinutes.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
