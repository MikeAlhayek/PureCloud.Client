using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssessmentForm
/// </summary>

public partial class AssessmentForm : IEquatable<AssessmentForm>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentForm" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AssessmentForm() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AssessmentForm" /> class.
    /// </summary>
    /// <param name="PassPercent">The pass percent for the assessment form (required).</param>
    /// <param name="QuestionGroups">A list of question groups (required).</param>
    public AssessmentForm(int? PassPercent = null, List<AssessmentFormQuestionGroup> QuestionGroups = null)
    {
        this.PassPercent = PassPercent;
        this.QuestionGroups = QuestionGroups;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Last modified date of the assessment form. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date of the assessment form. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The unique Id for all versions of this assessment form
    /// </summary>
    /// <value>The unique Id for all versions of this assessment form</value>
    [JsonPropertyName("contextId")]
    public string ContextId { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }



    /// <summary>
    /// If true, assessment form is published
    /// </summary>
    /// <value>If true, assessment form is published</value>
    [JsonPropertyName("published")]
    public bool? Published { get; private set; }



    /// <summary>
    /// The pass percent for the assessment form
    /// </summary>
    /// <value>The pass percent for the assessment form</value>
    [JsonPropertyName("passPercent")]
    public int? PassPercent { get; set; }



    /// <summary>
    /// A list of question groups
    /// </summary>
    /// <value>A list of question groups</value>
    [JsonPropertyName("questionGroups")]
    public List<AssessmentFormQuestionGroup> QuestionGroups { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AssessmentForm {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  PassPercent: ").Append(PassPercent).Append("\n");
        sb.Append("  QuestionGroups: ").Append(QuestionGroups).Append("\n");
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
        return Equals(obj as AssessmentForm);
    }

    /// <summary>
    /// Returns true if AssessmentForm instances are equal
    /// </summary>
    /// <param name="other">Instance of AssessmentForm to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssessmentForm other)
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
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                PassPercent == other.PassPercent ||
                PassPercent != null &&
                PassPercent.Equals(other.PassPercent)
            ) &&
            (
                QuestionGroups == other.QuestionGroups ||
                QuestionGroups != null &&
                QuestionGroups.SequenceEqual(other.QuestionGroups)
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

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (PassPercent != null)
            {
                hash = hash * 59 + PassPercent.GetHashCode();
            }

            if (QuestionGroups != null)
            {
                hash = hash * 59 + QuestionGroups.GetHashCode();
            }

            return hash;
        }
    }
}
