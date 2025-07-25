using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DIDPoolProvider
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "PURE_CLOUD")]
    Cloud,

    [EnumMember(Value = "PURE_CLOUD_VOICE")]
    CloudVoice
}