using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Mode constraints to observe when operating on a bot flow.
/// </summary>
[DataContract]
public partial class TextBotTextModeConstraints : IEquatable<TextBotTextModeConstraints>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotTextModeConstraints" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotTextModeConstraints() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotTextModeConstraints" /> class.
    /// </summary>
    /// <param name="LanguagePreferences">The list of language preferences by their ISO language code. (required).</param>
    /// <param name="NoInputTimeoutMilliseconds">The amount of time, in milliseconds, before the client should send the &#39;NoInput&#39; event  to trigger the \&quot;no input\&quot; bot response and handling on digital channels.  Note: This optional field will only be returned for &#39;Digital Bot Flow&#39; turns..</param>
    public TextBotTextModeConstraints(List<string> LanguagePreferences = null, int? NoInputTimeoutMilliseconds = null)
    {
        this.LanguagePreferences = LanguagePreferences;
        this.NoInputTimeoutMilliseconds = NoInputTimeoutMilliseconds;

    }



    /// <summary>
    /// The list of language preferences by their ISO language code.
    /// </summary>
    /// <value>The list of language preferences by their ISO language code.</value>
    [DataMember(Name = "languagePreferences", EmitDefaultValue = false)]
    public List<string> LanguagePreferences { get; set; }



    /// <summary>
    /// The amount of time, in milliseconds, before the client should send the &#39;NoInput&#39; event  to trigger the \&quot;no input\&quot; bot response and handling on digital channels.  Note: This optional field will only be returned for &#39;Digital Bot Flow&#39; turns.
    /// </summary>
    /// <value>The amount of time, in milliseconds, before the client should send the &#39;NoInput&#39; event  to trigger the \&quot;no input\&quot; bot response and handling on digital channels.  Note: This optional field will only be returned for &#39;Digital Bot Flow&#39; turns.</value>
    [DataMember(Name = "noInputTimeoutMilliseconds", EmitDefaultValue = false)]
    public int? NoInputTimeoutMilliseconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotTextModeConstraints {\n");

        sb.Append("  LanguagePreferences: ").Append(LanguagePreferences).Append("\n");
        sb.Append("  NoInputTimeoutMilliseconds: ").Append(NoInputTimeoutMilliseconds).Append("\n");
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
        return Equals(obj as TextBotTextModeConstraints);
    }

    /// <summary>
    /// Returns true if TextBotTextModeConstraints instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotTextModeConstraints to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotTextModeConstraints other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LanguagePreferences == other.LanguagePreferences ||
                LanguagePreferences != null &&
                LanguagePreferences.SequenceEqual(other.LanguagePreferences)
            ) &&
            (
                NoInputTimeoutMilliseconds == other.NoInputTimeoutMilliseconds ||
                NoInputTimeoutMilliseconds != null &&
                NoInputTimeoutMilliseconds.Equals(other.NoInputTimeoutMilliseconds)
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
            if (LanguagePreferences != null)
            {
                hash = hash * 59 + LanguagePreferences.GetHashCode();
            }

            if (NoInputTimeoutMilliseconds != null)
            {
                hash = hash * 59 + NoInputTimeoutMilliseconds.GetHashCode();
            }

            return hash;
        }
    }
}
