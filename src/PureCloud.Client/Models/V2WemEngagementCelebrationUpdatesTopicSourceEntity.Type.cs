using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2WemEngagementCelebrationUpdatesTopicSourceEntityTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum ThankYou for "THANK_YOU"
    /// </summary>
    [EnumMember(Value = "THANK_YOU")]
    ThankYou,

    /// <summary>
    /// Enum Congratulations for "CONGRATULATIONS"
    /// </summary>
    [EnumMember(Value = "CONGRATULATIONS")]
    Congratulations,

    /// <summary>
    /// Enum HighPerformance for "HIGH_PERFORMANCE"
    /// </summary>
    [EnumMember(Value = "HIGH_PERFORMANCE")]
    HighPerformance,

    /// <summary>
    /// Enum CompanyValues for "COMPANY_VALUES"
    /// </summary>
    [EnumMember(Value = "COMPANY_VALUES")]
    CompanyValues,

    /// <summary>
    /// Enum Competition for "COMPETITION"
    /// </summary>
    [EnumMember(Value = "COMPETITION")]
    Competition,

    /// <summary>
    /// Enum Race for "RACE"
    /// </summary>
    [EnumMember(Value = "RACE")]
    Race,

    /// <summary>
    /// Enum Raffle for "RAFFLE"
    /// </summary>
    [EnumMember(Value = "RAFFLE")]
    Raffle,

    /// <summary>
    /// Enum TeamGoal for "TEAM_GOAL"
    /// </summary>
    [EnumMember(Value = "TEAM_GOAL")]
    TeamGoal
}
