using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum NluDomainVersionTrainingStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Untrained for "Untrained"
    /// </summary>
    [EnumMember(Value = "Untrained")]
    Untrained,

    /// <summary>
    /// Enum Training for "Training"
    /// </summary>
    [EnumMember(Value = "Training")]
    Training,

    /// <summary>
    /// Enum Trained for "Trained"
    /// </summary>
    [EnumMember(Value = "Trained")]
    Trained,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
