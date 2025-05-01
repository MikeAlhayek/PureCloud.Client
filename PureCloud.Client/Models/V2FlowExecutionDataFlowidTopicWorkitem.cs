using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// This contains information about the workitem that invoked this flow execution.
/// </summary>
[DataContract]
public partial class V2FlowExecutionDataFlowidTopicWorkitem : IEquatable<V2FlowExecutionDataFlowidTopicWorkitem>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicWorkitem" /> class.
    /// </summary>
    /// <param name="WorkitemId">The identifier of the workitem that invoked this flow..</param>
    /// <param name="WorkitemName">The name of the process workitem that invoked this flow..</param>
    public V2FlowExecutionDataFlowidTopicWorkitem(string WorkitemId = null, string WorkitemName = null)
    {
        this.WorkitemId = WorkitemId;
        this.WorkitemName = WorkitemName;

    }



    /// <summary>
    /// The identifier of the workitem that invoked this flow.
    /// </summary>
    /// <value>The identifier of the workitem that invoked this flow.</value>
    [DataMember(Name = "workitemId", EmitDefaultValue = false)]
    public string WorkitemId { get; set; }



    /// <summary>
    /// The name of the process workitem that invoked this flow.
    /// </summary>
    /// <value>The name of the process workitem that invoked this flow.</value>
    [DataMember(Name = "workitemName", EmitDefaultValue = false)]
    public string WorkitemName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2FlowExecutionDataFlowidTopicWorkitem {\n");

        sb.Append("  WorkitemId: ").Append(WorkitemId).Append("\n");
        sb.Append("  WorkitemName: ").Append(WorkitemName).Append("\n");
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
        return Equals(obj as V2FlowExecutionDataFlowidTopicWorkitem);
    }

    /// <summary>
    /// Returns true if V2FlowExecutionDataFlowidTopicWorkitem instances are equal
    /// </summary>
    /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicWorkitem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2FlowExecutionDataFlowidTopicWorkitem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                WorkitemId == other.WorkitemId ||
                WorkitemId != null &&
                WorkitemId.Equals(other.WorkitemId)
            ) &&
            (
                WorkitemName == other.WorkitemName ||
                WorkitemName != null &&
                WorkitemName.Equals(other.WorkitemName)
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
            if (WorkitemId != null)
            {
                hash = hash * 59 + WorkitemId.GetHashCode();
            }

            if (WorkitemName != null)
            {
                hash = hash * 59 + WorkitemName.GetHashCode();
            }

            return hash;
        }
    }
}
