using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AuditLogMessageLevelEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum User for "USER"
    /// </summary>
    [EnumMember(Value = "USER")]
    User,

    /// <summary>
    /// Enum System for "SYSTEM"
    /// </summary>
    [EnumMember(Value = "SYSTEM")]
    System,

    /// <summary>
    /// Enum GenesysInternal for "GENESYS_INTERNAL"
    /// </summary>
    [EnumMember(Value = "GENESYS_INTERNAL")]
    GenesysInternal
}
