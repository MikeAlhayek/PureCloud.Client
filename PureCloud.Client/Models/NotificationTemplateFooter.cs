using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Template footer object.
/// </summary>

public partial class NotificationTemplateFooter : IEquatable<NotificationTemplateFooter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationTemplateFooter" /> class.
    /// </summary>
    /// <param name="Text">Footer text. For WhatsApp, ignored..</param>
    public NotificationTemplateFooter(string Text = null)
    {
        this.Text = Text;

    }



    /// <summary>
    /// Footer text. For WhatsApp, ignored.
    /// </summary>
    /// <value>Footer text. For WhatsApp, ignored.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NotificationTemplateFooter {\n");

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
        return Equals(obj as NotificationTemplateFooter);
    }

    /// <summary>
    /// Returns true if NotificationTemplateFooter instances are equal
    /// </summary>
    /// <param name="other">Instance of NotificationTemplateFooter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NotificationTemplateFooter other)
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
