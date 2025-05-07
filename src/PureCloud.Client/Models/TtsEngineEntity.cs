using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TtsEngineEntity
/// </summary>

public partial class TtsEngineEntity : IEquatable<TtsEngineEntity>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TtsEngineEntity" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TtsEngineEntity() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TtsEngineEntity" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Languages">The set of languages the TTS engine supports (required).</param>
    /// <param name="OutputFormats">The set of output formats the TTS engine can produce (required).</param>
    /// <param name="Voices">The set of voices the TTS engine supports.</param>
    /// <param name="IsDefault">The TTS engine is the global default engine.</param>
    /// <param name="IsSecure">The TTS engine can be used in a secure call flow.</param>
    public TtsEngineEntity(string Name = null, List<string> Languages = null, List<string> OutputFormats = null, List<TtsVoiceEntity> Voices = null, bool? IsDefault = null, bool? IsSecure = null)
    {
        this.Name = Name;
        this.Languages = Languages;
        this.OutputFormats = OutputFormats;
        this.Voices = Voices;
        this.IsDefault = IsDefault;
        this.IsSecure = IsSecure;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The set of languages the TTS engine supports
    /// </summary>
    /// <value>The set of languages the TTS engine supports</value>
    [JsonPropertyName("languages")]
    public List<string> Languages { get; set; }



    /// <summary>
    /// The set of output formats the TTS engine can produce
    /// </summary>
    /// <value>The set of output formats the TTS engine can produce</value>
    [JsonPropertyName("outputFormats")]
    public List<string> OutputFormats { get; set; }



    /// <summary>
    /// The set of voices the TTS engine supports
    /// </summary>
    /// <value>The set of voices the TTS engine supports</value>
    [JsonPropertyName("voices")]
    public List<TtsVoiceEntity> Voices { get; set; }



    /// <summary>
    /// The TTS engine is the global default engine
    /// </summary>
    /// <value>The TTS engine is the global default engine</value>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }



    /// <summary>
    /// The TTS engine can be used in a secure call flow
    /// </summary>
    /// <value>The TTS engine can be used in a secure call flow</value>
    [JsonPropertyName("isSecure")]
    public bool? IsSecure { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TtsEngineEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Languages: ").Append(Languages).Append("\n");
        sb.Append("  OutputFormats: ").Append(OutputFormats).Append("\n");
        sb.Append("  Voices: ").Append(Voices).Append("\n");
        sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
        sb.Append("  IsSecure: ").Append(IsSecure).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as TtsEngineEntity);
    }

    /// <summary>
    /// Returns true if TtsEngineEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of TtsEngineEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TtsEngineEntity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Languages == other.Languages ||
                Languages != null &&
                Languages.SequenceEqual(other.Languages)
            ) &&
            (
                OutputFormats == other.OutputFormats ||
                OutputFormats != null &&
                OutputFormats.SequenceEqual(other.OutputFormats)
            ) &&
            (
                Voices == other.Voices ||
                Voices != null &&
                Voices.SequenceEqual(other.Voices)
            ) &&
            (
                IsDefault == other.IsDefault ||
                IsDefault != null &&
                IsDefault.Equals(other.IsDefault)
            ) &&
            (
                IsSecure == other.IsSecure ||
                IsSecure != null &&
                IsSecure.Equals(other.IsSecure)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Languages != null)
            {
                hash = hash * 59 + Languages.GetHashCode();
            }

            if (OutputFormats != null)
            {
                hash = hash * 59 + OutputFormats.GetHashCode();
            }

            if (Voices != null)
            {
                hash = hash * 59 + Voices.GetHashCode();
            }

            if (IsDefault != null)
            {
                hash = hash * 59 + IsDefault.GetHashCode();
            }

            if (IsSecure != null)
            {
                hash = hash * 59 + IsSecure.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
