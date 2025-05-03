using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TopicOffset
/// </summary>

public partial class TopicOffset : IEquatable<TopicOffset>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TopicOffset" /> class.
    /// </summary>
    public TopicOffset()
    {

    }



    /// <summary>
    /// Count of words before the topic 
    /// </summary>
    /// <value>Count of words before the topic </value>
    [JsonPropertyName("wordCount")]
    public long? WordCount { get; private set; }



    /// <summary>
    /// Count of characters before the topic 
    /// </summary>
    /// <value>Count of characters before the topic </value>
    [JsonPropertyName("characterCount")]
    public long? CharacterCount { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TopicOffset {\n");

        sb.Append("  WordCount: ").Append(WordCount).Append("\n");
        sb.Append("  CharacterCount: ").Append(CharacterCount).Append("\n");
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
        return Equals(obj as TopicOffset);
    }

    /// <summary>
    /// Returns true if TopicOffset instances are equal
    /// </summary>
    /// <param name="other">Instance of TopicOffset to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TopicOffset other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WordCount == other.WordCount ||
                WordCount != null &&
                WordCount.Equals(other.WordCount)
            ) &&
            (
                CharacterCount == other.CharacterCount ||
                CharacterCount != null &&
                CharacterCount.Equals(other.CharacterCount)
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
            if (WordCount != null)
            {
                hash = hash * 59 + WordCount.GetHashCode();
            }

            if (CharacterCount != null)
            {
                hash = hash * 59 + CharacterCount.GetHashCode();
            }

            return hash;
        }
    }
}
