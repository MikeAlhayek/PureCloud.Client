using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Structured template button object.
/// </summary>
[DataContract]
public partial class ButtonComponent : IEquatable<ButtonComponent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ButtonComponent" /> class.
    /// </summary>
    /// <param name="Title">Text to show inside the button..</param>
    /// <param name="Actions">The button actions (Deprecated)..</param>
    public ButtonComponent(string Title = null, ContentActions Actions = null)
    {
        this.Title = Title;
        this.Actions = Actions;

    }



    /// <summary>
    /// Text to show inside the button.
    /// </summary>
    /// <value>Text to show inside the button.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// The button actions (Deprecated).
    /// </summary>
    /// <value>The button actions (Deprecated).</value>
    [DataMember(Name = "actions", EmitDefaultValue = false)]
    public ContentActions Actions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ButtonComponent {\n");

        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
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
        return Equals(obj as ButtonComponent);
    }

    /// <summary>
    /// Returns true if ButtonComponent instances are equal
    /// </summary>
    /// <param name="other">Instance of ButtonComponent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ButtonComponent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.Equals(other.Actions)
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
            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            return hash;
        }
    }
}
