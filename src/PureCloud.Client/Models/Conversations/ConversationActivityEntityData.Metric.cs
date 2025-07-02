using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConversationActivityEntityDataMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Oalerting for "oAlerting"
    /// </summary>
    [EnumMember(Value = "oAlerting")]
    Oalerting,

    /// <summary>
    /// Enum Ointeracting for "oInteracting"
    /// </summary>
    [EnumMember(Value = "oInteracting")]
    Ointeracting,

    /// <summary>
    /// Enum Owaiting for "oWaiting"
    /// </summary>
    [EnumMember(Value = "oWaiting")]
    Owaiting
}
