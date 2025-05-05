using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GenerateBuForecastRequest
/// </summary>

public partial class GenerateBuForecastRequest : IEquatable<GenerateBuForecastRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GenerateBuForecastRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GenerateBuForecastRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GenerateBuForecastRequest" /> class.
    /// </summary>
    /// <param name="Description">The description for the forecast (required).</param>
    /// <param name="WeekCount">The number of weeks this forecast covers.</param>
    /// <param name="CanUseForScheduling">Whether this forecast can be used for scheduling.</param>
    public GenerateBuForecastRequest(string Description = null, int? WeekCount = null, bool? CanUseForScheduling = null)
    {
        this.Description = Description;
        this.WeekCount = WeekCount;
        this.CanUseForScheduling = CanUseForScheduling;

    }



    /// <summary>
    /// The description for the forecast
    /// </summary>
    /// <value>The description for the forecast</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The number of weeks this forecast covers
    /// </summary>
    /// <value>The number of weeks this forecast covers</value>
    [JsonPropertyName("weekCount")]
    public int? WeekCount { get; set; }



    /// <summary>
    /// Whether this forecast can be used for scheduling
    /// </summary>
    /// <value>Whether this forecast can be used for scheduling</value>
    [JsonPropertyName("canUseForScheduling")]
    public bool? CanUseForScheduling { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GenerateBuForecastRequest {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  CanUseForScheduling: ").Append(CanUseForScheduling).Append("\n");
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
        return Equals(obj as GenerateBuForecastRequest);
    }

    /// <summary>
    /// Returns true if GenerateBuForecastRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of GenerateBuForecastRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GenerateBuForecastRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
            ) &&
            (
                CanUseForScheduling == other.CanUseForScheduling ||
                CanUseForScheduling != null &&
                CanUseForScheduling.Equals(other.CanUseForScheduling)
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
            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (CanUseForScheduling != null)
            {
                hash = hash * 59 + CanUseForScheduling.GetHashCode();
            }

            return hash;
        }
    }
}
