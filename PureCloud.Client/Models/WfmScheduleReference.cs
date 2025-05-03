using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmScheduleReference
/// </summary>

public partial class WfmScheduleReference : IEquatable<WfmScheduleReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WfmScheduleReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WfmScheduleReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmScheduleReference" /> class.
    /// </summary>
    /// <param name="Id">The ID of the WFM schedule (required).</param>
    /// <param name="BusinessUnit">A reference to a Workforce Management Business Unit (required).</param>
    /// <param name="WeekDate">The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    public WfmScheduleReference(string Id = null, WfmBusinessUnitReference BusinessUnit = null, string WeekDate = null)
    {
        this.Id = Id;
        this.BusinessUnit = BusinessUnit;
        this.WeekDate = WeekDate;

    }



    /// <summary>
    /// The ID of the WFM schedule
    /// </summary>
    /// <value>The ID of the WFM schedule</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// A reference to a Workforce Management Business Unit
    /// </summary>
    /// <value>A reference to a Workforce Management Business Unit</value>
    [JsonPropertyName("businessUnit")]
    public WfmBusinessUnitReference BusinessUnit { get; set; }



    /// <summary>
    /// The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start week date for this schedule. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }



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
        sb.Append("class WfmScheduleReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  BusinessUnit: ").Append(BusinessUnit).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
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
        return Equals(obj as WfmScheduleReference);
    }

    /// <summary>
    /// Returns true if WfmScheduleReference instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmScheduleReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmScheduleReference other)
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
                BusinessUnit == other.BusinessUnit ||
                BusinessUnit != null &&
                BusinessUnit.Equals(other.BusinessUnit)
            ) &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
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

            if (BusinessUnit != null)
            {
                hash = hash * 59 + BusinessUnit.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
