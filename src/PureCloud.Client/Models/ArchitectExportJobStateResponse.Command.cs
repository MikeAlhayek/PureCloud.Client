using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The command executed by the Architect Job
/// </summary>
/// <value>The command executed by the Architect Job</value>

public enum ArchitectExportJobStateResponseCommandEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Publish for "Publish"
    /// </summary>
    [EnumMember(Value = "Publish")]
    Publish,

    /// <summary>
    /// Enum Create for "Create"
    /// </summary>
    [EnumMember(Value = "Create")]
    Create,

    /// <summary>
    /// Enum Update for "Update"
    /// </summary>
    [EnumMember(Value = "Update")]
    Update,

    /// <summary>
    /// Enum Export for "Export"
    /// </summary>
    [EnumMember(Value = "Export")]
    Export
}
