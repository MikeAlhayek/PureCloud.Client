using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Sorting of results based on time
/// </summary>
public enum SocialMediaAsyncDetailQueryOrder
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Asc for "asc"
    /// </summary>
    [EnumMember(Value = "asc")]
    Asc,

    /// <summary>
    /// Enum Desc for "desc"
    /// </summary>
    [EnumMember(Value = "desc")]
    Desc
}