using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AuthorizationPolicyEffectEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Allow for "ALLOW"
    /// </summary>
    [EnumMember(Value = "ALLOW")]
    Allow,

    /// <summary>
    /// Enum Deny for "DENY"
    /// </summary>
    [EnumMember(Value = "DENY")]
    Deny
}
