using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Locations;

namespace PureCloud.Client.Models.Locations;

/// <summary>
/// LocationsSearchResponse
/// </summary>

public sealed class LocationsSearchResponse
{
    /// <summary>
    /// The total number of results found
    /// </summary>
    /// <value>The total number of results found</value>
    public long? Total { get; set; }



    /// <summary>
    /// The total number of pages
    /// </summary>
    /// <value>The total number of pages</value>    
    public int? PageCount { get; set; }



    /// <summary>
    /// The current page size
    /// </summary>
    /// <value>The current page size</value>
    public int? PageSize { get; set; }



    /// <summary>
    /// The current page number
    /// </summary>
    /// <value>The current page number</value>
    public int? PageNumber { get; set; }



    /// <summary>
    /// Q64 value for the previous page of results
    /// </summary>
    /// <value>Q64 value for the previous page of results</value>
    public string PreviousPage { get; set; }



    /// <summary>
    /// Q64 value for the current page of results
    /// </summary>
    /// <value>Q64 value for the current page of results</value>
    public string CurrentPage { get; set; }



    /// <summary>
    /// Q64 value for the next page of results
    /// </summary>
    /// <value>Q64 value for the next page of results</value>
    public string NextPage { get; set; }



    /// <summary>
    /// Resource types the search was performed against
    /// </summary>
    /// <value>Resource types the search was performed against</value>
    public IEnumerable<string> Types { get; set; }



    /// <summary>
    /// Search results
    /// </summary>
    /// <value>Search results</value>
    public IEnumerable<LocationDefinition> Results { get; set; }
}
