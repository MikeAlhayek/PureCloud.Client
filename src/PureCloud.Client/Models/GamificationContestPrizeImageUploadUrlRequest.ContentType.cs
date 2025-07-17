using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum GamificationContestPrizeImageUploadUrlRequestContentTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Jpeg for "image/jpeg"
    /// </summary>
    [EnumMember(Value = "image/jpeg")]
    Jpeg,

    /// <summary>
    /// Enum Jpg for "image/jpg"
    /// </summary>
    [EnumMember(Value = "image/jpg")]
    Jpg,

    /// <summary>
    /// Enum Png for "image/png"
    /// </summary>
    [EnumMember(Value = "image/png")]
    Png
}
