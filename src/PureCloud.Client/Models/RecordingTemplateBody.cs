using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingTemplateBody
/// </summary>

public partial class RecordingTemplateBody : IEquatable<RecordingTemplateBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingTemplateBody" /> class.
    /// </summary>
    /// <param name="Text">Template parameters for placeholders in template..</param>
    public RecordingTemplateBody(string Text = null)
    {
        this.Text = Text;

    }



    /// <summary>
    /// Template parameters for placeholders in template.
    /// </summary>
    /// <value>Template parameters for placeholders in template.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingTemplateBody {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
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
        return Equals(obj as RecordingTemplateBody);
    }

    /// <summary>
    /// Returns true if RecordingTemplateBody instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingTemplateBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingTemplateBody other)
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

            return hash;
        }
    }
}
