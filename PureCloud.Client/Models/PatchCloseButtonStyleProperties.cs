using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchCloseButtonStyleProperties
/// </summary>
[DataContract]
public partial class PatchCloseButtonStyleProperties : IEquatable<PatchCloseButtonStyleProperties>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchCloseButtonStyleProperties" /> class.
    /// </summary>
    /// <param name="Color">Color of button. (eg. #FF0000).</param>
    /// <param name="Opacity">Opacity of button..</param>
    public PatchCloseButtonStyleProperties(string Color = null, float? Opacity = null)
    {
        this.Color = Color;
        this.Opacity = Opacity;

    }



    /// <summary>
    /// Color of button. (eg. #FF0000)
    /// </summary>
    /// <value>Color of button. (eg. #FF0000)</value>
    [DataMember(Name = "color", EmitDefaultValue = false)]
    public string Color { get; set; }



    /// <summary>
    /// Opacity of button.
    /// </summary>
    /// <value>Opacity of button.</value>
    [DataMember(Name = "opacity", EmitDefaultValue = false)]
    public float? Opacity { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchCloseButtonStyleProperties {\n");

        sb.Append("  Color: ").Append(Color).Append("\n");
        sb.Append("  Opacity: ").Append(Opacity).Append("\n");
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
        return Equals(obj as PatchCloseButtonStyleProperties);
    }

    /// <summary>
    /// Returns true if PatchCloseButtonStyleProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchCloseButtonStyleProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchCloseButtonStyleProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Color == other.Color ||
                Color != null &&
                Color.Equals(other.Color)
            ) &&
            (
                Opacity == other.Opacity ||
                Opacity != null &&
                Opacity.Equals(other.Opacity)
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
            if (Color != null)
            {
                hash = hash * 59 + Color.GetHashCode();
            }

            if (Opacity != null)
            {
                hash = hash * 59 + Opacity.GetHashCode();
            }

            return hash;
        }
    }
}
