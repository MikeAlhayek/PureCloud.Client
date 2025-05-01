using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TtsVoiceEntity
/// </summary>
[DataContract]
public partial class TtsVoiceEntity : IEquatable<TtsVoiceEntity>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TtsVoiceEntity" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TtsVoiceEntity() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TtsVoiceEntity" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Gender">The gender of the TTS voice (required).</param>
    /// <param name="Language">The language supported by the TTS voice (required).</param>
    /// <param name="Engine">Ths TTS engine this voice belongs to (required).</param>
    /// <param name="IsDefault">The voice is the default voice for its language.</param>
    public TtsVoiceEntity(string Name = null, string Gender = null, string Language = null, TtsEngineEntity Engine = null, bool? IsDefault = null)
    {
        this.Name = Name;
        this.Gender = Gender;
        this.Language = Language;
        this.Engine = Engine;
        this.IsDefault = IsDefault;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The gender of the TTS voice
    /// </summary>
    /// <value>The gender of the TTS voice</value>
    [DataMember(Name = "gender", EmitDefaultValue = false)]
    public string Gender { get; set; }



    /// <summary>
    /// The language supported by the TTS voice
    /// </summary>
    /// <value>The language supported by the TTS voice</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }



    /// <summary>
    /// Ths TTS engine this voice belongs to
    /// </summary>
    /// <value>Ths TTS engine this voice belongs to</value>
    [DataMember(Name = "engine", EmitDefaultValue = false)]
    public TtsEngineEntity Engine { get; set; }



    /// <summary>
    /// The voice is the default voice for its language
    /// </summary>
    /// <value>The voice is the default voice for its language</value>
    [DataMember(Name = "isDefault", EmitDefaultValue = false)]
    public bool? IsDefault { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TtsVoiceEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Gender: ").Append(Gender).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Engine: ").Append(Engine).Append("\n");
        sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
        return Equals(obj as TtsVoiceEntity);
    }

    /// <summary>
    /// Returns true if TtsVoiceEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of TtsVoiceEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TtsVoiceEntity other)
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
                Gender == other.Gender ||
                Gender != null &&
                Gender.Equals(other.Gender)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Engine == other.Engine ||
                Engine != null &&
                Engine.Equals(other.Engine)
            ) &&
            (
                IsDefault == other.IsDefault ||
                IsDefault != null &&
                IsDefault.Equals(other.IsDefault)
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

            if (Gender != null)
            {
                hash = hash * 59 + Gender.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Engine != null)
            {
                hash = hash * 59 + Engine.GetHashCode();
            }

            if (IsDefault != null)
            {
                hash = hash * 59 + IsDefault.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
