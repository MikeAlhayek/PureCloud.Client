using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeExportJobDocumentsFilter
/// </summary>

public partial class KnowledgeExportJobDocumentsFilter : IEquatable<KnowledgeExportJobDocumentsFilter>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeExportJobDocumentsFilter" /> class.
    /// </summary>
    /// <param name="Interval">Retrieves the documents modified in specified date and time range. Cannot be used together with entities filter. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    /// <param name="Entities">Retrieves the documents with the given ids. Cannot be used together with internal filter..</param>
    /// <param name="SourceId">SourceId.</param>
    /// <param name="IncludeDocumentsWithFileBody">IncludeDocumentsWithFileBody.</param>
    public KnowledgeExportJobDocumentsFilter(string Interval = null, List<Entity> Entities = null, string SourceId = null, bool? IncludeDocumentsWithFileBody = null)
    {
        this.Interval = Interval;
        this.Entities = Entities;
        this.SourceId = SourceId;
        this.IncludeDocumentsWithFileBody = IncludeDocumentsWithFileBody;

    }



    /// <summary>
    /// Retrieves the documents modified in specified date and time range. Cannot be used together with entities filter. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>Retrieves the documents modified in specified date and time range. Cannot be used together with entities filter. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("interval")]
    public string Interval { get; set; }



    /// <summary>
    /// Retrieves the documents with the given ids. Cannot be used together with internal filter.
    /// </summary>
    /// <value>Retrieves the documents with the given ids. Cannot be used together with internal filter.</value>
    [JsonPropertyName("entities")]
    public List<Entity> Entities { get; set; }



    /// <summary>
    /// Gets or Sets SourceId
    /// </summary>
    [JsonPropertyName("sourceId")]
    public string SourceId { get; set; }



    /// <summary>
    /// Gets or Sets IncludeDocumentsWithFileBody
    /// </summary>
    [JsonPropertyName("includeDocumentsWithFileBody")]
    public bool? IncludeDocumentsWithFileBody { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeExportJobDocumentsFilter {\n");

        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  SourceId: ").Append(SourceId).Append("\n");
        sb.Append("  IncludeDocumentsWithFileBody: ").Append(IncludeDocumentsWithFileBody).Append("\n");
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
        return Equals(obj as KnowledgeExportJobDocumentsFilter);
    }

    /// <summary>
    /// Returns true if KnowledgeExportJobDocumentsFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeExportJobDocumentsFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeExportJobDocumentsFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                SourceId == other.SourceId ||
                SourceId != null &&
                SourceId.Equals(other.SourceId)
            ) &&
            (
                IncludeDocumentsWithFileBody == other.IncludeDocumentsWithFileBody ||
                IncludeDocumentsWithFileBody != null &&
                IncludeDocumentsWithFileBody.Equals(other.IncludeDocumentsWithFileBody)
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
            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (SourceId != null)
            {
                hash = hash * 59 + SourceId.GetHashCode();
            }

            if (IncludeDocumentsWithFileBody != null)
            {
                hash = hash * 59 + IncludeDocumentsWithFileBody.GetHashCode();
            }

            return hash;
        }
    }
}
