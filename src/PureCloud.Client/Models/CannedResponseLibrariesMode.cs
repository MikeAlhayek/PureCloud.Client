using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CannedResponseLibrariesMode
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All,

    /// <summary>
    /// Enum Selectedonly for "SelectedOnly"
    /// </summary>
    [EnumMember(Value = "SelectedOnly")]
    Selectedonly,

    /// <summary>
    /// Enum None for "None"
    /// </summary>
    [EnumMember(Value = "None")]
    None
}
