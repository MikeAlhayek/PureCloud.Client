using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlternativeShiftNotification
/// </summary>

public partial class AlternativeShiftNotification : IEquatable<AlternativeShiftNotification>
{
    /// <summary>
    /// The granularity of alternative shifts to be traded
    /// </summary>
    /// <value>The granularity of alternative shifts to be traded</value>
    
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
        Daily
    }
    /// <summary>
    /// The new state of the alternative shift trade, null if there was no change
    /// </summary>
    /// <value>The new state of the alternative shift trade, null if there was no change</value>
    
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
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

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
        /// Enum Submitted for "Submitted"
        /// </summary>
        [EnumMember(Value = "Submitted")]
        Submitted,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved
    }
    /// <summary>
    /// The granularity of alternative shifts to be traded
    /// </summary>
    /// <value>The granularity of alternative shifts to be traded</value>
    [JsonPropertyName("granularity")]
    public GranularityEnum? Granularity { get; set; }
    /// <summary>
    /// The new state of the alternative shift trade, null if there was no change
    /// </summary>
    /// <value>The new state of the alternative shift trade, null if there was no change</value>
    [JsonPropertyName("newState")]
    public NewStateEnum? NewState { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftNotification" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlternativeShiftNotification() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlternativeShiftNotification" /> class.
    /// </summary>
    /// <param name="WeekDate">The start date of the schedule with which this trade is associated. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="Granularity">The granularity of alternative shifts to be traded (required).</param>
    /// <param name="NewState">The new state of the alternative shift trade, null if there was no change.</param>
    /// <param name="InitiatingUser">The user who initiated the alternative shift trade (required).</param>
    /// <param name="InitiatingShiftDate">The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ReceivingUser">The user on the receiving side of this alternative shift trade.</param>
    /// <param name="ReceivingShiftDate">The start date and time of the receiving alternative shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public AlternativeShiftNotification(string WeekDate = null, GranularityEnum? Granularity = null, NewStateEnum? NewState = null, UserReference InitiatingUser = null, DateTime? InitiatingShiftDate = null, UserReference ReceivingUser = null, DateTime? ReceivingShiftDate = null)
    {
        this.WeekDate = WeekDate;
        this.Granularity = Granularity;
        this.NewState = NewState;
        this.InitiatingUser = InitiatingUser;
        this.InitiatingShiftDate = InitiatingShiftDate;
        this.ReceivingUser = ReceivingUser;
        this.ReceivingShiftDate = ReceivingShiftDate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The start date of the schedule with which this trade is associated. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The start date of the schedule with which this trade is associated. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("weekDate")]
    public string WeekDate { get; set; }







    /// <summary>
    /// The user who initiated the alternative shift trade
    /// </summary>
    /// <value>The user who initiated the alternative shift trade</value>
    [JsonPropertyName("initiatingUser")]
    public UserReference InitiatingUser { get; set; }



    /// <summary>
    /// The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date and time of the initiating shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("initiatingShiftDate")]
    public DateTime? InitiatingShiftDate { get; set; }



    /// <summary>
    /// The user on the receiving side of this alternative shift trade
    /// </summary>
    /// <value>The user on the receiving side of this alternative shift trade</value>
    [JsonPropertyName("receivingUser")]
    public UserReference ReceivingUser { get; set; }



    /// <summary>
    /// The start date and time of the receiving alternative shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date and time of the receiving alternative shift. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("receivingShiftDate")]
    public DateTime? ReceivingShiftDate { get; set; }



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
        sb.Append("class AlternativeShiftNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WeekDate: ").Append(WeekDate).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  NewState: ").Append(NewState).Append("\n");
        sb.Append("  InitiatingUser: ").Append(InitiatingUser).Append("\n");
        sb.Append("  InitiatingShiftDate: ").Append(InitiatingShiftDate).Append("\n");
        sb.Append("  ReceivingUser: ").Append(ReceivingUser).Append("\n");
        sb.Append("  ReceivingShiftDate: ").Append(ReceivingShiftDate).Append("\n");
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
        return Equals(obj as AlternativeShiftNotification);
    }

    /// <summary>
    /// Returns true if AlternativeShiftNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of AlternativeShiftNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlternativeShiftNotification other)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
