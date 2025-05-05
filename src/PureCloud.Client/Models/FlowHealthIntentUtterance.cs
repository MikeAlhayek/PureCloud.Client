using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowHealthIntentUtterance
/// </summary>

public partial class FlowHealthIntentUtterance : IEquatable<FlowHealthIntentUtterance>
{
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
    /// Initializes a new instance of the <see cref="FlowHealthIntentUtterance" /> class.
    /// </summary>
    /// <param name="Text">Utterance Text..</param>
    /// <param name="IssueCount">Number of issues found for this utterance..</param>
    /// <param name="StaticValidationResults">Validation results for this utterance..</param>
    /// <param name="OutlierInfo">Details about this utterance being an outlier or not..</param>
    /// <param name="ConfusionInfo">Confusion details with other utterances..</param>
    public FlowHealthIntentUtterance(string Text = null, long? IssueCount = null, List<StaticValidationResultsEnum> StaticValidationResults = null, OutlierInfo OutlierInfo = null, ConfusionInfo ConfusionInfo = null)
    {
        this.Text = Text;
        this.IssueCount = IssueCount;
        this.StaticValidationResults = StaticValidationResults;
        this.OutlierInfo = OutlierInfo;
        this.ConfusionInfo = ConfusionInfo;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Utterance Text.
    /// </summary>
    /// <value>Utterance Text.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Number of issues found for this utterance.
    /// </summary>
    /// <value>Number of issues found for this utterance.</value>
    [JsonPropertyName("issueCount")]
    public long? IssueCount { get; set; }



    /// <summary>
    /// Validation results for this utterance.
    /// </summary>
    /// <value>Validation results for this utterance.</value>
    [JsonPropertyName("staticValidationResults")]
    public List<StaticValidationResultsEnum> StaticValidationResults { get; set; }



    /// <summary>
    /// Details about this utterance being an outlier or not.
    /// </summary>
    /// <value>Details about this utterance being an outlier or not.</value>
    [JsonPropertyName("outlierInfo")]
    public OutlierInfo OutlierInfo { get; set; }



    /// <summary>
    /// Confusion details with other utterances.
    /// </summary>
    /// <value>Confusion details with other utterances.</value>
    [JsonPropertyName("confusionInfo")]
    public ConfusionInfo ConfusionInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowHealthIntentUtterance {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  IssueCount: ").Append(IssueCount).Append("\n");
        sb.Append("  StaticValidationResults: ").Append(StaticValidationResults).Append("\n");
        sb.Append("  OutlierInfo: ").Append(OutlierInfo).Append("\n");
        sb.Append("  ConfusionInfo: ").Append(ConfusionInfo).Append("\n");
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
        return Equals(obj as FlowHealthIntentUtterance);
    }

    /// <summary>
    /// Returns true if FlowHealthIntentUtterance instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowHealthIntentUtterance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowHealthIntentUtterance other)
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
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
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
                OutlierInfo == other.OutlierInfo ||
                OutlierInfo != null &&
                OutlierInfo.Equals(other.OutlierInfo)
            ) &&
            (
                ConfusionInfo == other.ConfusionInfo ||
                ConfusionInfo != null &&
                ConfusionInfo.Equals(other.ConfusionInfo)
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

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (IssueCount != null)
            {
                hash = hash * 59 + IssueCount.GetHashCode();
            }

            if (StaticValidationResults != null)
            {
                hash = hash * 59 + StaticValidationResults.GetHashCode();
            }

            if (OutlierInfo != null)
            {
                hash = hash * 59 + OutlierInfo.GetHashCode();
            }

            if (ConfusionInfo != null)
            {
                hash = hash * 59 + ConfusionInfo.GetHashCode();
            }

            return hash;
        }
    }
}
