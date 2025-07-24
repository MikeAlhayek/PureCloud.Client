using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TermParticipantTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Internal for "Internal"
    /// </summary>
    [EnumMember(Value = "Internal")]
    Internal,

    /// <summary>
    /// Enum External for "External"
    /// </summary>
    [EnumMember(Value = "External")]
    External,

    /// <summary>
    /// Enum Both for "Both"
    /// </summary>
    [EnumMember(Value = "Both")]
    Both
}
