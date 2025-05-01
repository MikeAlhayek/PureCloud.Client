using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// This contains contextual information about an invoking entity.
/// </summary>
[DataContract]
public partial class V2FlowExecutionDataFlowidTopicProcessAutomation : IEquatable<V2FlowExecutionDataFlowidTopicProcessAutomation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicProcessAutomation" /> class.
    /// </summary>
    /// <param name="TriggerId">The identifier of the process automation trigger that invoked this flow..</param>
    /// <param name="TriggerName">The name of the process automation trigger that invoked this flow..</param>
    public V2FlowExecutionDataFlowidTopicProcessAutomation(string TriggerId = null, string TriggerName = null)
    {
        this.TriggerId = TriggerId;
        this.TriggerName = TriggerName;

    }



    /// <summary>
    /// The identifier of the process automation trigger that invoked this flow.
    /// </summary>
    /// <value>The identifier of the process automation trigger that invoked this flow.</value>
    [DataMember(Name = "triggerId", EmitDefaultValue = false)]
    public string TriggerId { get; set; }



    /// <summary>
    /// The name of the process automation trigger that invoked this flow.
    /// </summary>
    /// <value>The name of the process automation trigger that invoked this flow.</value>
    [DataMember(Name = "triggerName", EmitDefaultValue = false)]
    public string TriggerName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2FlowExecutionDataFlowidTopicProcessAutomation {\n");

        sb.Append("  TriggerId: ").Append(TriggerId).Append("\n");
        sb.Append("  TriggerName: ").Append(TriggerName).Append("\n");
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
        return Equals(obj as V2FlowExecutionDataFlowidTopicProcessAutomation);
    }

    /// <summary>
    /// Returns true if V2FlowExecutionDataFlowidTopicProcessAutomation instances are equal
    /// </summary>
    /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicProcessAutomation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2FlowExecutionDataFlowidTopicProcessAutomation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TriggerId == other.TriggerId ||
                TriggerId != null &&
                TriggerId.Equals(other.TriggerId)
            ) &&
            (
                TriggerName == other.TriggerName ||
                TriggerName != null &&
                TriggerName.Equals(other.TriggerName)
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
            if (TriggerId != null)
            {
                hash = hash * 59 + TriggerId.GetHashCode();
            }

            if (TriggerName != null)
            {
                hash = hash * 59 + TriggerName.GetHashCode();
            }

            return hash;
        }
    }
}
