using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationFormResponse
/// </summary>

public partial class EvaluationFormResponse : IEquatable<EvaluationFormResponse>
{
    /// <summary>
    /// Mode for evaluation form weight
    /// </summary>
    /// <value>Mode for evaluation form weight</value>
    
    public enum WeightModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Scaled for "SCALED"
        /// </summary>
        [EnumMember(Value = "SCALED")]
        Scaled,

        /// <summary>
        /// Enum Off for "OFF"
        /// </summary>
        [EnumMember(Value = "OFF")]
        Off
    }
    /// <summary>
    /// Mode for evaluation form weight
    /// </summary>
    /// <value>Mode for evaluation form weight</value>
    [JsonPropertyName("weightMode")]
    public WeightModeEnum? WeightMode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationFormResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EvaluationFormResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationFormResponse" /> class.
    /// </summary>
    /// <param name="Name">The evaluation form name (required).</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Published">Published.</param>
    /// <param name="ContextId">ContextId.</param>
    /// <param name="QuestionGroups">A list of question groups.</param>
    /// <param name="WeightMode">Mode for evaluation form weight.</param>
    /// <param name="EvaluationSettings">Settings for evaluations associated with this form.</param>
    /// <param name="PublishedVersions">A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable)..</param>
    public EvaluationFormResponse(string Name = null, DateTime? ModifiedDate = null, bool? Published = null, string ContextId = null, List<EvaluationQuestionGroup> QuestionGroups = null, WeightModeEnum? WeightMode = null, EvaluationSettings EvaluationSettings = null, DomainEntityListingEvaluationForm PublishedVersions = null)
    {
        this.Name = Name;
        this.ModifiedDate = ModifiedDate;
        this.Published = Published;
        this.ContextId = ContextId;
        this.QuestionGroups = QuestionGroups;
        this.WeightMode = WeightMode;
        this.EvaluationSettings = EvaluationSettings;
        this.PublishedVersions = PublishedVersions;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The evaluation form name
    /// </summary>
    /// <value>The evaluation form name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    [JsonPropertyName("published")]
    public bool? Published { get; set; }



    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    [JsonPropertyName("contextId")]
    public string ContextId { get; set; }



    /// <summary>
    /// A list of question groups
    /// </summary>
    /// <value>A list of question groups</value>
    [JsonPropertyName("questionGroups")]
    public List<EvaluationQuestionGroup> QuestionGroups { get; set; }





    /// <summary>
    /// Settings for evaluations associated with this form
    /// </summary>
    /// <value>Settings for evaluations associated with this form</value>
    [JsonPropertyName("evaluationSettings")]
    public EvaluationSettings EvaluationSettings { get; set; }



    /// <summary>
    /// A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable).
    /// </summary>
    /// <value>A list of the published versions of this form. Not populated by default, its availability depends on the endpoint. Use the &#39;expand&#x3D;publishHistory&#39; query parameter to retrieve this data where applicable (refer to the endpoint description to see if it is applicable).</value>
    [JsonPropertyName("publishedVersions")]
    public DomainEntityListingEvaluationForm PublishedVersions { get; set; }



    /// <summary>
    /// AI scoring settings for the evaluation form.
    /// </summary>
    /// <value>AI scoring settings for the evaluation form.</value>
    [JsonPropertyName("aiScoring")]
    public AiScoringSettings AiScoring { get; set; }



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
        sb.Append("class EvaluationFormResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  QuestionGroups: ").Append(QuestionGroups).Append("\n");
        sb.Append("  WeightMode: ").Append(WeightMode).Append("\n");
        sb.Append("  EvaluationSettings: ").Append(EvaluationSettings).Append("\n");
        sb.Append("  PublishedVersions: ").Append(PublishedVersions).Append("\n");
        sb.Append("  AiScoring: ").Append(AiScoring).Append("\n");
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
        return Equals(obj as EvaluationFormResponse);
    }

    /// <summary>
    /// Returns true if EvaluationFormResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationFormResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationFormResponse other)
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
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                QuestionGroups == other.QuestionGroups ||
                QuestionGroups != null &&
                QuestionGroups.SequenceEqual(other.QuestionGroups)
            ) &&
            (
                WeightMode == other.WeightMode ||
                WeightMode != null &&
                WeightMode.Equals(other.WeightMode)
            ) &&
            (
                EvaluationSettings == other.EvaluationSettings ||
                EvaluationSettings != null &&
                EvaluationSettings.Equals(other.EvaluationSettings)
            ) &&
            (
                PublishedVersions == other.PublishedVersions ||
                PublishedVersions != null &&
                PublishedVersions.Equals(other.PublishedVersions)
            ) &&
            (
                AiScoring == other.AiScoring ||
                AiScoring != null &&
                AiScoring.Equals(other.AiScoring)
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

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (QuestionGroups != null)
            {
                hash = hash * 59 + QuestionGroups.GetHashCode();
            }

            if (WeightMode != null)
            {
                hash = hash * 59 + WeightMode.GetHashCode();
            }

            if (EvaluationSettings != null)
            {
                hash = hash * 59 + EvaluationSettings.GetHashCode();
            }

            if (PublishedVersions != null)
            {
                hash = hash * 59 + PublishedVersions.GetHashCode();
            }

            if (AiScoring != null)
            {
                hash = hash * 59 + AiScoring.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
