using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestionEngagement
/// </summary>

public partial class SuggestionEngagement : IEquatable<SuggestionEngagement>
{
    /// <summary>
    /// The type of engagement with the suggestion.
    /// </summary>
    /// <value>The type of engagement with the suggestion.</value>
    
    public enum EngagementTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Dismissed for "Dismissed"
        /// </summary>
        [EnumMember(Value = "Dismissed")]
        Dismissed,

        /// <summary>
        /// Enum Copied for "Copied"
        /// </summary>
        [EnumMember(Value = "Copied")]
        Copied,

        /// <summary>
        /// Enum Opened for "Opened"
        /// </summary>
        [EnumMember(Value = "Opened")]
        Opened,

        /// <summary>
        /// Enum Feedback for "Feedback"
        /// </summary>
        [EnumMember(Value = "Feedback")]
        Feedback
    }
    /// <summary>
    /// The type of engagement with the suggestion.
    /// </summary>
    /// <value>The type of engagement with the suggestion.</value>
    [JsonPropertyName("engagementType")]
    public EngagementTypeEnum? EngagementType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionEngagement" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SuggestionEngagement() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionEngagement" /> class.
    /// </summary>
    /// <param name="EngagementType">The type of engagement with the suggestion. (required).</param>
    /// <param name="Feedback">The given feedback on the suggestion, if any..</param>
    public SuggestionEngagement(EngagementTypeEnum? EngagementType = null, SuggestionFeedback Feedback = null)
    {
        this.EngagementType = EngagementType;
        this.Feedback = Feedback;

    }





    /// <summary>
    /// The given feedback on the suggestion, if any.
    /// </summary>
    /// <value>The given feedback on the suggestion, if any.</value>
    [JsonPropertyName("feedback")]
    public SuggestionFeedback Feedback { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestionEngagement {\n");

        sb.Append("  EngagementType: ").Append(EngagementType).Append("\n");
        sb.Append("  Feedback: ").Append(Feedback).Append("\n");
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
        return Equals(obj as SuggestionEngagement);
    }

    /// <summary>
    /// Returns true if SuggestionEngagement instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestionEngagement to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestionEngagement other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EngagementType == other.EngagementType ||
                EngagementType != null &&
                EngagementType.Equals(other.EngagementType)
            ) &&
            (
                Feedback == other.Feedback ||
                Feedback != null &&
                Feedback.Equals(other.Feedback)
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
            if (EngagementType != null)
            {
                hash = hash * 59 + EngagementType.GetHashCode();
            }

            if (Feedback != null)
            {
                hash = hash * 59 + Feedback.GetHashCode();
            }

            return hash;
        }
    }
}
