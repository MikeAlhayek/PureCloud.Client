using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Phrase
/// </summary>

public partial class Phrase : IEquatable<Phrase>
{
    /// <summary>
    /// The phrase strictness, default value is null
    /// </summary>
    /// <value>The phrase strictness, default value is null</value>
    
    public enum StrictnessEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum _1 for "1"
        /// </summary>
        [EnumMember(Value = "1")]
        _1,

        /// <summary>
        /// Enum _55 for "55"
        /// </summary>
        [EnumMember(Value = "55")]
        _55,

        /// <summary>
        /// Enum _65 for "65"
        /// </summary>
        [EnumMember(Value = "65")]
        _65,

        /// <summary>
        /// Enum _72 for "72"
        /// </summary>
        [EnumMember(Value = "72")]
        _72,

        /// <summary>
        /// Enum _85 for "85"
        /// </summary>
        [EnumMember(Value = "85")]
        _85,

        /// <summary>
        /// Enum _90 for "90"
        /// </summary>
        [EnumMember(Value = "90")]
        _90
    }
    /// <summary>
    /// The phrase sentiment, default value is Unspecified. Note: Sentiment value for phrases is currently not in use and has no impact to the system.
    /// </summary>
    /// <value>The phrase sentiment, default value is Unspecified. Note: Sentiment value for phrases is currently not in use and has no impact to the system.</value>
    
    public enum SentimentEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unspecified for "Unspecified"
        /// </summary>
        [EnumMember(Value = "Unspecified")]
        Unspecified,

        /// <summary>
        /// Enum Positive for "Positive"
        /// </summary>
        [EnumMember(Value = "Positive")]
        Positive,

        /// <summary>
        /// Enum Neutral for "Neutral"
        /// </summary>
        [EnumMember(Value = "Neutral")]
        Neutral,

        /// <summary>
        /// Enum Negative for "Negative"
        /// </summary>
        [EnumMember(Value = "Negative")]
        Negative
    }
    /// <summary>
    /// The phrase strictness, default value is null
    /// </summary>
    /// <value>The phrase strictness, default value is null</value>
    [JsonPropertyName("strictness")]
    public StrictnessEnum? Strictness { get; set; }
    /// <summary>
    /// The phrase sentiment, default value is Unspecified. Note: Sentiment value for phrases is currently not in use and has no impact to the system.
    /// </summary>
    /// <value>The phrase sentiment, default value is Unspecified. Note: Sentiment value for phrases is currently not in use and has no impact to the system.</value>
    [JsonPropertyName("sentiment")]
    public SentimentEnum? Sentiment { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Phrase" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Phrase() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Phrase" /> class.
    /// </summary>
    /// <param name="Text">The phrase text (required).</param>
    /// <param name="Strictness">The phrase strictness, default value is null.</param>
    /// <param name="Sentiment">The phrase sentiment, default value is Unspecified. Note: Sentiment value for phrases is currently not in use and has no impact to the system..</param>
    public Phrase(string Text = null, StrictnessEnum? Strictness = null, SentimentEnum? Sentiment = null)
    {
        this.Text = Text;
        this.Strictness = Strictness;
        this.Sentiment = Sentiment;

    }



    /// <summary>
    /// The phrase text
    /// </summary>
    /// <value>The phrase text</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Phrase {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Strictness: ").Append(Strictness).Append("\n");
        sb.Append("  Sentiment: ").Append(Sentiment).Append("\n");
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
        return Equals(obj as Phrase);
    }

    /// <summary>
    /// Returns true if Phrase instances are equal
    /// </summary>
    /// <param name="other">Instance of Phrase to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Phrase other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Strictness == other.Strictness ||
                Strictness != null &&
                Strictness.Equals(other.Strictness)
            ) &&
            (
                Sentiment == other.Sentiment ||
                Sentiment != null &&
                Sentiment.Equals(other.Sentiment)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Strictness != null)
            {
                hash = hash * 59 + Strictness.GetHashCode();
            }

            if (Sentiment != null)
            {
                hash = hash * 59 + Sentiment.GetHashCode();
            }

            return hash;
        }
    }
}
