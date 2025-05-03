using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalShrinkageActivityCodeResponse
/// </summary>

public partial class HistoricalShrinkageActivityCodeResponse : IEquatable<HistoricalShrinkageActivityCodeResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalShrinkageActivityCodeResponse" /> class.
    /// </summary>
    /// <param name="ActivityCodeId">The ID of the activity code for which shrinkage data is provided.</param>
    /// <param name="ShrinkageForActivityCode">Aggregated shrinkage data for the activity code.</param>
    public HistoricalShrinkageActivityCodeResponse(string ActivityCodeId = null, HistoricalShrinkageAggregateResponse ShrinkageForActivityCode = null)
    {
        this.ActivityCodeId = ActivityCodeId;
        this.ShrinkageForActivityCode = ShrinkageForActivityCode;

    }



    /// <summary>
    /// The ID of the activity code for which shrinkage data is provided
    /// </summary>
    /// <value>The ID of the activity code for which shrinkage data is provided</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; set; }



    /// <summary>
    /// Aggregated shrinkage data for the activity code
    /// </summary>
    /// <value>Aggregated shrinkage data for the activity code</value>
    [JsonPropertyName("shrinkageForActivityCode")]
    public HistoricalShrinkageAggregateResponse ShrinkageForActivityCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalShrinkageActivityCodeResponse {\n");

        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  ShrinkageForActivityCode: ").Append(ShrinkageForActivityCode).Append("\n");
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
        return Equals(obj as HistoricalShrinkageActivityCodeResponse);
    }

    /// <summary>
    /// Returns true if HistoricalShrinkageActivityCodeResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalShrinkageActivityCodeResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalShrinkageActivityCodeResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                ShrinkageForActivityCode == other.ShrinkageForActivityCode ||
                ShrinkageForActivityCode != null &&
                ShrinkageForActivityCode.Equals(other.ShrinkageForActivityCode)
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
            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (ShrinkageForActivityCode != null)
            {
                hash = hash * 59 + ShrinkageForActivityCode.GetHashCode();
            }

            return hash;
        }
    }
}
