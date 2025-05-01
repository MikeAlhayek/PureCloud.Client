using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GrammarLanguageFileMetadata
/// </summary>
[DataContract]
public partial class GrammarLanguageFileMetadata : IEquatable<GrammarLanguageFileMetadata>
{
    /// <summary>
    /// The extension of the file
    /// </summary>
    /// <value>The extension of the file</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Gram for "Gram"
        /// </summary>
        [EnumMember(Value = "Gram")]
        Gram,

        /// <summary>
        /// Enum Grxml for "Grxml"
        /// </summary>
        [EnumMember(Value = "Grxml")]
        Grxml
    }
    /// <summary>
    /// The extension of the file
    /// </summary>
    /// <value>The extension of the file</value>
    [DataMember(Name = "fileType", EmitDefaultValue = false)]
    public FileTypeEnum? FileType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="GrammarLanguageFileMetadata" /> class.
    /// </summary>
    /// <param name="FileName">The name of the file as defined by the user.</param>
    /// <param name="FileSizeBytes">The size of the file in bytes.</param>
    /// <param name="DateUploaded">The date the file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="FileType">The extension of the file.</param>
    public GrammarLanguageFileMetadata(string FileName = null, int? FileSizeBytes = null, DateTime? DateUploaded = null, FileTypeEnum? FileType = null)
    {
        this.FileName = FileName;
        this.FileSizeBytes = FileSizeBytes;
        this.DateUploaded = DateUploaded;
        this.FileType = FileType;

    }



    /// <summary>
    /// The name of the file as defined by the user
    /// </summary>
    /// <value>The name of the file as defined by the user</value>
    [DataMember(Name = "fileName", EmitDefaultValue = false)]
    public string FileName { get; set; }



    /// <summary>
    /// The size of the file in bytes
    /// </summary>
    /// <value>The size of the file in bytes</value>
    [DataMember(Name = "fileSizeBytes", EmitDefaultValue = false)]
    public int? FileSizeBytes { get; set; }



    /// <summary>
    /// The date the file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the file was uploaded. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateUploaded", EmitDefaultValue = false)]
    public DateTime? DateUploaded { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GrammarLanguageFileMetadata {\n");

        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  FileSizeBytes: ").Append(FileSizeBytes).Append("\n");
        sb.Append("  DateUploaded: ").Append(DateUploaded).Append("\n");
        sb.Append("  FileType: ").Append(FileType).Append("\n");
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
        return Equals(obj as GrammarLanguageFileMetadata);
    }

    /// <summary>
    /// Returns true if GrammarLanguageFileMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of GrammarLanguageFileMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GrammarLanguageFileMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                FileSizeBytes == other.FileSizeBytes ||
                FileSizeBytes != null &&
                FileSizeBytes.Equals(other.FileSizeBytes)
            ) &&
            (
                DateUploaded == other.DateUploaded ||
                DateUploaded != null &&
                DateUploaded.Equals(other.DateUploaded)
            ) &&
            (
                FileType == other.FileType ||
                FileType != null &&
                FileType.Equals(other.FileType)
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
            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (FileSizeBytes != null)
            {
                hash = hash * 59 + FileSizeBytes.GetHashCode();
            }

            if (DateUploaded != null)
            {
                hash = hash * 59 + DateUploaded.GetHashCode();
            }

            if (FileType != null)
            {
                hash = hash * 59 + FileType.GetHashCode();
            }

            return hash;
        }
    }
}
