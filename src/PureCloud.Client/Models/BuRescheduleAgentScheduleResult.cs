using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuRescheduleAgentScheduleResult
/// </summary>

public partial class BuRescheduleAgentScheduleResult : IEquatable<BuRescheduleAgentScheduleResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuRescheduleAgentScheduleResult" /> class.
    /// </summary>
    /// <param name="ManagementUnit">The management unit to which this part of the result applies.</param>
    /// <param name="DownloadResult">The agent schedules.  Result will always come via the downloadUrl; however the schema is included for documentation.</param>
    /// <param name="DownloadUrl">The download URL from which to fetch the result.</param>
    public BuRescheduleAgentScheduleResult(ManagementUnitReference ManagementUnit = null, MuRescheduleResultWrapper DownloadResult = null, string DownloadUrl = null)
    {
        this.ManagementUnit = ManagementUnit;
        this.DownloadResult = DownloadResult;
        this.DownloadUrl = DownloadUrl;

    }



    /// <summary>
    /// The management unit to which this part of the result applies
    /// </summary>
    /// <value>The management unit to which this part of the result applies</value>
    [JsonPropertyName("managementUnit")]
    public ManagementUnitReference ManagementUnit { get; set; }



    /// <summary>
    /// The agent schedules.  Result will always come via the downloadUrl; however the schema is included for documentation
    /// </summary>
    /// <value>The agent schedules.  Result will always come via the downloadUrl; however the schema is included for documentation</value>
    [JsonPropertyName("downloadResult")]
    public MuRescheduleResultWrapper DownloadResult { get; set; }



    /// <summary>
    /// The download URL from which to fetch the result
    /// </summary>
    /// <value>The download URL from which to fetch the result</value>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuRescheduleAgentScheduleResult {\n");

        sb.Append("  ManagementUnit: ").Append(ManagementUnit).Append("\n");
        sb.Append("  DownloadResult: ").Append(DownloadResult).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
        return Equals(obj as BuRescheduleAgentScheduleResult);
    }

    /// <summary>
    /// Returns true if BuRescheduleAgentScheduleResult instances are equal
    /// </summary>
    /// <param name="other">Instance of BuRescheduleAgentScheduleResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuRescheduleAgentScheduleResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnit == other.ManagementUnit ||
                ManagementUnit != null &&
                ManagementUnit.Equals(other.ManagementUnit)
            ) &&
            (
                DownloadResult == other.DownloadResult ||
                DownloadResult != null &&
                DownloadResult.Equals(other.DownloadResult)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
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
            if (ManagementUnit != null)
            {
                hash = hash * 59 + ManagementUnit.GetHashCode();
            }

            if (DownloadResult != null)
            {
                hash = hash * 59 + DownloadResult.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            return hash;
        }
    }
}
