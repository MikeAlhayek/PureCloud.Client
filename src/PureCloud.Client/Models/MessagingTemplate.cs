using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The messaging template identifies a structured message templates supported by a messaging channel.
/// </summary>

public partial class MessagingTemplate : IEquatable<MessagingTemplate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingTemplate" /> class.
    /// </summary>
    /// <param name="WhatsApp">Defines a messaging template for a WhatsApp messaging channel.</param>
    public MessagingTemplate(WhatsAppDefinition WhatsApp = null)
    {
        this.WhatsApp = WhatsApp;

    }



    /// <summary>
    /// Defines a messaging template for a WhatsApp messaging channel
    /// </summary>
    /// <value>Defines a messaging template for a WhatsApp messaging channel</value>
    [JsonPropertyName("whatsApp")]
    public WhatsAppDefinition WhatsApp { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessagingTemplate {\n");

        sb.Append("  WhatsApp: ").Append(WhatsApp).Append("\n");
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
        return Equals(obj as MessagingTemplate);
    }

    /// <summary>
    /// Returns true if MessagingTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingTemplate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WhatsApp == other.WhatsApp ||
                WhatsApp != null &&
                WhatsApp.Equals(other.WhatsApp)
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
            if (WhatsApp != null)
            {
                hash = hash * 59 + WhatsApp.GetHashCode();
            }

            return hash;
        }
    }
}
