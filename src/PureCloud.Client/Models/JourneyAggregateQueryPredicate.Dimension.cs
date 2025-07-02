using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum JourneyAggregateQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Containsallcondition for "containsAllCondition"
    /// </summary>
    [EnumMember(Value = "containsAllCondition")]
    Containsallcondition,

    /// <summary>
    /// Enum Containsanycondition for "containsAnyCondition"
    /// </summary>
    [EnumMember(Value = "containsAnyCondition")]
    Containsanycondition,

    /// <summary>
    /// Enum Endswithcondition for "endsWithCondition"
    /// </summary>
    [EnumMember(Value = "endsWithCondition")]
    Endswithcondition,

    /// <summary>
    /// Enum Equalcondition for "equalCondition"
    /// </summary>
    [EnumMember(Value = "equalCondition")]
    Equalcondition,

    /// <summary>
    /// Enum Journeyactionid for "journeyActionId"
    /// </summary>
    [EnumMember(Value = "journeyActionId")]
    Journeyactionid,

    /// <summary>
    /// Enum Journeyactionmapid for "journeyActionMapId"
    /// </summary>
    [EnumMember(Value = "journeyActionMapId")]
    Journeyactionmapid,

    /// <summary>
    /// Enum Journeyactionmapversion for "journeyActionMapVersion"
    /// </summary>
    [EnumMember(Value = "journeyActionMapVersion")]
    Journeyactionmapversion,

    /// <summary>
    /// Enum Journeyactionmediatype for "journeyActionMediaType"
    /// </summary>
    [EnumMember(Value = "journeyActionMediaType")]
    Journeyactionmediatype,

    /// <summary>
    /// Enum Journeyactiontargetid for "journeyActionTargetId"
    /// </summary>
    [EnumMember(Value = "journeyActionTargetId")]
    Journeyactiontargetid,

    /// <summary>
    /// Enum Journeyactiontemplateid for "journeyActionTemplateId"
    /// </summary>
    [EnumMember(Value = "journeyActionTemplateId")]
    Journeyactiontemplateid,

    /// <summary>
    /// Enum Journeyblockingactionmapid for "journeyBlockingActionMapId"
    /// </summary>
    [EnumMember(Value = "journeyBlockingActionMapId")]
    Journeyblockingactionmapid,

    /// <summary>
    /// Enum Journeyblockingemergencyschedulegroupid for "journeyBlockingEmergencyScheduleGroupId"
    /// </summary>
    [EnumMember(Value = "journeyBlockingEmergencyScheduleGroupId")]
    Journeyblockingemergencyschedulegroupid,

    /// <summary>
    /// Enum Journeyblockingreason for "journeyBlockingReason"
    /// </summary>
    [EnumMember(Value = "journeyBlockingReason")]
    Journeyblockingreason,

    /// <summary>
    /// Enum Journeyblockingschedulegroupid for "journeyBlockingScheduleGroupId"
    /// </summary>
    [EnumMember(Value = "journeyBlockingScheduleGroupId")]
    Journeyblockingschedulegroupid,

    /// <summary>
    /// Enum Journeydevicecategory for "journeyDeviceCategory"
    /// </summary>
    [EnumMember(Value = "journeyDeviceCategory")]
    Journeydevicecategory,

    /// <summary>
    /// Enum Journeydevicetype for "journeyDeviceType"
    /// </summary>
    [EnumMember(Value = "journeyDeviceType")]
    Journeydevicetype,

    /// <summary>
    /// Enum Journeyfrequencycapreason for "journeyFrequencyCapReason"
    /// </summary>
    [EnumMember(Value = "journeyFrequencyCapReason")]
    Journeyfrequencycapreason,

    /// <summary>
    /// Enum Journeyipgeolocationcountry for "journeyIpGeolocationCountry"
    /// </summary>
    [EnumMember(Value = "journeyIpGeolocationCountry")]
    Journeyipgeolocationcountry,

    /// <summary>
    /// Enum Journeyoutcomeid for "journeyOutcomeId"
    /// </summary>
    [EnumMember(Value = "journeyOutcomeId")]
    Journeyoutcomeid,

    /// <summary>
    /// Enum Journeysegmentid for "journeySegmentId"
    /// </summary>
    [EnumMember(Value = "journeySegmentId")]
    Journeysegmentid,

    /// <summary>
    /// Enum Journeysegmentscope for "journeySegmentScope"
    /// </summary>
    [EnumMember(Value = "journeySegmentScope")]
    Journeysegmentscope,

    /// <summary>
    /// Enum Journeysessionid for "journeySessionId"
    /// </summary>
    [EnumMember(Value = "journeySessionId")]
    Journeysessionid,

    /// <summary>
    /// Enum Journeysessionsegmentid for "journeySessionSegmentId"
    /// </summary>
    [EnumMember(Value = "journeySessionSegmentId")]
    Journeysessionsegmentid,

    /// <summary>
    /// Enum Journeysessiontype for "journeySessionType"
    /// </summary>
    [EnumMember(Value = "journeySessionType")]
    Journeysessiontype,

    /// <summary>
    /// Enum Notcontainsallcondition for "notContainsAllCondition"
    /// </summary>
    [EnumMember(Value = "notContainsAllCondition")]
    Notcontainsallcondition,

    /// <summary>
    /// Enum Notcontainsanycondition for "notContainsAnyCondition"
    /// </summary>
    [EnumMember(Value = "notContainsAnyCondition")]
    Notcontainsanycondition,

    /// <summary>
    /// Enum Notequalcondition for "notEqualCondition"
    /// </summary>
    [EnumMember(Value = "notEqualCondition")]
    Notequalcondition,

    /// <summary>
    /// Enum Startswithcondition for "startsWithCondition"
    /// </summary>
    [EnumMember(Value = "startsWithCondition")]
    Startswithcondition,

    /// <summary>
    /// Enum Touchpointactionmapid for "touchpointActionMapId"
    /// </summary>
    [EnumMember(Value = "touchpointActionMapId")]
    Touchpointactionmapid,

    /// <summary>
    /// Enum Touchpointagentid for "touchpointAgentId"
    /// </summary>
    [EnumMember(Value = "touchpointAgentId")]
    Touchpointagentid,

    /// <summary>
    /// Enum Touchpointattributionscope for "touchpointAttributionScope"
    /// </summary>
    [EnumMember(Value = "touchpointAttributionScope")]
    Touchpointattributionscope,

    /// <summary>
    /// Enum Touchpointchannelmessagetype for "touchpointChannelMessageType"
    /// </summary>
    [EnumMember(Value = "touchpointChannelMessageType")]
    Touchpointchannelmessagetype,

    /// <summary>
    /// Enum Touchpointchannelplatform for "touchpointChannelPlatform"
    /// </summary>
    [EnumMember(Value = "touchpointChannelPlatform")]
    Touchpointchannelplatform,

    /// <summary>
    /// Enum Touchpointchanneltype for "touchpointChannelType"
    /// </summary>
    [EnumMember(Value = "touchpointChannelType")]
    Touchpointchanneltype,

    /// <summary>
    /// Enum Touchpointconversationid for "touchpointConversationId"
    /// </summary>
    [EnumMember(Value = "touchpointConversationId")]
    Touchpointconversationid,

    /// <summary>
    /// Enum Touchpointinteractiontype for "touchpointInteractionType"
    /// </summary>
    [EnumMember(Value = "touchpointInteractionType")]
    Touchpointinteractiontype,

    /// <summary>
    /// Enum Touchpointqueueid for "touchpointQueueId"
    /// </summary>
    [EnumMember(Value = "touchpointQueueId")]
    Touchpointqueueid,

    /// <summary>
    /// Enum Touchpointrequestedrouting for "touchpointRequestedRouting"
    /// </summary>
    [EnumMember(Value = "touchpointRequestedRouting")]
    Touchpointrequestedrouting,

    /// <summary>
    /// Enum Touchpointusedrouting for "touchpointUsedRouting"
    /// </summary>
    [EnumMember(Value = "touchpointUsedRouting")]
    Touchpointusedrouting,

    /// <summary>
    /// Enum Touchpointwrapupcode for "touchpointWrapupCode"
    /// </summary>
    [EnumMember(Value = "touchpointWrapupCode")]
    Touchpointwrapupcode
}
