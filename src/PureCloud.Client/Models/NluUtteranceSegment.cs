using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluUtteranceSegment
/// </summary>

public partial class NluUtteranceSegment : IEquatable<NluUtteranceSegment>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluUtteranceSegment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluUtteranceSegment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluUtteranceSegment" /> class.
    /// </summary>
    /// <param name="Text">The text of the segment. (required).</param>
    /// <param name="Entity">The entity annotation of the segment..</param>
    public NluUtteranceSegment(string Text = null, NamedEntityAnnotation Entity = null)
    {
        this.Text = Text;
        this.Entity = Entity;

    }



    /// <summary>
    /// The text of the segment.
    /// </summary>
    /// <value>The text of the segment.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// The entity annotation of the segment.
    /// </summary>
    /// <value>The entity annotation of the segment.</value>
    [JsonPropertyName("entity")]
    public NamedEntityAnnotation Entity { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluUtteranceSegment {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
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
        return Equals(obj as NluUtteranceSegment);
    }

    /// <summary>
    /// Returns true if NluUtteranceSegment instances are equal
    /// </summary>
    /// <param name="other">Instance of NluUtteranceSegment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluUtteranceSegment other)
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
                Entity == other.Entity ||
                Entity != null &&
                Entity.Equals(other.Entity)
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

            if (Entity != null)
            {
                hash = hash * 59 + Entity.GetHashCode();
            }

            return hash;
        }
    }
}
