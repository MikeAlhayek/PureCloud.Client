using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DomainCertificateAuthorityServices
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "SIP")]
    Sip,

    [EnumMember(Value = "PROVISION")]
    Provision,

    [EnumMember(Value = "PROVISION_PHONE")]
    ProvisionPhone
}