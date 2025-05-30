using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuHeadcountForecast
/// </summary>

public partial class BuHeadcountForecast : IEquatable<BuHeadcountForecast>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuHeadcountForecast" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="ReferenceStartDate">Reference start date for the interval values in each forecast entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public BuHeadcountForecast(List<BuPlanningGroupHeadcountForecast> Entities = null, DateTime? ReferenceStartDate = null)
    {
        this.Entities = Entities;
        this.ReferenceStartDate = ReferenceStartDate;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<BuPlanningGroupHeadcountForecast> Entities { get; set; }



    /// <summary>
    /// Reference start date for the interval values in each forecast entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Reference start date for the interval values in each forecast entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("referenceStartDate")]
    public DateTime? ReferenceStartDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuHeadcountForecast {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  ReferenceStartDate: ").Append(ReferenceStartDate).Append("\n");
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
        return Equals(obj as BuHeadcountForecast);
    }

    /// <summary>
    /// Returns true if BuHeadcountForecast instances are equal
    /// </summary>
    /// <param name="other">Instance of BuHeadcountForecast to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuHeadcountForecast other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                ReferenceStartDate == other.ReferenceStartDate ||
                ReferenceStartDate != null &&
                ReferenceStartDate.Equals(other.ReferenceStartDate)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (ReferenceStartDate != null)
            {
                hash = hash * 59 + ReferenceStartDate.GetHashCode();
            }

            return hash;
        }
    }
}
