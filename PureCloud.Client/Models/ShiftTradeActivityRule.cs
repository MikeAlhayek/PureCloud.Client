using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ShiftTradeActivityRule
/// </summary>
[DataContract]
public partial class ShiftTradeActivityRule : IEquatable<ShiftTradeActivityRule>
{
    /// <summary>
    /// The activity category to which to apply this rule
    /// </summary>
    /// <value>The activity category to which to apply this rule</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActivityCategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Onqueuework for "OnQueueWork"
        /// </summary>
        [EnumMember(Value = "OnQueueWork")]
        Onqueuework,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Offqueuework for "OffQueueWork"
        /// </summary>
        [EnumMember(Value = "OffQueueWork")]
        Offqueuework,

        /// <summary>
        /// Enum Timeoff for "TimeOff"
        /// </summary>
        [EnumMember(Value = "TimeOff")]
        Timeoff,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,

        /// <summary>
        /// Enum Unscheduled for "Unscheduled"
        /// </summary>
        [EnumMember(Value = "Unscheduled")]
        Unscheduled
    }
    /// <summary>
    /// The action this rule invokes
    /// </summary>
    /// <value>The action this rule invokes</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Replace for "Replace"
        /// </summary>
        [EnumMember(Value = "Replace")]
        Replace,

        /// <summary>
        /// Enum Donotallowtrade for "DoNotAllowTrade"
        /// </summary>
        [EnumMember(Value = "DoNotAllowTrade")]
        Donotallowtrade,

        /// <summary>
        /// Enum Keepwithschedule for "KeepWithSchedule"
        /// </summary>
        [EnumMember(Value = "KeepWithSchedule")]
        Keepwithschedule
    }
    /// <summary>
    /// The activity category to which to apply this rule
    /// </summary>
    /// <value>The activity category to which to apply this rule</value>
    [DataMember(Name = "activityCategory", EmitDefaultValue = false)]
    public ActivityCategoryEnum? ActivityCategory { get; set; }
    /// <summary>
    /// The action this rule invokes
    /// </summary>
    /// <value>The action this rule invokes</value>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public ActionEnum? Action { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftTradeActivityRule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ShiftTradeActivityRule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftTradeActivityRule" /> class.
    /// </summary>
    /// <param name="ActivityCategory">The activity category to which to apply this rule (required).</param>
    /// <param name="Action">The action this rule invokes (required).</param>
    /// <param name="ActivityCodeIdReplacement">The activity code ID with which to replace activities belonging to the original category if applicable (required if action &#x3D;&#x3D; Replace, must be a default activity code ID).</param>
    public ShiftTradeActivityRule(ActivityCategoryEnum? ActivityCategory = null, ActionEnum? Action = null, string ActivityCodeIdReplacement = null)
    {
        this.ActivityCategory = ActivityCategory;
        this.Action = Action;
        this.ActivityCodeIdReplacement = ActivityCodeIdReplacement;

    }







    /// <summary>
    /// The activity code ID with which to replace activities belonging to the original category if applicable (required if action &#x3D;&#x3D; Replace, must be a default activity code ID)
    /// </summary>
    /// <value>The activity code ID with which to replace activities belonging to the original category if applicable (required if action &#x3D;&#x3D; Replace, must be a default activity code ID)</value>
    [DataMember(Name = "activityCodeIdReplacement", EmitDefaultValue = false)]
    public string ActivityCodeIdReplacement { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShiftTradeActivityRule {\n");

        sb.Append("  ActivityCategory: ").Append(ActivityCategory).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  ActivityCodeIdReplacement: ").Append(ActivityCodeIdReplacement).Append("\n");
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
        return Equals(obj as ShiftTradeActivityRule);
    }

    /// <summary>
    /// Returns true if ShiftTradeActivityRule instances are equal
    /// </summary>
    /// <param name="other">Instance of ShiftTradeActivityRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShiftTradeActivityRule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityCategory == other.ActivityCategory ||
                ActivityCategory != null &&
                ActivityCategory.Equals(other.ActivityCategory)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                ActivityCodeIdReplacement == other.ActivityCodeIdReplacement ||
                ActivityCodeIdReplacement != null &&
                ActivityCodeIdReplacement.Equals(other.ActivityCodeIdReplacement)
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
            if (ActivityCategory != null)
            {
                hash = hash * 59 + ActivityCategory.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (ActivityCodeIdReplacement != null)
            {
                hash = hash * 59 + ActivityCodeIdReplacement.GetHashCode();
            }

            return hash;
        }
    }
}
