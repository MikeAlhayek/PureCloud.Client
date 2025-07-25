using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EdgeStatusCode
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "NEW")]
    New,

    [EnumMember(Value = "AWAITING_CONNECTION")]
    AwaitingConnection,

    [EnumMember(Value = "AWAITING_FINGERPRINT")]
    AwaitingFingerprint,

    [EnumMember(Value = "AWAITING_FINGERPRINT_VERIFICATION")]
    AwaitingFingerprintVerification,

    [EnumMember(Value = "FINGERPRINT_VERIFIED")]
    FingerprintVerified,

    [EnumMember(Value = "AWAITING_BOOTSTRAP")]
    AwaitingBootstrap,

    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "INACTIVE")]
    Inactive,

    [EnumMember(Value = "RMA")]
    Rma,

    [EnumMember(Value = "UNPAIRING")]
    Unpairing,

    [EnumMember(Value = "UNPAIRED")]
    Unpaired,

    [EnumMember(Value = "INITIALIZING")]
    Initializing
}