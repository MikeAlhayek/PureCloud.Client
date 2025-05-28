using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CopilotNluEngineTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Nluv3 for "NluV3"
    /// </summary>
    [EnumMember(Value = "NluV3")]
    Nluv3
}
