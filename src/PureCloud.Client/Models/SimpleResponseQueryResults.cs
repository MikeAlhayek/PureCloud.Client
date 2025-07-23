namespace PureCloud.Client.Models;

/// <summary>
/// Simplified Response Query Results for Response Management API
/// </summary>
public sealed class SimpleResponseQueryResults
{
    public IEnumerable<Response> Results { get; set; } = new List<Response>();

    public int? PageCount { get; set; }

    public int? PageSize { get; set; }

    public int? PageNumber { get; set; }

    public string PreviousPage { get; set; }

    public string CurrentPage { get; set; }

    public string NextPage { get; set; }

    public IEnumerable<string> Types { get; set; } = new List<string>();

    public IEnumerable<object> Aggregations { get; set; } = new List<object>();
}