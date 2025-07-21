namespace PureCloud.Client.Models;

public sealed class VoicemailSearchRequest
{
    public VoicemailSearchRequestSortOrder? SortOrder { get; set; }

    public string SortBy { get; set; }

    public int? PageSize { get; set; }

    public int? PageNumber { get; set; }

    public IEnumerable<string> Expand { get; set; }
}
