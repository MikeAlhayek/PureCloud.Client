using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ShiftTradeNotification
/// </summary>
[DataContract]
public partial class ShiftTradeNotification : IEquatable<ShiftTradeNotification>
{
    /// <summary>
    /// The new state of the shift trade, null if there was no change
    /// </summary>
    /// <value>The new state of the shift trade, null if there was no change</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NewStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unmatched for "Unmatched"
        /// </summary>
        [EnumMember(Value = "Unmatched")]
        Unmatched,

        /// <summary>
        /// Enum Matched for "Matched"
        /// </summary>
        [EnumMember(Value = "Matched")]
        Matched,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,

        /// <summary>
        /// Enum Denied for "Denied"
        /// </summary>
        [EnumMember(Value = "Denied")]
        Denied,

        /// <summary>
        /// Enum Expired for "Expired"
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled
    }
    /// <summary>
    /// The new state of the shift trade, null if there was no change
    /// </summary>
    /// <value>The new state of the shift trade, null if there was no change</value>
    [DataMember(Name = "newState", EmitDefaultValue = false)]
    public NewStateEnum? NewState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftTradeNotification" /> class.
    /// </summary>
    /// <param name="WeekDate">The start week date of the initiating shift of the shift trade in yyyy-MM-dd format.</param>
    /// <param name="TradeId">The ID of the shift trade.</param>
    /// <param name="OneSided">Whether this is a one sided shift trade.</param>
    /// <param name="NewState">The new state of the shift trade, null if there was no change.</param>
    /// <param name="InitiatingUser">The user who initiated the shift trade.</param>
    /// <param name="InitiatingShiftDate">The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ReceivingUser">The user on the receiving side of this shift trade (null if not matched).</param>
    /// <param name="ReceivingShiftDate">The start date and time of the receiving shift (null if not matched or if one-sided. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ShiftTradeNotification(string WeekDate = null, string TradeId = null, bool? OneSided = null, NewStateEnum? NewState = null, UserReference InitiatingUser = null, DateTime? InitiatingShiftDate = null, UserReference ReceivingUser = null, DateTime? ReceivingShiftDate = null)
    {
        this.WeekDate = WeekDate;
        this.TradeId = TradeId;
        this.OneSided = OneSided;
        this.NewState = NewState;
        this.InitiatingUser = InitiatingUser;
        this.InitiatingShiftDate = InitiatingShiftDate;
        this.ReceivingUser = ReceivingUser;
        this.ReceivingShiftDate = ReceivingShiftDate;

    }



    /// <summary>
    /// The start week date of the initiating shift of the shift trade in yyyy-MM-dd format
    /// </summary>
    /// <value>The start week date of the initiating shift of the shift trade in yyyy-MM-dd format</value>
    [DataMember(Name = "weekDate", EmitDefaultValue = false)]
    public string WeekDate { get; set; }



    /// <summary>
    /// The ID of the shift trade
    /// </summary>
    /// <value>The ID of the shift trade</value>
    [DataMember(Name = "tradeId", EmitDefaultValue = false)]
    public string TradeId { get; set; }



    /// <summary>
    /// Whether this is a one sided shift trade
    /// </summary>
    /// <value>Whether this is a one sided shift trade</value>
    [DataMember(Name = "oneSided", EmitDefaultValue = false)]
    public bool? OneSided { get; set; }





    /// <summary>
    /// The user who initiated the shift trade
    /// </summary>
    /// <value>The user who initiated the shift trade</value>
    [DataMember(Name = "initiatingUser", EmitDefaultValue = false)]
    public UserReference InitiatingUser { get; set; }



    /// <summary>
    /// The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "initiatingShiftDate", EmitDefaultValue = false)]
    public DateTime? InitiatingShiftDate { get; set; }



    /// <summary>
    /// The user on the receiving side of this shift trade (null if not matched)
    /// </summary>
    /// <value>The user on the receiving side of this shift trade (null if not matched)</value>
    [DataMember(Name = "receivingUser", EmitDefaultValue = false)]
    public UserReference ReceivingUser { get; set; }



    /// <summary>
    /// The start date and time of the receiving shift (null if not matched or if one-sided. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date and time of the receiving shift (null if not matched or if one-sided. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "receivingShiftDate", EmitDefaultValue = false)]
    public DateTime? ReceivingShiftDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShiftTradeNotification {\n");

        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  TradeId: ").Append(TradeId).Append("\n");
        sb.Append("  OneSided: ").Append(OneSided).Append("\n");
        sb.Append("  NewState: ").Append(NewState).Append("\n");
        sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
        sb.Append("  InitiatingShiftDate: ").Append(InitiatingShiftDate).Append("\n");
        sb.Append("  ReceivingUser: ").Append(ReceivingUser).Append("\n");
        sb.Append("  ReceivingShiftDate: ").Append(ReceivingShiftDate).Append("\n");
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
        return Equals(obj as ShiftTradeNotification);
    }

    /// <summary>
    /// Returns true if ShiftTradeNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of ShiftTradeNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShiftTradeNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WeekDate == other.WeekDate ||
                WeekDate != null &&
                WeekDate.Equals(other.WeekDate)
            ) &&
            (
                TradeId == other.TradeId ||
                TradeId != null &&
                TradeId.Equals(other.TradeId)
            ) &&
            (
                OneSided == other.OneSided ||
                OneSided != null &&
                OneSided.Equals(other.OneSided)
            ) &&
            (
                NewState == other.NewState ||
                NewState != null &&
                NewState.Equals(other.NewState)
            ) &&
            (
                InitiatingUser == other.InitiatingUser ||
                InitiatingUser != null &&
                InitiatingUser.Equals(other.InitiatingUser)
            ) &&
            (
                InitiatingShiftDate == other.InitiatingShiftDate ||
                InitiatingShiftDate != null &&
                InitiatingShiftDate.Equals(other.InitiatingShiftDate)
            ) &&
            (
                ReceivingUser == other.ReceivingUser ||
                ReceivingUser != null &&
                ReceivingUser.Equals(other.ReceivingUser)
            ) &&
            (
                ReceivingShiftDate == other.ReceivingShiftDate ||
                ReceivingShiftDate != null &&
                ReceivingShiftDate.Equals(other.ReceivingShiftDate)
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
            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (TradeId != null)
            {
                hash = hash * 59 + TradeId.GetHashCode();
            }

            if (OneSided != null)
            {
                hash = hash * 59 + OneSided.GetHashCode();
            }

            if (NewState != null)
            {
                hash = hash * 59 + NewState.GetHashCode();
            }

            if (InitiatingUser != null)
            {
                hash = hash * 59 + InitiatingUser.GetHashCode();
            }

            if (InitiatingShiftDate != null)
            {
                hash = hash * 59 + InitiatingShiftDate.GetHashCode();
            }

            if (ReceivingUser != null)
            {
                hash = hash * 59 + ReceivingUser.GetHashCode();
            }

            if (ReceivingShiftDate != null)
            {
                hash = hash * 59 + ReceivingShiftDate.GetHashCode();
            }

            return hash;
        }
    }
}
