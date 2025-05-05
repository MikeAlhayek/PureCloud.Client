using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportCenterGlobalStyle
/// </summary>

public partial class SupportCenterGlobalStyle : IEquatable<SupportCenterGlobalStyle>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterGlobalStyle" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportCenterGlobalStyle() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterGlobalStyle" /> class.
    /// </summary>
    /// <param name="BackgroundColor">Global background color, in hexadecimal format, eg #ffffff (required).</param>
    /// <param name="PrimaryColor">Global primary color, in hexadecimal format, eg #ffffff (required).</param>
    /// <param name="PrimaryColorDark">Global dark primary color, in hexadecimal format, eg #ffffff (required).</param>
    /// <param name="PrimaryColorLight">Global light primary color, in hexadecimal format, eg #ffffff (required).</param>
    /// <param name="TextColor">Global text color, in hexadecimal format, eg #ffffff (required).</param>
    /// <param name="FontFamily">Global font family (required).</param>
    public SupportCenterGlobalStyle(string BackgroundColor = null, string PrimaryColor = null, string PrimaryColorDark = null, string PrimaryColorLight = null, string TextColor = null, string FontFamily = null)
    {
        this.BackgroundColor = BackgroundColor;
        this.PrimaryColor = PrimaryColor;
        this.PrimaryColorDark = PrimaryColorDark;
        this.PrimaryColorLight = PrimaryColorLight;
        this.TextColor = TextColor;
        this.FontFamily = FontFamily;

    }



    /// <summary>
    /// Global background color, in hexadecimal format, eg #ffffff
    /// </summary>
    /// <value>Global background color, in hexadecimal format, eg #ffffff</value>
    [JsonPropertyName("backgroundColor")]
    public string BackgroundColor { get; set; }



    /// <summary>
    /// Global primary color, in hexadecimal format, eg #ffffff
    /// </summary>
    /// <value>Global primary color, in hexadecimal format, eg #ffffff</value>
    [JsonPropertyName("primaryColor")]
    public string PrimaryColor { get; set; }



    /// <summary>
    /// Global dark primary color, in hexadecimal format, eg #ffffff
    /// </summary>
    /// <value>Global dark primary color, in hexadecimal format, eg #ffffff</value>
    [JsonPropertyName("primaryColorDark")]
    public string PrimaryColorDark { get; set; }



    /// <summary>
    /// Global light primary color, in hexadecimal format, eg #ffffff
    /// </summary>
    /// <value>Global light primary color, in hexadecimal format, eg #ffffff</value>
    [JsonPropertyName("primaryColorLight")]
    public string PrimaryColorLight { get; set; }



    /// <summary>
    /// Global text color, in hexadecimal format, eg #ffffff
    /// </summary>
    /// <value>Global text color, in hexadecimal format, eg #ffffff</value>
    [JsonPropertyName("textColor")]
    public string TextColor { get; set; }



    /// <summary>
    /// Global font family
    /// </summary>
    /// <value>Global font family</value>
    [JsonPropertyName("fontFamily")]
    public string FontFamily { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterGlobalStyle {\n");

        sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
        sb.Append("  PrimaryColor: ").Append(PrimaryColor).Append("\n");
        sb.Append("  PrimaryColorDark: ").Append(PrimaryColorDark).Append("\n");
        sb.Append("  PrimaryColorLight: ").Append(PrimaryColorLight).Append("\n");
        sb.Append("  TextColor: ").Append(TextColor).Append("\n");
        sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
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
        return Equals(obj as SupportCenterGlobalStyle);
    }

    /// <summary>
    /// Returns true if SupportCenterGlobalStyle instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterGlobalStyle to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterGlobalStyle other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                BackgroundColor == other.BackgroundColor ||
                BackgroundColor != null &&
                BackgroundColor.Equals(other.BackgroundColor)
            ) &&
            (
                PrimaryColor == other.PrimaryColor ||
                PrimaryColor != null &&
                PrimaryColor.Equals(other.PrimaryColor)
            ) &&
            (
                PrimaryColorDark == other.PrimaryColorDark ||
                PrimaryColorDark != null &&
                PrimaryColorDark.Equals(other.PrimaryColorDark)
            ) &&
            (
                PrimaryColorLight == other.PrimaryColorLight ||
                PrimaryColorLight != null &&
                PrimaryColorLight.Equals(other.PrimaryColorLight)
            ) &&
            (
                TextColor == other.TextColor ||
                TextColor != null &&
                TextColor.Equals(other.TextColor)
            ) &&
            (
                FontFamily == other.FontFamily ||
                FontFamily != null &&
                FontFamily.Equals(other.FontFamily)
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
            if (BackgroundColor != null)
            {
                hash = hash * 59 + BackgroundColor.GetHashCode();
            }

            if (PrimaryColor != null)
            {
                hash = hash * 59 + PrimaryColor.GetHashCode();
            }

            if (PrimaryColorDark != null)
            {
                hash = hash * 59 + PrimaryColorDark.GetHashCode();
            }

            if (PrimaryColorLight != null)
            {
                hash = hash * 59 + PrimaryColorLight.GetHashCode();
            }

            if (TextColor != null)
            {
                hash = hash * 59 + TextColor.GetHashCode();
            }

            if (FontFamily != null)
            {
                hash = hash * 59 + FontFamily.GetHashCode();
            }

            return hash;
        }
    }
}
