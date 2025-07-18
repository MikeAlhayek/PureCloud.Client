using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// type of the artifact
/// </summary>
/// <value>type of the artifact</value>

public enum AcceleratorSpecificationTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Module for "Module"
    /// </summary>
    [EnumMember(Value = "Module")]
    Module,

    /// <summary>
    /// Enum Accelerator for "Accelerator"
    /// </summary>
    [EnumMember(Value = "Accelerator")]
    Accelerator,

    /// <summary>
    /// Enum Blueprint for "Blueprint"
    /// </summary>
    [EnumMember(Value = "Blueprint")]
    Blueprint
}
