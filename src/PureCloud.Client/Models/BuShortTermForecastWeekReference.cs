using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuShortTermForecastWeekReference
/// </summary>

public partial class BuShortTermForecastWeekReference : IEquatable<BuShortTermForecastWeekReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuShortTermForecastWeekReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuShortTermForecastWeekReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuShortTermForecastWeekReference" /> class.
    /// </summary>
    /// <param name="Id">Forecast id used in this work plan bid (required).</param>
    /// <param name="WeekDate">The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="WeekNumber">The week number used for this bid. First week starts with number 1 (required).</param>
    public BuShortTermForecastWeekReference(string Id = null, string WeekDate = null, int? WeekNumber = null)
    {
        this.Id = Id;
        this.WeekDate = WeekDate;
        this.WeekNumber = WeekNumber;

    }



    /// <summary>
    /// Forecast id used in this work plan bid
    /// </summary>
    /// <value>Forecast id used in this work plan bid</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The weekDate of the short term forecast in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }



    /// <summary>
    /// The description of the short term forecast
    /// </summary>
    /// <value>The description of the short term forecast</value>
    [JsonPropertyName("description")]
    public string Description { get; private set; }



    /// <summary>
    /// The week number used for this bid. First week starts with number 1
    /// </summary>
    /// <value>The week number used for this bid. First week starts with number 1</value>
    [JsonPropertyName("weekNumber")]
    public int? WeekNumber { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuShortTermForecastWeekReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  WeekNumber: ").Append(WeekNumber).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as BuShortTermForecastWeekReference);
    }

    /// <summary>
    /// Returns true if BuShortTermForecastWeekReference instances are equal
    /// </summary>
    /// <param name="other">Instance of BuShortTermForecastWeekReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuShortTermForecastWeekReference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                WeekNumber == other.WeekNumber ||
                WeekNumber != null &&
                WeekNumber.Equals(other.WeekNumber)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (WeekNumber != null)
            {
                hash = hash * 59 + WeekNumber.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
