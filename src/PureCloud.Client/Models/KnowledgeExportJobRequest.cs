using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeExportJobRequest
/// </summary>

public partial class KnowledgeExportJobRequest : IEquatable<KnowledgeExportJobRequest>
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
    /// Initializes a new instance of the <see cref="KnowledgeExportJobRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeExportJobRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeExportJobRequest" /> class.
    /// </summary>
    /// <param name="ExportFilter">What to export. (required).</param>
    /// <param name="FileType">File type of the document (required).</param>
    /// <param name="SourceId">Knowledge integration source id..</param>
    /// <param name="JsonFileVersion">Requested version of the exported json file. Available versions are 2 and 3, default is 2.</param>
    public KnowledgeExportJobRequest(KnowledgeExportJobFilter ExportFilter = null, FileTypeEnum? FileType = null, string SourceId = null, int? JsonFileVersion = null)
    {
        this.ExportFilter = ExportFilter;
        this.FileType = FileType;
        this.SourceId = SourceId;
        this.JsonFileVersion = JsonFileVersion;

    }



    /// <summary>
    /// What to export.
    /// </summary>
    /// <value>What to export.</value>
    [JsonPropertyName("exportFilter")]
    public KnowledgeExportJobFilter ExportFilter { get; set; }





    /// <summary>
    /// Knowledge integration source id.
    /// </summary>
    /// <value>Knowledge integration source id.</value>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; }



    /// <summary>
    /// Requested version of the exported json file. Available versions are 2 and 3, default is 2
    /// </summary>
    /// <value>Requested version of the exported json file. Available versions are 2 and 3, default is 2</value>
    [JsonPropertyName("jsonFileVersion")]
    public int? JsonFileVersion { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeExportJobRequest {\n");

        sb.Append("  ExportFilter: ").Append(ExportFilter).Append("\n");
        sb.Append("  FileType: ").Append(FileType).Append("\n");
        sb.Append("  SourceId: ").Append(SourceId).Append("\n");
        sb.Append("  JsonFileVersion: ").Append(JsonFileVersion).Append("\n");
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
        return Equals(obj as KnowledgeExportJobRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeExportJobRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeExportJobRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeExportJobRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExportFilter == other.ExportFilter ||
                ExportFilter != null &&
                ExportFilter.Equals(other.ExportFilter)
            ) &&
            (
                FileType == other.FileType ||
                FileType != null &&
                FileType.Equals(other.FileType)
            ) &&
            (
                SourceId == other.SourceId ||
                SourceId != null &&
                SourceId.Equals(other.SourceId)
            ) &&
            (
                JsonFileVersion == other.JsonFileVersion ||
                JsonFileVersion != null &&
                JsonFileVersion.Equals(other.JsonFileVersion)
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
            if (ExportFilter != null)
            {
                hash = hash * 59 + ExportFilter.GetHashCode();
            }

            if (FileType != null)
            {
                hash = hash * 59 + FileType.GetHashCode();
            }

            if (SourceId != null)
            {
                hash = hash * 59 + SourceId.GetHashCode();
            }

            if (JsonFileVersion != null)
            {
                hash = hash * 59 + JsonFileVersion.GetHashCode();
            }

            return hash;
        }
    }
}
