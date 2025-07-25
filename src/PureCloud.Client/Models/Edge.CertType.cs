using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EdgeCertType
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "PureCloud")]
    Purecloud,

    [EnumMember(Value = "Public")]
    Public,

    [EnumMember(Value = "China")]
    China,

    [EnumMember(Value = "NotRequested")]
    Notrequested
}