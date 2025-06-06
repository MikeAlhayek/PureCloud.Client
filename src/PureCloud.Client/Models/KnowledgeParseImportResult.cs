using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeParseImportResult
/// </summary>

public partial class KnowledgeParseImportResult : IEquatable<KnowledgeParseImportResult>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeParseImportResult" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeParseImportResult() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeParseImportResult" /> class.
    /// </summary>
    /// <param name="Success">Number of imported articles. (required).</param>
    /// <param name="Failure">Number of articles failed to import. (required).</param>
    /// <param name="Errors">Error information about the failures..</param>
    public KnowledgeParseImportResult(int? Success = null, int? Failure = null, List<ErrorBody> Errors = null)
    {
        this.Success = Success;
        this.Failure = Failure;
        this.Errors = Errors;

    }



    /// <summary>
    /// Number of imported articles.
    /// </summary>
    /// <value>Number of imported articles.</value>
    [JsonPropertyName("success")]
    public int? Success { get; set; }



    /// <summary>
    /// Number of articles failed to import.
    /// </summary>
    /// <value>Number of articles failed to import.</value>
    [JsonPropertyName("failure")]
    public int? Failure { get; set; }



    /// <summary>
    /// Error information about the failures.
    /// </summary>
    /// <value>Error information about the failures.</value>
    [JsonPropertyName("errors")]
    public List<ErrorBody> Errors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeParseImportResult {\n");

        sb.Append("  Success: ").Append(Success).Append("\n");
        sb.Append("  Failure: ").Append(Failure).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
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
        return Equals(obj as KnowledgeParseImportResult);
    }

    /// <summary>
    /// Returns true if KnowledgeParseImportResult instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeParseImportResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeParseImportResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Success == other.Success ||
                Success != null &&
                Success.Equals(other.Success)
            ) &&
            (
                Failure == other.Failure ||
                Failure != null &&
                Failure.Equals(other.Failure)
            ) &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
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
            if (Success != null)
            {
                hash = hash * 59 + Success.GetHashCode();
            }

            if (Failure != null)
            {
                hash = hash * 59 + Failure.GetHashCode();
            }

            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            return hash;
        }
    }
}
