using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlertRuleProperties
/// </summary>

public partial class AlertRuleProperties : IEquatable<AlertRuleProperties>
{
    /// <summary>
    /// The type of rule being alerted.
    /// </summary>
    /// <value>The type of rule being alerted.</value>
    
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
        /// Enum Conversationmetrics for "ConversationMetrics"
        /// </summary>
        [EnumMember(Value = "ConversationMetrics")]
        Conversationmetrics,

        /// <summary>
        /// Enum Userpresence for "UserPresence"
        /// </summary>
        [EnumMember(Value = "UserPresence")]
        Userpresence,

        /// <summary>
        /// Enum Workforcemanagement for "WorkforceManagement"
        /// </summary>
        [EnumMember(Value = "WorkforceManagement")]
        Workforcemanagement,

        /// <summary>
        /// Enum Operationalconsole for "OperationalConsole"
        /// </summary>
        [EnumMember(Value = "OperationalConsole")]
        Operationalconsole,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The type of rule being alerted.
    /// </summary>
    /// <value>The type of rule being alerted.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlertRuleProperties" /> class.
    /// </summary>
    public AlertRuleProperties()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlertRuleProperties {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as AlertRuleProperties);
    }

    /// <summary>
    /// Returns true if AlertRuleProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of AlertRuleProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlertRuleProperties other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
