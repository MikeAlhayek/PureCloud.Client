using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Learning module preview get response
/// </summary>

public partial class LearningModulePreviewGetResponse : IEquatable<LearningModulePreviewGetResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePreviewGetResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningModulePreviewGetResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningModulePreviewGetResponse" /> class.
    /// </summary>
    /// <param name="Name">The name of learning module (required).</param>
    /// <param name="Description">The description of learning module.</param>
    /// <param name="CoverArt">The cover art for the learning module.</param>
    /// <param name="EnforceContentOrder">If true, learning module content should be viewed one by one in order.</param>
    /// <param name="ReviewAssessmentResults">Allows to view Assessment results in detail.</param>
    /// <param name="AssessmentForm">The assessment form for learning module.</param>
    /// <param name="Assignment">the assignment preview.</param>
    public LearningModulePreviewGetResponse(string Name = null, string Description = null, LearningModuleCoverArtResponse CoverArt = null, bool? EnforceContentOrder = null, ReviewAssessmentResults ReviewAssessmentResults = null, AssessmentForm AssessmentForm = null, LearningModulePreviewGetResponseAssignment Assignment = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.CoverArt = CoverArt;
        this.EnforceContentOrder = EnforceContentOrder;
        this.ReviewAssessmentResults = ReviewAssessmentResults;
        this.AssessmentForm = AssessmentForm;
        this.Assignment = Assignment;

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
    /// The description of learning module
    /// </summary>
    /// <value>The description of learning module</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The cover art for the learning module
    /// </summary>
    /// <value>The cover art for the learning module</value>
    [JsonPropertyName("coverArt")]
    public LearningModuleCoverArtResponse CoverArt { get; set; }



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
    /// The assessment form for learning module
    /// </summary>
    /// <value>The assessment form for learning module</value>
    [JsonPropertyName("assessmentForm")]
    public AssessmentForm AssessmentForm { get; set; }



    /// <summary>
    /// the assignment preview
    /// </summary>
    /// <value>the assignment preview</value>
    [JsonPropertyName("assignment")]
    public LearningModulePreviewGetResponseAssignment Assignment { get; set; }



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
        sb.Append("class LearningModulePreviewGetResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  CoverArt: ").Append(CoverArt).Append("\n");
        sb.Append("  EnforceContentOrder: ").Append(EnforceContentOrder).Append("\n");
        sb.Append("  ReviewAssessmentResults: ").Append(ReviewAssessmentResults).Append("\n");
        sb.Append("  AssessmentForm: ").Append(AssessmentForm).Append("\n");
        sb.Append("  Assignment: ").Append(Assignment).Append("\n");
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
        return Equals(obj as LearningModulePreviewGetResponse);
    }

    /// <summary>
    /// Returns true if LearningModulePreviewGetResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningModulePreviewGetResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningModulePreviewGetResponse other)
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
                CoverArt == other.CoverArt ||
                CoverArt != null &&
                CoverArt.Equals(other.CoverArt)
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
                AssessmentForm == other.AssessmentForm ||
                AssessmentForm != null &&
                AssessmentForm.Equals(other.AssessmentForm)
            ) &&
            (
                Assignment == other.Assignment ||
                Assignment != null &&
                Assignment.Equals(other.Assignment)
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

            if (CoverArt != null)
            {
                hash = hash * 59 + CoverArt.GetHashCode();
            }

            if (EnforceContentOrder != null)
            {
                hash = hash * 59 + EnforceContentOrder.GetHashCode();
            }

            if (ReviewAssessmentResults != null)
            {
                hash = hash * 59 + ReviewAssessmentResults.GetHashCode();
            }

            if (AssessmentForm != null)
            {
                hash = hash * 59 + AssessmentForm.GetHashCode();
            }

            if (Assignment != null)
            {
                hash = hash * 59 + Assignment.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
