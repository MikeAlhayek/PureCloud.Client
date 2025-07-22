using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum VoicemailSearchRequestSortOrder
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc,

    [EnumMember(Value = "SCORE")]
    Score
}
