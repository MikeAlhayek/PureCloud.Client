using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Media model for the current site.
/// </summary>
/// <value>Media model for the current site.</value>

public enum SiteConnectionMediaModelEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Premises for "Premises"
    /// </summary>
    [EnumMember(Value = "Premises")]
    Premises,

    /// <summary>
    /// Enum Cloud for "Cloud"
    /// </summary>
    [EnumMember(Value = "Cloud")]
    Cloud
}
