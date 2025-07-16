using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContactEnrichRequestActionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Merge for "Merge"
    /// </summary>
    [EnumMember(Value = "Merge")]
    Merge,

    /// <summary>
    /// Enum Upsert for "Upsert"
    /// </summary>
    [EnumMember(Value = "Upsert")]
    Upsert,

    /// <summary>
    /// Enum Update for "Update"
    /// </summary>
    [EnumMember(Value = "Update")]
    Update,

    /// <summary>
    /// Enum Insert for "Insert"
    /// </summary>
    [EnumMember(Value = "Insert")]
    Insert
}
