using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A WhatsApp messaging template definition as defined in the WhatsApp Business Manager
/// </summary>

public partial class WhatsAppDefinition : IEquatable<WhatsAppDefinition>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppDefinition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WhatsAppDefinition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppDefinition" /> class.
    /// </summary>
    /// <param name="Name">The messaging template name. (required).</param>
    /// <param name="Namespace">The messaging template namespace..</param>
    /// <param name="Language">The messaging template language configured for this template. This is a WhatsApp specific value. For example, &#39;en_US&#39; (required).</param>
    /// <param name="Buttons">List of buttons to be included in the WhatsApp messages channel.</param>
    /// <param name="MessageFooter">Footer for the message in the WhatsApp messages channel.</param>
    /// <param name="Header">Header for the message in the WhatsApp messages channel.</param>
    public WhatsAppDefinition(string Name = null, string Namespace = null, string Language = null, List<Button> Buttons = null, MessageFooter MessageFooter = null, MessageHeader Header = null)
    {
        this.Name = Name;
        this.Namespace = Namespace;
        this.Language = Language;
        this.Buttons = Buttons;
        this.MessageFooter = MessageFooter;
        this.Header = Header;

    }



    /// <summary>
    /// The messaging template name.
    /// </summary>
    /// <value>The messaging template name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The messaging template namespace.
    /// </summary>
    /// <value>The messaging template namespace.</value>
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }



    /// <summary>
    /// The messaging template language configured for this template. This is a WhatsApp specific value. For example, &#39;en_US&#39;
    /// </summary>
    /// <value>The messaging template language configured for this template. This is a WhatsApp specific value. For example, &#39;en_US&#39;</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// List of buttons to be included in the WhatsApp messages channel
    /// </summary>
    /// <value>List of buttons to be included in the WhatsApp messages channel</value>
    [JsonPropertyName("buttons")]
    public List<Button> Buttons { get; set; }



    /// <summary>
    /// Footer for the message in the WhatsApp messages channel
    /// </summary>
    /// <value>Footer for the message in the WhatsApp messages channel</value>
    [JsonPropertyName("messageFooter")]
    public MessageFooter MessageFooter { get; set; }



    /// <summary>
    /// Header for the message in the WhatsApp messages channel
    /// </summary>
    /// <value>Header for the message in the WhatsApp messages channel</value>
    [JsonPropertyName("header")]
    public MessageHeader Header { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WhatsAppDefinition {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Namespace: ").Append(Namespace).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Buttons: ").Append(Buttons).Append("\n");
        sb.Append("  MessageFooter: ").Append(MessageFooter).Append("\n");
        sb.Append("  Header: ").Append(Header).Append("\n");
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
        return Equals(obj as WhatsAppDefinition);
    }

    /// <summary>
    /// Returns true if WhatsAppDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of WhatsAppDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WhatsAppDefinition other)
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
                Namespace == other.Namespace ||
                Namespace != null &&
                Namespace.Equals(other.Namespace)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Buttons == other.Buttons ||
                Buttons != null &&
                Buttons.SequenceEqual(other.Buttons)
            ) &&
            (
                MessageFooter == other.MessageFooter ||
                MessageFooter != null &&
                MessageFooter.Equals(other.MessageFooter)
            ) &&
            (
                Header == other.Header ||
                Header != null &&
                Header.Equals(other.Header)
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

            if (Namespace != null)
            {
                hash = hash * 59 + Namespace.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Buttons != null)
            {
                hash = hash * 59 + Buttons.GetHashCode();
            }

            if (MessageFooter != null)
            {
                hash = hash * 59 + MessageFooter.GetHashCode();
            }

            if (Header != null)
            {
                hash = hash * 59 + Header.GetHashCode();
            }

            return hash;
        }
    }
}
