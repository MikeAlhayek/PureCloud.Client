using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationParticipantSearchRequest
/// </summary>

public partial class ConversationParticipantSearchRequest : IEquatable<ConversationParticipantSearchRequest>
{
    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    
    public enum SortOrderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Asc for "ASC"
        /// </summary>
        [EnumMember(Value = "ASC")]
        Asc,

        /// <summary>
        /// Enum Desc for "DESC"
        /// </summary>
        [EnumMember(Value = "DESC")]
        Desc,

        /// <summary>
        /// Enum Score for "SCORE"
        /// </summary>
        [EnumMember(Value = "SCORE")]
        Score
    }
    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationParticipantSearchRequest" /> class.
    /// </summary>
    /// <param name="SortOrder">The sort order for results.</param>
    /// <param name="SortBy">The field in the resource that you want to sort the results by.</param>
    /// <param name="Sort">Multi-value sort order, list of multiple sort values.</param>
    /// <param name="ReturnFields">ReturnFields.</param>
    /// <param name="Query">Query.</param>
    /// <param name="Cursor">Cursor.</param>
    public ConversationParticipantSearchRequest(SortOrderEnum? SortOrder = null, string SortBy = null, List<SearchSort> Sort = null, List<string> ReturnFields = null, List<ConversationParticipantSearchCriteria> Query = null, string Cursor = null)
    {
        this.SortOrder = SortOrder;
        this.SortBy = SortBy;
        this.Sort = Sort;
        this.ReturnFields = ReturnFields;
        this.Query = Query;
        this.Cursor = Cursor;

    }





    /// <summary>
    /// The field in the resource that you want to sort the results by
    /// </summary>
    /// <value>The field in the resource that you want to sort the results by</value>
    [JsonPropertyName("sortBy")]
    public string SortBy { get; set; }



    /// <summary>
    /// Multi-value sort order, list of multiple sort values
    /// </summary>
    /// <value>Multi-value sort order, list of multiple sort values</value>
    [JsonPropertyName("sort")]
    public List<SearchSort> Sort { get; set; }



    /// <summary>
    /// Gets or Sets ReturnFields
    /// </summary>
    [JsonPropertyName("returnFields")]
    public List<string> ReturnFields { get; set; }



    /// <summary>
    /// Gets or Sets Query
    /// </summary>
    [JsonPropertyName("query")]
    public List<ConversationParticipantSearchCriteria> Query { get; set; }



    /// <summary>
    /// Gets or Sets Cursor
    /// </summary>
    [JsonPropertyName("cursor")]
    public string Cursor { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationParticipantSearchRequest {\n");

        sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
        sb.Append("  SortBy: ").Append(SortBy).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
        sb.Append("  ReturnFields: ").Append(ReturnFields).Append("\n");
        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
        return Equals(obj as ConversationParticipantSearchRequest);
    }

    /// <summary>
    /// Returns true if ConversationParticipantSearchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationParticipantSearchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationParticipantSearchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SortOrder == other.SortOrder ||
                SortOrder != null &&
                SortOrder.Equals(other.SortOrder)
            ) &&
            (
                SortBy == other.SortBy ||
                SortBy != null &&
                SortBy.Equals(other.SortBy)
            ) &&
            (
                Sort == other.Sort ||
                Sort != null &&
                Sort.SequenceEqual(other.Sort)
            ) &&
            (
                ReturnFields == other.ReturnFields ||
                ReturnFields != null &&
                ReturnFields.SequenceEqual(other.ReturnFields)
            ) &&
            (
                Query == other.Query ||
                Query != null &&
                Query.SequenceEqual(other.Query)
            ) &&
            (
                Cursor == other.Cursor ||
                Cursor != null &&
                Cursor.Equals(other.Cursor)
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
            if (SortOrder != null)
            {
                hash = hash * 59 + SortOrder.GetHashCode();
            }

            if (SortBy != null)
            {
                hash = hash * 59 + SortBy.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            if (ReturnFields != null)
            {
                hash = hash * 59 + ReturnFields.GetHashCode();
            }

            if (Query != null)
            {
                hash = hash * 59 + Query.GetHashCode();
            }

            if (Cursor != null)
            {
                hash = hash * 59 + Cursor.GetHashCode();
            }

            return hash;
        }
    }
}
