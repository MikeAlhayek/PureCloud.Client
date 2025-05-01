using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JsonSearchResponse
/// </summary>
[DataContract]
public partial class JsonSearchResponse : IEquatable<JsonSearchResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="JsonSearchResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JsonSearchResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JsonSearchResponse" /> class.
    /// </summary>
    /// <param name="Total">The total number of results found (required).</param>
    /// <param name="PageCount">The total number of pages (required).</param>
    /// <param name="PageSize">The current page size (required).</param>
    /// <param name="PageNumber">The current page number (required).</param>
    /// <param name="Types">Resource types the search was performed against (required).</param>
    /// <param name="Results">Search results (required).</param>
    /// <param name="Aggregations">Aggregations.</param>
    public JsonSearchResponse(long? Total = null, int? PageCount = null, int? PageSize = null, int? PageNumber = null, List<string> Types = null, object Results = null, object Aggregations = null)
    {
        this.Total = Total;
        this.PageCount = PageCount;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.Types = Types;
        this.Results = Results;
        this.Aggregations = Aggregations;

    }



    /// <summary>
    /// The total number of results found
    /// </summary>
    /// <value>The total number of results found</value>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public long? Total { get; set; }



    /// <summary>
    /// The total number of pages
    /// </summary>
    /// <value>The total number of pages</value>
    [DataMember(Name = "pageCount", EmitDefaultValue = false)]
    public int? PageCount { get; set; }



    /// <summary>
    /// The current page size
    /// </summary>
    /// <value>The current page size</value>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }



    /// <summary>
    /// The current page number
    /// </summary>
    /// <value>The current page number</value>
    [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Resource types the search was performed against
    /// </summary>
    /// <value>Resource types the search was performed against</value>
    [DataMember(Name = "types", EmitDefaultValue = false)]
    public List<string> Types { get; set; }



    /// <summary>
    /// Search results
    /// </summary>
    /// <value>Search results</value>
    [DataMember(Name = "results", EmitDefaultValue = false)]
    public object Results { get; set; }



    /// <summary>
    /// Gets or Sets Aggregations
    /// </summary>
    [DataMember(Name = "aggregations", EmitDefaultValue = false)]
    public object Aggregations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JsonSearchResponse {\n");

        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  PageCount: ").Append(PageCount).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  Types: ").Append(Types).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
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
        return Equals(obj as JsonSearchResponse);
    }

    /// <summary>
    /// Returns true if JsonSearchResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of JsonSearchResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JsonSearchResponse other)
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
                Types == other.Types ||
                Types != null &&
                Types.SequenceEqual(other.Types)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.Equals(other.Results)
            ) &&
            (
                Aggregations == other.Aggregations ||
                Aggregations != null &&
                Aggregations.Equals(other.Aggregations)
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

            if (Types != null)
            {
                hash = hash * 59 + Types.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (Aggregations != null)
            {
                hash = hash * 59 + Aggregations.GetHashCode();
            }

            return hash;
        }
    }
}
