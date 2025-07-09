using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum NamedEntityTypeMechanismTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ai for "AI"
    /// </summary>
    [EnumMember(Value = "AI")]
    Ai,

    /// <summary>
    /// Enum Dynamicdatetime for "DynamicDateTime"
    /// </summary>
    [EnumMember(Value = "DynamicDateTime")]
    Dynamicdatetime,

    /// <summary>
    /// Enum Dynamiclist for "DynamicList"
    /// </summary>
    [EnumMember(Value = "DynamicList")]
    Dynamiclist,

    /// <summary>
    /// Enum List for "List"
    /// </summary>
    [EnumMember(Value = "List")]
    List,

    /// <summary>
    /// Enum Regex for "Regex"
    /// </summary>
    [EnumMember(Value = "Regex")]
    Regex,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
