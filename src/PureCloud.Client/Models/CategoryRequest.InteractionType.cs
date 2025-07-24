using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of interaction the category will apply to
/// </summary>
/// <value>The type of interaction the category will apply to</value>
public enum CategoryRequestInteractionType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Voice for "Voice"
    /// </summary>
    [EnumMember(Value = "Voice")]
    Voice,

    /// <summary>
    /// Enum Digital for "Digital"
    /// </summary>
    [EnumMember(Value = "Digital")]
    Digital,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All
}