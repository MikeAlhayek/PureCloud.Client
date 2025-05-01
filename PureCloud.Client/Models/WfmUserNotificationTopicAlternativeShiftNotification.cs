using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserNotificationTopicAlternativeShiftNotification
/// </summary>
[DataContract]
public partial class WfmUserNotificationTopicAlternativeShiftNotification : IEquatable<WfmUserNotificationTopicAlternativeShiftNotification>
{
    /// <summary>
    /// Gets or Sets Granularity
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GranularityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Daily for "Daily"
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily,

        /// <summary>
        /// Enum Weekly for "Weekly"
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly
    }
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
        /// Enum Submitted for "Submitted"
        /// </summary>
        [EnumMember(Value = "Submitted")]
        Submitted,

        /// <summary>
        /// Enum Expired for "Expired"
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired,

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
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled
    }
    /// <summary>
    /// Gets or Sets Granularity
    /// </summary>
    [DataMember(Name = "granularity", EmitDefaultValue = false)]
    public GranularityEnum? Granularity { get; set; }
    /// <summary>
    /// Gets or Sets NewState
    /// </summary>
    [DataMember(Name = "newState", EmitDefaultValue = false)]
    public NewStateEnum? NewState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserNotificationTopicAlternativeShiftNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="WeekDate">WeekDate.</param>
    /// <param name="Granularity">Granularity.</param>
    /// <param name="NewState">NewState.</param>
    /// <param name="InitiatingUser">InitiatingUser.</param>
    /// <param name="InitiatingShiftDate">InitiatingShiftDate.</param>
    /// <param name="ReceivingUser">ReceivingUser.</param>
    /// <param name="ReceivingShiftDate">ReceivingShiftDate.</param>
    public WfmUserNotificationTopicAlternativeShiftNotification(string Id = null, DateTime? WeekDate = null, GranularityEnum? Granularity = null, NewStateEnum? NewState = null, WfmUserNotificationTopicUserReference InitiatingUser = null, DateTime? InitiatingShiftDate = null, WfmUserNotificationTopicUserReference ReceivingUser = null, DateTime? ReceivingShiftDate = null)
    {
        this.Id = Id;
        this.WeekDate = WeekDate;
        this.Granularity = Granularity;
        this.NewState = NewState;
        this.InitiatingUser = InitiatingUser;
        this.InitiatingShiftDate = InitiatingShiftDate;
        this.ReceivingUser = ReceivingUser;
        this.ReceivingShiftDate = ReceivingShiftDate;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets WeekDate
    /// </summary>
    [DataMember(Name = "weekDate", EmitDefaultValue = false)]
    public DateTime? WeekDate { get; set; }







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
        sb.Append("class WfmUserNotificationTopicAlternativeShiftNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
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
        return Equals(obj as WfmUserNotificationTopicAlternativeShiftNotification);
    }

    /// <summary>
    /// Returns true if WfmUserNotificationTopicAlternativeShiftNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserNotificationTopicAlternativeShiftNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserNotificationTopicAlternativeShiftNotification other)
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
                Granularity == other.Granularity ||
                Granularity != null &&
                Granularity.Equals(other.Granularity)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (WeekDate != null)
            {
                hash = hash * 59 + WeekDate.GetHashCode();
            }

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
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
