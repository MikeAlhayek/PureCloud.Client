namespace PureCloud.Client.Models;

public sealed class SearchSort
{
    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    public SortOrderType? SortOrder { get; set; }

    /// <summary>
    /// The field in the resource that you want to sort the results by
    /// </summary>
    /// <value>The field in the resource that you want to sort the results by</value>
    public string SortBy { get; set; }
}
