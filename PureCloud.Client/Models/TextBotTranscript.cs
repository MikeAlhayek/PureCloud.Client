using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Data for a single bot flow transcript.
/// </summary>
[DataContract]
public partial class TextBotTranscript : IEquatable<TextBotTranscript>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotTranscript" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotTranscript() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotTranscript" /> class.
    /// </summary>
    /// <param name="Text">The text of the transcript item. (required).</param>
    /// <param name="Confidence">The confidence factor, expressed as a decimal between 0.0 and 1.0, of the transcript item..</param>
    public TextBotTranscript(string Text = null, float? Confidence = null)
    {
        this.Text = Text;
        this.Confidence = Confidence;

    }



    /// <summary>
    /// The text of the transcript item.
    /// </summary>
    /// <value>The text of the transcript item.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// The confidence factor, expressed as a decimal between 0.0 and 1.0, of the transcript item.
    /// </summary>
    /// <value>The confidence factor, expressed as a decimal between 0.0 and 1.0, of the transcript item.</value>
    [DataMember(Name = "confidence", EmitDefaultValue = false)]
    public float? Confidence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotTranscript {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
        return Equals(obj as TextBotTranscript);
    }

    /// <summary>
    /// Returns true if TextBotTranscript instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotTranscript to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotTranscript other)
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
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
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

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            return hash;
        }
    }
}
