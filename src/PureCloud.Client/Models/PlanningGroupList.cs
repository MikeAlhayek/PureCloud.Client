using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PlanningGroupList
/// </summary>

public partial class PlanningGroupList : IEquatable<PlanningGroupList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PlanningGroupList" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="Metadata">Version metadata for the planning groups.</param>
    public PlanningGroupList(List<PlanningGroup> Entities = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Entities = Entities;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<PlanningGroup> Entities { get; set; }



    /// <summary>
    /// Version metadata for the planning groups
    /// </summary>
    /// <value>Version metadata for the planning groups</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PlanningGroupList {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as PlanningGroupList);
    }

    /// <summary>
    /// Returns true if PlanningGroupList instances are equal
    /// </summary>
    /// <param name="other">Instance of PlanningGroupList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PlanningGroupList other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
