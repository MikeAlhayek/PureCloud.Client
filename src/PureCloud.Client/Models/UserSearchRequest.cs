using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserSearchRequest
/// </summary>

public partial class UserSearchRequest : IEquatable<UserSearchRequest>
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
    /// Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \"expand\". When using this parameter the maximum number of users that can be returned is 100.
    /// </summary>
    /// <value>Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \"expand\". When using this parameter the maximum number of users that can be returned is 100.</value>
    
    public enum IntegrationPresenceSourceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Microsoftteams for "MicrosoftTeams"
        /// </summary>
        [EnumMember(Value = "MicrosoftTeams")]
        Microsoftteams,

        /// <summary>
        /// Enum Zoomphone for "ZoomPhone"
        /// </summary>
        [EnumMember(Value = "ZoomPhone")]
        Zoomphone,

        /// <summary>
        /// Enum Eightbyeight for "EightByEight"
        /// </summary>
        [EnumMember(Value = "EightByEight")]
        Eightbyeight
    }
    /// <summary>
    /// The sort order for results
    /// </summary>
    /// <value>The sort order for results</value>
    [JsonPropertyName("sortOrder")]
    public SortOrderEnum? SortOrder { get; set; }
    /// <summary>
    /// Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \"expand\". When using this parameter the maximum number of users that can be returned is 100.
    /// </summary>
    /// <value>Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \"expand\". When using this parameter the maximum number of users that can be returned is 100.</value>
    [JsonPropertyName("integrationPresenceSource")]
    public IntegrationPresenceSourceEnum? IntegrationPresenceSource { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserSearchRequest" /> class.
    /// </summary>
    /// <param name="SortOrder">The sort order for results.</param>
    /// <param name="SortBy">The field in the resource that you want to sort the results by.</param>
    /// <param name="PageSize">The number of results per page.</param>
    /// <param name="PageNumber">The page of resources you want to retrieve.</param>
    /// <param name="Sort">Multi-value sort order, list of multiple sort values.</param>
    /// <param name="Expand">Provides more details about a specified resource.</param>
    /// <param name="Query">Query.</param>
    /// <param name="IntegrationPresenceSource">Gets an integration presence for users instead of their defaults. This parameter will only be used when presence is provided as an \&quot;expand\&quot;. When using this parameter the maximum number of users that can be returned is 100..</param>
    /// <param name="EnforcePermissions">This property only applies to api/v2/user/search; when set to true add additional search criteria to filter users by: directory:user:view.</param>
    public UserSearchRequest(SortOrderEnum? SortOrder = null, string SortBy = null, int? PageSize = null, int? PageNumber = null, List<SearchSort> Sort = null, List<string> Expand = null, List<UserSearchCriteria> Query = null, IntegrationPresenceSourceEnum? IntegrationPresenceSource = null, bool? EnforcePermissions = null)
    {
        this.SortOrder = SortOrder;
        this.SortBy = SortBy;
        this.PageSize = PageSize;
        this.PageNumber = PageNumber;
        this.Sort = Sort;
        this.Expand = Expand;
        this.Query = Query;
        this.IntegrationPresenceSource = IntegrationPresenceSource;
        this.EnforcePermissions = EnforcePermissions;

    }





    /// <summary>
    /// The field in the resource that you want to sort the results by
    /// </summary>
    /// <value>The field in the resource that you want to sort the results by</value>
    [JsonPropertyName("sortBy")]
    public string SortBy { get; set; }



    /// <summary>
    /// The number of results per page
    /// </summary>
    /// <value>The number of results per page</value>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; set; }



    /// <summary>
    /// The page of resources you want to retrieve
    /// </summary>
    /// <value>The page of resources you want to retrieve</value>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; set; }



    /// <summary>
    /// Multi-value sort order, list of multiple sort values
    /// </summary>
    /// <value>Multi-value sort order, list of multiple sort values</value>
    [JsonPropertyName("sort")]
    public List<SearchSort> Sort { get; set; }



    /// <summary>
    /// Provides more details about a specified resource
    /// </summary>
    /// <value>Provides more details about a specified resource</value>
    [JsonPropertyName("expand")]
    public List<string> Expand { get; set; }



    /// <summary>
    /// Gets or Sets Query
    /// </summary>
    [JsonPropertyName("query")]
    public List<UserSearchCriteria> Query { get; set; }





    /// <summary>
    /// This property only applies to api/v2/user/search; when set to true add additional search criteria to filter users by: directory:user:view
    /// </summary>
    /// <value>This property only applies to api/v2/user/search; when set to true add additional search criteria to filter users by: directory:user:view</value>
    [JsonPropertyName("enforcePermissions")]
    public bool? EnforcePermissions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserSearchRequest {\n");

        sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
        sb.Append("  SortBy: ").Append(SortBy).Append("\n");
        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
        sb.Append("  Expand: ").Append(Expand).Append("\n");
        sb.Append("  Query: ").Append(Query).Append("\n");
        sb.Append("  IntegrationPresenceSource: ").Append(IntegrationPresenceSource).Append("\n");
        sb.Append("  EnforcePermissions: ").Append(EnforcePermissions).Append("\n");
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
        return Equals(obj as UserSearchRequest);
    }

    /// <summary>
    /// Returns true if UserSearchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UserSearchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserSearchRequest other)
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
                Sort == other.Sort ||
                Sort != null &&
                Sort.SequenceEqual(other.Sort)
            ) &&
            (
                Expand == other.Expand ||
                Expand != null &&
                Expand.SequenceEqual(other.Expand)
            ) &&
            (
                Query == other.Query ||
                Query != null &&
                Query.SequenceEqual(other.Query)
            ) &&
            (
                IntegrationPresenceSource == other.IntegrationPresenceSource ||
                IntegrationPresenceSource != null &&
                IntegrationPresenceSource.Equals(other.IntegrationPresenceSource)
            ) &&
            (
                EnforcePermissions == other.EnforcePermissions ||
                EnforcePermissions != null &&
                EnforcePermissions.Equals(other.EnforcePermissions)
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

            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (PageNumber != null)
            {
                hash = hash * 59 + PageNumber.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            if (Expand != null)
            {
                hash = hash * 59 + Expand.GetHashCode();
            }

            if (Query != null)
            {
                hash = hash * 59 + Query.GetHashCode();
            }

            if (IntegrationPresenceSource != null)
            {
                hash = hash * 59 + IntegrationPresenceSource.GetHashCode();
            }

            if (EnforcePermissions != null)
            {
                hash = hash * 59 + EnforcePermissions.GetHashCode();
            }

            return hash;
        }
    }
}
