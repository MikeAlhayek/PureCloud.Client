using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeImportJobReport
/// </summary>

public partial class KnowledgeImportJobReport : IEquatable<KnowledgeImportJobReport>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeImportJobReport" /> class.
    /// </summary>
    /// <param name="Errors">List of errors occurred during processing import..</param>
    /// <param name="Statistics">Statistics related to the import job..</param>
    public KnowledgeImportJobReport(List<KnowledgeImportJobError> Errors = null, KnowledgeImportJobStatistics Statistics = null)
    {
        this.Errors = Errors;
        this.Statistics = Statistics;

    }



    /// <summary>
    /// List of errors occurred during processing import.
    /// </summary>
    /// <value>List of errors occurred during processing import.</value>
    [JsonPropertyName("errors")]
    public List<KnowledgeImportJobError> Errors { get; set; }



    /// <summary>
    /// Statistics related to the import job.
    /// </summary>
    /// <value>Statistics related to the import job.</value>
    [JsonPropertyName("statistics")]
    public KnowledgeImportJobStatistics Statistics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeImportJobReport {\n");

        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
        return Equals(obj as KnowledgeImportJobReport);
    }

    /// <summary>
    /// Returns true if KnowledgeImportJobReport instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeImportJobReport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeImportJobReport other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
            ) &&
            (
                Statistics == other.Statistics ||
                Statistics != null &&
                Statistics.Equals(other.Statistics)
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
            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            if (Statistics != null)
            {
                hash = hash * 59 + Statistics.GetHashCode();
            }

            return hash;
        }
    }
}
