using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConfusionUtterance
/// </summary>

public partial class ConfusionUtterance : IEquatable<ConfusionUtterance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfusionUtterance" /> class.
    /// </summary>
    /// <param name="Text">Utterance Text..</param>
    /// <param name="Similarity">Utterance&#39;s similarity score, 0 being dissimilar and 1 being very similar..</param>
    public ConfusionUtterance(string Text = null, float? Similarity = null)
    {
        this.Text = Text;
        this.Similarity = Similarity;

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
    /// Utterance&#39;s similarity score, 0 being dissimilar and 1 being very similar.
    /// </summary>
    /// <value>Utterance&#39;s similarity score, 0 being dissimilar and 1 being very similar.</value>
    [JsonPropertyName("similarity")]
    public float? Similarity { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConfusionUtterance {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Similarity: ").Append(Similarity).Append("\n");
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
        return Equals(obj as ConfusionUtterance);
    }

    /// <summary>
    /// Returns true if ConfusionUtterance instances are equal
    /// </summary>
    /// <param name="other">Instance of ConfusionUtterance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConfusionUtterance other)
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
                Similarity == other.Similarity ||
                Similarity != null &&
                Similarity.Equals(other.Similarity)
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

            if (Similarity != null)
            {
                hash = hash * 59 + Similarity.GetHashCode();
            }

            return hash;
        }
    }
}
