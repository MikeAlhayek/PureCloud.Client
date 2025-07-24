using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The Sentiment Trend Class
/// </summary>
/// <value>The Sentiment Trend Class</value>
public enum ConversationMetricsSentimentTrendClass
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Notcalculated for "NotCalculated"
    /// </summary>
    [EnumMember(Value = "NotCalculated")]
    Notcalculated,

    /// <summary>
    /// Enum Declining for "Declining"
    /// </summary>
    [EnumMember(Value = "Declining")]
    Declining,

    /// <summary>
    /// Enum Slightlydeclining for "SlightlyDeclining"
    /// </summary>
    [EnumMember(Value = "SlightlyDeclining")]
    Slightlydeclining,

    /// <summary>
    /// Enum Nochange for "NoChange"
    /// </summary>
    [EnumMember(Value = "NoChange")]
    Nochange,

    /// <summary>
    /// Enum Slightlyimproving for "SlightlyImproving"
    /// </summary>
    [EnumMember(Value = "SlightlyImproving")]
    Slightlyimproving,

    /// <summary>
    /// Enum Improving for "Improving"
    /// </summary>
    [EnumMember(Value = "Improving")]
    Improving
}