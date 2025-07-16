using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EnrichFieldRulesDefaultActionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Alwaysuseprovided for "AlwaysUseProvided"
    /// </summary>
    [EnumMember(Value = "AlwaysUseProvided")]
    Alwaysuseprovided,

    /// <summary>
    /// Enum Preferexisting for "PreferExisting"
    /// </summary>
    [EnumMember(Value = "PreferExisting")]
    Preferexisting,

    /// <summary>
    /// Enum Preferprovided for "PreferProvided"
    /// </summary>
    [EnumMember(Value = "PreferProvided")]
    Preferprovided
}
