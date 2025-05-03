using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectFlowFields
/// </summary>

public partial class ArchitectFlowFields : IEquatable<ArchitectFlowFields>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectFlowFields" /> class.
    /// </summary>
    /// <param name="ArchitectFlow">The architect flow..</param>
    /// <param name="FlowRequestMappings">Collection of Architect Flow Request Mappings to use..</param>
    public ArchitectFlowFields(AddressableEntityRef ArchitectFlow = null, List<RequestMapping> FlowRequestMappings = null)
    {
        this.ArchitectFlow = ArchitectFlow;
        this.FlowRequestMappings = FlowRequestMappings;

    }



    /// <summary>
    /// The architect flow.
    /// </summary>
    /// <value>The architect flow.</value>
    [JsonPropertyName("architectFlow")]
    public AddressableEntityRef ArchitectFlow { get; set; }



    /// <summary>
    /// Collection of Architect Flow Request Mappings to use.
    /// </summary>
    /// <value>Collection of Architect Flow Request Mappings to use.</value>
    [JsonPropertyName("flowRequestMappings")]
    public List<RequestMapping> FlowRequestMappings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectFlowFields {\n");

        sb.Append("  ArchitectFlow: ").Append(ArchitectFlow).Append("\n");
        sb.Append("  FlowRequestMappings: ").Append(FlowRequestMappings).Append("\n");
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
        return Equals(obj as ArchitectFlowFields);
    }

    /// <summary>
    /// Returns true if ArchitectFlowFields instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectFlowFields to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectFlowFields other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ArchitectFlow == other.ArchitectFlow ||
                ArchitectFlow != null &&
                ArchitectFlow.Equals(other.ArchitectFlow)
            ) &&
            (
                FlowRequestMappings == other.FlowRequestMappings ||
                FlowRequestMappings != null &&
                FlowRequestMappings.SequenceEqual(other.FlowRequestMappings)
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
            if (ArchitectFlow != null)
            {
                hash = hash * 59 + ArchitectFlow.GetHashCode();
            }

            if (FlowRequestMappings != null)
            {
                hash = hash * 59 + FlowRequestMappings.GetHashCode();
            }

            return hash;
        }
    }
}
