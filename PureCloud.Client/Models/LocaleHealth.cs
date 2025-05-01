using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LocaleHealth
/// </summary>
[DataContract]
public partial class LocaleHealth : IEquatable<LocaleHealth>
{
    /// <summary>
    /// Gets or Sets StaticValidationResults
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StaticValidationResultsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Toofewutterances for "TooFewUtterances"
        /// </summary>
        [EnumMember(Value = "TooFewUtterances")]
        Toofewutterances,

        /// <summary>
        /// Enum Toomanyutterances for "TooManyUtterances"
        /// </summary>
        [EnumMember(Value = "TooManyUtterances")]
        Toomanyutterances,

        /// <summary>
        /// Enum Utterancetooshort for "UtteranceTooShort"
        /// </summary>
        [EnumMember(Value = "UtteranceTooShort")]
        Utterancetooshort,

        /// <summary>
        /// Enum Utterancetoolong for "UtteranceTooLong"
        /// </summary>
        [EnumMember(Value = "UtteranceTooLong")]
        Utterancetoolong
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="LocaleHealth" /> class.
    /// </summary>
    /// <param name="OverallScore">Overall health score for the intent..</param>
    /// <param name="IssueCount">Number of issues found in the intent..</param>
    /// <param name="StaticValidationResults">Validation results for the intent..</param>
    public LocaleHealth(float? OverallScore = null, long? IssueCount = null, List<StaticValidationResultsEnum> StaticValidationResults = null)
    {
        this.OverallScore = OverallScore;
        this.IssueCount = IssueCount;
        this.StaticValidationResults = StaticValidationResults;

    }



    /// <summary>
    /// Overall health score for the intent.
    /// </summary>
    /// <value>Overall health score for the intent.</value>
    [DataMember(Name = "overallScore", EmitDefaultValue = false)]
    public float? OverallScore { get; set; }



    /// <summary>
    /// Number of issues found in the intent.
    /// </summary>
    /// <value>Number of issues found in the intent.</value>
    [DataMember(Name = "issueCount", EmitDefaultValue = false)]
    public long? IssueCount { get; set; }



    /// <summary>
    /// Validation results for the intent.
    /// </summary>
    /// <value>Validation results for the intent.</value>
    [DataMember(Name = "staticValidationResults", EmitDefaultValue = false)]
    public List<StaticValidationResultsEnum> StaticValidationResults { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LocaleHealth {\n");

        sb.Append("  OverallScore: ").Append(OverallScore).Append("\n");
        sb.Append("  IssueCount: ").Append(IssueCount).Append("\n");
        sb.Append("  StaticValidationResults: ").Append(StaticValidationResults).Append("\n");
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
        return Equals(obj as LocaleHealth);
    }

    /// <summary>
    /// Returns true if LocaleHealth instances are equal
    /// </summary>
    /// <param name="other">Instance of LocaleHealth to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LocaleHealth other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OverallScore == other.OverallScore ||
                OverallScore != null &&
                OverallScore.Equals(other.OverallScore)
            ) &&
            (
                IssueCount == other.IssueCount ||
                IssueCount != null &&
                IssueCount.Equals(other.IssueCount)
            ) &&
            (
                StaticValidationResults == other.StaticValidationResults ||
                StaticValidationResults != null &&
                StaticValidationResults.SequenceEqual(other.StaticValidationResults)
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
            if (OverallScore != null)
            {
                hash = hash * 59 + OverallScore.GetHashCode();
            }

            if (IssueCount != null)
            {
                hash = hash * 59 + IssueCount.GetHashCode();
            }

            if (StaticValidationResults != null)
            {
                hash = hash * 59 + StaticValidationResults.GetHashCode();
            }

            return hash;
        }
    }
}
