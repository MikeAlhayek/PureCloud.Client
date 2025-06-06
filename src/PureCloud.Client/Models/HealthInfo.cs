using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HealthInfo
/// </summary>

public partial class HealthInfo : IEquatable<HealthInfo>
{
    /// <summary>
    /// Status of health computation for this intent.
    /// </summary>
    /// <value>Status of health computation for this intent.</value>
    
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
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Gets or Sets StaticValidationResults
    /// </summary>
    
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
    /// Status of health computation for this intent.
    /// </summary>
    /// <value>Status of health computation for this intent.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="HealthInfo" /> class.
    /// </summary>
    /// <param name="Status">Status of health computation for this intent..</param>
    /// <param name="ErrorInfo">Error details for the intent, if any..</param>
    /// <param name="OverallScore">Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score..</param>
    /// <param name="IssueCount">Number of issues found in the intent..</param>
    /// <param name="StaticValidationResults">Validation results for the intent..</param>
    /// <param name="Utterances">Utterances for this intent..</param>
    public HealthInfo(StatusEnum? Status = null, FlowHealthErrorInfo ErrorInfo = null, float? OverallScore = null, long? IssueCount = null, List<StaticValidationResultsEnum> StaticValidationResults = null, List<FlowHealthIntentUtterance> Utterances = null)
    {
        this.Status = Status;
        this.ErrorInfo = ErrorInfo;
        this.OverallScore = OverallScore;
        this.IssueCount = IssueCount;
        this.StaticValidationResults = StaticValidationResults;
        this.Utterances = Utterances;

    }





    /// <summary>
    /// Error details for the intent, if any.
    /// </summary>
    /// <value>Error details for the intent, if any.</value>
    [JsonPropertyName("errorInfo")]
    public FlowHealthErrorInfo ErrorInfo { get; set; }



    /// <summary>
    /// Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score.
    /// </summary>
    /// <value>Overall health score for the intent ranged between 0 and 100 as 100 is the perfect health score.</value>
    [JsonPropertyName("overallScore")]
    public float? OverallScore { get; set; }



    /// <summary>
    /// Number of issues found in the intent.
    /// </summary>
    /// <value>Number of issues found in the intent.</value>
    [JsonPropertyName("issueCount")]
    public long? IssueCount { get; set; }



    /// <summary>
    /// Validation results for the intent.
    /// </summary>
    /// <value>Validation results for the intent.</value>
    [JsonPropertyName("staticValidationResults")]
    public List<StaticValidationResultsEnum> StaticValidationResults { get; set; }



    /// <summary>
    /// Utterances for this intent.
    /// </summary>
    /// <value>Utterances for this intent.</value>
    [JsonPropertyName("utterances")]
    public List<FlowHealthIntentUtterance> Utterances { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HealthInfo {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  OverallScore: ").Append(OverallScore).Append("\n");
        sb.Append("  IssueCount: ").Append(IssueCount).Append("\n");
        sb.Append("  StaticValidationResults: ").Append(StaticValidationResults).Append("\n");
        sb.Append("  Utterances: ").Append(Utterances).Append("\n");
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
        return Equals(obj as HealthInfo);
    }

    /// <summary>
    /// Returns true if HealthInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of HealthInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HealthInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
            ) &&
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
            ) &&
            (
                Utterances == other.Utterances ||
                Utterances != null &&
                Utterances.SequenceEqual(other.Utterances)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

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

            if (Utterances != null)
            {
                hash = hash * 59 + Utterances.GetHashCode();
            }

            return hash;
        }
    }
}
