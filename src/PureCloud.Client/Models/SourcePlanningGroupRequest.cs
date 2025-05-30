using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SourcePlanningGroupRequest
/// </summary>

public partial class SourcePlanningGroupRequest : IEquatable<SourcePlanningGroupRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SourcePlanningGroupRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SourcePlanningGroupRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SourcePlanningGroupRequest" /> class.
    /// </summary>
    /// <param name="Id">The ID of the planning group (required).</param>
    /// <param name="Metadata">Version metadata for the planning group (required).</param>
    public SourcePlanningGroupRequest(string Id = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Id = Id;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The ID of the planning group
    /// </summary>
    /// <value>The ID of the planning group</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Version metadata for the planning group
    /// </summary>
    /// <value>Version metadata for the planning group</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SourcePlanningGroupRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as SourcePlanningGroupRequest);
    }

    /// <summary>
    /// Returns true if SourcePlanningGroupRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SourcePlanningGroupRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SourcePlanningGroupRequest other)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
