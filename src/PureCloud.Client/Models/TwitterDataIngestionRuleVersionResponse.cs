using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TwitterDataIngestionRuleVersionResponse
/// </summary>

public partial class TwitterDataIngestionRuleVersionResponse : IEquatable<TwitterDataIngestionRuleVersionResponse>
{
    /// <summary>
    /// The status of the data ingestion rule.
    /// </summary>
    /// <value>The status of the data ingestion rule.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Paused for "Paused"
        /// </summary>
        [EnumMember(Value = "Paused")]
        Paused,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Systempaused for "SystemPaused"
        /// </summary>
        [EnumMember(Value = "SystemPaused")]
        Systempaused
    }
    /// <summary>
    /// The status of the data ingestion rule.
    /// </summary>
    /// <value>The status of the data ingestion rule.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TwitterDataIngestionRuleVersionResponse" /> class.
    /// </summary>
    /// <param name="Id">ID of the data ingestion rule..</param>
    /// <param name="Name">The name of the data ingestion rule..</param>
    /// <param name="Description">A description of the data ingestion rule..</param>
    /// <param name="Status">The status of the data ingestion rule..</param>
    /// <param name="Version">The version number of the data ingestion rule..</param>
    /// <param name="SearchTerms">Search terms for X (formally Twitter)..</param>
    /// <param name="Countries">ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide..</param>
    public TwitterDataIngestionRuleVersionResponse(string Id = null, string Name = null, string Description = null, StatusEnum? Status = null, int? Version = null, string SearchTerms = null, List<string> Countries = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.Status = Status;
        this.Version = Version;
        this.SearchTerms = SearchTerms;
        this.Countries = Countries;

    }



    /// <summary>
    /// ID of the data ingestion rule.
    /// </summary>
    /// <value>ID of the data ingestion rule.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the data ingestion rule.
    /// </summary>
    /// <value>The name of the data ingestion rule.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A description of the data ingestion rule.
    /// </summary>
    /// <value>A description of the data ingestion rule.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }





    /// <summary>
    /// The version number of the data ingestion rule.
    /// </summary>
    /// <value>The version number of the data ingestion rule.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the data ingestion rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the data ingestion rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The platform of the data ingestion rule.
    /// </summary>
    /// <value>The platform of the data ingestion rule.</value>
    [JsonPropertyName("platform")]
    public string Platform { get; set; }



    /// <summary>
    /// Search terms for X (formally Twitter).
    /// </summary>
    /// <value>Search terms for X (formally Twitter).</value>
    [JsonPropertyName("searchTerms")]
    public string SearchTerms { get; set; }



    /// <summary>
    /// ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide.
    /// </summary>
    /// <value>ISO 3166-1 alpha-2 country codes where Data Ingestion Rules should apply. Defaults to worldwide.</value>
    [JsonPropertyName("countries")]
    public List<string> Countries { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TwitterDataIngestionRuleVersionResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Platform: ").Append(Platform).Append("\n");
        sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
        sb.Append("  Countries: ").Append(Countries).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as TwitterDataIngestionRuleVersionResponse);
    }

    /// <summary>
    /// Returns true if TwitterDataIngestionRuleVersionResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of TwitterDataIngestionRuleVersionResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TwitterDataIngestionRuleVersionResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Platform == other.Platform ||
                Platform != null &&
                Platform.Equals(other.Platform)
            ) &&
            (
                SearchTerms == other.SearchTerms ||
                SearchTerms != null &&
                SearchTerms.Equals(other.SearchTerms)
            ) &&
            (
                Countries == other.Countries ||
                Countries != null &&
                Countries.SequenceEqual(other.Countries)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Platform != null)
            {
                hash = hash * 59 + Platform.GetHashCode();
            }

            if (SearchTerms != null)
            {
                hash = hash * 59 + SearchTerms.GetHashCode();
            }

            if (Countries != null)
            {
                hash = hash * 59 + Countries.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
