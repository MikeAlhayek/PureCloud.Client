using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CopyBuForecastRequest
/// </summary>

public partial class CopyBuForecastRequest : IEquatable<CopyBuForecastRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CopyBuForecastRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CopyBuForecastRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CopyBuForecastRequest" /> class.
    /// </summary>
    /// <param name="Description">The description for the forecast (required).</param>
    /// <param name="WeekDate">The start date of the new forecast to create from the existing forecast. Must correspond to the start day of week for the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    public CopyBuForecastRequest(string Description = null, string WeekDate = null)
    {
        this.Description = Description;
        this.WeekDate = WeekDate;

    }



    /// <summary>
    /// The description for the forecast
    /// </summary>
    /// <value>The description for the forecast</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The start date of the new forecast to create from the existing forecast. Must correspond to the start day of week for the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start date of the new forecast to create from the existing forecast. Must correspond to the start day of week for the business unit. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CopyBuForecastRequest {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
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
        return Equals(obj as CopyBuForecastRequest);
    }

    /// <summary>
    /// Returns true if CopyBuForecastRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CopyBuForecastRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CopyBuForecastRequest other)
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
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
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

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            return hash;
        }
    }
}
