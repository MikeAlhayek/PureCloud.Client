using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ForecastServiceGoalTemplateImpactOverrideResponse
/// </summary>

public partial class ForecastServiceGoalTemplateImpactOverrideResponse : IEquatable<ForecastServiceGoalTemplateImpactOverrideResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForecastServiceGoalTemplateImpactOverrideResponse" /> class.
    /// </summary>
    /// <param name="ServiceLevel">Allowed service level percent increase and decrease; undefined if the goal is not enabled.</param>
    /// <param name="AverageSpeedOfAnswer">Allowed average speed of answer percent increase and decrease; undefined if the goal is not enabled.</param>
    /// <param name="AbandonRate">Allowed abandon rate percent increase and decrease; undefined if the goal is not enabled.</param>
    public ForecastServiceGoalTemplateImpactOverrideResponse(WfmServiceGoalImpact ServiceLevel = null, WfmServiceGoalImpact AverageSpeedOfAnswer = null, WfmServiceGoalImpact AbandonRate = null)
    {
        this.ServiceLevel = ServiceLevel;
        this.AverageSpeedOfAnswer = AverageSpeedOfAnswer;
        this.AbandonRate = AbandonRate;

    }



    /// <summary>
    /// Allowed service level percent increase and decrease; undefined if the goal is not enabled
    /// </summary>
    /// <value>Allowed service level percent increase and decrease; undefined if the goal is not enabled</value>
    [JsonPropertyName("serviceLevel")]
    public WfmServiceGoalImpact ServiceLevel { get; set; }



    /// <summary>
    /// Allowed average speed of answer percent increase and decrease; undefined if the goal is not enabled
    /// </summary>
    /// <value>Allowed average speed of answer percent increase and decrease; undefined if the goal is not enabled</value>
    [JsonPropertyName("averageSpeedOfAnswer")]
    public WfmServiceGoalImpact AverageSpeedOfAnswer { get; set; }



    /// <summary>
    /// Allowed abandon rate percent increase and decrease; undefined if the goal is not enabled
    /// </summary>
    /// <value>Allowed abandon rate percent increase and decrease; undefined if the goal is not enabled</value>
    [JsonPropertyName("abandonRate")]
    public WfmServiceGoalImpact AbandonRate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ForecastServiceGoalTemplateImpactOverrideResponse {\n");

        sb.Append("  ServiceLevel: ").Append(ServiceLevel).Append("\n");
        sb.Append("  AverageSpeedOfAnswer: ").Append(AverageSpeedOfAnswer).Append("\n");
        sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
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
        return Equals(obj as ForecastServiceGoalTemplateImpactOverrideResponse);
    }

    /// <summary>
    /// Returns true if ForecastServiceGoalTemplateImpactOverrideResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ForecastServiceGoalTemplateImpactOverrideResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ForecastServiceGoalTemplateImpactOverrideResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ServiceLevel == other.ServiceLevel ||
                ServiceLevel != null &&
                ServiceLevel.Equals(other.ServiceLevel)
            ) &&
            (
                AverageSpeedOfAnswer == other.AverageSpeedOfAnswer ||
                AverageSpeedOfAnswer != null &&
                AverageSpeedOfAnswer.Equals(other.AverageSpeedOfAnswer)
            ) &&
            (
                AbandonRate == other.AbandonRate ||
                AbandonRate != null &&
                AbandonRate.Equals(other.AbandonRate)
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
            if (ServiceLevel != null)
            {
                hash = hash * 59 + ServiceLevel.GetHashCode();
            }

            if (AverageSpeedOfAnswer != null)
            {
                hash = hash * 59 + AverageSpeedOfAnswer.GetHashCode();
            }

            if (AbandonRate != null)
            {
                hash = hash * 59 + AbandonRate.GetHashCode();
            }

            return hash;
        }
    }
}
