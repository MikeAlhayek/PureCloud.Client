using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Parameters for launching a flow.
/// </summary>

public partial class FlowExecutionLaunchRequest : IEquatable<FlowExecutionLaunchRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowExecutionLaunchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowExecutionLaunchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowExecutionLaunchRequest" /> class.
    /// </summary>
    /// <param name="FlowId">ID of the flow to launch. (required).</param>
    /// <param name="FlowVersion">The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version..</param>
    /// <param name="InputData">Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema..</param>
    /// <param name="Name">A displayable name to assign to the new flow execution.</param>
    public FlowExecutionLaunchRequest(string FlowId = null, string FlowVersion = null, Dictionary<string, object> InputData = null, string Name = null)
    {
        this.FlowId = FlowId;
        this.FlowVersion = FlowVersion;
        this.InputData = InputData;
        this.Name = Name;

    }



    /// <summary>
    /// ID of the flow to launch.
    /// </summary>
    /// <value>ID of the flow to launch.</value>
    [JsonPropertyName("flowId")]
    public string FlowId { get; set; }



    /// <summary>
    /// The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version.
    /// </summary>
    /// <value>The version of the flow to launch. Omit this value (or supply null/empty) to use the latest published version.</value>
    [JsonPropertyName("flowVersion")]
    public string FlowVersion { get; set; }



    /// <summary>
    /// Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema.
    /// </summary>
    /// <value>Input values to the flow. Valid values are defined by a flow&#39;s input JSON schema.</value>
    [JsonPropertyName("inputData")]
    public Dictionary<string, object> InputData { get; set; }



    /// <summary>
    /// A displayable name to assign to the new flow execution
    /// </summary>
    /// <value>A displayable name to assign to the new flow execution</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowExecutionLaunchRequest {\n");

        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  InputData: ").Append(InputData).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as FlowExecutionLaunchRequest);
    }

    /// <summary>
    /// Returns true if FlowExecutionLaunchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowExecutionLaunchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowExecutionLaunchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                FlowVersion == other.FlowVersion ||
                FlowVersion != null &&
                FlowVersion.Equals(other.FlowVersion)
            ) &&
            (
                InputData == other.InputData ||
                InputData != null &&
                InputData.SequenceEqual(other.InputData)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
            }

            if (InputData != null)
            {
                hash = hash * 59 + InputData.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            return hash;
        }
    }
}
