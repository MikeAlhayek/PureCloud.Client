using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanConstraintConflictMessage
/// </summary>
[DataContract]
public partial class WorkPlanConstraintConflictMessage : IEquatable<WorkPlanConstraintConflictMessage>
{
    /// <summary>
    /// Type of constraint conflict that can be resolved by clients in order to generate agent schedules
    /// </summary>
    /// <value>Type of constraint conflict that can be resolved by clients in order to generate agent schedules</value>
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
        /// Enum Unknownfix for "UnknownFix"
        /// </summary>
        [EnumMember(Value = "UnknownFix")]
        Unknownfix,

        /// <summary>
        /// Enum Withpotentialfixes for "WithPotentialFixes"
        /// </summary>
        [EnumMember(Value = "WithPotentialFixes")]
        Withpotentialfixes
    }
    /// <summary>
    /// Type of constraint conflict that can be resolved by clients in order to generate agent schedules
    /// </summary>
    /// <value>Type of constraint conflict that can be resolved by clients in order to generate agent schedules</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanConstraintConflictMessage" /> class.
    /// </summary>
    /// <param name="Type">Type of constraint conflict that can be resolved by clients in order to generate agent schedules.</param>
    /// <param name="Arguments">The arguments to the type of the message that can help clients resolve validation issues.</param>
    public WorkPlanConstraintConflictMessage(TypeEnum? Type = null, List<WorkPlanValidationMessageArgument> Arguments = null)
    {
        this.Type = Type;
        this.Arguments = Arguments;

    }





    /// <summary>
    /// The arguments to the type of the message that can help clients resolve validation issues
    /// </summary>
    /// <value>The arguments to the type of the message that can help clients resolve validation issues</value>
    [DataMember(Name = "arguments", EmitDefaultValue = false)]
    public List<WorkPlanValidationMessageArgument> Arguments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanConstraintConflictMessage {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
        return Equals(obj as WorkPlanConstraintConflictMessage);
    }

    /// <summary>
    /// Returns true if WorkPlanConstraintConflictMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanConstraintConflictMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanConstraintConflictMessage other)
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
                Arguments == other.Arguments ||
                Arguments != null &&
                Arguments.SequenceEqual(other.Arguments)
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

            if (Arguments != null)
            {
                hash = hash * 59 + Arguments.GetHashCode();
            }

            return hash;
        }
    }
}
