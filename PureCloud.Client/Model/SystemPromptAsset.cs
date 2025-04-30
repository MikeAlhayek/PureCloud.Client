using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// SystemPromptAsset
    /// </summary>
    [DataContract]
    public partial class SystemPromptAsset :  IEquatable<SystemPromptAsset>
    {
        /// <summary>
        /// Gets or Sets UploadStatus
        /// </summary>
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
        /// Gets or Sets UploadStatus
        /// </summary>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
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
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Gets or Sets PromptId
        /// </summary>
        [DataMember(Name="promptId", EmitDefaultValue=false)]
        public string PromptId { get; set; }



        /// <summary>
        /// The asset resource language
        /// </summary>
        /// <value>The asset resource language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }



        /// <summary>
        /// Gets or Sets DurationSeconds
        /// </summary>
        [DataMember(Name="durationSeconds", EmitDefaultValue=false)]
        public double? DurationSeconds { get; set; }



        /// <summary>
        /// Gets or Sets MediaUri
        /// </summary>
        [DataMember(Name="mediaUri", EmitDefaultValue=false)]
        public string MediaUri { get; set; }



        /// <summary>
        /// Gets or Sets TtsString
        /// </summary>
        [DataMember(Name="ttsString", EmitDefaultValue=false)]
        public string TtsString { get; set; }



        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }



        /// <summary>
        /// Gets or Sets UploadUri
        /// </summary>
        [DataMember(Name="uploadUri", EmitDefaultValue=false)]
        public string UploadUri { get; set; }





        /// <summary>
        /// Gets or Sets HasDefault
        /// </summary>
        [DataMember(Name="hasDefault", EmitDefaultValue=false)]
        public bool? HasDefault { get; set; }



        /// <summary>
        /// Gets or Sets LanguageDefault
        /// </summary>
        [DataMember(Name="languageDefault", EmitDefaultValue=false)]
        public bool? LanguageDefault { get; set; }



        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> Tags { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


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
            return this.Equals(obj as SystemPromptAsset);
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
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.PromptId == other.PromptId ||
                    this.PromptId != null &&
                    this.PromptId.Equals(other.PromptId)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.DurationSeconds == other.DurationSeconds ||
                    this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(other.DurationSeconds)
                ) &&
                (
                    this.MediaUri == other.MediaUri ||
                    this.MediaUri != null &&
                    this.MediaUri.Equals(other.MediaUri)
                ) &&
                (
                    this.TtsString == other.TtsString ||
                    this.TtsString != null &&
                    this.TtsString.Equals(other.TtsString)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.UploadUri == other.UploadUri ||
                    this.UploadUri != null &&
                    this.UploadUri.Equals(other.UploadUri)
                ) &&
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) &&
                (
                    this.HasDefault == other.HasDefault ||
                    this.HasDefault != null &&
                    this.HasDefault.Equals(other.HasDefault)
                ) &&
                (
                    this.LanguageDefault == other.LanguageDefault ||
                    this.LanguageDefault != null &&
                    this.LanguageDefault.Equals(other.LanguageDefault)
                ) &&
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.PromptId != null)
                    hash = hash * 59 + this.PromptId.GetHashCode();

                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();

                if (this.DurationSeconds != null)
                    hash = hash * 59 + this.DurationSeconds.GetHashCode();

                if (this.MediaUri != null)
                    hash = hash * 59 + this.MediaUri.GetHashCode();

                if (this.TtsString != null)
                    hash = hash * 59 + this.TtsString.GetHashCode();

                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();

                if (this.UploadUri != null)
                    hash = hash * 59 + this.UploadUri.GetHashCode();

                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();

                if (this.HasDefault != null)
                    hash = hash * 59 + this.HasDefault.GetHashCode();

                if (this.LanguageDefault != null)
                    hash = hash * 59 + this.LanguageDefault.GetHashCode();

                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
