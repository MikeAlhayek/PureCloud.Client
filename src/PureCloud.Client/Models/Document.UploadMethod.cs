using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets UploadMethod
/// </summary>

public enum DocumentUploadMethodEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum SinglePut for "SINGLE_PUT"
    /// </summary>
    [EnumMember(Value = "SINGLE_PUT")]
    SinglePut,

    /// <summary>
    /// Enum MultipartPost for "MULTIPART_POST"
    /// </summary>
    [EnumMember(Value = "MULTIPART_POST")]
    MultipartPost
}
