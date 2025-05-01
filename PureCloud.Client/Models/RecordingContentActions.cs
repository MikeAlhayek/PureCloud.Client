using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// User actions available on the content. All actions are optional and all actions are executed simultaneously.
/// </summary>
[DataContract]
public partial class RecordingContentActions : IEquatable<RecordingContentActions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingContentActions" /> class.
    /// </summary>
    /// <param name="Url">A URL of a web page to direct the user to..</param>
    /// <param name="UrlTarget">The target window in which to open the URL. If empty will open a blank page or tab..</param>
    /// <param name="Textback">Text to be sent back in reply when the item is selected..</param>
    public RecordingContentActions(string Url = null, string UrlTarget = null, string Textback = null)
    {
        this.Url = Url;
        this.UrlTarget = UrlTarget;
        this.Textback = Textback;

    }



    /// <summary>
    /// A URL of a web page to direct the user to.
    /// </summary>
    /// <value>A URL of a web page to direct the user to.</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; set; }



    /// <summary>
    /// The target window in which to open the URL. If empty will open a blank page or tab.
    /// </summary>
    /// <value>The target window in which to open the URL. If empty will open a blank page or tab.</value>
    [DataMember(Name = "urlTarget", EmitDefaultValue = false)]
    public string UrlTarget { get; set; }



    /// <summary>
    /// Text to be sent back in reply when the item is selected.
    /// </summary>
    /// <value>Text to be sent back in reply when the item is selected.</value>
    [DataMember(Name = "textback", EmitDefaultValue = false)]
    public string Textback { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingContentActions {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  UrlTarget: ").Append(UrlTarget).Append("\n");
        sb.Append("  Textback: ").Append(Textback).Append("\n");
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
        return Equals(obj as RecordingContentActions);
    }

    /// <summary>
    /// Returns true if RecordingContentActions instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingContentActions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingContentActions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                UrlTarget == other.UrlTarget ||
                UrlTarget != null &&
                UrlTarget.Equals(other.UrlTarget)
            ) &&
            (
                Textback == other.Textback ||
                Textback != null &&
                Textback.Equals(other.Textback)
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (UrlTarget != null)
            {
                hash = hash * 59 + UrlTarget.GetHashCode();
            }

            if (Textback != null)
            {
                hash = hash * 59 + Textback.GetHashCode();
            }

            return hash;
        }
    }
}
