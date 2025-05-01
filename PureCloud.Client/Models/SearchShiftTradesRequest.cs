using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SearchShiftTradesRequest
/// </summary>
[DataContract]
public partial class SearchShiftTradesRequest : IEquatable<SearchShiftTradesRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SearchShiftTradesRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SearchShiftTradesRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SearchShiftTradesRequest" /> class.
    /// </summary>
    /// <param name="ReceivingScheduleId">The ID of the schedule for which to search for available shift trades (required).</param>
    /// <param name="ReceivingShiftIds">The IDs of shifts that the receiving user would potentially be willing to trade. If empty, only returns one sided trades (pick up a shift).</param>
    public SearchShiftTradesRequest(string ReceivingScheduleId = null, List<string> ReceivingShiftIds = null)
    {
        this.ReceivingScheduleId = ReceivingScheduleId;
        this.ReceivingShiftIds = ReceivingShiftIds;

    }



    /// <summary>
    /// The ID of the schedule for which to search for available shift trades
    /// </summary>
    /// <value>The ID of the schedule for which to search for available shift trades</value>
    [DataMember(Name = "receivingScheduleId", EmitDefaultValue = false)]
    public string ReceivingScheduleId { get; set; }



    /// <summary>
    /// The IDs of shifts that the receiving user would potentially be willing to trade. If empty, only returns one sided trades (pick up a shift)
    /// </summary>
    /// <value>The IDs of shifts that the receiving user would potentially be willing to trade. If empty, only returns one sided trades (pick up a shift)</value>
    [DataMember(Name = "receivingShiftIds", EmitDefaultValue = false)]
    public List<string> ReceivingShiftIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SearchShiftTradesRequest {\n");

        sb.Append("  ReceivingScheduleId: ").Append(ReceivingScheduleId).Append("\n");
        sb.Append("  ReceivingShiftIds: ").Append(ReceivingShiftIds).Append("\n");
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
        return Equals(obj as SearchShiftTradesRequest);
    }

    /// <summary>
    /// Returns true if SearchShiftTradesRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SearchShiftTradesRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SearchShiftTradesRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ReceivingScheduleId == other.ReceivingScheduleId ||
                ReceivingScheduleId != null &&
                ReceivingScheduleId.Equals(other.ReceivingScheduleId)
            ) &&
            (
                ReceivingShiftIds == other.ReceivingShiftIds ||
                ReceivingShiftIds != null &&
                ReceivingShiftIds.SequenceEqual(other.ReceivingShiftIds)
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
            if (ReceivingScheduleId != null)
            {
                hash = hash * 59 + ReceivingScheduleId.GetHashCode();
            }

            if (ReceivingShiftIds != null)
            {
                hash = hash * 59 + ReceivingShiftIds.GetHashCode();
            }

            return hash;
        }
    }
}
