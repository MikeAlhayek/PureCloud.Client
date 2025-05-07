using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GDPRRequest
/// </summary>

public partial class GDPRRequest : IEquatable<GDPRRequest>
{
    /// <summary>
    /// The type of GDPR request
    /// </summary>
    /// <value>The type of GDPR request</value>
    
    public enum RequestTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Export for "GDPR_EXPORT"
        /// </summary>
        [EnumMember(Value = "GDPR_EXPORT")]
        Export,

        /// <summary>
        /// Enum Update for "GDPR_UPDATE"
        /// </summary>
        [EnumMember(Value = "GDPR_UPDATE")]
        Update,

        /// <summary>
        /// Enum Delete for "GDPR_DELETE"
        /// </summary>
        [EnumMember(Value = "GDPR_DELETE")]
        Delete
    }
    /// <summary>
    /// The status of the request
    /// </summary>
    /// <value>The status of the request</value>
    
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
        /// Enum Initiated for "INITIATED"
        /// </summary>
        [EnumMember(Value = "INITIATED")]
        Initiated,

        /// <summary>
        /// Enum Searching for "SEARCHING"
        /// </summary>
        [EnumMember(Value = "SEARCHING")]
        Searching,

        /// <summary>
        /// Enum Updating for "UPDATING"
        /// </summary>
        [EnumMember(Value = "UPDATING")]
        Updating,

        /// <summary>
        /// Enum Deleting for "DELETING"
        /// </summary>
        [EnumMember(Value = "DELETING")]
        Deleting,

        /// <summary>
        /// Enum Completed for "COMPLETED"
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        /// Enum Error for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        Error,

        /// <summary>
        /// Enum Finalizing for "FINALIZING"
        /// </summary>
        [EnumMember(Value = "FINALIZING")]
        Finalizing
    }
    /// <summary>
    /// The type of GDPR request
    /// </summary>
    /// <value>The type of GDPR request</value>
    [JsonPropertyName("requestType")]
    public RequestTypeEnum? RequestType { get; set; }
    /// <summary>
    /// The status of the request
    /// </summary>
    /// <value>The status of the request</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GDPRRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GDPRRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GDPRRequest" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ReplacementTerms">The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request.</param>
    /// <param name="RequestType">The type of GDPR request (required).</param>
    /// <param name="Subject">The subject of the GDPR request (required).</param>
    public GDPRRequest(string Name = null, List<ReplacementTerm> ReplacementTerms = null, RequestTypeEnum? RequestType = null, GDPRSubject Subject = null)
    {
        this.Name = Name;
        this.ReplacementTerms = ReplacementTerms;
        this.RequestType = RequestType;
        this.Subject = Subject;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The user that created this request
    /// </summary>
    /// <value>The user that created this request</value>
    [JsonPropertyName("createdBy")]
    public DomainEntityRef CreatedBy { get; set; }



    /// <summary>
    /// The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request
    /// </summary>
    /// <value>The replacement terms for the provided search terms, in the case of a GDPR_UPDATE request</value>
    [JsonPropertyName("replacementTerms")]
    public List<ReplacementTerm> ReplacementTerms { get; set; }





    /// <summary>
    /// When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }





    /// <summary>
    /// The subject of the GDPR request
    /// </summary>
    /// <value>The subject of the GDPR request</value>
    [JsonPropertyName("subject")]
    public GDPRSubject Subject { get; set; }



    /// <summary>
    /// The location where the results of the request can be retrieved
    /// </summary>
    /// <value>The location where the results of the request can be retrieved</value>
    [JsonPropertyName("resultsUrl")]
    public string ResultsUrl { get; set; }



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
        sb.Append("class GDPRRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ReplacementTerms: ").Append(ReplacementTerms).Append("\n");
        sb.Append("  RequestType: ").Append(RequestType).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  ResultsUrl: ").Append(ResultsUrl).Append("\n");
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
        return Equals(obj as GDPRRequest);
    }

    /// <summary>
    /// Returns true if GDPRRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of GDPRRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GDPRRequest other)
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
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ReplacementTerms == other.ReplacementTerms ||
                ReplacementTerms != null &&
                ReplacementTerms.SequenceEqual(other.ReplacementTerms)
            ) &&
            (
                RequestType == other.RequestType ||
                RequestType != null &&
                RequestType.Equals(other.RequestType)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                ResultsUrl == other.ResultsUrl ||
                ResultsUrl != null &&
                ResultsUrl.Equals(other.ResultsUrl)
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

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ReplacementTerms != null)
            {
                hash = hash * 59 + ReplacementTerms.GetHashCode();
            }

            if (RequestType != null)
            {
                hash = hash * 59 + RequestType.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (ResultsUrl != null)
            {
                hash = hash * 59 + ResultsUrl.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
