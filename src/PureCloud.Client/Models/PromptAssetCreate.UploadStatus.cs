using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum PromptAssetCreateUploadStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Created for "created"
    /// </summary>
    [EnumMember(Value = "created")]
    Created,

    /// <summary>
    /// Enum Uploaded for "uploaded"
    /// </summary>
    [EnumMember(Value = "uploaded")]
    Uploaded,

    /// <summary>
    /// Enum Transcoded for "transcoded"
    /// </summary>
    [EnumMember(Value = "transcoded")]
    Transcoded,

    /// <summary>
    /// Enum Transcodefailed for "transcodeFailed"
    /// </summary>
    [EnumMember(Value = "transcodeFailed")]
    Transcodefailed
}
