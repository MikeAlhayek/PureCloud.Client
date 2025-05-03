using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkRecordingEnabledCount
/// </summary>

public partial class TrunkRecordingEnabledCount : IEquatable<TrunkRecordingEnabledCount>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkRecordingEnabledCount" /> class.
    /// </summary>
    /// <param name="EnabledCount">The amount of trunks that have recording enabled.</param>
    /// <param name="DisabledCount">The amount of trunks that do not have recording enabled.</param>
    public TrunkRecordingEnabledCount(int? EnabledCount = null, int? DisabledCount = null)
    {
        this.EnabledCount = EnabledCount;
        this.DisabledCount = DisabledCount;

    }



    /// <summary>
    /// The amount of trunks that have recording enabled
    /// </summary>
    /// <value>The amount of trunks that have recording enabled</value>
    [JsonPropertyName("enabledCount")]
    public int? EnabledCount { get; set; }



    /// <summary>
    /// The amount of trunks that do not have recording enabled
    /// </summary>
    /// <value>The amount of trunks that do not have recording enabled</value>
    [JsonPropertyName("disabledCount")]
    public int? DisabledCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkRecordingEnabledCount {\n");

        sb.Append("  EnabledCount: ").Append(EnabledCount).Append("\n");
        sb.Append("  DisabledCount: ").Append(DisabledCount).Append("\n");
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
        return Equals(obj as TrunkRecordingEnabledCount);
    }

    /// <summary>
    /// Returns true if TrunkRecordingEnabledCount instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkRecordingEnabledCount to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkRecordingEnabledCount other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EnabledCount == other.EnabledCount ||
                EnabledCount != null &&
                EnabledCount.Equals(other.EnabledCount)
            ) &&
            (
                DisabledCount == other.DisabledCount ||
                DisabledCount != null &&
                DisabledCount.Equals(other.DisabledCount)
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
            if (EnabledCount != null)
            {
                hash = hash * 59 + EnabledCount.GetHashCode();
            }

            if (DisabledCount != null)
            {
                hash = hash * 59 + DisabledCount.GetHashCode();
            }

            return hash;
        }
    }
}
