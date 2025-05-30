using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportCenterStyleSetting
/// </summary>

public partial class SupportCenterStyleSetting : IEquatable<SupportCenterStyleSetting>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterStyleSetting" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportCenterStyleSetting() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterStyleSetting" /> class.
    /// </summary>
    /// <param name="HeroStyle">Knowledge portal (previously support center) hero customizations (required).</param>
    /// <param name="GlobalStyle">Knowledge portal (previously support center) global customizations (required).</param>
    public SupportCenterStyleSetting(SupportCenterHeroStyle HeroStyle = null, SupportCenterGlobalStyle GlobalStyle = null)
    {
        this.HeroStyle = HeroStyle;
        this.GlobalStyle = GlobalStyle;

    }



    /// <summary>
    /// Knowledge portal (previously support center) hero customizations
    /// </summary>
    /// <value>Knowledge portal (previously support center) hero customizations</value>
    [JsonPropertyName("heroStyle")]
    public SupportCenterHeroStyle HeroStyle { get; set; }



    /// <summary>
    /// Knowledge portal (previously support center) global customizations
    /// </summary>
    /// <value>Knowledge portal (previously support center) global customizations</value>
    [JsonPropertyName("globalStyle")]
    public SupportCenterGlobalStyle GlobalStyle { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterStyleSetting {\n");

        sb.Append("  HeroStyle: ").Append(HeroStyle).Append("\n");
        sb.Append("  GlobalStyle: ").Append(GlobalStyle).Append("\n");
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
        return Equals(obj as SupportCenterStyleSetting);
    }

    /// <summary>
    /// Returns true if SupportCenterStyleSetting instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterStyleSetting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterStyleSetting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                HeroStyle == other.HeroStyle ||
                HeroStyle != null &&
                HeroStyle.Equals(other.HeroStyle)
            ) &&
            (
                GlobalStyle == other.GlobalStyle ||
                GlobalStyle != null &&
                GlobalStyle.Equals(other.GlobalStyle)
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
            if (HeroStyle != null)
            {
                hash = hash * 59 + HeroStyle.GetHashCode();
            }

            if (GlobalStyle != null)
            {
                hash = hash * 59 + GlobalStyle.GetHashCode();
            }

            return hash;
        }
    }
}
