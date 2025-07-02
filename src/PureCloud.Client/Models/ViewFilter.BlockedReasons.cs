using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets BlockedReasons
/// </summary>

public enum ViewFilterBlockedReasonsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pageurlconditionsnotmatching for "PageUrlConditionsNotMatching"
    /// </summary>
    [EnumMember(Value = "PageUrlConditionsNotMatching")]
    Pageurlconditionsnotmatching,

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
    /// Enum Frequencycapping for "FrequencyCapping"
    /// </summary>
    [EnumMember(Value = "FrequencyCapping")]
    Frequencycapping,

    /// <summary>
    /// Enum Offeredoutsideschedule for "OfferedOutsideSchedule"
    /// </summary>
    [EnumMember(Value = "OfferedOutsideSchedule")]
    Offeredoutsideschedule,

    /// <summary>
    /// Enum Servicelevelthrottling for "ServiceLevelThrottling"
    /// </summary>
    [EnumMember(Value = "ServiceLevelThrottling")]
    Servicelevelthrottling,

    /// <summary>
    /// Enum Noavailableagents for "NoAvailableAgents"
    /// </summary>
    [EnumMember(Value = "NoAvailableAgents")]
    Noavailableagents
}
