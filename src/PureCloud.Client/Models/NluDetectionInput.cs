using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDetectionInput
/// </summary>

public partial class NluDetectionInput : IEquatable<NluDetectionInput>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionInput" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluDetectionInput() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionInput" /> class.
    /// </summary>
    /// <param name="Text">The text to perform NLU detection on. (required).</param>
    /// <param name="Language">Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.</param>
    public NluDetectionInput(string Text = null, string Language = null)
    {
        this.Text = Text;
        this.Language = Language;

    }



    /// <summary>
    /// The text to perform NLU detection on.
    /// </summary>
    /// <value>The text to perform NLU detection on.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;
    /// </summary>
    /// <value>Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluDetectionInput {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
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
        return Equals(obj as NluDetectionInput);
    }

    /// <summary>
    /// Returns true if NluDetectionInput instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDetectionInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluDetectionInput other)
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
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
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

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            return hash;
        }
    }
}
