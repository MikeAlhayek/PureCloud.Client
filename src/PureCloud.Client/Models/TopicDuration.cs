using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TopicDuration
/// </summary>

public partial class TopicDuration : IEquatable<TopicDuration>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TopicDuration" /> class.
    /// </summary>
    public TopicDuration()
    {

    }



    /// <summary>
    /// The total duration of the topic phrase within the conversation
    /// </summary>
    /// <value>The total duration of the topic phrase within the conversation</value>
    [JsonPropertyName("totalMilliseconds")]
    public long? TotalMilliseconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TopicDuration {\n");

        sb.Append("  TotalMilliseconds: ").Append(TotalMilliseconds).Append("\n");
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
        return Equals(obj as TopicDuration);
    }

    /// <summary>
    /// Returns true if TopicDuration instances are equal
    /// </summary>
    /// <param name="other">Instance of TopicDuration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TopicDuration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TotalMilliseconds == other.TotalMilliseconds ||
                TotalMilliseconds != null &&
                TotalMilliseconds.Equals(other.TotalMilliseconds)
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
            if (TotalMilliseconds != null)
            {
                hash = hash * 59 + TotalMilliseconds.GetHashCode();
            }

            return hash;
        }
    }
}
