using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FileSpecificationTemplate
/// </summary>

public partial class FileSpecificationTemplate : IEquatable<FileSpecificationTemplate>
{
    /// <summary>
    /// File format
    /// </summary>
    /// <value>File format</value>
    
    public enum FormatEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Fixedlength for "FixedLength"
        /// </summary>
        [EnumMember(Value = "FixedLength")]
        Fixedlength,

        /// <summary>
        /// Enum Delimited for "Delimited"
        /// </summary>
        [EnumMember(Value = "Delimited")]
        Delimited
    }
    /// <summary>
    /// Kind of delimiter
    /// </summary>
    /// <value>Kind of delimiter</value>
    
    public enum DelimiterEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Comma for "Comma"
        /// </summary>
        [EnumMember(Value = "Comma")]
        Comma,

        /// <summary>
        /// Enum Pipe for "Pipe"
        /// </summary>
        [EnumMember(Value = "Pipe")]
        Pipe,

        /// <summary>
        /// Enum Colon for "Colon"
        /// </summary>
        [EnumMember(Value = "Colon")]
        Colon,

        /// <summary>
        /// Enum Tab for "Tab"
        /// </summary>
        [EnumMember(Value = "Tab")]
        Tab,

        /// <summary>
        /// Enum Semicolon for "Semicolon"
        /// </summary>
        [EnumMember(Value = "Semicolon")]
        Semicolon,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom
    }
    /// <summary>
    /// File format
    /// </summary>
    /// <value>File format</value>
    [JsonPropertyName("format")]
    public FormatEnum? Format { get; set; }
    /// <summary>
    /// Kind of delimiter
    /// </summary>
    /// <value>Kind of delimiter</value>
    [JsonPropertyName("delimiter")]
    public DelimiterEnum? Delimiter { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileSpecificationTemplate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FileSpecificationTemplate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FileSpecificationTemplate" /> class.
    /// </summary>
    /// <param name="Name">The name of the File Specification template. (required).</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="Description">Description of the file specification template.</param>
    /// <param name="Format">File format (required).</param>
    /// <param name="NumberOfHeadingLinesSkipped">Number of heading lines to be skipped.</param>
    /// <param name="NumberOfTrailingLinesSkipped">Number of trailing lines to be skipped.</param>
    /// <param name="Header">If true indicates that delimited file has a header row, which can provide column names.</param>
    /// <param name="Delimiter">Kind of delimiter.</param>
    /// <param name="DelimiterValue">Delimiter character, used only when delimiter&#x3D;\&quot;Custom\&quot;.</param>
    /// <param name="ColumnInformation">Columns specification.</param>
    /// <param name="PreprocessingRules">Preprocessing rules.</param>
    public FileSpecificationTemplate(string Name = null, int? Version = null, string Description = null, FormatEnum? Format = null, int? NumberOfHeadingLinesSkipped = null, int? NumberOfTrailingLinesSkipped = null, bool? Header = null, DelimiterEnum? Delimiter = null, string DelimiterValue = null, List<Column> ColumnInformation = null, List<PreprocessingRule> PreprocessingRules = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.Description = Description;
        this.Format = Format;
        this.NumberOfHeadingLinesSkipped = NumberOfHeadingLinesSkipped;
        this.NumberOfTrailingLinesSkipped = NumberOfTrailingLinesSkipped;
        this.Header = Header;
        this.Delimiter = Delimiter;
        this.DelimiterValue = DelimiterValue;
        this.ColumnInformation = ColumnInformation;
        this.PreprocessingRules = PreprocessingRules;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the File Specification template.
    /// </summary>
    /// <value>The name of the File Specification template.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Description of the file specification template
    /// </summary>
    /// <value>Description of the file specification template</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }





    /// <summary>
    /// Number of heading lines to be skipped
    /// </summary>
    /// <value>Number of heading lines to be skipped</value>
    [JsonPropertyName("numberOfHeadingLinesSkipped")]
    public int? NumberOfHeadingLinesSkipped { get; set; }



    /// <summary>
    /// Number of trailing lines to be skipped
    /// </summary>
    /// <value>Number of trailing lines to be skipped</value>
    [JsonPropertyName("numberOfTrailingLinesSkipped")]
    public int? NumberOfTrailingLinesSkipped { get; set; }



    /// <summary>
    /// If true indicates that delimited file has a header row, which can provide column names
    /// </summary>
    /// <value>If true indicates that delimited file has a header row, which can provide column names</value>
    [JsonPropertyName("header")]
    public bool? Header { get; set; }





    /// <summary>
    /// Delimiter character, used only when delimiter&#x3D;\&quot;Custom\&quot;
    /// </summary>
    /// <value>Delimiter character, used only when delimiter&#x3D;\&quot;Custom\&quot;</value>
    [JsonPropertyName("delimiterValue")]
    public string DelimiterValue { get; set; }



    /// <summary>
    /// Columns specification
    /// </summary>
    /// <value>Columns specification</value>
    [JsonPropertyName("columnInformation")]
    public List<Column> ColumnInformation { get; set; }



    /// <summary>
    /// Preprocessing rules
    /// </summary>
    /// <value>Preprocessing rules</value>
    [JsonPropertyName("preprocessingRules")]
    public List<PreprocessingRule> PreprocessingRules { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FileSpecificationTemplate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Format: ").Append(Format).Append("\n");
        sb.Append("  NumberOfHeadingLinesSkipped: ").Append(NumberOfHeadingLinesSkipped).Append("\n");
        sb.Append("  NumberOfTrailingLinesSkipped: ").Append(NumberOfTrailingLinesSkipped).Append("\n");
        sb.Append("  Header: ").Append(Header).Append("\n");
        sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
        sb.Append("  DelimiterValue: ").Append(DelimiterValue).Append("\n");
        sb.Append("  ColumnInformation: ").Append(ColumnInformation).Append("\n");
        sb.Append("  PreprocessingRules: ").Append(PreprocessingRules).Append("\n");
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
        return Equals(obj as FileSpecificationTemplate);
    }

    /// <summary>
    /// Returns true if FileSpecificationTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of FileSpecificationTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FileSpecificationTemplate other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Format == other.Format ||
                Format != null &&
                Format.Equals(other.Format)
            ) &&
            (
                NumberOfHeadingLinesSkipped == other.NumberOfHeadingLinesSkipped ||
                NumberOfHeadingLinesSkipped != null &&
                NumberOfHeadingLinesSkipped.Equals(other.NumberOfHeadingLinesSkipped)
            ) &&
            (
                NumberOfTrailingLinesSkipped == other.NumberOfTrailingLinesSkipped ||
                NumberOfTrailingLinesSkipped != null &&
                NumberOfTrailingLinesSkipped.Equals(other.NumberOfTrailingLinesSkipped)
            ) &&
            (
                Header == other.Header ||
                Header != null &&
                Header.Equals(other.Header)
            ) &&
            (
                Delimiter == other.Delimiter ||
                Delimiter != null &&
                Delimiter.Equals(other.Delimiter)
            ) &&
            (
                DelimiterValue == other.DelimiterValue ||
                DelimiterValue != null &&
                DelimiterValue.Equals(other.DelimiterValue)
            ) &&
            (
                ColumnInformation == other.ColumnInformation ||
                ColumnInformation != null &&
                ColumnInformation.SequenceEqual(other.ColumnInformation)
            ) &&
            (
                PreprocessingRules == other.PreprocessingRules ||
                PreprocessingRules != null &&
                PreprocessingRules.SequenceEqual(other.PreprocessingRules)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Format != null)
            {
                hash = hash * 59 + Format.GetHashCode();
            }

            if (NumberOfHeadingLinesSkipped != null)
            {
                hash = hash * 59 + NumberOfHeadingLinesSkipped.GetHashCode();
            }

            if (NumberOfTrailingLinesSkipped != null)
            {
                hash = hash * 59 + NumberOfTrailingLinesSkipped.GetHashCode();
            }

            if (Header != null)
            {
                hash = hash * 59 + Header.GetHashCode();
            }

            if (Delimiter != null)
            {
                hash = hash * 59 + Delimiter.GetHashCode();
            }

            if (DelimiterValue != null)
            {
                hash = hash * 59 + DelimiterValue.GetHashCode();
            }

            if (ColumnInformation != null)
            {
                hash = hash * 59 + ColumnInformation.GetHashCode();
            }

            if (PreprocessingRules != null)
            {
                hash = hash * 59 + PreprocessingRules.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
