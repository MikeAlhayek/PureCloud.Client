using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A set of available characteristic definitions
/// </summary>
[DataContract]
public partial class FlowLogLevelCharacteristicsDefinitions : IEquatable<FlowLogLevelCharacteristicsDefinitions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowLogLevelCharacteristicsDefinitions" /> class.
    /// </summary>
    public FlowLogLevelCharacteristicsDefinitions()
    {

    }



    /// <summary>
    /// A list of flow log levels available to the organization.
    /// </summary>
    /// <value>A list of flow log levels available to the organization.</value>
    [DataMember(Name = "logLevels", EmitDefaultValue = false)]
    public List<FlowLogLevel> LogLevels { get; private set; }



    /// <summary>
    /// A list of characteristics that the loglevels will have that are available to the organization..
    /// </summary>
    /// <value>A list of characteristics that the loglevels will have that are available to the organization..</value>
    [DataMember(Name = "characteristics", EmitDefaultValue = false)]
    public List<FlowLogLevelCharacteristicsDefinition> Characteristics { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowLogLevelCharacteristicsDefinitions {\n");

        sb.Append("  LogLevels: ").Append(LogLevels).Append("\n");
        sb.Append("  Characteristics: ").Append(Characteristics).Append("\n");
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
        return Equals(obj as FlowLogLevelCharacteristicsDefinitions);
    }

    /// <summary>
    /// Returns true if FlowLogLevelCharacteristicsDefinitions instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowLogLevelCharacteristicsDefinitions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowLogLevelCharacteristicsDefinitions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LogLevels == other.LogLevels ||
                LogLevels != null &&
                LogLevels.SequenceEqual(other.LogLevels)
            ) &&
            (
                Characteristics == other.Characteristics ||
                Characteristics != null &&
                Characteristics.SequenceEqual(other.Characteristics)
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
            if (LogLevels != null)
            {
                hash = hash * 59 + LogLevels.GetHashCode();
            }

            if (Characteristics != null)
            {
                hash = hash * 59 + Characteristics.GetHashCode();
            }

            return hash;
        }
    }
}
