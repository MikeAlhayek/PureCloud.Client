using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PromptAsset
/// </summary>
[DataContract]
public partial class PromptAsset : IEquatable<PromptAsset>
{
    /// <summary>
    /// Audio upload status
    /// </summary>
    /// <value>Audio upload status</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UploadStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Created for "created"
        /// </summary>
        [EnumMember(Value = "created")]
        Created,

        /// <summary>
        /// Enum Uploaded for "uploaded"
        /// </summary>
        [EnumMember(Value = "uploaded")]
        Uploaded,

        /// <summary>
        /// Enum Transcoded for "transcoded"
        /// </summary>
        [EnumMember(Value = "transcoded")]
        Transcoded,

        /// <summary>
        /// Enum Transcodefailed for "transcodeFailed"
        /// </summary>
        [EnumMember(Value = "transcodeFailed")]
        Transcodefailed
    }
    /// <summary>
    /// Audio upload status
    /// </summary>
    /// <value>Audio upload status</value>
    [DataMember(Name = "uploadStatus", EmitDefaultValue = false)]
    public UploadStatusEnum? UploadStatus { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PromptAsset" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="TtsString">Text to speech of the resource.</param>
    /// <param name="Text">Text of the resource.</param>
    /// <param name="Tags">Tags.</param>
    /// <param name="DurationSeconds">DurationSeconds.</param>
    public PromptAsset(string Name = null, string TtsString = null, string Text = null, Dictionary<string, List<string>> Tags = null, double? DurationSeconds = null)
    {
        this.Name = Name;
        this.TtsString = TtsString;
        this.Text = Text;
        this.Tags = Tags;
        this.DurationSeconds = DurationSeconds;

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
    /// Associated prompt ID
    /// </summary>
    /// <value>Associated prompt ID</value>
    [DataMember(Name = "promptId", EmitDefaultValue = false)]
    public string PromptId { get; private set; }



    /// <summary>
    /// Prompt resource language
    /// </summary>
    /// <value>Prompt resource language</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; private set; }



    /// <summary>
    /// URI of the resource audio
    /// </summary>
    /// <value>URI of the resource audio</value>
    [DataMember(Name = "mediaUri", EmitDefaultValue = false)]
    public string MediaUri { get; private set; }



    /// <summary>
    /// Text to speech of the resource
    /// </summary>
    /// <value>Text to speech of the resource</value>
    [DataMember(Name = "ttsString", EmitDefaultValue = false)]
    public string TtsString { get; set; }



    /// <summary>
    /// Text of the resource
    /// </summary>
    /// <value>Text of the resource</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }





    /// <summary>
    /// Upload URI for the resource audio
    /// </summary>
    /// <value>Upload URI for the resource audio</value>
    [DataMember(Name = "uploadUri", EmitDefaultValue = false)]
    public string UploadUri { get; private set; }



    /// <summary>
    /// Whether or not this resource locale is the default for the language
    /// </summary>
    /// <value>Whether or not this resource locale is the default for the language</value>
    [DataMember(Name = "languageDefault", EmitDefaultValue = false)]
    public bool? LanguageDefault { get; private set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    public Dictionary<string, List<string>> Tags { get; set; }



    /// <summary>
    /// Gets or Sets DurationSeconds
    /// </summary>
    [DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
    public double? DurationSeconds { get; set; }



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
        sb.Append("class PromptAsset {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PromptId: ").Append(PromptId).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
        sb.Append("  TtsString: ").Append(TtsString).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
        sb.Append("  UploadUri: ").Append(UploadUri).Append("\n");
        sb.Append("  LanguageDefault: ").Append(LanguageDefault).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
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
        return Equals(obj as PromptAsset);
    }

    /// <summary>
    /// Returns true if PromptAsset instances are equal
    /// </summary>
    /// <param name="other">Instance of PromptAsset to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PromptAsset other)
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
                PromptId == other.PromptId ||
                PromptId != null &&
                PromptId.Equals(other.PromptId)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                MediaUri == other.MediaUri ||
                MediaUri != null &&
                MediaUri.Equals(other.MediaUri)
            ) &&
            (
                TtsString == other.TtsString ||
                TtsString != null &&
                TtsString.Equals(other.TtsString)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                UploadStatus == other.UploadStatus ||
                UploadStatus != null &&
                UploadStatus.Equals(other.UploadStatus)
            ) &&
            (
                UploadUri == other.UploadUri ||
                UploadUri != null &&
                UploadUri.Equals(other.UploadUri)
            ) &&
            (
                LanguageDefault == other.LanguageDefault ||
                LanguageDefault != null &&
                LanguageDefault.Equals(other.LanguageDefault)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                DurationSeconds == other.DurationSeconds ||
                DurationSeconds != null &&
                DurationSeconds.Equals(other.DurationSeconds)
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

            if (PromptId != null)
            {
                hash = hash * 59 + PromptId.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (MediaUri != null)
            {
                hash = hash * 59 + MediaUri.GetHashCode();
            }

            if (TtsString != null)
            {
                hash = hash * 59 + TtsString.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (UploadStatus != null)
            {
                hash = hash * 59 + UploadStatus.GetHashCode();
            }

            if (UploadUri != null)
            {
                hash = hash * 59 + UploadUri.GetHashCode();
            }

            if (LanguageDefault != null)
            {
                hash = hash * 59 + LanguageDefault.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (DurationSeconds != null)
            {
                hash = hash * 59 + DurationSeconds.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
