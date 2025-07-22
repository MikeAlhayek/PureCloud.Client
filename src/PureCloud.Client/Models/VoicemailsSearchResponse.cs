namespace PureCloud.Client.Models;

public sealed class VoicemailsSearchResponse
{
    public long? Total { get; set; }

    public int? PageCount { get; set; }

    public int? PageSize { get; set; }

    public int? PageNumber { get; set; }

    public string PreviousPage { get; set; }

    public string CurrentPage { get; set; }

    public string NextPage { get; set; }

    public IEnumerable<string> Types { get; set; }

    public IEnumerable<VoicemailMessage> Results { get; set; }
}
