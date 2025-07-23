namespace PureCloud.Client.Models;

/// <summary>
/// Simplified Library Entity Listing for Response Management API
/// </summary>
public sealed class SimpleLibraryEntityListing
{
    public IEnumerable<Library> Entities { get; set; } = new List<Library>();

    public int? PageSize { get; set; }

    public int? PageNumber { get; set; }

    public long? Total { get; set; }

    public int? PageCount { get; set; }

    public string SelfUri { get; set; }

    public string FirstUri { get; set; }

    public string LastUri { get; set; }

    public string NextUri { get; set; }

    public string PreviousUri { get; set; }
}