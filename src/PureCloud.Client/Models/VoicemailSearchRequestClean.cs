using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public sealed class VoicemailSearchRequestClean
{
    public VoicemailSearchRequestSortOrder? SortOrder { get; set; }
    public string SortBy { get; set; }
    public int? PageSize { get; set; }
    public int? PageNumber { get; set; }
    public IEnumerable<string> Expand { get; set; }
}

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