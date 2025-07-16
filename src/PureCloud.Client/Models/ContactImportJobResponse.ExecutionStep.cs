using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Detailed description for the Job execution state
/// </summary>
/// <value>Detailed description for the Job execution state</value>

public enum ContactImportJobResponseExecutionStepEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Validating for "Validating"
    /// </summary>
    [EnumMember(Value = "Validating")]
    Validating,

    /// <summary>
    /// Enum Validated for "Validated"
    /// </summary>
    [EnumMember(Value = "Validated")]
    Validated,

    /// <summary>
    /// Enum Importing for "Importing"
    /// </summary>
    [EnumMember(Value = "Importing")]
    Importing
}
