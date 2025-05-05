using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchCallToAction
/// </summary>

public partial class PatchCallToAction : IEquatable<PatchCallToAction>
{
    /// <summary>
    /// Where the URL should be opened when the user clicks on the call to action button.
    /// </summary>
    /// <value>Where the URL should be opened when the user clicks on the call to action button.</value>
    
    public enum TargetEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Blank for "Blank"
        /// </summary>
        [EnumMember(Value = "Blank")]
        Blank,

        /// <summary>
        /// Enum Self for "Self"
        /// </summary>
        [EnumMember(Value = "Self")]
        Self
    }
    /// <summary>
    /// Where the URL should be opened when the user clicks on the call to action button.
    /// </summary>
    /// <value>Where the URL should be opened when the user clicks on the call to action button.</value>
    [JsonPropertyName("target")]
    public TargetEnum? Target { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchCallToAction" /> class.
    /// </summary>
    /// <param name="Text">Text displayed on the call to action button..</param>
    /// <param name="Url">URL to open when user clicks on the call to action button..</param>
    /// <param name="Target">Where the URL should be opened when the user clicks on the call to action button..</param>
    public PatchCallToAction(string Text = null, string Url = null, TargetEnum? Target = null)
    {
        this.Text = Text;
        this.Url = Url;
        this.Target = Target;

    }



    /// <summary>
    /// Text displayed on the call to action button.
    /// </summary>
    /// <value>Text displayed on the call to action button.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// URL to open when user clicks on the call to action button.
    /// </summary>
    /// <value>URL to open when user clicks on the call to action button.</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchCallToAction {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Target: ").Append(Target).Append("\n");
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
        return Equals(obj as PatchCallToAction);
    }

    /// <summary>
    /// Returns true if PatchCallToAction instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchCallToAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchCallToAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Target == other.Target ||
                Target != null &&
                Target.Equals(other.Target)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Target != null)
            {
                hash = hash * 59 + Target.GetHashCode();
            }

            return hash;
        }
    }
}
