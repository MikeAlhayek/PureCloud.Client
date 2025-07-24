using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum StateEnum
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "inactive")]
    Inactive,

    [EnumMember(Value = "deleted")]
    Deleted
}