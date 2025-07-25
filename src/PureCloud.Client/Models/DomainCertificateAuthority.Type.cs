using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DomainCertificateAuthorityType
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "MANAGED")]
    Managed,

    [EnumMember(Value = "REMOTE")]
    Remote
}