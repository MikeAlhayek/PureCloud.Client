using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EdgeOnlineStatus
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "ONLINE")]
    Online,

    [EnumMember(Value = "OFFLINE")]
    Offline
}