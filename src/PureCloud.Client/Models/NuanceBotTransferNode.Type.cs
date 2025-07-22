using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum NuanceBotTransferNodeTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum End for "End"
    /// </summary>
    [EnumMember(Value = "End")]
    End,

    /// <summary>
    /// Enum Escalate for "Escalate"
    /// </summary>
    [EnumMember(Value = "Escalate")]
    Escalate
}
