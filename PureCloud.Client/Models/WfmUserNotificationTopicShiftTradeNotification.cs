using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserNotificationTopicShiftTradeNotification
/// </summary>
[DataContract]
public partial class WfmUserNotificationTopicShiftTradeNotification : IEquatable<WfmUserNotificationTopicShiftTradeNotification>
{
    /// <summary>
    /// Gets or Sets NewState
    /// </summary>
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
    /// Gets or Sets NewState
    /// </summary>
    [DataMember(Name = "newState", EmitDefaultValue = false)]
    public NewStateEnum? NewState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserNotificationTopicShiftTradeNotification" /> class.
    /// </summary>
    /// <param name="WeekDate">WeekDate.</param>
    /// <param name="TradeId">TradeId.</param>
    /// <param name="OneSided">OneSided.</param>
    /// <param name="NewState">NewState.</param>
    /// <param name="InitiatingUser">InitiatingUser.</param>
    /// <param name="InitiatingShiftDate">InitiatingShiftDate.</param>
    /// <param name="ReceivingUser">ReceivingUser.</param>
    /// <param name="ReceivingShiftDate">ReceivingShiftDate.</param>
    public WfmUserNotificationTopicShiftTradeNotification(string WeekDate = null, string TradeId = null, bool? OneSided = null, NewStateEnum? NewState = null, WfmUserNotificationTopicUserReference InitiatingUser = null, DateTime? InitiatingShiftDate = null, WfmUserNotificationTopicUserReference ReceivingUser = null, DateTime? ReceivingShiftDate = null)
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
    /// Gets or Sets WeekDate
    /// </summary>
    [DataMember(Name = "weekDate", EmitDefaultValue = false)]
    public string WeekDate { get; set; }



    /// <summary>
    /// Gets or Sets TradeId
    /// </summary>
    [DataMember(Name = "tradeId", EmitDefaultValue = false)]
    public string TradeId { get; set; }



    /// <summary>
    /// Gets or Sets OneSided
    /// </summary>
    [DataMember(Name = "oneSided", EmitDefaultValue = false)]
    public bool? OneSided { get; set; }





    /// <summary>
    /// Gets or Sets InitiatingUser
    /// </summary>
    [DataMember(Name = "initiatingUser", EmitDefaultValue = false)]
    public WfmUserNotificationTopicUserReference InitiatingUser { get; set; }



    /// <summary>
    /// Gets or Sets InitiatingShiftDate
    /// </summary>
    [DataMember(Name = "initiatingShiftDate", EmitDefaultValue = false)]
    public DateTime? InitiatingShiftDate { get; set; }



    /// <summary>
    /// Gets or Sets ReceivingUser
    /// </summary>
    [DataMember(Name = "receivingUser", EmitDefaultValue = false)]
    public WfmUserNotificationTopicUserReference ReceivingUser { get; set; }



    /// <summary>
    /// Gets or Sets ReceivingShiftDate
    /// </summary>
    [DataMember(Name = "receivingShiftDate", EmitDefaultValue = false)]
    public DateTime? ReceivingShiftDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserNotificationTopicShiftTradeNotification {\n");

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
        return Equals(obj as WfmUserNotificationTopicShiftTradeNotification);
    }

    /// <summary>
    /// Returns true if WfmUserNotificationTopicShiftTradeNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserNotificationTopicShiftTradeNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserNotificationTopicShiftTradeNotification other)
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
