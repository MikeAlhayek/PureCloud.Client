using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeImportJobRequest
/// </summary>

public partial class KnowledgeImportJobRequest : IEquatable<KnowledgeImportJobRequest>
{
    /// <summary>
    /// File type of the document
    /// </summary>
    /// <value>File type of the document</value>
    
    public enum FileTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Json for "Json"
        /// </summary>
        [EnumMember(Value = "Json")]
        Json,

        /// <summary>
        /// Enum Csv for "Csv"
        /// </summary>
        [EnumMember(Value = "Csv")]
        Csv,

        /// <summary>
        /// Enum Xlsx for "Xlsx"
        /// </summary>
        [EnumMember(Value = "Xlsx")]
        Xlsx
    }
    /// <summary>
    /// File type of the document
    /// </summary>
    /// <value>File type of the document</value>
    [JsonPropertyName("fileType")]
    public FileTypeEnum? FileType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeImportJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeImportJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeImportJobRequest" /> class.
    /// </summary>
    /// <param name="UploadKey">Upload key (required).</param>
    /// <param name="FileType">File type of the document (required).</param>
    /// <param name="Settings">Additional optional settings.</param>
    /// <param name="SkipConfirmationStep">If enabled pre-validation step will be skipped..</param>
    public KnowledgeImportJobRequest(string UploadKey = null, FileTypeEnum? FileType = null, KnowledgeImportJobSettings Settings = null, bool? SkipConfirmationStep = null)
    {
        this.UploadKey = UploadKey;
        this.FileType = FileType;
        this.Settings = Settings;
        this.SkipConfirmationStep = SkipConfirmationStep;

    }



    /// <summary>
    /// Upload key
    /// </summary>
    /// <value>Upload key</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }





    /// <summary>
    /// Additional optional settings
    /// </summary>
    /// <value>Additional optional settings</value>
    [JsonPropertyName("settings")]
    public KnowledgeImportJobSettings Settings { get; set; }



    /// <summary>
    /// If enabled pre-validation step will be skipped.
    /// </summary>
    /// <value>If enabled pre-validation step will be skipped.</value>
    [JsonPropertyName("skipConfirmationStep")]
    public bool? SkipConfirmationStep { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeImportJobRequest {\n");

        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  FileType: ").Append(FileType).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
        sb.Append("  SkipConfirmationStep: ").Append(SkipConfirmationStep).Append("\n");
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
        return Equals(obj as KnowledgeImportJobRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeImportJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeImportJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeImportJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                FileType == other.FileType ||
                FileType != null &&
                FileType.Equals(other.FileType)
            ) &&
            (
                Settings == other.Settings ||
                Settings != null &&
                Settings.Equals(other.Settings)
            ) &&
            (
                SkipConfirmationStep == other.SkipConfirmationStep ||
                SkipConfirmationStep != null &&
                SkipConfirmationStep.Equals(other.SkipConfirmationStep)
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
            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (FileType != null)
            {
                hash = hash * 59 + FileType.GetHashCode();
            }

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            if (SkipConfirmationStep != null)
            {
                hash = hash * 59 + SkipConfirmationStep.GetHashCode();
            }

            return hash;
        }
    }
}
