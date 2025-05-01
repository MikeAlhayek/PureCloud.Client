using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingTemplateFooter
/// </summary>
[DataContract]
public partial class RecordingTemplateFooter : IEquatable<RecordingTemplateFooter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingTemplateFooter" /> class.
    /// </summary>
    /// <param name="Text">Footer text..</param>
    public RecordingTemplateFooter(string Text = null)
    {
        this.Text = Text;

    }



    /// <summary>
    /// Footer text.
    /// </summary>
    /// <value>Footer text.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingTemplateFooter {\n");

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
        return Equals(obj as RecordingTemplateFooter);
    }

    /// <summary>
    /// Returns true if RecordingTemplateFooter instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingTemplateFooter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingTemplateFooter other)
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
