using System.Collections.Generic;

namespace PureCloud.Client.Models.Locations;

public sealed class LocationSearchRequest
{
    public string SortOrder { get; set; }
    public string SortBy { get; set; }
    public int? PageSize { get; set; }
    public int? PageNumber { get; set; }
    public IEnumerable<SearchSort> Sort { get; set; }
    public IEnumerable<string> Expand { get; set; }
    public IEnumerable<LocationSearchCriteria> Query { get; set; }
}
