using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebEventBrowser
/// </summary>

public partial class WebEventBrowser : IEquatable<WebEventBrowser>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebEventBrowser" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebEventBrowser() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebEventBrowser" /> class.
    /// </summary>
    /// <param name="Family">Browser family (e.g. Chrome, Safari, Firefox). (required).</param>
    /// <param name="Version">Browser version (e.g. 68.0.3440.84). (required).</param>
    /// <param name="Lang">Language the browser is set to. Must conform to BCP 47..</param>
    public WebEventBrowser(string Family = null, string Version = null, string Lang = null)
    {
        this.Family = Family;
        this.Version = Version;
        this.Lang = Lang;

    }



    /// <summary>
    /// Browser family (e.g. Chrome, Safari, Firefox).
    /// </summary>
    /// <value>Browser family (e.g. Chrome, Safari, Firefox).</value>
    [JsonPropertyName("family")]
    public string Family { get; set; }



    /// <summary>
    /// Browser version (e.g. 68.0.3440.84).
    /// </summary>
    /// <value>Browser version (e.g. 68.0.3440.84).</value>
    [JsonPropertyName("version")]
    public string Version { get; set; }



    /// <summary>
    /// Language the browser is set to. Must conform to BCP 47.
    /// </summary>
    /// <value>Language the browser is set to. Must conform to BCP 47.</value>
    [JsonPropertyName("lang")]
    public string Lang { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebEventBrowser {\n");

        sb.Append("  Family: ").Append(Family).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Lang: ").Append(Lang).Append("\n");
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
        return Equals(obj as WebEventBrowser);
    }

    /// <summary>
    /// Returns true if WebEventBrowser instances are equal
    /// </summary>
    /// <param name="other">Instance of WebEventBrowser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebEventBrowser other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Family == other.Family ||
                Family != null &&
                Family.Equals(other.Family)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Lang == other.Lang ||
                Lang != null &&
                Lang.Equals(other.Lang)
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
            if (Family != null)
            {
                hash = hash * 59 + Family.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Lang != null)
            {
                hash = hash * 59 + Lang.GetHashCode();
            }

            return hash;
        }
    }
}
