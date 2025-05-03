using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Template parameters for placeholders in template.
/// </summary>

public partial class ConversationNotificationTemplateParameter : IEquatable<ConversationNotificationTemplateParameter>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationNotificationTemplateParameter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationNotificationTemplateParameter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationNotificationTemplateParameter" /> class.
    /// </summary>
    /// <param name="Name">Parameter name..</param>
    /// <param name="Text">Parameter text value. (required).</param>
    public ConversationNotificationTemplateParameter(string Name = null, string Text = null)
    {
        this.Name = Name;
        this.Text = Text;

    }



    /// <summary>
    /// Parameter name.
    /// </summary>
    /// <value>Parameter name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Parameter text value.
    /// </summary>
    /// <value>Parameter text value.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationNotificationTemplateParameter {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as ConversationNotificationTemplateParameter);
    }

    /// <summary>
    /// Returns true if ConversationNotificationTemplateParameter instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationNotificationTemplateParameter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationNotificationTemplateParameter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            return hash;
        }
    }
}
