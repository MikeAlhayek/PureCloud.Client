using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchContentOfferStyleProperties
/// </summary>

public partial class PatchContentOfferStyleProperties : IEquatable<PatchContentOfferStyleProperties>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchContentOfferStyleProperties" /> class.
    /// </summary>
    /// <param name="Padding">Padding of the offer. (eg. 10px).</param>
    /// <param name="Color">Text color of the offer. (eg. #FF0000).</param>
    /// <param name="BackgroundColor">Background color of the offer. (eg. #000000).</param>
    public PatchContentOfferStyleProperties(string Padding = null, string Color = null, string BackgroundColor = null)
    {
        this.Padding = Padding;
        this.Color = Color;
        this.BackgroundColor = BackgroundColor;

    }



    /// <summary>
    /// Padding of the offer. (eg. 10px)
    /// </summary>
    /// <value>Padding of the offer. (eg. 10px)</value>
    [JsonPropertyName("padding")]
    public string Padding { get; set; }



    /// <summary>
    /// Text color of the offer. (eg. #FF0000)
    /// </summary>
    /// <value>Text color of the offer. (eg. #FF0000)</value>
    [JsonPropertyName("color")]
    public string Color { get; set; }



    /// <summary>
    /// Background color of the offer. (eg. #000000)
    /// </summary>
    /// <value>Background color of the offer. (eg. #000000)</value>
    [JsonPropertyName("backgroundColor")]
    public string BackgroundColor { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchContentOfferStyleProperties {\n");

        sb.Append("  Padding: ").Append(Padding).Append("\n");
        sb.Append("  Color: ").Append(Color).Append("\n");
        sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
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
        return Equals(obj as PatchContentOfferStyleProperties);
    }

    /// <summary>
    /// Returns true if PatchContentOfferStyleProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchContentOfferStyleProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchContentOfferStyleProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Padding == other.Padding ||
                Padding != null &&
                Padding.Equals(other.Padding)
            ) &&
            (
                Color == other.Color ||
                Color != null &&
                Color.Equals(other.Color)
            ) &&
            (
                BackgroundColor == other.BackgroundColor ||
                BackgroundColor != null &&
                BackgroundColor.Equals(other.BackgroundColor)
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
            if (Padding != null)
            {
                hash = hash * 59 + Padding.GetHashCode();
            }

            if (Color != null)
            {
                hash = hash * 59 + Color.GetHashCode();
            }

            if (BackgroundColor != null)
            {
                hash = hash * 59 + BackgroundColor.GetHashCode();
            }

            return hash;
        }
    }
}
