using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuRescheduleResult
/// </summary>

public partial class BuRescheduleResult : IEquatable<BuRescheduleResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuRescheduleResult" /> class.
    /// </summary>
    /// <param name="GenerationResults">The generation results.  Note the result will always be delivered via the generationResultsDownloadUrl; however the schema is included for documentation.</param>
    /// <param name="GenerationResultsDownloadUrl">The download URL from which to fetch the generation results for the rescheduling run.</param>
    /// <param name="HeadcountForecast">The headcount forecast.  Note the result will always be delivered via the headcountForecastDownloadUrl; however the schema is included for documentation.</param>
    /// <param name="HeadcountForecastDownloadUrl">The download URL from which to fetch the headcount forecast for the rescheduling run.</param>
    /// <param name="AgentSchedules">List of download links for agent schedules produced by the rescheduling run.</param>
    public BuRescheduleResult(ScheduleGenerationResult GenerationResults = null, string GenerationResultsDownloadUrl = null, BuHeadcountForecast HeadcountForecast = null, string HeadcountForecastDownloadUrl = null, List<BuRescheduleAgentScheduleResult> AgentSchedules = null)
    {
        this.GenerationResults = GenerationResults;
        this.GenerationResultsDownloadUrl = GenerationResultsDownloadUrl;
        this.HeadcountForecast = HeadcountForecast;
        this.HeadcountForecastDownloadUrl = HeadcountForecastDownloadUrl;
        this.AgentSchedules = AgentSchedules;

    }



    /// <summary>
    /// The generation results.  Note the result will always be delivered via the generationResultsDownloadUrl; however the schema is included for documentation
    /// </summary>
    /// <value>The generation results.  Note the result will always be delivered via the generationResultsDownloadUrl; however the schema is included for documentation</value>
    [JsonPropertyName("generationResults")]
    public ScheduleGenerationResult GenerationResults { get; set; }



    /// <summary>
    /// The download URL from which to fetch the generation results for the rescheduling run
    /// </summary>
    /// <value>The download URL from which to fetch the generation results for the rescheduling run</value>
    [JsonPropertyName("generationResultsDownloadUrl")]
    public string GenerationResultsDownloadUrl { get; set; }



    /// <summary>
    /// The headcount forecast.  Note the result will always be delivered via the headcountForecastDownloadUrl; however the schema is included for documentation
    /// </summary>
    /// <value>The headcount forecast.  Note the result will always be delivered via the headcountForecastDownloadUrl; however the schema is included for documentation</value>
    [JsonPropertyName("headcountForecast")]
    public BuHeadcountForecast HeadcountForecast { get; set; }



    /// <summary>
    /// The download URL from which to fetch the headcount forecast for the rescheduling run
    /// </summary>
    /// <value>The download URL from which to fetch the headcount forecast for the rescheduling run</value>
    [JsonPropertyName("headcountForecastDownloadUrl")]
    public string HeadcountForecastDownloadUrl { get; set; }



    /// <summary>
    /// List of download links for agent schedules produced by the rescheduling run
    /// </summary>
    /// <value>List of download links for agent schedules produced by the rescheduling run</value>
    [JsonPropertyName("agentSchedules")]
    public List<BuRescheduleAgentScheduleResult> AgentSchedules { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuRescheduleResult {\n");

        sb.Append("  GenerationResults: ").Append(GenerationResults).Append("\n");
        sb.Append("  GenerationResultsDownloadUrl: ").Append(GenerationResultsDownloadUrl).Append("\n");
        sb.Append("  HeadcountForecast: ").Append(HeadcountForecast).Append("\n");
        sb.Append("  HeadcountForecastDownloadUrl: ").Append(HeadcountForecastDownloadUrl).Append("\n");
        sb.Append("  AgentSchedules: ").Append(AgentSchedules).Append("\n");
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
        return Equals(obj as BuRescheduleResult);
    }

    /// <summary>
    /// Returns true if BuRescheduleResult instances are equal
    /// </summary>
    /// <param name="other">Instance of BuRescheduleResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuRescheduleResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                GenerationResults == other.GenerationResults ||
                GenerationResults != null &&
                GenerationResults.Equals(other.GenerationResults)
            ) &&
            (
                GenerationResultsDownloadUrl == other.GenerationResultsDownloadUrl ||
                GenerationResultsDownloadUrl != null &&
                GenerationResultsDownloadUrl.Equals(other.GenerationResultsDownloadUrl)
            ) &&
            (
                HeadcountForecast == other.HeadcountForecast ||
                HeadcountForecast != null &&
                HeadcountForecast.Equals(other.HeadcountForecast)
            ) &&
            (
                HeadcountForecastDownloadUrl == other.HeadcountForecastDownloadUrl ||
                HeadcountForecastDownloadUrl != null &&
                HeadcountForecastDownloadUrl.Equals(other.HeadcountForecastDownloadUrl)
            ) &&
            (
                AgentSchedules == other.AgentSchedules ||
                AgentSchedules != null &&
                AgentSchedules.SequenceEqual(other.AgentSchedules)
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
            if (GenerationResults != null)
            {
                hash = hash * 59 + GenerationResults.GetHashCode();
            }

            if (GenerationResultsDownloadUrl != null)
            {
                hash = hash * 59 + GenerationResultsDownloadUrl.GetHashCode();
            }

            if (HeadcountForecast != null)
            {
                hash = hash * 59 + HeadcountForecast.GetHashCode();
            }

            if (HeadcountForecastDownloadUrl != null)
            {
                hash = hash * 59 + HeadcountForecastDownloadUrl.GetHashCode();
            }

            if (AgentSchedules != null)
            {
                hash = hash * 59 + AgentSchedules.GetHashCode();
            }

            return hash;
        }
    }
}
