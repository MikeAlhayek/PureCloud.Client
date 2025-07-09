using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DependencyStatusStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Buildincomplete for "BUILDINCOMPLETE"
    /// </summary>
    [EnumMember(Value = "BUILDINCOMPLETE")]
    Buildincomplete,

    /// <summary>
    /// Enum Buildinitializing for "BUILDINITIALIZING"
    /// </summary>
    [EnumMember(Value = "BUILDINITIALIZING")]
    Buildinitializing,

    /// <summary>
    /// Enum Buildinprogress for "BUILDINPROGRESS"
    /// </summary>
    [EnumMember(Value = "BUILDINPROGRESS")]
    Buildinprogress,

    /// <summary>
    /// Enum Notbuilt for "NOTBUILT"
    /// </summary>
    [EnumMember(Value = "NOTBUILT")]
    Notbuilt,

    /// <summary>
    /// Enum Operational for "OPERATIONAL"
    /// </summary>
    [EnumMember(Value = "OPERATIONAL")]
    Operational,

    /// <summary>
    /// Enum Operationalneedsrebuild for "OPERATIONALNEEDSREBUILD"
    /// </summary>
    [EnumMember(Value = "OPERATIONALNEEDSREBUILD")]
    Operationalneedsrebuild
}
