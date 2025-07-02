using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum JourneyAggregationViewTargetEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ndistinctjourneyactions for "nDistinctJourneyActions"
    /// </summary>
    [EnumMember(Value = "nDistinctJourneyActions")]
    Ndistinctjourneyactions,

    /// <summary>
    /// Enum Ndistinctjourneysessions for "nDistinctJourneySessions"
    /// </summary>
    [EnumMember(Value = "nDistinctJourneySessions")]
    Ndistinctjourneysessions,

    /// <summary>
    /// Enum Njourneyactionsblocked for "nJourneyActionsBlocked"
    /// </summary>
    [EnumMember(Value = "nJourneyActionsBlocked")]
    Njourneyactionsblocked,

    /// <summary>
    /// Enum Njourneyoutcomesachieved for "nJourneyOutcomesAchieved"
    /// </summary>
    [EnumMember(Value = "nJourneyOutcomesAchieved")]
    Njourneyoutcomesachieved,

    /// <summary>
    /// Enum Njourneyoutcomesattributed for "nJourneyOutcomesAttributed"
    /// </summary>
    [EnumMember(Value = "nJourneyOutcomesAttributed")]
    Njourneyoutcomesattributed,

    /// <summary>
    /// Enum Njourneysegmentsassigned for "nJourneySegmentsAssigned"
    /// </summary>
    [EnumMember(Value = "nJourneySegmentsAssigned")]
    Njourneysegmentsassigned,

    /// <summary>
    /// Enum Njourneysessions for "nJourneySessions"
    /// </summary>
    [EnumMember(Value = "nJourneySessions")]
    Njourneysessions,

    /// <summary>
    /// Enum Nwebactionsabandoned for "nWebActionsAbandoned"
    /// </summary>
    [EnumMember(Value = "nWebActionsAbandoned")]
    Nwebactionsabandoned,

    /// <summary>
    /// Enum Nwebactionsaccepted for "nWebActionsAccepted"
    /// </summary>
    [EnumMember(Value = "nWebActionsAccepted")]
    Nwebactionsaccepted,

    /// <summary>
    /// Enum Nwebactionsengaged for "nWebActionsEngaged"
    /// </summary>
    [EnumMember(Value = "nWebActionsEngaged")]
    Nwebactionsengaged,

    /// <summary>
    /// Enum Nwebactionserrored for "nWebActionsErrored"
    /// </summary>
    [EnumMember(Value = "nWebActionsErrored")]
    Nwebactionserrored,

    /// <summary>
    /// Enum Nwebactionsfrequencycapreached for "nWebActionsFrequencyCapReached"
    /// </summary>
    [EnumMember(Value = "nWebActionsFrequencyCapReached")]
    Nwebactionsfrequencycapreached,

    /// <summary>
    /// Enum Nwebactionsignored for "nWebActionsIgnored"
    /// </summary>
    [EnumMember(Value = "nWebActionsIgnored")]
    Nwebactionsignored,

    /// <summary>
    /// Enum Nwebactionsoffered for "nWebActionsOffered"
    /// </summary>
    [EnumMember(Value = "nWebActionsOffered")]
    Nwebactionsoffered,

    /// <summary>
    /// Enum Nwebactionsofferedoutsideschedule for "nWebActionsOfferedOutsideSchedule"
    /// </summary>
    [EnumMember(Value = "nWebActionsOfferedOutsideSchedule")]
    Nwebactionsofferedoutsideschedule,

    /// <summary>
    /// Enum Nwebactionsqualified for "nWebActionsQualified"
    /// </summary>
    [EnumMember(Value = "nWebActionsQualified")]
    Nwebactionsqualified,

    /// <summary>
    /// Enum Nwebactionsqualifiedoutsideschedule for "nWebActionsQualifiedOutsideSchedule"
    /// </summary>
    [EnumMember(Value = "nWebActionsQualifiedOutsideSchedule")]
    Nwebactionsqualifiedoutsideschedule,

    /// <summary>
    /// Enum Nwebactionsrejected for "nWebActionsRejected"
    /// </summary>
    [EnumMember(Value = "nWebActionsRejected")]
    Nwebactionsrejected,

    /// <summary>
    /// Enum Nwebactionsstarted for "nWebActionsStarted"
    /// </summary>
    [EnumMember(Value = "nWebActionsStarted")]
    Nwebactionsstarted,

    /// <summary>
    /// Enum Nwebactionstimedout for "nWebActionsTimedout"
    /// </summary>
    [EnumMember(Value = "nWebActionsTimedout")]
    Nwebactionstimedout,

    /// <summary>
    /// Enum Ojourneyoutcometouchpointvalue for "oJourneyOutcomeTouchpointValue"
    /// </summary>
    [EnumMember(Value = "oJourneyOutcomeTouchpointValue")]
    Ojourneyoutcometouchpointvalue,

    /// <summary>
    /// Enum Ojourneyoutcomevalue for "oJourneyOutcomeValue"
    /// </summary>
    [EnumMember(Value = "oJourneyOutcomeValue")]
    Ojourneyoutcomevalue
}
