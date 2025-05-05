using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuScheduleReferenceForMuRoute
/// </summary>

public partial class BuScheduleReferenceForMuRoute : IEquatable<BuScheduleReferenceForMuRoute>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuScheduleReferenceForMuRoute" /> class.
    /// </summary>
    /// <param name="WeekDate">The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="BusinessUnit">The start week date for this schedule.</param>
    public BuScheduleReferenceForMuRoute(string WeekDate = null, BusinessUnitReference BusinessUnit = null)
    {
        this.WeekDate = WeekDate;
        this.BusinessUnit = BusinessUnit;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }



    /// <summary>
    /// The start week date for this schedule
    /// </summary>
    /// <value>The start week date for this schedule</value>
    [JsonPropertyName("businessUnit")]
    public BusinessUnitReference BusinessUnit { get; set; }



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
        sb.Append("class BuScheduleReferenceForMuRoute {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
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
        return Equals(obj as BuScheduleReferenceForMuRoute);
    }

    /// <summary>
    /// Returns true if BuScheduleReferenceForMuRoute instances are equal
    /// </summary>
    /// <param name="other">Instance of BuScheduleReferenceForMuRoute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuScheduleReferenceForMuRoute other)
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
                BusinessUnit == other.BusinessUnit ||
                BusinessUnit != null &&
                BusinessUnit.Equals(other.BusinessUnit)
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

            if (BusinessUnit != null)
            {
                hash = hash * 59 + BusinessUnit.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
