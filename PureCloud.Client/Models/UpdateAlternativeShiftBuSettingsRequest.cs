using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateAlternativeShiftBuSettingsRequest
/// </summary>
[DataContract]
public partial class UpdateAlternativeShiftBuSettingsRequest : IEquatable<UpdateAlternativeShiftBuSettingsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateAlternativeShiftBuSettingsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateAlternativeShiftBuSettingsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateAlternativeShiftBuSettingsRequest" /> class.
    /// </summary>
    /// <param name="EnabledGranularities">The granularity at which alternative shifts is allowed. An empty list as the wrapped value will indicate alternative shifts is disabled.</param>
    /// <param name="MinMinutesBeforeStartTime">The minimum number of minutes before the start of a shift that an alternative shift can be automatically approved.</param>
    /// <param name="RetainedActivityCategories">Categories of activities that are required to remain at the same time slot for the alternative shifts offered. An empty list indicates no retained activities.</param>
    /// <param name="Metadata">Version metadata for this business unit&#39;s alternative shift settings (required).</param>
    public UpdateAlternativeShiftBuSettingsRequest(ListWrapperAlternativeShiftBuSettingsGranularity EnabledGranularities = null, int? MinMinutesBeforeStartTime = null, ListWrapperAlternativeShiftBuSettingsActivityCategory RetainedActivityCategories = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.EnabledGranularities = EnabledGranularities;
        this.MinMinutesBeforeStartTime = MinMinutesBeforeStartTime;
        this.RetainedActivityCategories = RetainedActivityCategories;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The granularity at which alternative shifts is allowed. An empty list as the wrapped value will indicate alternative shifts is disabled
    /// </summary>
    /// <value>The granularity at which alternative shifts is allowed. An empty list as the wrapped value will indicate alternative shifts is disabled</value>
    [DataMember(Name = "enabledGranularities", EmitDefaultValue = false)]
    public ListWrapperAlternativeShiftBuSettingsGranularity EnabledGranularities { get; set; }



    /// <summary>
    /// The minimum number of minutes before the start of a shift that an alternative shift can be automatically approved
    /// </summary>
    /// <value>The minimum number of minutes before the start of a shift that an alternative shift can be automatically approved</value>
    [DataMember(Name = "minMinutesBeforeStartTime", EmitDefaultValue = false)]
    public int? MinMinutesBeforeStartTime { get; set; }



    /// <summary>
    /// Categories of activities that are required to remain at the same time slot for the alternative shifts offered. An empty list indicates no retained activities
    /// </summary>
    /// <value>Categories of activities that are required to remain at the same time slot for the alternative shifts offered. An empty list indicates no retained activities</value>
    [DataMember(Name = "retainedActivityCategories", EmitDefaultValue = false)]
    public ListWrapperAlternativeShiftBuSettingsActivityCategory RetainedActivityCategories { get; set; }



    /// <summary>
    /// Version metadata for this business unit&#39;s alternative shift settings
    /// </summary>
    /// <value>Version metadata for this business unit&#39;s alternative shift settings</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateAlternativeShiftBuSettingsRequest {\n");

        sb.Append("  EnabledGranularities: ").Append(EnabledGranularities).Append("\n");
        sb.Append("  MinMinutesBeforeStartTime: ").Append(MinMinutesBeforeStartTime).Append("\n");
        sb.Append("  RetainedActivityCategories: ").Append(RetainedActivityCategories).Append("\n");
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
        return Equals(obj as UpdateAlternativeShiftBuSettingsRequest);
    }

    /// <summary>
    /// Returns true if UpdateAlternativeShiftBuSettingsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateAlternativeShiftBuSettingsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateAlternativeShiftBuSettingsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EnabledGranularities == other.EnabledGranularities ||
                EnabledGranularities != null &&
                EnabledGranularities.Equals(other.EnabledGranularities)
            ) &&
            (
                MinMinutesBeforeStartTime == other.MinMinutesBeforeStartTime ||
                MinMinutesBeforeStartTime != null &&
                MinMinutesBeforeStartTime.Equals(other.MinMinutesBeforeStartTime)
            ) &&
            (
                RetainedActivityCategories == other.RetainedActivityCategories ||
                RetainedActivityCategories != null &&
                RetainedActivityCategories.Equals(other.RetainedActivityCategories)
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
            if (EnabledGranularities != null)
            {
                hash = hash * 59 + EnabledGranularities.GetHashCode();
            }

            if (MinMinutesBeforeStartTime != null)
            {
                hash = hash * 59 + MinMinutesBeforeStartTime.GetHashCode();
            }

            if (RetainedActivityCategories != null)
            {
                hash = hash * 59 + RetainedActivityCategories.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
