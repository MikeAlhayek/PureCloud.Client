using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingNotificationTemplate
/// </summary>
[DataContract]
public partial class RecordingNotificationTemplate : IEquatable<RecordingNotificationTemplate>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingNotificationTemplate" /> class.
    /// </summary>
    /// <param name="Language">Template language..</param>
    /// <param name="Header">The template header..</param>
    /// <param name="Body">The template body..</param>
    /// <param name="Buttons">Template buttons.</param>
    /// <param name="Footer">The template footer..</param>
    public RecordingNotificationTemplate(string Language = null, RecordingTemplateHeader Header = null, RecordingTemplateBody Body = null, List<RecordingTemplateButton> Buttons = null, RecordingTemplateFooter Footer = null)
    {
        this.Language = Language;
        this.Header = Header;
        this.Body = Body;
        this.Buttons = Buttons;
        this.Footer = Footer;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Template language.
    /// </summary>
    /// <value>Template language.</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }



    /// <summary>
    /// The template header.
    /// </summary>
    /// <value>The template header.</value>
    [DataMember(Name = "header", EmitDefaultValue = false)]
    public RecordingTemplateHeader Header { get; set; }



    /// <summary>
    /// The template body.
    /// </summary>
    /// <value>The template body.</value>
    [DataMember(Name = "body", EmitDefaultValue = false)]
    public RecordingTemplateBody Body { get; set; }



    /// <summary>
    /// Template buttons
    /// </summary>
    /// <value>Template buttons</value>
    [DataMember(Name = "buttons", EmitDefaultValue = false)]
    public List<RecordingTemplateButton> Buttons { get; set; }



    /// <summary>
    /// The template footer.
    /// </summary>
    /// <value>The template footer.</value>
    [DataMember(Name = "footer", EmitDefaultValue = false)]
    public RecordingTemplateFooter Footer { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingNotificationTemplate {\n");

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
        return Equals(obj as RecordingNotificationTemplate);
    }

    /// <summary>
    /// Returns true if RecordingNotificationTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingNotificationTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingNotificationTemplate other)
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
