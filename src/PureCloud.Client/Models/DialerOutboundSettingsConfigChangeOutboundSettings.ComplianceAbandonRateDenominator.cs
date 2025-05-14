using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerOutboundSettingsConfigChangeOutboundSettingsComplianceAbandonRateDenominatorEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum AllCalls for "ALL_CALLS"
    /// </summary>
    [EnumMember(Value = "ALL_CALLS")]
    AllCalls,

    /// <summary>
    /// Enum CallsThatReachedQueue for "CALLS_THAT_REACHED_QUEUE"
    /// </summary>
    [EnumMember(Value = "CALLS_THAT_REACHED_QUEUE")]
    CallsThatReachedQueue
}
