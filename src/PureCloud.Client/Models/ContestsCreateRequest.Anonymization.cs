using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The Contest anonymization
/// </summary>
/// <value>The Contest anonymization</value>

public enum ContestsCreateRequestAnonymizationEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Noanonymization for "NoAnonymization"
    /// </summary>
    [EnumMember(Value = "NoAnonymization")]
    Noanonymization,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All,

    /// <summary>
    /// Enum Allexcepttop for "AllExceptTop"
    /// </summary>
    [EnumMember(Value = "AllExceptTop")]
    Allexcepttop
}
