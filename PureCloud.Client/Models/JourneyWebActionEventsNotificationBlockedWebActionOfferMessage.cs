using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyWebActionEventsNotificationBlockedWebActionOfferMessage
/// </summary>
[DataContract]
public partial class JourneyWebActionEventsNotificationBlockedWebActionOfferMessage : IEquatable<JourneyWebActionEventsNotificationBlockedWebActionOfferMessage>
{
    /// <summary>
    /// Gets or Sets BlockingReason
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BlockingReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Pageurlconditionsnotmatching for "PageUrlConditionsNotMatching"
        /// </summary>
        [EnumMember(Value = "PageUrlConditionsNotMatching")]
        Pageurlconditionsnotmatching,

        /// <summary>
        /// Enum Servicelevelthrottling for "ServiceLevelThrottling"
        /// </summary>
        [EnumMember(Value = "ServiceLevelThrottling")]
        Servicelevelthrottling,

        /// <summary>
        /// Enum Alreadyexistingoffer for "AlreadyExistingOffer"
        /// </summary>
        [EnumMember(Value = "AlreadyExistingOffer")]
        Alreadyexistingoffer,

        /// <summary>
        /// Enum Triggerdateinfuture for "TriggerDateInFuture"
        /// </summary>
        [EnumMember(Value = "TriggerDateInFuture")]
        Triggerdateinfuture,

        /// <summary>
        /// Enum Multiplesimultaneousoffers for "MultipleSimultaneousOffers"
        /// </summary>
        [EnumMember(Value = "MultipleSimultaneousOffers")]
        Multiplesimultaneousoffers,

        /// <summary>
        /// Enum Noavailableagents for "NoAvailableAgents"
        /// </summary>
        [EnumMember(Value = "NoAvailableAgents")]
        Noavailableagents,

        /// <summary>
        /// Enum Frequencycapping for "FrequencyCapping"
        /// </summary>
        [EnumMember(Value = "FrequencyCapping")]
        Frequencycapping,

        /// <summary>
        /// Enum Offeredoutsideschedule for "OfferedOutsideSchedule"
        /// </summary>
        [EnumMember(Value = "OfferedOutsideSchedule")]
        Offeredoutsideschedule
    }
    /// <summary>
    /// Gets or Sets BlockingFrequencyCapBehaviour
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BlockingFrequencyCapBehaviourEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Caponcefinalized for "CapOnceFinalized"
        /// </summary>
        [EnumMember(Value = "CapOnceFinalized")]
        Caponcefinalized,

        /// <summary>
        /// Enum Caponcerejected for "CapOnceRejected"
        /// </summary>
        [EnumMember(Value = "CapOnceRejected")]
        Caponcerejected,

        /// <summary>
        /// Enum Capforperiod for "CapForPeriod"
        /// </summary>
        [EnumMember(Value = "CapForPeriod")]
        Capforperiod
    }
    /// <summary>
    /// Gets or Sets BlockingReason
    /// </summary>
    [DataMember(Name = "blockingReason", EmitDefaultValue = false)]
    public BlockingReasonEnum? BlockingReason { get; set; }
    /// <summary>
    /// Gets or Sets BlockingFrequencyCapBehaviour
    /// </summary>
    [DataMember(Name = "blockingFrequencyCapBehaviour", EmitDefaultValue = false)]
    public BlockingFrequencyCapBehaviourEnum? BlockingFrequencyCapBehaviour { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebActionEventsNotificationBlockedWebActionOfferMessage" /> class.
    /// </summary>
    /// <param name="Action">Action.</param>
    /// <param name="ActionMap">ActionMap.</param>
    /// <param name="ActionTarget">ActionTarget.</param>
    /// <param name="BlockingReason">BlockingReason.</param>
    /// <param name="BlockingActionMap">BlockingActionMap.</param>
    /// <param name="BlockingAction">BlockingAction.</param>
    /// <param name="BlockingFrequencyCapBehaviour">BlockingFrequencyCapBehaviour.</param>
    /// <param name="BlockingPageUrlConditions">BlockingPageUrlConditions.</param>
    /// <param name="BlockingScheduleGroup">BlockingScheduleGroup.</param>
    /// <param name="BlockingEmergencyScheduleGroup">BlockingEmergencyScheduleGroup.</param>
    public JourneyWebActionEventsNotificationBlockedWebActionOfferMessage(JourneyWebActionEventsNotificationEventAction Action = null, JourneyWebActionEventsNotificationActionMap ActionMap = null, JourneyWebActionEventsNotificationActionTarget ActionTarget = null, BlockingReasonEnum? BlockingReason = null, JourneyWebActionEventsNotificationActionMap BlockingActionMap = null, JourneyWebActionEventsNotificationEventAction BlockingAction = null, BlockingFrequencyCapBehaviourEnum? BlockingFrequencyCapBehaviour = null, List<JourneyWebActionEventsNotificationActionMapPageUrlCondition> BlockingPageUrlConditions = null, JourneyWebActionEventsNotificationScheduleGroup BlockingScheduleGroup = null, JourneyWebActionEventsNotificationEmergencyGroup BlockingEmergencyScheduleGroup = null)
    {
        this.Action = Action;
        this.ActionMap = ActionMap;
        this.ActionTarget = ActionTarget;
        this.BlockingReason = BlockingReason;
        this.BlockingActionMap = BlockingActionMap;
        this.BlockingAction = BlockingAction;
        this.BlockingFrequencyCapBehaviour = BlockingFrequencyCapBehaviour;
        this.BlockingPageUrlConditions = BlockingPageUrlConditions;
        this.BlockingScheduleGroup = BlockingScheduleGroup;
        this.BlockingEmergencyScheduleGroup = BlockingEmergencyScheduleGroup;

    }



    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public JourneyWebActionEventsNotificationEventAction Action { get; set; }



    /// <summary>
    /// Gets or Sets ActionMap
    /// </summary>
    [DataMember(Name = "actionMap", EmitDefaultValue = false)]
    public JourneyWebActionEventsNotificationActionMap ActionMap { get; set; }



    /// <summary>
    /// Gets or Sets ActionTarget
    /// </summary>
    [DataMember(Name = "actionTarget", EmitDefaultValue = false)]
    public JourneyWebActionEventsNotificationActionTarget ActionTarget { get; set; }





    /// <summary>
    /// Gets or Sets BlockingActionMap
    /// </summary>
    [DataMember(Name = "blockingActionMap", EmitDefaultValue = false)]
    public JourneyWebActionEventsNotificationActionMap BlockingActionMap { get; set; }



    /// <summary>
    /// Gets or Sets BlockingAction
    /// </summary>
    [DataMember(Name = "blockingAction", EmitDefaultValue = false)]
    public JourneyWebActionEventsNotificationEventAction BlockingAction { get; set; }





    /// <summary>
    /// Gets or Sets BlockingPageUrlConditions
    /// </summary>
    [DataMember(Name = "blockingPageUrlConditions", EmitDefaultValue = false)]
    public List<JourneyWebActionEventsNotificationActionMapPageUrlCondition> BlockingPageUrlConditions { get; set; }



    /// <summary>
    /// Gets or Sets BlockingScheduleGroup
    /// </summary>
    [DataMember(Name = "blockingScheduleGroup", EmitDefaultValue = false)]
    public JourneyWebActionEventsNotificationScheduleGroup BlockingScheduleGroup { get; set; }



    /// <summary>
    /// Gets or Sets BlockingEmergencyScheduleGroup
    /// </summary>
    [DataMember(Name = "blockingEmergencyScheduleGroup", EmitDefaultValue = false)]
    public JourneyWebActionEventsNotificationEmergencyGroup BlockingEmergencyScheduleGroup { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebActionEventsNotificationBlockedWebActionOfferMessage {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  ActionMap: ").Append(ActionMap).Append("\n");
        sb.Append("  ActionTarget: ").Append(ActionTarget).Append("\n");
        sb.Append("  BlockingReason: ").Append(BlockingReason).Append("\n");
        sb.Append("  BlockingActionMap: ").Append(BlockingActionMap).Append("\n");
        sb.Append("  BlockingAction: ").Append(BlockingAction).Append("\n");
        sb.Append("  BlockingFrequencyCapBehaviour: ").Append(BlockingFrequencyCapBehaviour).Append("\n");
        sb.Append("  BlockingPageUrlConditions: ").Append(BlockingPageUrlConditions).Append("\n");
        sb.Append("  BlockingScheduleGroup: ").Append(BlockingScheduleGroup).Append("\n");
        sb.Append("  BlockingEmergencyScheduleGroup: ").Append(BlockingEmergencyScheduleGroup).Append("\n");
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
        return Equals(obj as JourneyWebActionEventsNotificationBlockedWebActionOfferMessage);
    }

    /// <summary>
    /// Returns true if JourneyWebActionEventsNotificationBlockedWebActionOfferMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebActionEventsNotificationBlockedWebActionOfferMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebActionEventsNotificationBlockedWebActionOfferMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                ActionMap == other.ActionMap ||
                ActionMap != null &&
                ActionMap.Equals(other.ActionMap)
            ) &&
            (
                ActionTarget == other.ActionTarget ||
                ActionTarget != null &&
                ActionTarget.Equals(other.ActionTarget)
            ) &&
            (
                BlockingReason == other.BlockingReason ||
                BlockingReason != null &&
                BlockingReason.Equals(other.BlockingReason)
            ) &&
            (
                BlockingActionMap == other.BlockingActionMap ||
                BlockingActionMap != null &&
                BlockingActionMap.Equals(other.BlockingActionMap)
            ) &&
            (
                BlockingAction == other.BlockingAction ||
                BlockingAction != null &&
                BlockingAction.Equals(other.BlockingAction)
            ) &&
            (
                BlockingFrequencyCapBehaviour == other.BlockingFrequencyCapBehaviour ||
                BlockingFrequencyCapBehaviour != null &&
                BlockingFrequencyCapBehaviour.Equals(other.BlockingFrequencyCapBehaviour)
            ) &&
            (
                BlockingPageUrlConditions == other.BlockingPageUrlConditions ||
                BlockingPageUrlConditions != null &&
                BlockingPageUrlConditions.SequenceEqual(other.BlockingPageUrlConditions)
            ) &&
            (
                BlockingScheduleGroup == other.BlockingScheduleGroup ||
                BlockingScheduleGroup != null &&
                BlockingScheduleGroup.Equals(other.BlockingScheduleGroup)
            ) &&
            (
                BlockingEmergencyScheduleGroup == other.BlockingEmergencyScheduleGroup ||
                BlockingEmergencyScheduleGroup != null &&
                BlockingEmergencyScheduleGroup.Equals(other.BlockingEmergencyScheduleGroup)
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
            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (ActionMap != null)
            {
                hash = hash * 59 + ActionMap.GetHashCode();
            }

            if (ActionTarget != null)
            {
                hash = hash * 59 + ActionTarget.GetHashCode();
            }

            if (BlockingReason != null)
            {
                hash = hash * 59 + BlockingReason.GetHashCode();
            }

            if (BlockingActionMap != null)
            {
                hash = hash * 59 + BlockingActionMap.GetHashCode();
            }

            if (BlockingAction != null)
            {
                hash = hash * 59 + BlockingAction.GetHashCode();
            }

            if (BlockingFrequencyCapBehaviour != null)
            {
                hash = hash * 59 + BlockingFrequencyCapBehaviour.GetHashCode();
            }

            if (BlockingPageUrlConditions != null)
            {
                hash = hash * 59 + BlockingPageUrlConditions.GetHashCode();
            }

            if (BlockingScheduleGroup != null)
            {
                hash = hash * 59 + BlockingScheduleGroup.GetHashCode();
            }

            if (BlockingEmergencyScheduleGroup != null)
            {
                hash = hash * 59 + BlockingEmergencyScheduleGroup.GetHashCode();
            }

            return hash;
        }
    }
}
