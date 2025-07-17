using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ExternalMetricDefinitionUpdateRequestDefaultObjectiveTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Higherisbetter for "HigherIsBetter"
    /// </summary>
    [EnumMember(Value = "HigherIsBetter")]
    Higherisbetter,

    /// <summary>
    /// Enum Lowerisbetter for "LowerIsBetter"
    /// </summary>
    [EnumMember(Value = "LowerIsBetter")]
    Lowerisbetter,

    /// <summary>
    /// Enum Targetarea for "TargetArea"
    /// </summary>
    [EnumMember(Value = "TargetArea")]
    Targetarea
}
