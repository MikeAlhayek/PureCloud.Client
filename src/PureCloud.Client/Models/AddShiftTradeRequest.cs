using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AddShiftTradeRequest
/// </summary>

public partial class AddShiftTradeRequest : IEquatable<AddShiftTradeRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AddShiftTradeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AddShiftTradeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AddShiftTradeRequest" /> class.
    /// </summary>
    /// <param name="ScheduleId">The ID of the schedule to which the initiating and receiving shifts belong (required).</param>
    /// <param name="InitiatingShiftId">The ID of the shift that the initiating user wants to give up (required).</param>
    /// <param name="ReceivingUserId">The ID of the user to whom to send the request (for use in direct trade requests).</param>
    /// <param name="Expiration">When this shift trade request should expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AcceptableIntervals">The acceptable intervals the initiating user is willing to accept in trade.  Empty indicates the user is giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    public AddShiftTradeRequest(string ScheduleId = null, string InitiatingShiftId = null, string ReceivingUserId = null, DateTime? Expiration = null, List<string> AcceptableIntervals = null)
    {
        this.ScheduleId = ScheduleId;
        this.InitiatingShiftId = InitiatingShiftId;
        this.ReceivingUserId = ReceivingUserId;
        this.Expiration = Expiration;
        this.AcceptableIntervals = AcceptableIntervals;

    }



    /// <summary>
    /// The ID of the schedule to which the initiating and receiving shifts belong
    /// </summary>
    /// <value>The ID of the schedule to which the initiating and receiving shifts belong</value>
    [JsonPropertyName("scheduleId")]
    public string ScheduleId { get; set; }



    /// <summary>
    /// The ID of the shift that the initiating user wants to give up
    /// </summary>
    /// <value>The ID of the shift that the initiating user wants to give up</value>
    [JsonPropertyName("initiatingShiftId")]
    public string InitiatingShiftId { get; set; }



    /// <summary>
    /// The ID of the user to whom to send the request (for use in direct trade requests)
    /// </summary>
    /// <value>The ID of the user to whom to send the request (for use in direct trade requests)</value>
    [JsonPropertyName("receivingUserId")]
    public string ReceivingUserId { get; set; }



    /// <summary>
    /// When this shift trade request should expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When this shift trade request should expire. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("expiration")]
    public DateTime? Expiration { get; set; }



    /// <summary>
    /// The acceptable intervals the initiating user is willing to accept in trade.  Empty indicates the user is giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>The acceptable intervals the initiating user is willing to accept in trade.  Empty indicates the user is giving up the shift. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("acceptableIntervals")]
    public List<string> AcceptableIntervals { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AddShiftTradeRequest {\n");

        sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
        sb.Append("  InitiatingShiftId: ").Append(InitiatingShiftId).Append("\n");
        sb.Append("  ReceivingUserId: ").Append(ReceivingUserId).Append("\n");
        sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
        return Equals(obj as AddShiftTradeRequest);
    }

    /// <summary>
    /// Returns true if AddShiftTradeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AddShiftTradeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AddShiftTradeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ScheduleId == other.ScheduleId ||
                ScheduleId != null &&
                ScheduleId.Equals(other.ScheduleId)
            ) &&
            (
                InitiatingShiftId == other.InitiatingShiftId ||
                InitiatingShiftId != null &&
                InitiatingShiftId.Equals(other.InitiatingShiftId)
            ) &&
            (
                ReceivingUserId == other.ReceivingUserId ||
                ReceivingUserId != null &&
                ReceivingUserId.Equals(other.ReceivingUserId)
            ) &&
            (
                Expiration == other.Expiration ||
                Expiration != null &&
                Expiration.Equals(other.Expiration)
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
            if (ScheduleId != null)
            {
                hash = hash * 59 + ScheduleId.GetHashCode();
            }

            if (InitiatingShiftId != null)
            {
                hash = hash * 59 + InitiatingShiftId.GetHashCode();
            }

            if (ReceivingUserId != null)
            {
                hash = hash * 59 + ReceivingUserId.GetHashCode();
            }

            if (Expiration != null)
            {
                hash = hash * 59 + Expiration.GetHashCode();
            }

            if (AcceptableIntervals != null)
            {
                hash = hash * 59 + AcceptableIntervals.GetHashCode();
            }

            return hash;
        }
    }
}
