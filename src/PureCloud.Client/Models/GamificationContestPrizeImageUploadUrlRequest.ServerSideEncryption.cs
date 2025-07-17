using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets ServerSideEncryption
/// </summary>

public enum GamificationContestPrizeImageUploadUrlRequestServerSideEncryptionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Aes256 for "AES256"
    /// </summary>
    [EnumMember(Value = "AES256")]
    Aes256
}
