using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EdgeCallDrainingState
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "NONE")]
    None,

    [EnumMember(Value = "WAIT")]
    Wait,

    [EnumMember(Value = "WAIT_TIMEOUT")]
    WaitTimeout,

    [EnumMember(Value = "TERMINATE")]
    Terminate,

    [EnumMember(Value = "COMPLETE")]
    Complete
}