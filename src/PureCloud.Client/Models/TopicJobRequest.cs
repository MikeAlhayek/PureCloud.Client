using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TopicJobRequest
/// </summary>

public partial class TopicJobRequest : IEquatable<TopicJobRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TopicJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TopicJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TopicJobRequest" /> class.
    /// </summary>
    /// <param name="TopicIds">The ids of the topics used for this job (required).</param>
    public TopicJobRequest(List<string> TopicIds = null)
    {
        this.TopicIds = TopicIds;

    }



    /// <summary>
    /// The ids of the topics used for this job
    /// </summary>
    /// <value>The ids of the topics used for this job</value>
    [JsonPropertyName("topicIds")]
    public List<string> TopicIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TopicJobRequest {\n");

        sb.Append("  TopicIds: ").Append(TopicIds).Append("\n");
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
        return Equals(obj as TopicJobRequest);
    }

    /// <summary>
    /// Returns true if TopicJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TopicJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TopicJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TopicIds == other.TopicIds ||
                TopicIds != null &&
                TopicIds.SequenceEqual(other.TopicIds)
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
            if (TopicIds != null)
            {
                hash = hash * 59 + TopicIds.GetHashCode();
            }

            return hash;
        }
    }
}
