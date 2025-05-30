using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ProgramMappingsRequest
/// </summary>

public partial class ProgramMappingsRequest : IEquatable<ProgramMappingsRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramMappingsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ProgramMappingsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgramMappingsRequest" /> class.
    /// </summary>
    /// <param name="QueueIds">The program queues (required).</param>
    /// <param name="FlowIds">The program flows (required).</param>
    public ProgramMappingsRequest(List<string> QueueIds = null, List<string> FlowIds = null)
    {
        this.QueueIds = QueueIds;
        this.FlowIds = FlowIds;

    }



    /// <summary>
    /// The program queues
    /// </summary>
    /// <value>The program queues</value>
    [JsonPropertyName("queueIds")]
    public List<string> QueueIds { get; set; }



    /// <summary>
    /// The program flows
    /// </summary>
    /// <value>The program flows</value>
    [JsonPropertyName("flowIds")]
    public List<string> FlowIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ProgramMappingsRequest {\n");

        sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
        sb.Append("  FlowIds: ").Append(FlowIds).Append("\n");
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
        return Equals(obj as ProgramMappingsRequest);
    }

    /// <summary>
    /// Returns true if ProgramMappingsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ProgramMappingsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ProgramMappingsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QueueIds == other.QueueIds ||
                QueueIds != null &&
                QueueIds.SequenceEqual(other.QueueIds)
            ) &&
            (
                FlowIds == other.FlowIds ||
                FlowIds != null &&
                FlowIds.SequenceEqual(other.FlowIds)
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
            if (QueueIds != null)
            {
                hash = hash * 59 + QueueIds.GetHashCode();
            }

            if (FlowIds != null)
            {
                hash = hash * 59 + FlowIds.GetHashCode();
            }

            return hash;
        }
    }
}
