using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlternativeShiftSearchOffersRequest
/// </summary>
[DataContract]
public partial class AlternativeShiftSearchOffersRequest : IEquatable<AlternativeShiftSearchOffersRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftSearchOffersRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlternativeShiftSearchOffersRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftSearchOffersRequest" /> class.
    /// </summary>
    /// <param name="Schedule">The existing schedule being used to find alternative shift offers (required).</param>
    /// <param name="QueryWeekDate">The start date for the week in this schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="InitiatingShift">The shift a user puts up for alternative shift offers (required).</param>
    /// <param name="AcceptableIntervals">The acceptable intervals in offers. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    public AlternativeShiftSearchOffersRequest(AlternativeShiftScheduleLookup Schedule = null, string QueryWeekDate = null, InitiatingAlternativeShift InitiatingShift = null, List<string> AcceptableIntervals = null)
    {
        this.Schedule = Schedule;
        this.QueryWeekDate = QueryWeekDate;
        this.InitiatingShift = InitiatingShift;
        this.AcceptableIntervals = AcceptableIntervals;

    }



    /// <summary>
    /// The existing schedule being used to find alternative shift offers
    /// </summary>
    /// <value>The existing schedule being used to find alternative shift offers</value>
    [DataMember(Name = "schedule", EmitDefaultValue = false)]
    public AlternativeShiftScheduleLookup Schedule { get; set; }



    /// <summary>
    /// The start date for the week in this schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start date for the week in this schedule in yyyy-MM-dd format. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "queryWeekDate", EmitDefaultValue = false)]
    public string QueryWeekDate { get; set; }



    /// <summary>
    /// The shift a user puts up for alternative shift offers
    /// </summary>
    /// <value>The shift a user puts up for alternative shift offers</value>
    [DataMember(Name = "initiatingShift", EmitDefaultValue = false)]
    public InitiatingAlternativeShift InitiatingShift { get; set; }



    /// <summary>
    /// The acceptable intervals in offers. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>The acceptable intervals in offers. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [DataMember(Name = "acceptableIntervals", EmitDefaultValue = false)]
    public List<string> AcceptableIntervals { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlternativeShiftSearchOffersRequest {\n");

        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  QueryWeekDate: ").Append(QueryWeekDate).Append("\n");
        sb.Append("  InitiatingShift: ").Append(InitiatingShift).Append("\n");
        sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
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
        return Equals(obj as AlternativeShiftSearchOffersRequest);
    }

    /// <summary>
    /// Returns true if AlternativeShiftSearchOffersRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AlternativeShiftSearchOffersRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlternativeShiftSearchOffersRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
            ) &&
            (
                QueryWeekDate == other.QueryWeekDate ||
                QueryWeekDate != null &&
                QueryWeekDate.Equals(other.QueryWeekDate)
            ) &&
            (
                InitiatingShift == other.InitiatingShift ||
                InitiatingShift != null &&
                InitiatingShift.Equals(other.InitiatingShift)
            ) &&
            (
                AcceptableIntervals == other.AcceptableIntervals ||
                AcceptableIntervals != null &&
                AcceptableIntervals.SequenceEqual(other.AcceptableIntervals)
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
            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (QueryWeekDate != null)
            {
                hash = hash * 59 + QueryWeekDate.GetHashCode();
            }

            if (InitiatingShift != null)
            {
                hash = hash * 59 + InitiatingShift.GetHashCode();
            }

            if (AcceptableIntervals != null)
            {
                hash = hash * 59 + AcceptableIntervals.GetHashCode();
            }

            return hash;
        }
    }
}
