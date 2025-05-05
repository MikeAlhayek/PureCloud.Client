using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeExportJobFilter
/// </summary>

public partial class KnowledgeExportJobFilter : IEquatable<KnowledgeExportJobFilter>
{
    /// <summary>
    /// Specifies what version should be exported.
    /// </summary>
    /// <value>Specifies what version should be exported.</value>
    
    public enum VersionFilterEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum Latest for "Latest"
        /// </summary>
        [EnumMember(Value = "Latest")]
        Latest
    }
    /// <summary>
    /// Gets or Sets Exclude
    /// </summary>
    
    public enum ExcludeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Categories for "Categories"
        /// </summary>
        [EnumMember(Value = "Categories")]
        Categories,

        /// <summary>
        /// Enum Labels for "Labels"
        /// </summary>
        [EnumMember(Value = "Labels")]
        Labels,

        /// <summary>
        /// Enum Variations for "Variations"
        /// </summary>
        [EnumMember(Value = "Variations")]
        Variations
    }
    /// <summary>
    /// Specifies what version should be exported.
    /// </summary>
    /// <value>Specifies what version should be exported.</value>
    [JsonPropertyName("versionFilter")]
    public VersionFilterEnum? VersionFilter { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeExportJobFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeExportJobFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeExportJobFilter" /> class.
    /// </summary>
    /// <param name="DocumentsFilter">Filters for narrowing down which documents to export..</param>
    /// <param name="VersionFilter">Specifies what version should be exported. (required).</param>
    /// <param name="Exclude">Reduce the size of the export file by excluding certain items..</param>
    public KnowledgeExportJobFilter(KnowledgeExportJobDocumentsFilter DocumentsFilter = null, VersionFilterEnum? VersionFilter = null, List<ExcludeEnum> Exclude = null)
    {
        this.DocumentsFilter = DocumentsFilter;
        this.VersionFilter = VersionFilter;
        this.Exclude = Exclude;

    }



    /// <summary>
    /// Filters for narrowing down which documents to export.
    /// </summary>
    /// <value>Filters for narrowing down which documents to export.</value>
    [JsonPropertyName("documentsFilter")]
    public KnowledgeExportJobDocumentsFilter DocumentsFilter { get; set; }





    /// <summary>
    /// Reduce the size of the export file by excluding certain items.
    /// </summary>
    /// <value>Reduce the size of the export file by excluding certain items.</value>
    [JsonPropertyName("exclude")]
    public List<ExcludeEnum> Exclude { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeExportJobFilter {\n");

        sb.Append("  DocumentsFilter: ").Append(DocumentsFilter).Append("\n");
        sb.Append("  VersionFilter: ").Append(VersionFilter).Append("\n");
        sb.Append("  Exclude: ").Append(Exclude).Append("\n");
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
        return Equals(obj as KnowledgeExportJobFilter);
    }

    /// <summary>
    /// Returns true if KnowledgeExportJobFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeExportJobFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeExportJobFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DocumentsFilter == other.DocumentsFilter ||
                DocumentsFilter != null &&
                DocumentsFilter.Equals(other.DocumentsFilter)
            ) &&
            (
                VersionFilter == other.VersionFilter ||
                VersionFilter != null &&
                VersionFilter.Equals(other.VersionFilter)
            ) &&
            (
                Exclude == other.Exclude ||
                Exclude != null &&
                Exclude.SequenceEqual(other.Exclude)
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
            if (DocumentsFilter != null)
            {
                hash = hash * 59 + DocumentsFilter.GetHashCode();
            }

            if (VersionFilter != null)
            {
                hash = hash * 59 + VersionFilter.GetHashCode();
            }

            if (Exclude != null)
            {
                hash = hash * 59 + Exclude.GetHashCode();
            }

            return hash;
        }
    }
}
