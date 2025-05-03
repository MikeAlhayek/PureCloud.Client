using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeParseJobResponse
/// </summary>

public partial class KnowledgeParseJobResponse : IEquatable<KnowledgeParseJobResponse>
{
    /// <summary>
    /// Status of the parse job
    /// </summary>
    /// <value>Status of the parse job</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Readytoparse for "ReadyToParse"
        /// </summary>
        [EnumMember(Value = "ReadyToParse")]
        Readytoparse,

        /// <summary>
        /// Enum Parseinprogress for "ParseInProgress"
        /// </summary>
        [EnumMember(Value = "ParseInProgress")]
        Parseinprogress,

        /// <summary>
        /// Enum Parsecompleted for "ParseCompleted"
        /// </summary>
        [EnumMember(Value = "ParseCompleted")]
        Parsecompleted,

        /// <summary>
        /// Enum Readytoimport for "ReadyToImport"
        /// </summary>
        [EnumMember(Value = "ReadyToImport")]
        Readytoimport,

        /// <summary>
        /// Enum Importinprogress for "ImportInProgress"
        /// </summary>
        [EnumMember(Value = "ImportInProgress")]
        Importinprogress,

        /// <summary>
        /// Enum Importcompleted for "ImportCompleted"
        /// </summary>
        [EnumMember(Value = "ImportCompleted")]
        Importcompleted,

        /// <summary>
        /// Enum Importpartialcompleted for "ImportPartialCompleted"
        /// </summary>
        [EnumMember(Value = "ImportPartialCompleted")]
        Importpartialcompleted,

        /// <summary>
        /// Enum Importfailed for "ImportFailed"
        /// </summary>
        [EnumMember(Value = "ImportFailed")]
        Importfailed
    }
    /// <summary>
    /// Status of the parse job
    /// </summary>
    /// <value>Status of the parse job</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeParseJobResponse" /> class.
    /// </summary>
    /// <param name="DownloadURL">The URL of the location at which the caller can download the original html file..</param>
    /// <param name="Hints">Hinted titles for the parser..</param>
    /// <param name="CreatedBy">The user who created the operation.</param>
    public KnowledgeParseJobResponse(string DownloadURL = null, List<string> Hints = null, UserReference CreatedBy = null)
    {
        this.DownloadURL = DownloadURL;
        this.Hints = Hints;
        this.CreatedBy = CreatedBy;

    }



    /// <summary>
    /// Id of the parse job
    /// </summary>
    /// <value>Id of the parse job</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The URL of the location at which the caller can download the original html file.
    /// </summary>
    /// <value>The URL of the location at which the caller can download the original html file.</value>
    [JsonPropertyName("downloadURL")]
    public string DownloadURL { get; set; }



    /// <summary>
    /// Hinted titles for the parser.
    /// </summary>
    /// <value>Hinted titles for the parser.</value>
    [JsonPropertyName("hints")]
    public List<string> Hints { get; set; }





    /// <summary>
    /// Results of the parse
    /// </summary>
    /// <value>Results of the parse</value>
    [JsonPropertyName("parseResults")]
    public List<KnowledgeParseRecord> ParseResults { get; private set; }



    /// <summary>
    /// Result of the import phase
    /// </summary>
    /// <value>Result of the import phase</value>
    [JsonPropertyName("importResult")]
    public KnowledgeParseImportResult ImportResult { get; private set; }



    /// <summary>
    /// The user who created the operation
    /// </summary>
    /// <value>The user who created the operation</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



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
        sb.Append("class KnowledgeParseJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DownloadURL: ").Append(DownloadURL).Append("\n");
        sb.Append("  Hints: ").Append(Hints).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ParseResults: ").Append(ParseResults).Append("\n");
        sb.Append("  ImportResult: ").Append(ImportResult).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as KnowledgeParseJobResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeParseJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeParseJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeParseJobResponse other)
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
                DownloadURL == other.DownloadURL ||
                DownloadURL != null &&
                DownloadURL.Equals(other.DownloadURL)
            ) &&
            (
                Hints == other.Hints ||
                Hints != null &&
                Hints.SequenceEqual(other.Hints)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ParseResults == other.ParseResults ||
                ParseResults != null &&
                ParseResults.SequenceEqual(other.ParseResults)
            ) &&
            (
                ImportResult == other.ImportResult ||
                ImportResult != null &&
                ImportResult.Equals(other.ImportResult)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
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

            if (DownloadURL != null)
            {
                hash = hash * 59 + DownloadURL.GetHashCode();
            }

            if (Hints != null)
            {
                hash = hash * 59 + Hints.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ParseResults != null)
            {
                hash = hash * 59 + ParseResults.GetHashCode();
            }

            if (ImportResult != null)
            {
                hash = hash * 59 + ImportResult.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
