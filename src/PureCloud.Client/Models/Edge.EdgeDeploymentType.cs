using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EdgeDeploymentType
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "HARDWARE")]
    Hardware,

    [EnumMember(Value = "LDM")]
    Ldm,

    [EnumMember(Value = "CDM")]
    Cdm,

    [EnumMember(Value = "CHS")]
    Chs,

    [EnumMember(Value = "INVALID")]
    Invalid
}