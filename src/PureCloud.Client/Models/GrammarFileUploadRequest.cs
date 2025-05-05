using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GrammarFileUploadRequest
/// </summary>

public partial class GrammarFileUploadRequest : IEquatable<GrammarFileUploadRequest>
{
    /// <summary>
    /// Gets or Sets FileType
    /// </summary>
    
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
        /// Enum Gram for "gram"
        /// </summary>
        [EnumMember(Value = "gram")]
        Gram,

        /// <summary>
        /// Enum Grxml for "grxml"
        /// </summary>
        [EnumMember(Value = "grxml")]
        Grxml
    }
    /// <summary>
    /// Gets or Sets FileType
    /// </summary>
    [JsonPropertyName("fileType")]
    public FileTypeEnum? FileType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="GrammarFileUploadRequest" /> class.
    /// </summary>
    /// <param name="FileType">FileType.</param>
    public GrammarFileUploadRequest(FileTypeEnum? FileType = null)
    {
        this.FileType = FileType;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GrammarFileUploadRequest {\n");

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
        return Equals(obj as GrammarFileUploadRequest);
    }

    /// <summary>
    /// Returns true if GrammarFileUploadRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of GrammarFileUploadRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GrammarFileUploadRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (FileType != null)
            {
                hash = hash * 59 + FileType.GetHashCode();
            }

            return hash;
        }
    }
}
