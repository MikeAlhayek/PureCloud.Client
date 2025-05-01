using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AdherenceExplanationJob
/// </summary>
[DataContract]
public partial class AdherenceExplanationJob : IEquatable<AdherenceExplanationJob>
{
    /// <summary>
    /// The type of the adherence explanation job
    /// </summary>
    /// <value>The type of the adherence explanation job</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Addexplanation for "AddExplanation"
        /// </summary>
        [EnumMember(Value = "AddExplanation")]
        Addexplanation,

        /// <summary>
        /// Enum Updateexplanation for "UpdateExplanation"
        /// </summary>
        [EnumMember(Value = "UpdateExplanation")]
        Updateexplanation,

        /// <summary>
        /// Enum Queryagentexplanations for "QueryAgentExplanations"
        /// </summary>
        [EnumMember(Value = "QueryAgentExplanations")]
        Queryagentexplanations,

        /// <summary>
        /// Enum Querybuexplanations for "QueryBuExplanations"
        /// </summary>
        [EnumMember(Value = "QueryBuExplanations")]
        Querybuexplanations,
    }
    /// <summary>
    /// The status of the adherence explanation job
    /// </summary>
    /// <value>The status of the adherence explanation job</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// The type of the adherence explanation job
    /// </summary>
    /// <value>The type of the adherence explanation job</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The status of the adherence explanation job
    /// </summary>
    /// <value>The status of the adherence explanation job</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AdherenceExplanationJob" /> class.
    /// </summary>
    /// <param name="Type">The type of the adherence explanation job.</param>
    /// <param name="Status">The status of the adherence explanation job.</param>
    /// <param name="AdherenceExplanation">The adherence explanation added or modified by the job once complete; may be null if status &#x3D;&#x3D; &#39;Error&#39;. Used if type is in [ &#39;AddExplanation&#39;, &#39;UpdateExplanation&#39; ].</param>
    /// <param name="DownloadUrl">A URL to fetch results of the job. Only set if status &#x3D;&#x3D; &#39;Complete&#39; and type is in [ &#39;QueryAgentExplanations&#39;, &#39;QueryBuExplanations&#39; ].</param>
    /// <param name="Error">Error details if status &#x3D;&#x3D; &#39;Error&#39;.</param>
    /// <param name="AgentQueryResponseTemplate">Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;QueryAgentExplanations&#39;.</param>
    /// <param name="BuQueryResponseTemplate">Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;QueryBuExplanations&#39;.</param>
    public AdherenceExplanationJob(TypeEnum? Type = null, StatusEnum? Status = null, AdherenceExplanationResponse AdherenceExplanation = null, string DownloadUrl = null, ErrorBody Error = null, AdherenceExplanationListingAgentQueryResponse AgentQueryResponseTemplate = null, AdherenceExplanationListingBuQueryResponse BuQueryResponseTemplate = null)
    {
        this.Type = Type;
        this.Status = Status;
        this.AdherenceExplanation = AdherenceExplanation;
        this.DownloadUrl = DownloadUrl;
        this.Error = Error;
        this.AgentQueryResponseTemplate = AgentQueryResponseTemplate;
        this.BuQueryResponseTemplate = BuQueryResponseTemplate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }







    /// <summary>
    /// The adherence explanation added or modified by the job once complete; may be null if status &#x3D;&#x3D; &#39;Error&#39;. Used if type is in [ &#39;AddExplanation&#39;, &#39;UpdateExplanation&#39; ]
    /// </summary>
    /// <value>The adherence explanation added or modified by the job once complete; may be null if status &#x3D;&#x3D; &#39;Error&#39;. Used if type is in [ &#39;AddExplanation&#39;, &#39;UpdateExplanation&#39; ]</value>
    [DataMember(Name = "adherenceExplanation", EmitDefaultValue = false)]
    public AdherenceExplanationResponse AdherenceExplanation { get; set; }



    /// <summary>
    /// A URL to fetch results of the job. Only set if status &#x3D;&#x3D; &#39;Complete&#39; and type is in [ &#39;QueryAgentExplanations&#39;, &#39;QueryBuExplanations&#39; ]
    /// </summary>
    /// <value>A URL to fetch results of the job. Only set if status &#x3D;&#x3D; &#39;Complete&#39; and type is in [ &#39;QueryAgentExplanations&#39;, &#39;QueryBuExplanations&#39; ]</value>
    [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// Error details if status &#x3D;&#x3D; &#39;Error&#39;
    /// </summary>
    /// <value>Error details if status &#x3D;&#x3D; &#39;Error&#39;</value>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public ErrorBody Error { get; set; }



    /// <summary>
    /// Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;QueryAgentExplanations&#39;
    /// </summary>
    /// <value>Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;QueryAgentExplanations&#39;</value>
    [DataMember(Name = "agentQueryResponseTemplate", EmitDefaultValue = false)]
    public AdherenceExplanationListingAgentQueryResponse AgentQueryResponseTemplate { get; set; }



    /// <summary>
    /// Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;QueryBuExplanations&#39;
    /// </summary>
    /// <value>Schema template for deserializing data returned from the downloadUrl. Use if type &#x3D;&#x3D; &#39;QueryBuExplanations&#39;</value>
    [DataMember(Name = "buQueryResponseTemplate", EmitDefaultValue = false)]
    public AdherenceExplanationListingBuQueryResponse BuQueryResponseTemplate { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AdherenceExplanationJob {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  AdherenceExplanation: ").Append(AdherenceExplanation).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  AgentQueryResponseTemplate: ").Append(AgentQueryResponseTemplate).Append("\n");
        sb.Append("  BuQueryResponseTemplate: ").Append(BuQueryResponseTemplate).Append("\n");
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
        return this.Equals(obj as AdherenceExplanationJob);
    }

    /// <summary>
    /// Returns true if AdherenceExplanationJob instances are equal
    /// </summary>
    /// <param name="other">Instance of AdherenceExplanationJob to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AdherenceExplanationJob other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Status == other.Status ||
                this.Status != null &&
                this.Status.Equals(other.Status)
            ) &&
            (
                this.AdherenceExplanation == other.AdherenceExplanation ||
                this.AdherenceExplanation != null &&
                this.AdherenceExplanation.Equals(other.AdherenceExplanation)
            ) &&
            (
                this.DownloadUrl == other.DownloadUrl ||
                this.DownloadUrl != null &&
                this.DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                this.Error == other.Error ||
                this.Error != null &&
                this.Error.Equals(other.Error)
            ) &&
            (
                this.AgentQueryResponseTemplate == other.AgentQueryResponseTemplate ||
                this.AgentQueryResponseTemplate != null &&
                this.AgentQueryResponseTemplate.Equals(other.AgentQueryResponseTemplate)
            ) &&
            (
                this.BuQueryResponseTemplate == other.BuQueryResponseTemplate ||
                this.BuQueryResponseTemplate != null &&
                this.BuQueryResponseTemplate.Equals(other.BuQueryResponseTemplate)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.Status != null)
            {
                hash = hash * 59 + this.Status.GetHashCode();
            }

            if (this.AdherenceExplanation != null)
            {
                hash = hash * 59 + this.AdherenceExplanation.GetHashCode();
            }

            if (this.DownloadUrl != null)
            {
                hash = hash * 59 + this.DownloadUrl.GetHashCode();
            }

            if (this.Error != null)
            {
                hash = hash * 59 + this.Error.GetHashCode();
            }

            if (this.AgentQueryResponseTemplate != null)
            {
                hash = hash * 59 + this.AgentQueryResponseTemplate.GetHashCode();
            }

            if (this.BuQueryResponseTemplate != null)
            {
                hash = hash * 59 + this.BuQueryResponseTemplate.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
