using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module response
/// </summary>

public partial class LearningModule : IEquatable<LearningModule>
{
    /// <summary>
    /// The source of the learning module
    /// </summary>
    /// <value>The source of the learning module</value>
    
    public enum SourceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Usercreated for "UserCreated"
        /// </summary>
        [EnumMember(Value = "UserCreated")]
        Usercreated,

        /// <summary>
        /// Enum Genesysbeyond for "GenesysBeyond"
        /// </summary>
        [EnumMember(Value = "GenesysBeyond")]
        Genesysbeyond
    }
    /// <summary>
    /// The type for the learning module
    /// </summary>
    /// <value>The type for the learning module</value>
    
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
    /// The mode of archival for learning module
    /// </summary>
    /// <value>The mode of archival for learning module</value>
    
    public enum ArchivalModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Graceful for "Graceful"
        /// </summary>
        [EnumMember(Value = "Graceful")]
        Graceful,

        /// <summary>
        /// Enum Immediate for "Immediate"
        /// </summary>
        [EnumMember(Value = "Immediate")]
        Immediate
    }
    /// <summary>
    /// The source of the learning module
    /// </summary>
    /// <value>The source of the learning module</value>
    [JsonPropertyName("source")]
    public SourceEnum? Source { get; set; }
    /// <summary>
    /// The type for the learning module
    /// </summary>
    /// <value>The type for the learning module</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The mode of archival for learning module
    /// </summary>
    /// <value>The mode of archival for learning module</value>
    [JsonPropertyName("archivalMode")]
    public ArchivalModeEnum? ArchivalMode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningModule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModule" /> class.
    /// </summary>
    /// <param name="Name">The name of learning module (required).</param>
    /// <param name="ExcludedFromCatalog">If true, learning module is excluded when retrieving modules for manual assignment.</param>
    /// <param name="EnforceContentOrder">If true, learning module content should be viewed one by one in order.</param>
    /// <param name="ReviewAssessmentResults">Allows to view Assessment results in detail.</param>
    /// <param name="Description">The description of learning module.</param>
    /// <param name="CompletionTimeInDays">The completion time of learning module in days (required).</param>
    /// <param name="Type">The type for the learning module.</param>
    /// <param name="InformSteps">The list of inform steps in a learning module.</param>
    /// <param name="AssessmentForm">The assessment form for learning module.</param>
    /// <param name="SummaryData">The learning module summary data.</param>
    /// <param name="ReassignSummaryData">The learning module reassign summary data.</param>
    /// <param name="CoverArt">The cover art for the learning module.</param>
    /// <param name="LengthInMinutes">The recommended time in minutes to complete the module.</param>
    /// <param name="ArchivalMode">The mode of archival for learning module.</param>
    public LearningModule(string Name = null, bool? ExcludedFromCatalog = null, bool? EnforceContentOrder = null, ReviewAssessmentResults ReviewAssessmentResults = null, string Description = null, int? CompletionTimeInDays = null, TypeEnum? Type = null, List<LearningModuleInformStep> InformSteps = null, AssessmentForm AssessmentForm = null, LearningModuleSummary SummaryData = null, LearningModuleReassignSummary ReassignSummaryData = null, LearningModuleCoverArtResponse CoverArt = null, int? LengthInMinutes = null, ArchivalModeEnum? ArchivalMode = null)
    {
        this.Name = Name;
        this.ExcludedFromCatalog = ExcludedFromCatalog;
        this.EnforceContentOrder = EnforceContentOrder;
        this.ReviewAssessmentResults = ReviewAssessmentResults;
        this.Description = Description;
        this.CompletionTimeInDays = CompletionTimeInDays;
        this.Type = Type;
        this.InformSteps = InformSteps;
        this.AssessmentForm = AssessmentForm;
        this.SummaryData = SummaryData;
        this.ReassignSummaryData = ReassignSummaryData;
        this.CoverArt = CoverArt;
        this.LengthInMinutes = LengthInMinutes;
        this.ArchivalMode = ArchivalMode;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of learning module
    /// </summary>
    /// <value>The name of learning module</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// If true, learning module is excluded when retrieving modules for manual assignment
    /// </summary>
    /// <value>If true, learning module is excluded when retrieving modules for manual assignment</value>
    [JsonPropertyName("excludedFromCatalog")]
    public bool? ExcludedFromCatalog { get; set; }



    /// <summary>
    /// The user who created learning module
    /// </summary>
    /// <value>The user who created learning module</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The date/time learning module was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time learning module was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The user who modified learning module
    /// </summary>
    /// <value>The user who modified learning module</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// The date/time learning module was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time learning module was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The version of published learning module
    /// </summary>
    /// <value>The version of published learning module</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The external ID of the learning module
    /// </summary>
    /// <value>The external ID of the learning module</value>
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }





    /// <summary>
    /// The rule for learning module; read-only, and only populated when requested via expand param.
    /// </summary>
    /// <value>The rule for learning module; read-only, and only populated when requested via expand param.</value>
    [JsonPropertyName("rule")]
    public LearningModuleRule Rule { get; set; }



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
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// If true, learning module is archived
    /// </summary>
    /// <value>If true, learning module is archived</value>
    [JsonPropertyName("isArchived")]
    public bool? IsArchived { get; set; }



    /// <summary>
    /// If true, learning module is published
    /// </summary>
    /// <value>If true, learning module is published</value>
    [JsonPropertyName("isPublished")]
    public bool? IsPublished { get; set; }



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
    public List<LearningModuleInformStep> InformSteps { get; set; }



    /// <summary>
    /// The assessment form for learning module
    /// </summary>
    /// <value>The assessment form for learning module</value>
    [JsonPropertyName("assessmentForm")]
    public AssessmentForm AssessmentForm { get; set; }



    /// <summary>
    /// The learning module summary data
    /// </summary>
    /// <value>The learning module summary data</value>
    [JsonPropertyName("summaryData")]
    public LearningModuleSummary SummaryData { get; set; }



    /// <summary>
    /// The learning module reassign summary data
    /// </summary>
    /// <value>The learning module reassign summary data</value>
    [JsonPropertyName("reassignSummaryData")]
    public LearningModuleReassignSummary ReassignSummaryData { get; set; }



    /// <summary>
    /// The cover art for the learning module
    /// </summary>
    /// <value>The cover art for the learning module</value>
    [JsonPropertyName("coverArt")]
    public LearningModuleCoverArtResponse CoverArt { get; set; }



    /// <summary>
    /// The recommended time in minutes to complete the module
    /// </summary>
    /// <value>The recommended time in minutes to complete the module</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningModule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ExcludedFromCatalog: ").Append(ExcludedFromCatalog).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  Rule: ").Append(Rule).Append("\n");
        sb.Append("  EnforceContentOrder: ").Append(EnforceContentOrder).Append("\n");
        sb.Append("  ReviewAssessmentResults: ").Append(ReviewAssessmentResults).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
        sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  CompletionTimeInDays: ").Append(CompletionTimeInDays).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  InformSteps: ").Append(InformSteps).Append("\n");
        sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
        sb.Append("  SummaryData: ").Append(SummaryData).Append("\n");
        sb.Append("  ReassignSummaryData: ").Append(ReassignSummaryData).Append("\n");
        sb.Append("  CoverArt: ").Append(CoverArt).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  ArchivalMode: ").Append(ArchivalMode).Append("\n");
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
        return Equals(obj as LearningModule);
    }

    /// <summary>
    /// Returns true if LearningModule instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModule other)
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
                ExcludedFromCatalog == other.ExcludedFromCatalog ||
                ExcludedFromCatalog != null &&
                ExcludedFromCatalog.Equals(other.ExcludedFromCatalog)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                Rule == other.Rule ||
                Rule != null &&
                Rule.Equals(other.Rule)
            ) &&
            (
                EnforceContentOrder == other.EnforceContentOrder ||
                EnforceContentOrder != null &&
                EnforceContentOrder.Equals(other.EnforceContentOrder)
            ) &&
            (
                ReviewAssessmentResults == other.ReviewAssessmentResults ||
                ReviewAssessmentResults != null &&
                ReviewAssessmentResults.Equals(other.ReviewAssessmentResults)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                IsArchived == other.IsArchived ||
                IsArchived != null &&
                IsArchived.Equals(other.IsArchived)
            ) &&
            (
                IsPublished == other.IsPublished ||
                IsPublished != null &&
                IsPublished.Equals(other.IsPublished)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                CompletionTimeInDays == other.CompletionTimeInDays ||
                CompletionTimeInDays != null &&
                CompletionTimeInDays.Equals(other.CompletionTimeInDays)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                InformSteps == other.InformSteps ||
                InformSteps != null &&
                InformSteps.SequenceEqual(other.InformSteps)
            ) &&
            (
                AssessmentForm == other.AssessmentForm ||
                AssessmentForm != null &&
                AssessmentForm.Equals(other.AssessmentForm)
            ) &&
            (
                SummaryData == other.SummaryData ||
                SummaryData != null &&
                SummaryData.Equals(other.SummaryData)
            ) &&
            (
                ReassignSummaryData == other.ReassignSummaryData ||
                ReassignSummaryData != null &&
                ReassignSummaryData.Equals(other.ReassignSummaryData)
            ) &&
            (
                CoverArt == other.CoverArt ||
                CoverArt != null &&
                CoverArt.Equals(other.CoverArt)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                ArchivalMode == other.ArchivalMode ||
                ArchivalMode != null &&
                ArchivalMode.Equals(other.ArchivalMode)
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

            if (ExcludedFromCatalog != null)
            {
                hash = hash * 59 + ExcludedFromCatalog.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (Rule != null)
            {
                hash = hash * 59 + Rule.GetHashCode();
            }

            if (EnforceContentOrder != null)
            {
                hash = hash * 59 + EnforceContentOrder.GetHashCode();
            }

            if (ReviewAssessmentResults != null)
            {
                hash = hash * 59 + ReviewAssessmentResults.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (IsArchived != null)
            {
                hash = hash * 59 + IsArchived.GetHashCode();
            }

            if (IsPublished != null)
            {
                hash = hash * 59 + IsPublished.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (CompletionTimeInDays != null)
            {
                hash = hash * 59 + CompletionTimeInDays.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (InformSteps != null)
            {
                hash = hash * 59 + InformSteps.GetHashCode();
            }

            if (AssessmentForm != null)
            {
                hash = hash * 59 + AssessmentForm.GetHashCode();
            }

            if (SummaryData != null)
            {
                hash = hash * 59 + SummaryData.GetHashCode();
            }

            if (ReassignSummaryData != null)
            {
                hash = hash * 59 + ReassignSummaryData.GetHashCode();
            }

            if (CoverArt != null)
            {
                hash = hash * 59 + CoverArt.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (ArchivalMode != null)
            {
                hash = hash * 59 + ArchivalMode.GetHashCode();
            }

            return hash;
        }
    }
}
