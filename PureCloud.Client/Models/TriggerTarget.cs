using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The target of a trigger invocation
/// </summary>
[DataContract]
public partial class TriggerTarget : IEquatable<TriggerTarget>
{
    /// <summary>
    /// The entity type to target
    /// </summary>
    /// <value>The entity type to target</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Workflow for "Workflow"
        /// </summary>
        [EnumMember(Value = "Workflow")]
        Workflow
    }
    /// <summary>
    /// The entity type to target
    /// </summary>
    /// <value>The entity type to target</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TriggerTarget" /> class.
    /// </summary>
    /// <param name="Type">The entity type to target.</param>
    /// <param name="Id">The ID of the entity to target.</param>
    /// <param name="WorkflowTargetSettings">Optional config for the target..</param>
    public TriggerTarget(TypeEnum? Type = null, string Id = null, WorkflowTargetSettings WorkflowTargetSettings = null)
    {
        this.Type = Type;
        this.Id = Id;
        this.WorkflowTargetSettings = WorkflowTargetSettings;

    }





    /// <summary>
    /// The ID of the entity to target
    /// </summary>
    /// <value>The ID of the entity to target</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Optional config for the target.
    /// </summary>
    /// <value>Optional config for the target.</value>
    [DataMember(Name = "workflowTargetSettings", EmitDefaultValue = false)]
    public WorkflowTargetSettings WorkflowTargetSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TriggerTarget {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WorkflowTargetSettings: ").Append(WorkflowTargetSettings).Append("\n");
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
        return Equals(obj as TriggerTarget);
    }

    /// <summary>
    /// Returns true if TriggerTarget instances are equal
    /// </summary>
    /// <param name="other">Instance of TriggerTarget to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TriggerTarget other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                WorkflowTargetSettings == other.WorkflowTargetSettings ||
                WorkflowTargetSettings != null &&
                WorkflowTargetSettings.Equals(other.WorkflowTargetSettings)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (WorkflowTargetSettings != null)
            {
                hash = hash * 59 + WorkflowTargetSettings.GetHashCode();
            }

            return hash;
        }
    }
}
