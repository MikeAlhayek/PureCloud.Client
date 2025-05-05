using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Template notification object.
/// </summary>

public partial class ConversationContentNotificationTemplate : IEquatable<ConversationContentNotificationTemplate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentNotificationTemplate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationContentNotificationTemplate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentNotificationTemplate" /> class.
    /// </summary>
    /// <param name="Id">The identifier of the message template in &#39;your-namespace@your-template-id/name&#39; format. For External vendor (e.g WhatsApp), &#39;your-namespace@your-template-name&#39;. For GenesysCloud canned response message template use &#39;cannedresponse&#39; as your-namespace and use response ID as your-template-id (e.g. response ID&#x3D;1234 then &#39;cannedresponse@1234&#39;).</param>
    /// <param name="Language">Template language..</param>
    /// <param name="Header">The template header..</param>
    /// <param name="Body">The template body. (required).</param>
    /// <param name="Buttons">Template buttons.</param>
    /// <param name="Footer">The template footer..</param>
    public ConversationContentNotificationTemplate(string Id = null, string Language = null, ConversationNotificationTemplateHeader Header = null, ConversationNotificationTemplateBody Body = null, List<ConversationNotificationTemplateButton> Buttons = null, ConversationNotificationTemplateFooter Footer = null)
    {
        this.Id = Id;
        this.Language = Language;
        this.Header = Header;
        this.Body = Body;
        this.Buttons = Buttons;
        this.Footer = Footer;

    }



    /// <summary>
    /// The identifier of the message template in &#39;your-namespace@your-template-id/name&#39; format. For External vendor (e.g WhatsApp), &#39;your-namespace@your-template-name&#39;. For GenesysCloud canned response message template use &#39;cannedresponse&#39; as your-namespace and use response ID as your-template-id (e.g. response ID&#x3D;1234 then &#39;cannedresponse@1234&#39;)
    /// </summary>
    /// <value>The identifier of the message template in &#39;your-namespace@your-template-id/name&#39; format. For External vendor (e.g WhatsApp), &#39;your-namespace@your-template-name&#39;. For GenesysCloud canned response message template use &#39;cannedresponse&#39; as your-namespace and use response ID as your-template-id (e.g. response ID&#x3D;1234 then &#39;cannedresponse@1234&#39;)</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Template language.
    /// </summary>
    /// <value>Template language.</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// The template header.
    /// </summary>
    /// <value>The template header.</value>
    [JsonPropertyName("header")]
    public ConversationNotificationTemplateHeader Header { get; set; }



    /// <summary>
    /// The template body.
    /// </summary>
    /// <value>The template body.</value>
    [JsonPropertyName("body")]
    public ConversationNotificationTemplateBody Body { get; set; }



    /// <summary>
    /// Template buttons
    /// </summary>
    /// <value>Template buttons</value>
    [JsonPropertyName("buttons")]
    public List<ConversationNotificationTemplateButton> Buttons { get; set; }



    /// <summary>
    /// The template footer.
    /// </summary>
    /// <value>The template footer.</value>
    [JsonPropertyName("footer")]
    public ConversationNotificationTemplateFooter Footer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationContentNotificationTemplate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Header: ").Append(Header).Append("\n");
        sb.Append("  Body: ").Append(Body).Append("\n");
        sb.Append("  Buttons: ").Append(Buttons).Append("\n");
        sb.Append("  Footer: ").Append(Footer).Append("\n");
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
        return Equals(obj as ConversationContentNotificationTemplate);
    }

    /// <summary>
    /// Returns true if ConversationContentNotificationTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationContentNotificationTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationContentNotificationTemplate other)
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
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Header == other.Header ||
                Header != null &&
                Header.Equals(other.Header)
            ) &&
            (
                Body == other.Body ||
                Body != null &&
                Body.Equals(other.Body)
            ) &&
            (
                Buttons == other.Buttons ||
                Buttons != null &&
                Buttons.SequenceEqual(other.Buttons)
            ) &&
            (
                Footer == other.Footer ||
                Footer != null &&
                Footer.Equals(other.Footer)
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

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Header != null)
            {
                hash = hash * 59 + Header.GetHashCode();
            }

            if (Body != null)
            {
                hash = hash * 59 + Body.GetHashCode();
            }

            if (Buttons != null)
            {
                hash = hash * 59 + Buttons.GetHashCode();
            }

            if (Footer != null)
            {
                hash = hash * 59 + Footer.GetHashCode();
            }

            return hash;
        }
    }
}
