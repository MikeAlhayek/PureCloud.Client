using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestionFeedback
/// </summary>

public partial class SuggestionFeedback : IEquatable<SuggestionFeedback>
{
    /// <summary>
    /// The rating value of the suggestion feedback.
    /// </summary>
    /// <value>The rating value of the suggestion feedback.</value>
    
    public enum RatingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Negative for "Negative"
        /// </summary>
        [EnumMember(Value = "Negative")]
        Negative,

        /// <summary>
        /// Enum Positive for "Positive"
        /// </summary>
        [EnumMember(Value = "Positive")]
        Positive
    }
    /// <summary>
    /// The rating value of the suggestion feedback.
    /// </summary>
    /// <value>The rating value of the suggestion feedback.</value>
    [JsonPropertyName("rating")]
    public RatingEnum? Rating { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionFeedback" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SuggestionFeedback() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionFeedback" /> class.
    /// </summary>
    /// <param name="Rating">The rating value of the suggestion feedback. (required).</param>
    public SuggestionFeedback(RatingEnum? Rating = null)
    {
        this.Rating = Rating;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestionFeedback {\n");

        sb.Append("  Rating: ").Append(Rating).Append("\n");
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
        return Equals(obj as SuggestionFeedback);
    }

    /// <summary>
    /// Returns true if SuggestionFeedback instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestionFeedback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestionFeedback other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Rating == other.Rating ||
                Rating != null &&
                Rating.Equals(other.Rating)
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
            if (Rating != null)
            {
                hash = hash * 59 + Rating.GetHashCode();
            }

            return hash;
        }
    }
}
