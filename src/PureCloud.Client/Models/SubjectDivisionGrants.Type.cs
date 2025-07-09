using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum SubjectDivisionGrantsTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum PcUser for "PC_USER"
    /// </summary>
    [EnumMember(Value = "PC_USER")]
    PcUser,

    /// <summary>
    /// Enum PcGroup for "PC_GROUP"
    /// </summary>
    [EnumMember(Value = "PC_GROUP")]
    PcGroup,

    /// <summary>
    /// Enum PcOauthClient for "PC_OAUTH_CLIENT"
    /// </summary>
    [EnumMember(Value = "PC_OAUTH_CLIENT")]
    PcOauthClient,

    /// <summary>
    /// Enum PcTrusteeUser for "PC_TRUSTEE_USER"
    /// </summary>
    [EnumMember(Value = "PC_TRUSTEE_USER")]
    PcTrusteeUser,

    /// <summary>
    /// Enum PcTrusteeGroup for "PC_TRUSTEE_GROUP"
    /// </summary>
    [EnumMember(Value = "PC_TRUSTEE_GROUP")]
    PcTrusteeGroup,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
