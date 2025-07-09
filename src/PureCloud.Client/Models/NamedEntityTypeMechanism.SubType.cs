using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Subtype of detection mechanism
/// </summary>
/// <value>Subtype of detection mechanism</value>

public enum NamedEntityTypeMechanismSubTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Alphanumeric for "Alphanumeric"
    /// </summary>
    [EnumMember(Value = "Alphanumeric")]
    Alphanumeric,

    /// <summary>
    /// Enum Numbersequence for "NumberSequence"
    /// </summary>
    [EnumMember(Value = "NumberSequence")]
    Numbersequence,

    /// <summary>
    /// Enum Freeform for "FreeForm"
    /// </summary>
    [EnumMember(Value = "FreeForm")]
    Freeform
}
