using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GroupsSearchResponse
/// </summary>

public partial class GroupsSearchResponse : IEquatable<GroupsSearchResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="GroupsSearchResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GroupsSearchResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GroupsSearchResponse" /> class.
    /// </summary>
    /// <param name="Total">The total number of results found (required).</param>
    /// <param name="PageCount">The total number of pages (required).</param>
    /// <param name="PageSize">The current page size (required).</param>
    /// <param name="PageNumber">The current page number (required).</param>
    /// <param name="PreviousPage">Q64 value for the previous page of results.</param>
    /// <param name="CurrentPage">Q64 value for the current page of results.</param>
    /// <param name="NextPage">Q64 value for the next page of results.</param>
    /// <param name="Types">Resource types the search was performed against (required).</param>
    /// <param name="Results">Search results (required).</param>
    public GroupsSearchResponse(long? Total = null, int? PageCount = null, int? PageSize = null, int? PageNumber = null, string PreviousPage = null, string CurrentPage = null, string NextPage = null, List<string> Types = null, List<Group> Results = null)
    {
        this.Total = Total;
        this.PageCount = PageCount;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.PreviousPage = PreviousPage;
        this.CurrentPage = CurrentPage;
        this.NextPage = NextPage;
        this.Types = Types;
        this.Results = Results;

    }



    /// <summary>
    /// The total number of results found
    /// </summary>
    /// <value>The total number of results found</value>
    [JsonPropertyName("total")]
    public long? Total { get; set; }



    /// <summary>
    /// The total number of pages
    /// </summary>
    /// <value>The total number of pages</value>
    [JsonPropertyName("pageCount")]
    public int? PageCount { get; set; }



    /// <summary>
    /// The current page size
    /// </summary>
    /// <value>The current page size</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// The current page number
    /// </summary>
    /// <value>The current page number</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Q64 value for the previous page of results
    /// </summary>
    /// <value>Q64 value for the previous page of results</value>
    [JsonPropertyName("previousPage")]
    public string PreviousPage { get; set; }



    /// <summary>
    /// Q64 value for the current page of results
    /// </summary>
    /// <value>Q64 value for the current page of results</value>
    [JsonPropertyName("currentPage")]
    public string CurrentPage { get; set; }



    /// <summary>
    /// Q64 value for the next page of results
    /// </summary>
    /// <value>Q64 value for the next page of results</value>
    [JsonPropertyName("nextPage")]
    public string NextPage { get; set; }



    /// <summary>
    /// Resource types the search was performed against
    /// </summary>
    /// <value>Resource types the search was performed against</value>
    [JsonPropertyName("types")]
    public List<string> Types { get; set; }



    /// <summary>
    /// Search results
    /// </summary>
    /// <value>Search results</value>
    [JsonPropertyName("results")]
    public List<Group> Results { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GroupsSearchResponse {\n");

        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
        sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
        sb.Append("  NextPage: ").Append(NextPage).Append("\n");
        sb.Append("  Types: ").Append(Types).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as GroupsSearchResponse);
    }

    /// <summary>
    /// Returns true if GroupsSearchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of GroupsSearchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GroupsSearchResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
            ) &&
            (
                PageCount == other.PageCount ||
                PageCount != null &&
                PageCount.Equals(other.PageCount)
            ) &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                PageNumber == other.PageNumber ||
                PageNumber != null &&
                PageNumber.Equals(other.PageNumber)
            ) &&
            (
                PreviousPage == other.PreviousPage ||
                PreviousPage != null &&
                PreviousPage.Equals(other.PreviousPage)
            ) &&
            (
                CurrentPage == other.CurrentPage ||
                CurrentPage != null &&
                CurrentPage.Equals(other.CurrentPage)
            ) &&
            (
                NextPage == other.NextPage ||
                NextPage != null &&
                NextPage.Equals(other.NextPage)
            ) &&
            (
                Types == other.Types ||
                Types != null &&
                Types.SequenceEqual(other.Types)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            if (PageCount != null)
            {
                hash = hash * 59 + PageCount.GetHashCode();
            }

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (PreviousPage != null)
            {
                hash = hash * 59 + PreviousPage.GetHashCode();
            }

            if (CurrentPage != null)
            {
                hash = hash * 59 + CurrentPage.GetHashCode();
            }

            if (NextPage != null)
            {
                hash = hash * 59 + NextPage.GetHashCode();
            }

            if (Types != null)
            {
                hash = hash * 59 + Types.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            return hash;
        }
    }
}
