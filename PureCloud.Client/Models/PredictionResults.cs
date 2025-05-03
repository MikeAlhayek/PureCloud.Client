using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PredictionResults
/// </summary>

public partial class PredictionResults : IEquatable<PredictionResults>
{
    /// <summary>
    /// Indicates the media type scope of this estimated wait time
    /// </summary>
    /// <value>Indicates the media type scope of this estimated wait time</value>
    
    public enum IntentEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum All for "ALL"
        /// </summary>
        [EnumMember(Value = "ALL")]
        All,

        /// <summary>
        /// Enum Call for "CALL"
        /// </summary>
        [EnumMember(Value = "CALL")]
        Call,

        /// <summary>
        /// Enum Callback for "CALLBACK"
        /// </summary>
        [EnumMember(Value = "CALLBACK")]
        Callback,

        /// <summary>
        /// Enum Chat for "CHAT"
        /// </summary>
        [EnumMember(Value = "CHAT")]
        Chat,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Socialexpression for "SOCIALEXPRESSION"
        /// </summary>
        [EnumMember(Value = "SOCIALEXPRESSION")]
        Socialexpression,

        /// <summary>
        /// Enum Videocomm for "VIDEOCOMM"
        /// </summary>
        [EnumMember(Value = "VIDEOCOMM")]
        Videocomm,

        /// <summary>
        /// Enum Message for "MESSAGE"
        /// </summary>
        [EnumMember(Value = "MESSAGE")]
        Message
    }
    /// <summary>
    /// Indicates the estimated wait time Formula
    /// </summary>
    /// <value>Indicates the estimated wait time Formula</value>
    
    public enum FormulaEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Best for "BEST"
        /// </summary>
        [EnumMember(Value = "BEST")]
        Best,

        /// <summary>
        /// Enum Simple for "SIMPLE"
        /// </summary>
        [EnumMember(Value = "SIMPLE")]
        Simple,

        /// <summary>
        /// Enum Abandon for "ABANDON"
        /// </summary>
        [EnumMember(Value = "ABANDON")]
        Abandon,

        /// <summary>
        /// Enum PatienceAbandon for "PATIENCE_ABANDON"
        /// </summary>
        [EnumMember(Value = "PATIENCE_ABANDON")]
        PatienceAbandon
    }
    /// <summary>
    /// Indicates the media type scope of this estimated wait time
    /// </summary>
    /// <value>Indicates the media type scope of this estimated wait time</value>
    [JsonPropertyName("intent")]
    public IntentEnum? Intent { get; set; }
    /// <summary>
    /// Indicates the estimated wait time Formula
    /// </summary>
    /// <value>Indicates the estimated wait time Formula</value>
    [JsonPropertyName("formula")]
    public FormulaEnum? Formula { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PredictionResults" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PredictionResults() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictionResults" /> class.
    /// </summary>
    /// <param name="Intent">Indicates the media type scope of this estimated wait time.</param>
    /// <param name="Formula">Indicates the estimated wait time Formula (required).</param>
    /// <param name="EstimatedWaitTimeSeconds">Estimated wait time in seconds (required).</param>
    /// <param name="Label">This specifies the interaction label scoped to this estimated wait time calculation.</param>
    public PredictionResults(IntentEnum? Intent = null, FormulaEnum? Formula = null, int? EstimatedWaitTimeSeconds = null, AddressableEntityRef Label = null)
    {
        this.Intent = Intent;
        this.Formula = Formula;
        this.EstimatedWaitTimeSeconds = EstimatedWaitTimeSeconds;
        this.Label = Label;

    }







    /// <summary>
    /// Estimated wait time in seconds
    /// </summary>
    /// <value>Estimated wait time in seconds</value>
    [JsonPropertyName("estimatedWaitTimeSeconds")]
    public int? EstimatedWaitTimeSeconds { get; set; }



    /// <summary>
    /// This specifies the interaction label scoped to this estimated wait time calculation
    /// </summary>
    /// <value>This specifies the interaction label scoped to this estimated wait time calculation</value>
    [JsonPropertyName("label")]
    public AddressableEntityRef Label { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictionResults {\n");

        sb.Append("  Intent: ").Append(Intent).Append("\n");
        sb.Append("  Formula: ").Append(Formula).Append("\n");
        sb.Append("  EstimatedWaitTimeSeconds: ").Append(EstimatedWaitTimeSeconds).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
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
        return Equals(obj as PredictionResults);
    }

    /// <summary>
    /// Returns true if PredictionResults instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictionResults to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictionResults other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Intent == other.Intent ||
                Intent != null &&
                Intent.Equals(other.Intent)
            ) &&
            (
                Formula == other.Formula ||
                Formula != null &&
                Formula.Equals(other.Formula)
            ) &&
            (
                EstimatedWaitTimeSeconds == other.EstimatedWaitTimeSeconds ||
                EstimatedWaitTimeSeconds != null &&
                EstimatedWaitTimeSeconds.Equals(other.EstimatedWaitTimeSeconds)
            ) &&
            (
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
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
            if (Intent != null)
            {
                hash = hash * 59 + Intent.GetHashCode();
            }

            if (Formula != null)
            {
                hash = hash * 59 + Formula.GetHashCode();
            }

            if (EstimatedWaitTimeSeconds != null)
            {
                hash = hash * 59 + EstimatedWaitTimeSeconds.GetHashCode();
            }

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            return hash;
        }
    }
}
