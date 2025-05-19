using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets AlertTypes
/// </summary>

public enum KlaxonInteractionStatsRulesTopicInteractionStatRuleAlertTypesEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Sms for "SMS"
    /// </summary>
    [EnumMember(Value = "SMS")]
    Sms,

    /// <summary>
    /// Enum Device for "DEVICE"
    /// </summary>
    [EnumMember(Value = "DEVICE")]
    Device,

    /// <summary>
    /// Enum Email for "EMAIL"
    /// </summary>
    [EnumMember(Value = "EMAIL")]
    Email
}
