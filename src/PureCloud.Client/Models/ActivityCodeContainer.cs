using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActivityCodeContainer
/// </summary>

public partial class ActivityCodeContainer : IEquatable<ActivityCodeContainer>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityCodeContainer" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActivityCodeContainer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityCodeContainer" /> class.
    /// </summary>
    /// <param name="ActivityCodes">Map of activity code id to activity code.</param>
    /// <param name="Metadata">Version metadata for the associated management unit&#39;s list of activity codes (required).</param>
    public ActivityCodeContainer(Dictionary<string, ActivityCode> ActivityCodes = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.ActivityCodes = ActivityCodes;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Map of activity code id to activity code
    /// </summary>
    /// <value>Map of activity code id to activity code</value>
    [JsonPropertyName("activityCodes")]
    public Dictionary<string, ActivityCode> ActivityCodes { get; set; }



    /// <summary>
    /// Version metadata for the associated management unit&#39;s list of activity codes
    /// </summary>
    /// <value>Version metadata for the associated management unit&#39;s list of activity codes</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActivityCodeContainer {\n");

        sb.Append("  ActivityCodes: ").Append(ActivityCodes).Append("\n");
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
        return Equals(obj as ActivityCodeContainer);
    }

    /// <summary>
    /// Returns true if ActivityCodeContainer instances are equal
    /// </summary>
    /// <param name="other">Instance of ActivityCodeContainer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActivityCodeContainer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityCodes == other.ActivityCodes ||
                ActivityCodes != null &&
                ActivityCodes.SequenceEqual(other.ActivityCodes)
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
            if (ActivityCodes != null)
            {
                hash = hash * 59 + ActivityCodes.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
