using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum LockInfoActionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Update for "UPDATE"
    /// </summary>
    [EnumMember(Value = "UPDATE")]
    Update,

    /// <summary>
    /// Enum Delete for "DELETE"
    /// </summary>
    [EnumMember(Value = "DELETE")]
    Delete,

    /// <summary>
    /// Enum Copy for "COPY"
    /// </summary>
    [EnumMember(Value = "COPY")]
    Copy,

    /// <summary>
    /// Enum Move for "MOVE"
    /// </summary>
    [EnumMember(Value = "MOVE")]
    Move,

    /// <summary>
    /// Enum Replace for "REPLACE"
    /// </summary>
    [EnumMember(Value = "REPLACE")]
    Replace,

    /// <summary>
    /// Enum Thumbnail for "THUMBNAIL"
    /// </summary>
    [EnumMember(Value = "THUMBNAIL")]
    Thumbnail,

    /// <summary>
    /// Enum TextExtraction for "TEXT_EXTRACTION"
    /// </summary>
    [EnumMember(Value = "TEXT_EXTRACTION")]
    TextExtraction
}
