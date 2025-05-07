using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SystemPromptAsset
/// </summary>

public partial class SystemPromptAsset : IEquatable<SystemPromptAsset>
{
    /// <summary>
    /// Gets or Sets UploadStatus
    /// </summary>
    
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
    /// Gets or Sets UploadStatus
    /// </summary>
    [JsonPropertyName("uploadStatus")]
    public UploadStatusEnum? UploadStatus { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SystemPromptAsset" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SystemPromptAsset() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SystemPromptAsset" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="PromptId">PromptId.</param>
    /// <param name="Language">The asset resource language (required).</param>
    /// <param name="DurationSeconds">DurationSeconds.</param>
    /// <param name="MediaUri">MediaUri.</param>
    /// <param name="TtsString">TtsString.</param>
    /// <param name="Text">Text.</param>
    /// <param name="UploadUri">UploadUri.</param>
    /// <param name="UploadStatus">UploadStatus.</param>
    /// <param name="HasDefault">HasDefault.</param>
    /// <param name="LanguageDefault">LanguageDefault.</param>
    /// <param name="Tags">Tags.</param>
    public SystemPromptAsset(string Name = null, string PromptId = null, string Language = null, double? DurationSeconds = null, string MediaUri = null, string TtsString = null, string Text = null, string UploadUri = null, UploadStatusEnum? UploadStatus = null, bool? HasDefault = null, bool? LanguageDefault = null, Dictionary<string, List<string>> Tags = null)
    {
        this.Name = Name;
        this.PromptId = PromptId;
        this.Language = Language;
        this.DurationSeconds = DurationSeconds;
        this.MediaUri = MediaUri;
        this.TtsString = TtsString;
        this.Text = Text;
        this.UploadUri = UploadUri;
        this.UploadStatus = UploadStatus;
        this.HasDefault = HasDefault;
        this.LanguageDefault = LanguageDefault;
        this.Tags = Tags;

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
    /// Gets or Sets PromptId
    /// </summary>
    [JsonPropertyName("promptId")]
    public string PromptId { get; set; }



    /// <summary>
    /// The asset resource language
    /// </summary>
    /// <value>The asset resource language</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// Gets or Sets DurationSeconds
    /// </summary>
    [JsonPropertyName("durationSeconds")]
    public double? DurationSeconds { get; set; }



    /// <summary>
    /// Gets or Sets MediaUri
    /// </summary>
    [JsonPropertyName("mediaUri")]
    public string MediaUri { get; set; }



    /// <summary>
    /// Gets or Sets TtsString
    /// </summary>
    [JsonPropertyName("ttsString")]
    public string TtsString { get; set; }



    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Gets or Sets UploadUri
    /// </summary>
    [JsonPropertyName("uploadUri")]
    public string UploadUri { get; set; }





    /// <summary>
    /// Gets or Sets HasDefault
    /// </summary>
    [JsonPropertyName("hasDefault")]
    public bool? HasDefault { get; set; }



    /// <summary>
    /// Gets or Sets LanguageDefault
    /// </summary>
    [JsonPropertyName("languageDefault")]
    public bool? LanguageDefault { get; set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public Dictionary<string, List<string>> Tags { get; set; }



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
        sb.Append("class SystemPromptAsset {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PromptId: ").Append(PromptId).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
        sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
        sb.Append("  TtsString: ").Append(TtsString).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  UploadUri: ").Append(UploadUri).Append("\n");
        sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
        sb.Append("  HasDefault: ").Append(HasDefault).Append("\n");
        sb.Append("  LanguageDefault: ").Append(LanguageDefault).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
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
        return Equals(obj as SystemPromptAsset);
    }

    /// <summary>
    /// Returns true if SystemPromptAsset instances are equal
    /// </summary>
    /// <param name="other">Instance of SystemPromptAsset to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SystemPromptAsset other)
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
                DurationSeconds == other.DurationSeconds ||
                DurationSeconds != null &&
                DurationSeconds.Equals(other.DurationSeconds)
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
                UploadUri == other.UploadUri ||
                UploadUri != null &&
                UploadUri.Equals(other.UploadUri)
            ) &&
            (
                UploadStatus == other.UploadStatus ||
                UploadStatus != null &&
                UploadStatus.Equals(other.UploadStatus)
            ) &&
            (
                HasDefault == other.HasDefault ||
                HasDefault != null &&
                HasDefault.Equals(other.HasDefault)
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

            if (DurationSeconds != null)
            {
                hash = hash * 59 + DurationSeconds.GetHashCode();
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

            if (UploadUri != null)
            {
                hash = hash * 59 + UploadUri.GetHashCode();
            }

            if (UploadStatus != null)
            {
                hash = hash * 59 + UploadStatus.GetHashCode();
            }

            if (HasDefault != null)
            {
                hash = hash * 59 + HasDefault.GetHashCode();
            }

            if (LanguageDefault != null)
            {
                hash = hash * 59 + LanguageDefault.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
