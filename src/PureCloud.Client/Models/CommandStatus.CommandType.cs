using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets CommandType
/// </summary>

public enum CommandStatusCommandTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Upload for "UPLOAD"
    /// </summary>
    [EnumMember(Value = "UPLOAD")]
    Upload,

    /// <summary>
    /// Enum Copydocument for "COPYDOCUMENT"
    /// </summary>
    [EnumMember(Value = "COPYDOCUMENT")]
    Copydocument,

    /// <summary>
    /// Enum Movedocument for "MOVEDOCUMENT"
    /// </summary>
    [EnumMember(Value = "MOVEDOCUMENT")]
    Movedocument,

    /// <summary>
    /// Enum Deleteworkspace for "DELETEWORKSPACE"
    /// </summary>
    [EnumMember(Value = "DELETEWORKSPACE")]
    Deleteworkspace,

    /// <summary>
    /// Enum Deletedocument for "DELETEDOCUMENT"
    /// </summary>
    [EnumMember(Value = "DELETEDOCUMENT")]
    Deletedocument,

    /// <summary>
    /// Enum Deletetag for "DELETETAG"
    /// </summary>
    [EnumMember(Value = "DELETETAG")]
    Deletetag,

    /// <summary>
    /// Enum Updatetag for "UPDATETAG"
    /// </summary>
    [EnumMember(Value = "UPDATETAG")]
    Updatetag,

    /// <summary>
    /// Enum Reindex for "REINDEX"
    /// </summary>
    [EnumMember(Value = "REINDEX")]
    Reindex,

    /// <summary>
    /// Enum Cleanup for "CLEANUP"
    /// </summary>
    [EnumMember(Value = "CLEANUP")]
    Cleanup,

    /// <summary>
    /// Enum Replacedocument for "REPLACEDOCUMENT"
    /// </summary>
    [EnumMember(Value = "REPLACEDOCUMENT")]
    Replacedocument
}
