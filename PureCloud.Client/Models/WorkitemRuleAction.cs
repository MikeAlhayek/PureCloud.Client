using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemRuleAction
/// </summary>
[DataContract]
public partial class WorkitemRuleAction : IEquatable<WorkitemRuleAction>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
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
        /// Enum Launchflow for "LaunchFlow"
        /// </summary>
        [EnumMember(Value = "LaunchFlow")]
        Launchflow
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemRuleAction" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    public WorkitemRuleAction(TypeEnum? Type = null)
    {
        this.Type = Type;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemRuleAction {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return this.Equals(obj as WorkitemRuleAction);
    }

    /// <summary>
    /// Returns true if WorkitemRuleAction instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemRuleAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemRuleAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
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
            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            return hash;
        }
    }
}
