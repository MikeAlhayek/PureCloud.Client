using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeSyncJobReport
/// </summary>

public partial class KnowledgeSyncJobReport : IEquatable<KnowledgeSyncJobReport>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSyncJobReport" /> class.
    /// </summary>
    /// <param name="Errors">List of errors occurred during processing sync..</param>
    /// <param name="Statistics">Statistics related to the sync job..</param>
    public KnowledgeSyncJobReport(List<ErrorBody> Errors = null, KnowledgeSyncJobStatistics Statistics = null)
    {
        this.Errors = Errors;
        this.Statistics = Statistics;

    }



    /// <summary>
    /// List of errors occurred during processing sync.
    /// </summary>
    /// <value>List of errors occurred during processing sync.</value>
    [JsonPropertyName("errors")]
    public List<ErrorBody> Errors { get; set; }



    /// <summary>
    /// Statistics related to the sync job.
    /// </summary>
    /// <value>Statistics related to the sync job.</value>
    [JsonPropertyName("statistics")]
    public KnowledgeSyncJobStatistics Statistics { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeSyncJobReport {\n");

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
        return Equals(obj as KnowledgeSyncJobReport);
    }

    /// <summary>
    /// Returns true if KnowledgeSyncJobReport instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeSyncJobReport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeSyncJobReport other)
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
