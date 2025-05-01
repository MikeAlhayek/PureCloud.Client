using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FileUploadMode
/// </summary>
[DataContract]
public partial class FileUploadMode : IEquatable<FileUploadMode>
{
    /// <summary>
    /// Gets or Sets FileTypes
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FileTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Jpeg for "image/jpeg"
        /// </summary>
        [EnumMember(Value = "image/jpeg")]
        Jpeg,

        /// <summary>
        /// Enum Gif for "image/gif"
        /// </summary>
        [EnumMember(Value = "image/gif")]
        Gif,

        /// <summary>
        /// Enum Png for "image/png"
        /// </summary>
        [EnumMember(Value = "image/png")]
        Png
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="FileUploadMode" /> class.
    /// </summary>
    /// <param name="FileTypes">A list of supported content types for uploading files..</param>
    /// <param name="MaxFileSizeKB">The maximum file size for file uploads in kilobytes. Default is 10240 (10 MB).</param>
    public FileUploadMode(List<FileTypesEnum> FileTypes = null, long? MaxFileSizeKB = null)
    {
        this.FileTypes = FileTypes;
        this.MaxFileSizeKB = MaxFileSizeKB;

    }



    /// <summary>
    /// A list of supported content types for uploading files.
    /// </summary>
    /// <value>A list of supported content types for uploading files.</value>
    [DataMember(Name = "fileTypes", EmitDefaultValue = false)]
    public List<FileTypesEnum> FileTypes { get; set; }



    /// <summary>
    /// The maximum file size for file uploads in kilobytes. Default is 10240 (10 MB)
    /// </summary>
    /// <value>The maximum file size for file uploads in kilobytes. Default is 10240 (10 MB)</value>
    [DataMember(Name = "maxFileSizeKB", EmitDefaultValue = false)]
    public long? MaxFileSizeKB { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FileUploadMode {\n");

        sb.Append("  FileTypes: ").Append(FileTypes).Append("\n");
        sb.Append("  MaxFileSizeKB: ").Append(MaxFileSizeKB).Append("\n");
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
        return Equals(obj as FileUploadMode);
    }

    /// <summary>
    /// Returns true if FileUploadMode instances are equal
    /// </summary>
    /// <param name="other">Instance of FileUploadMode to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FileUploadMode other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FileTypes == other.FileTypes ||
                FileTypes != null &&
                FileTypes.SequenceEqual(other.FileTypes)
            ) &&
            (
                MaxFileSizeKB == other.MaxFileSizeKB ||
                MaxFileSizeKB != null &&
                MaxFileSizeKB.Equals(other.MaxFileSizeKB)
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
            if (FileTypes != null)
            {
                hash = hash * 59 + FileTypes.GetHashCode();
            }

            if (MaxFileSizeKB != null)
            {
                hash = hash * 59 + MaxFileSizeKB.GetHashCode();
            }

            return hash;
        }
    }
}
