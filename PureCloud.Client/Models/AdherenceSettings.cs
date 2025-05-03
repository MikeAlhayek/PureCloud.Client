using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdherenceSettings
/// </summary>

public partial class AdherenceSettings : IEquatable<AdherenceSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AdherenceSettings" /> class.
    /// </summary>
    /// <param name="SevereAlertThresholdMinutes">The threshold in minutes where an alert will be triggered when an agent is considered severely out of adherence.</param>
    /// <param name="AdherenceTargetPercent">Target adherence percentage.</param>
    /// <param name="AdherenceExceptionThresholdSeconds">The threshold in seconds for which agents should not be penalized for being momentarily out of adherence.</param>
    /// <param name="NonOnQueueActivitiesEquivalent">Whether to treat all non-on-queue activities as equivalent for adherence purposes.</param>
    /// <param name="TrackOnQueueActivity">Whether to track on-queue activities.</param>
    /// <param name="IgnoredActivityCategories">Activity categories that should be ignored for adherence purposes.</param>
    public AdherenceSettings(int? SevereAlertThresholdMinutes = null, int? AdherenceTargetPercent = null, int? AdherenceExceptionThresholdSeconds = null, bool? NonOnQueueActivitiesEquivalent = null, bool? TrackOnQueueActivity = null, IgnoredActivityCategories IgnoredActivityCategories = null)
    {
        this.SevereAlertThresholdMinutes = SevereAlertThresholdMinutes;
        this.AdherenceTargetPercent = AdherenceTargetPercent;
        this.AdherenceExceptionThresholdSeconds = AdherenceExceptionThresholdSeconds;
        this.NonOnQueueActivitiesEquivalent = NonOnQueueActivitiesEquivalent;
        this.TrackOnQueueActivity = TrackOnQueueActivity;
        this.IgnoredActivityCategories = IgnoredActivityCategories;

    }



    /// <summary>
    /// The threshold in minutes where an alert will be triggered when an agent is considered severely out of adherence
    /// </summary>
    /// <value>The threshold in minutes where an alert will be triggered when an agent is considered severely out of adherence</value>
    [JsonPropertyName("severeAlertThresholdMinutes")]
    public int? SevereAlertThresholdMinutes { get; set; }



    /// <summary>
    /// Target adherence percentage
    /// </summary>
    /// <value>Target adherence percentage</value>
    [JsonPropertyName("adherenceTargetPercent")]
    public int? AdherenceTargetPercent { get; set; }



    /// <summary>
    /// The threshold in seconds for which agents should not be penalized for being momentarily out of adherence
    /// </summary>
    /// <value>The threshold in seconds for which agents should not be penalized for being momentarily out of adherence</value>
    [JsonPropertyName("adherenceExceptionThresholdSeconds")]
    public int? AdherenceExceptionThresholdSeconds { get; set; }



    /// <summary>
    /// Whether to treat all non-on-queue activities as equivalent for adherence purposes
    /// </summary>
    /// <value>Whether to treat all non-on-queue activities as equivalent for adherence purposes</value>
    [JsonPropertyName("nonOnQueueActivitiesEquivalent")]
    public bool? NonOnQueueActivitiesEquivalent { get; set; }



    /// <summary>
    /// Whether to track on-queue activities
    /// </summary>
    /// <value>Whether to track on-queue activities</value>
    [JsonPropertyName("trackOnQueueActivity")]
    public bool? TrackOnQueueActivity { get; set; }



    /// <summary>
    /// Activity categories that should be ignored for adherence purposes
    /// </summary>
    /// <value>Activity categories that should be ignored for adherence purposes</value>
    [JsonPropertyName("ignoredActivityCategories")]
    public IgnoredActivityCategories IgnoredActivityCategories { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdherenceSettings {\n");

        sb.Append("  SevereAlertThresholdMinutes: ").Append(SevereAlertThresholdMinutes).Append("\n");
        sb.Append("  AdherenceTargetPercent: ").Append(AdherenceTargetPercent).Append("\n");
        sb.Append("  AdherenceExceptionThresholdSeconds: ").Append(AdherenceExceptionThresholdSeconds).Append("\n");
        sb.Append("  NonOnQueueActivitiesEquivalent: ").Append(NonOnQueueActivitiesEquivalent).Append("\n");
        sb.Append("  TrackOnQueueActivity: ").Append(TrackOnQueueActivity).Append("\n");
        sb.Append("  IgnoredActivityCategories: ").Append(IgnoredActivityCategories).Append("\n");
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
        return Equals(obj as AdherenceSettings);
    }

    /// <summary>
    /// Returns true if AdherenceSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AdherenceSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdherenceSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SevereAlertThresholdMinutes == other.SevereAlertThresholdMinutes ||
                SevereAlertThresholdMinutes != null &&
                SevereAlertThresholdMinutes.Equals(other.SevereAlertThresholdMinutes)
            ) &&
            (
                AdherenceTargetPercent == other.AdherenceTargetPercent ||
                AdherenceTargetPercent != null &&
                AdherenceTargetPercent.Equals(other.AdherenceTargetPercent)
            ) &&
            (
                AdherenceExceptionThresholdSeconds == other.AdherenceExceptionThresholdSeconds ||
                AdherenceExceptionThresholdSeconds != null &&
                AdherenceExceptionThresholdSeconds.Equals(other.AdherenceExceptionThresholdSeconds)
            ) &&
            (
                NonOnQueueActivitiesEquivalent == other.NonOnQueueActivitiesEquivalent ||
                NonOnQueueActivitiesEquivalent != null &&
                NonOnQueueActivitiesEquivalent.Equals(other.NonOnQueueActivitiesEquivalent)
            ) &&
            (
                TrackOnQueueActivity == other.TrackOnQueueActivity ||
                TrackOnQueueActivity != null &&
                TrackOnQueueActivity.Equals(other.TrackOnQueueActivity)
            ) &&
            (
                IgnoredActivityCategories == other.IgnoredActivityCategories ||
                IgnoredActivityCategories != null &&
                IgnoredActivityCategories.Equals(other.IgnoredActivityCategories)
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
            if (SevereAlertThresholdMinutes != null)
            {
                hash = hash * 59 + SevereAlertThresholdMinutes.GetHashCode();
            }

            if (AdherenceTargetPercent != null)
            {
                hash = hash * 59 + AdherenceTargetPercent.GetHashCode();
            }

            if (AdherenceExceptionThresholdSeconds != null)
            {
                hash = hash * 59 + AdherenceExceptionThresholdSeconds.GetHashCode();
            }

            if (NonOnQueueActivitiesEquivalent != null)
            {
                hash = hash * 59 + NonOnQueueActivitiesEquivalent.GetHashCode();
            }

            if (TrackOnQueueActivity != null)
            {
                hash = hash * 59 + TrackOnQueueActivity.GetHashCode();
            }

            if (IgnoredActivityCategories != null)
            {
                hash = hash * 59 + IgnoredActivityCategories.GetHashCode();
            }

            return hash;
        }
    }
}
