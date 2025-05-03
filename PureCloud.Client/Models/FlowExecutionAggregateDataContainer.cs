using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowExecutionAggregateDataContainer
/// </summary>

public partial class FlowExecutionAggregateDataContainer : IEquatable<FlowExecutionAggregateDataContainer>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowExecutionAggregateDataContainer" /> class.
    /// </summary>
    /// <param name="Group">A mapping from dimension to value.</param>
    /// <param name="Data">Data.</param>
    public FlowExecutionAggregateDataContainer(Dictionary<string, string> Group = null, List<StatisticalResponse> Data = null)
    {
        this.Group = Group;
        this.Data = Data;

    }



    /// <summary>
    /// A mapping from dimension to value
    /// </summary>
    /// <value>A mapping from dimension to value</value>
    [JsonPropertyName("group")]
    public Dictionary<string, string> Group { get; set; }



    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [JsonPropertyName("data")]
    public List<StatisticalResponse> Data { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowExecutionAggregateDataContainer {\n");

        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
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
        return Equals(obj as FlowExecutionAggregateDataContainer);
    }

    /// <summary>
    /// Returns true if FlowExecutionAggregateDataContainer instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowExecutionAggregateDataContainer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowExecutionAggregateDataContainer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Group == other.Group ||
                Group != null &&
                Group.SequenceEqual(other.Group)
            ) &&
            (
                Data == other.Data ||
                Data != null &&
                Data.SequenceEqual(other.Data)
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
            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            return hash;
        }
    }
}
