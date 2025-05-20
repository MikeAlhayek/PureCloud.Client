using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WfmUserNotificationTopicWfmUserNotificationTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Shifttrade for "ShiftTrade"
    /// </summary>
    [EnumMember(Value = "ShiftTrade")]
    Shifttrade,

    /// <summary>
    /// Enum Timeoffrequest for "TimeOffRequest"
    /// </summary>
    [EnumMember(Value = "TimeOffRequest")]
    Timeoffrequest,

    /// <summary>
    /// Enum Adherenceexplanation for "AdherenceExplanation"
    /// </summary>
    [EnumMember(Value = "AdherenceExplanation")]
    Adherenceexplanation,

    /// <summary>
    /// Enum Alternativeshift for "AlternativeShift"
    /// </summary>
    [EnumMember(Value = "AlternativeShift")]
    Alternativeshift
}
