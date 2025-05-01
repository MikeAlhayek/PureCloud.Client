using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// TopicPhrase
/// </summary>
[DataContract]
public partial class TopicPhrase : IEquatable<TopicPhrase>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TopicPhrase" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Text">Text.</param>
    /// <param name="UtteranceCount">UtteranceCount.</param>
    public TopicPhrase(string Id = null, string Text = null, int? UtteranceCount = null)
    {
        this.Id = Id;
        this.Text = Text;
        this.UtteranceCount = UtteranceCount;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets UtteranceCount
    /// </summary>
    [DataMember(Name = "utteranceCount", EmitDefaultValue = false)]
    public int? UtteranceCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TopicPhrase {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
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
        return Equals(obj as TopicPhrase);
    }

    /// <summary>
    /// Returns true if TopicPhrase instances are equal
    /// </summary>
    /// <param name="other">Instance of TopicPhrase to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TopicPhrase other)
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
                UtteranceCount == other.UtteranceCount ||
                UtteranceCount != null &&
                UtteranceCount.Equals(other.UtteranceCount)
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

            if (UtteranceCount != null)
            {
                hash = hash * 59 + UtteranceCount.GetHashCode();
            }

            return hash;
        }
    }
}
