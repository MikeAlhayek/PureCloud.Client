using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// This contains contextual information about an invoking entity.
/// </summary>
[DataContract]
public partial class V2FlowExecutionDataFlowidTopicInvokingContext : IEquatable<V2FlowExecutionDataFlowidTopicInvokingContext>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicInvokingContext" /> class.
    /// </summary>
    /// <param name="Flow">Flow.</param>
    /// <param name="JourneyActionMap">JourneyActionMap.</param>
    /// <param name="ProcessAutomation">ProcessAutomation.</param>
    /// <param name="Quality">Quality.</param>
    /// <param name="Workitem">Workitem.</param>
    public V2FlowExecutionDataFlowidTopicInvokingContext(V2FlowExecutionDataFlowidTopicFlow Flow = null, V2FlowExecutionDataFlowidTopicJourneyActionMap JourneyActionMap = null, V2FlowExecutionDataFlowidTopicProcessAutomation ProcessAutomation = null, V2FlowExecutionDataFlowidTopicQuality Quality = null, V2FlowExecutionDataFlowidTopicWorkitem Workitem = null)
    {
        this.Flow = Flow;
        this.JourneyActionMap = JourneyActionMap;
        this.ProcessAutomation = ProcessAutomation;
        this.Quality = Quality;
        this.Workitem = Workitem;

    }



    /// <summary>
    /// Gets or Sets Flow
    /// </summary>
    [DataMember(Name = "flow", EmitDefaultValue = false)]
    public V2FlowExecutionDataFlowidTopicFlow Flow { get; set; }



    /// <summary>
    /// Gets or Sets JourneyActionMap
    /// </summary>
    [DataMember(Name = "journeyActionMap", EmitDefaultValue = false)]
    public V2FlowExecutionDataFlowidTopicJourneyActionMap JourneyActionMap { get; set; }



    /// <summary>
    /// Gets or Sets ProcessAutomation
    /// </summary>
    [DataMember(Name = "processAutomation", EmitDefaultValue = false)]
    public V2FlowExecutionDataFlowidTopicProcessAutomation ProcessAutomation { get; set; }



    /// <summary>
    /// Gets or Sets Quality
    /// </summary>
    [DataMember(Name = "quality", EmitDefaultValue = false)]
    public V2FlowExecutionDataFlowidTopicQuality Quality { get; set; }



    /// <summary>
    /// Gets or Sets Workitem
    /// </summary>
    [DataMember(Name = "workitem", EmitDefaultValue = false)]
    public V2FlowExecutionDataFlowidTopicWorkitem Workitem { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2FlowExecutionDataFlowidTopicInvokingContext {\n");

        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  JourneyActionMap: ").Append(JourneyActionMap).Append("\n");
        sb.Append("  ProcessAutomation: ").Append(ProcessAutomation).Append("\n");
        sb.Append("  Quality: ").Append(Quality).Append("\n");
        sb.Append("  Workitem: ").Append(Workitem).Append("\n");
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
        return Equals(obj as V2FlowExecutionDataFlowidTopicInvokingContext);
    }

    /// <summary>
    /// Returns true if V2FlowExecutionDataFlowidTopicInvokingContext instances are equal
    /// </summary>
    /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicInvokingContext to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2FlowExecutionDataFlowidTopicInvokingContext other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
            ) &&
            (
                JourneyActionMap == other.JourneyActionMap ||
                JourneyActionMap != null &&
                JourneyActionMap.Equals(other.JourneyActionMap)
            ) &&
            (
                ProcessAutomation == other.ProcessAutomation ||
                ProcessAutomation != null &&
                ProcessAutomation.Equals(other.ProcessAutomation)
            ) &&
            (
                Quality == other.Quality ||
                Quality != null &&
                Quality.Equals(other.Quality)
            ) &&
            (
                Workitem == other.Workitem ||
                Workitem != null &&
                Workitem.Equals(other.Workitem)
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
            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (JourneyActionMap != null)
            {
                hash = hash * 59 + JourneyActionMap.GetHashCode();
            }

            if (ProcessAutomation != null)
            {
                hash = hash * 59 + ProcessAutomation.GetHashCode();
            }

            if (Quality != null)
            {
                hash = hash * 59 + Quality.GetHashCode();
            }

            if (Workitem != null)
            {
                hash = hash * 59 + Workitem.GetHashCode();
            }

            return hash;
        }
    }
}
