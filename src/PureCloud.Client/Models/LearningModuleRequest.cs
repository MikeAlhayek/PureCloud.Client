using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module request
/// </summary>
public sealed class LearningModuleRequest
{
    /// <summary>
    /// The type for the learning module. Informational, AssessedContent and Assessment are deprecated
    /// </summary>
    /// <value>The type for the learning module. Informational, AssessedContent and Assessment are deprecated</value>
    
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
        /// Enum Informational for "Informational"
        /// </summary>
        [EnumMember(Value = "Informational")]
        Informational,

        /// <summary>
        /// Enum Assessedcontent for "AssessedContent"
        /// </summary>
        [EnumMember(Value = "AssessedContent")]
        Assessedcontent,

        /// <summary>
        /// Enum Assessment for "Assessment"
        /// </summary>
        [EnumMember(Value = "Assessment")]
        Assessment,

        /// <summary>
        /// Enum External for "External"
        /// </summary>
        [EnumMember(Value = "External")]
        External,

        /// <summary>
        /// Enum Native for "Native"
        /// </summary>
        [EnumMember(Value = "Native")]
        Native
    }
    /// <summary>
    /// The type for the learning module. Informational, AssessedContent and Assessment are deprecated
    /// </summary>
    /// <value>The type for the learning module. Informational, AssessedContent and Assessment are deprecated</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleRequest" /> class.
    /// </summary>
    private LearningModuleRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModuleRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of learning module (required).</param>
    /// <param name="Description">The description of learning module.</param>
    /// <param name="CompletionTimeInDays">The completion time of learning module in days (required).</param>
    /// <param name="InformSteps">The list of inform steps in a learning module.</param>
    /// <param name="Type">The type for the learning module. Informational, AssessedContent and Assessment are deprecated.</param>
    /// <param name="AssessmentForm">The assessment form for learning module.</param>
    /// <param name="CoverArt">The cover art for the learning module.</param>
    /// <param name="LengthInMinutes">The recommended time in minutes to complete the module.</param>
    /// <param name="ExcludedFromCatalog">If true, learning module is excluded when retrieving modules for manual assignment.</param>
    /// <param name="ExternalId">The external ID of the learning module. Maximum length: 50 characters..</param>
    /// <param name="EnforceContentOrder">If true, learning module content should be viewed one by one in order.</param>
    /// <param name="ReviewAssessmentResults">Allows to view Assessment results in detail.</param>
    public LearningModuleRequest(string Name = null, string Description = null, int? CompletionTimeInDays = null, List<LearningModuleInformStepRequest> InformSteps = null, TypeEnum? Type = null, AssessmentForm AssessmentForm = null, LearningModuleCoverArtRequest CoverArt = null, int? LengthInMinutes = null, bool? ExcludedFromCatalog = null, string ExternalId = null, bool? EnforceContentOrder = null, ReviewAssessmentResults ReviewAssessmentResults = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.CompletionTimeInDays = CompletionTimeInDays;
        this.InformSteps = InformSteps;
        this.Type = Type;
        this.AssessmentForm = AssessmentForm;
        this.CoverArt = CoverArt;
        this.LengthInMinutes = LengthInMinutes;
        this.ExcludedFromCatalog = ExcludedFromCatalog;
        this.ExternalId = ExternalId;
        this.EnforceContentOrder = EnforceContentOrder;
        this.ReviewAssessmentResults = ReviewAssessmentResults;

    }



    /// <summary>
    /// The name of learning module
    /// </summary>
    /// <value>The name of learning module</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The description of learning module
    /// </summary>
    /// <value>The description of learning module</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The completion time of learning module in days
    /// </summary>
    /// <value>The completion time of learning module in days</value>
    [JsonPropertyName("completionTimeInDays")]
    public int? CompletionTimeInDays { get; set; }



    /// <summary>
    /// The list of inform steps in a learning module
    /// </summary>
    /// <value>The list of inform steps in a learning module</value>
    [JsonPropertyName("informSteps")]
    public List<LearningModuleInformStepRequest> InformSteps { get; set; }





    /// <summary>
    /// The assessment form for learning module
    /// </summary>
    /// <value>The assessment form for learning module</value>
    [JsonPropertyName("assessmentForm")]
    public AssessmentForm AssessmentForm { get; set; }



    /// <summary>
    /// The cover art for the learning module
    /// </summary>
    /// <value>The cover art for the learning module</value>
    [JsonPropertyName("coverArt")]
    public LearningModuleCoverArtRequest CoverArt { get; set; }



    /// <summary>
    /// The recommended time in minutes to complete the module
    /// </summary>
    /// <value>The recommended time in minutes to complete the module</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// If true, learning module is excluded when retrieving modules for manual assignment
    /// </summary>
    /// <value>If true, learning module is excluded when retrieving modules for manual assignment</value>
    [JsonPropertyName("excludedFromCatalog")]
    public bool? ExcludedFromCatalog { get; set; }



    /// <summary>
    /// The external ID of the learning module. Maximum length: 50 characters.
    /// </summary>
    /// <value>The external ID of the learning module. Maximum length: 50 characters.</value>
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }



    /// <summary>
    /// If true, learning module content should be viewed one by one in order
    /// </summary>
    /// <value>If true, learning module content should be viewed one by one in order</value>
    [JsonPropertyName("enforceContentOrder")]
    public bool? EnforceContentOrder { get; set; }



    /// <summary>
    /// Allows to view Assessment results in detail
    /// </summary>
    /// <value>Allows to view Assessment results in detail</value>
    [JsonPropertyName("reviewAssessmentResults")]
    public ReviewAssessmentResults ReviewAssessmentResults { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModuleRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  CompletionTimeInDays: ").Append(CompletionTimeInDays).Append("\n");
        sb.Append("  InformSteps: ").Append(InformSteps).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
        sb.Append("  CoverArt: ").Append(CoverArt).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  ExcludedFromCatalog: ").Append(ExcludedFromCatalog).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
        sb.Append("  EnforceContentOrder: ").Append(EnforceContentOrder).Append("\n");
        sb.Append("  ReviewAssessmentResults: ").Append(ReviewAssessmentResults).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}
