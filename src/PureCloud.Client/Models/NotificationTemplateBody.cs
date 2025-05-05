using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Template body object.
/// </summary>

public partial class NotificationTemplateBody : IEquatable<NotificationTemplateBody>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationTemplateBody" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NotificationTemplateBody() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NotificationTemplateBody" /> class.
    /// </summary>
    /// <param name="Text">Body text. For WhatsApp, ignored..</param>
    /// <param name="Parameters">Template parameters for placeholders in template. (required).</param>
    public NotificationTemplateBody(string Text = null, List<NotificationTemplateParameter> Parameters = null)
    {
        this.Text = Text;
        this.Parameters = Parameters;

    }



    /// <summary>
    /// Body text. For WhatsApp, ignored.
    /// </summary>
    /// <value>Body text. For WhatsApp, ignored.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Template parameters for placeholders in template.
    /// </summary>
    /// <value>Template parameters for placeholders in template.</value>
    [JsonPropertyName("parameters")]
    public List<NotificationTemplateParameter> Parameters { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NotificationTemplateBody {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
        return Equals(obj as NotificationTemplateBody);
    }

    /// <summary>
    /// Returns true if NotificationTemplateBody instances are equal
    /// </summary>
    /// <param name="other">Instance of NotificationTemplateBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NotificationTemplateBody other)
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
                Parameters == other.Parameters ||
                Parameters != null &&
                Parameters.SequenceEqual(other.Parameters)
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

            if (Parameters != null)
            {
                hash = hash * 59 + Parameters.GetHashCode();
            }

            return hash;
        }
    }
}
