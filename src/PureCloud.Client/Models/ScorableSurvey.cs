using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ScorableSurvey
/// </summary>

public partial class ScorableSurvey : IEquatable<ScorableSurvey>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
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
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Sent for "Sent"
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Finished for "Finished"
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished,

        /// <summary>
        /// Enum Optout for "OptOut"
        /// </summary>
        [EnumMember(Value = "OptOut")]
        Optout,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Expired for "Expired"
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScorableSurvey" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="SurveyForm">Survey form used for this survey..</param>
    /// <param name="Status">Status.</param>
    /// <param name="Answers">Answers.</param>
    public ScorableSurvey(string Name = null, SurveyForm SurveyForm = null, StatusEnum? Status = null, SurveyScoringSet Answers = null)
    {
        this.Name = Name;
        this.SurveyForm = SurveyForm;
        this.Status = Status;
        this.Answers = Answers;

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
    /// Survey form used for this survey.
    /// </summary>
    /// <value>Survey form used for this survey.</value>
    [JsonPropertyName("surveyForm")]
    public SurveyForm SurveyForm { get; set; }





    /// <summary>
    /// Gets or Sets Answers
    /// </summary>
    [JsonPropertyName("answers")]
    public SurveyScoringSet Answers { get; set; }



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
        sb.Append("class ScorableSurvey {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SurveyForm: ").Append(SurveyForm).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Answers: ").Append(Answers).Append("\n");
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
        return Equals(obj as ScorableSurvey);
    }

    /// <summary>
    /// Returns true if ScorableSurvey instances are equal
    /// </summary>
    /// <param name="other">Instance of ScorableSurvey to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScorableSurvey other)
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
                SurveyForm == other.SurveyForm ||
                SurveyForm != null &&
                SurveyForm.Equals(other.SurveyForm)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Answers == other.Answers ||
                Answers != null &&
                Answers.Equals(other.Answers)
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

            if (SurveyForm != null)
            {
                hash = hash * 59 + SurveyForm.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Answers != null)
            {
                hash = hash * 59 + Answers.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
