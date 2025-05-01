using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2FlowExecutionDataFlowidTopicExecution
/// </summary>
[DataContract]
public partial class V2FlowExecutionDataFlowidTopicExecution : IEquatable<V2FlowExecutionDataFlowidTopicExecution>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicExecution" /> class.
    /// </summary>
    /// <param name="ObjectType">The type of executionItem that was executed..</param>
    /// <param name="ObjectId">If applicable, the actionId, menuId or taskId for the executionItem..</param>
    /// <param name="OutputPathId">If applicable, the identifier of the OutputPath that was taken..</param>
    /// <param name="ExecutionId">If applicable, the executionId for the executionItem..</param>
    /// <param name="StartDateTime">This is the starting time of the executionItem..</param>
    /// <param name="Error">Event generated when a Flow&#39;s Execution History is received and logged..</param>
    /// <param name="Warning">Event generated when a Flow&#39;s Execution History is received and logged..</param>
    /// <param name="LanguageTag">If applicable, the language tag associated set by the execution..</param>
    public V2FlowExecutionDataFlowidTopicExecution(string ObjectType = null, string ObjectId = null, string OutputPathId = null, string ExecutionId = null, DateTime? StartDateTime = null, V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Error = null, V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Warning = null, string LanguageTag = null)
    {
        this.ObjectType = ObjectType;
        this.ObjectId = ObjectId;
        this.OutputPathId = OutputPathId;
        this.ExecutionId = ExecutionId;
        this.StartDateTime = StartDateTime;
        this.Error = Error;
        this.Warning = Warning;
        this.LanguageTag = LanguageTag;

    }



    /// <summary>
    /// The type of executionItem that was executed.
    /// </summary>
    /// <value>The type of executionItem that was executed.</value>
    [DataMember(Name = "objectType", EmitDefaultValue = false)]
    public string ObjectType { get; set; }



    /// <summary>
    /// If applicable, the actionId, menuId or taskId for the executionItem.
    /// </summary>
    /// <value>If applicable, the actionId, menuId or taskId for the executionItem.</value>
    [DataMember(Name = "objectId", EmitDefaultValue = false)]
    public string ObjectId { get; set; }



    /// <summary>
    /// If applicable, the identifier of the OutputPath that was taken.
    /// </summary>
    /// <value>If applicable, the identifier of the OutputPath that was taken.</value>
    [DataMember(Name = "outputPathId", EmitDefaultValue = false)]
    public string OutputPathId { get; set; }



    /// <summary>
    /// If applicable, the executionId for the executionItem.
    /// </summary>
    /// <value>If applicable, the executionId for the executionItem.</value>
    [DataMember(Name = "executionId", EmitDefaultValue = false)]
    public string ExecutionId { get; set; }



    /// <summary>
    /// This is the starting time of the executionItem.
    /// </summary>
    /// <value>This is the starting time of the executionItem.</value>
    [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
    public DateTime? StartDateTime { get; set; }



    /// <summary>
    /// Event generated when a Flow&#39;s Execution History is received and logged.
    /// </summary>
    /// <value>Event generated when a Flow&#39;s Execution History is received and logged.</value>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Error { get; set; }



    /// <summary>
    /// Event generated when a Flow&#39;s Execution History is received and logged.
    /// </summary>
    /// <value>Event generated when a Flow&#39;s Execution History is received and logged.</value>
    [DataMember(Name = "warning", EmitDefaultValue = false)]
    public V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo Warning { get; set; }



    /// <summary>
    /// If applicable, the language tag associated set by the execution.
    /// </summary>
    /// <value>If applicable, the language tag associated set by the execution.</value>
    [DataMember(Name = "languageTag", EmitDefaultValue = false)]
    public string LanguageTag { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2FlowExecutionDataFlowidTopicExecution {\n");

        sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
        sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
        sb.Append("  OutputPathId: ").Append(OutputPathId).Append("\n");
        sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
        sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  Warning: ").Append(Warning).Append("\n");
        sb.Append("  LanguageTag: ").Append(LanguageTag).Append("\n");
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
        return Equals(obj as V2FlowExecutionDataFlowidTopicExecution);
    }

    /// <summary>
    /// Returns true if V2FlowExecutionDataFlowidTopicExecution instances are equal
    /// </summary>
    /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicExecution to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2FlowExecutionDataFlowidTopicExecution other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ObjectType == other.ObjectType ||
                ObjectType != null &&
                ObjectType.Equals(other.ObjectType)
            ) &&
            (
                ObjectId == other.ObjectId ||
                ObjectId != null &&
                ObjectId.Equals(other.ObjectId)
            ) &&
            (
                OutputPathId == other.OutputPathId ||
                OutputPathId != null &&
                OutputPathId.Equals(other.OutputPathId)
            ) &&
            (
                ExecutionId == other.ExecutionId ||
                ExecutionId != null &&
                ExecutionId.Equals(other.ExecutionId)
            ) &&
            (
                StartDateTime == other.StartDateTime ||
                StartDateTime != null &&
                StartDateTime.Equals(other.StartDateTime)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            ) &&
            (
                Warning == other.Warning ||
                Warning != null &&
                Warning.Equals(other.Warning)
            ) &&
            (
                LanguageTag == other.LanguageTag ||
                LanguageTag != null &&
                LanguageTag.Equals(other.LanguageTag)
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
            if (ObjectType != null)
            {
                hash = hash * 59 + ObjectType.GetHashCode();
            }

            if (ObjectId != null)
            {
                hash = hash * 59 + ObjectId.GetHashCode();
            }

            if (OutputPathId != null)
            {
                hash = hash * 59 + OutputPathId.GetHashCode();
            }

            if (ExecutionId != null)
            {
                hash = hash * 59 + ExecutionId.GetHashCode();
            }

            if (StartDateTime != null)
            {
                hash = hash * 59 + StartDateTime.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (Warning != null)
            {
                hash = hash * 59 + Warning.GetHashCode();
            }

            if (LanguageTag != null)
            {
                hash = hash * 59 + LanguageTag.GetHashCode();
            }

            return hash;
        }
    }
}
