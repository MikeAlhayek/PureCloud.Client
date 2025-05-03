using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Template notification object.
/// </summary>

public partial class ContentNotificationTemplate : IEquatable<ContentNotificationTemplate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContentNotificationTemplate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContentNotificationTemplate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentNotificationTemplate" /> class.
    /// </summary>
    /// <param name="Id">The messaging provider template ID. For WhatsApp, &#39;namespace@name&#39;..</param>
    /// <param name="Language">Template language..</param>
    /// <param name="Header">The template header..</param>
    /// <param name="Body">The template body. (required).</param>
    /// <param name="Buttons">Template buttons.</param>
    /// <param name="Footer">The template footer..</param>
    public ContentNotificationTemplate(string Id = null, string Language = null, NotificationTemplateHeader Header = null, NotificationTemplateBody Body = null, List<NotificationTemplateButton> Buttons = null, NotificationTemplateFooter Footer = null)
    {
        this.Id = Id;
        this.Language = Language;
        this.Header = Header;
        this.Body = Body;
        this.Buttons = Buttons;
        this.Footer = Footer;

    }



    /// <summary>
    /// The messaging provider template ID. For WhatsApp, &#39;namespace@name&#39;.
    /// </summary>
    /// <value>The messaging provider template ID. For WhatsApp, &#39;namespace@name&#39;.</value>
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
    public NotificationTemplateHeader Header { get; set; }



    /// <summary>
    /// The template body.
    /// </summary>
    /// <value>The template body.</value>
    [JsonPropertyName("body")]
    public NotificationTemplateBody Body { get; set; }



    /// <summary>
    /// Template buttons
    /// </summary>
    /// <value>Template buttons</value>
    [JsonPropertyName("buttons")]
    public List<NotificationTemplateButton> Buttons { get; set; }



    /// <summary>
    /// The template footer.
    /// </summary>
    /// <value>The template footer.</value>
    [JsonPropertyName("footer")]
    public NotificationTemplateFooter Footer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentNotificationTemplate {\n");

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
        return Equals(obj as ContentNotificationTemplate);
    }

    /// <summary>
    /// Returns true if ContentNotificationTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentNotificationTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentNotificationTemplate other)
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
