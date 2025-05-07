using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Additional identifiers for describing messaging recipient.
/// </summary>

public partial class ConversationRecipientAdditionalIdentifier : IEquatable<ConversationRecipientAdditionalIdentifier>
{
    /// <summary>
    /// Type of the Identifier
    /// </summary>
    /// <value>Type of the Identifier</value>
    
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
        /// Enum Deployment for "Deployment"
        /// </summary>
        [EnumMember(Value = "Deployment")]
        Deployment,

        /// <summary>
        /// Enum Subject for "Subject"
        /// </summary>
        [EnumMember(Value = "Subject")]
        Subject,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Topic for "Topic"
        /// </summary>
        [EnumMember(Value = "Topic")]
        Topic,

        /// <summary>
        /// Enum Ingestionrule for "IngestionRule"
        /// </summary>
        [EnumMember(Value = "IngestionRule")]
        Ingestionrule,

        /// <summary>
        /// Enum Ingestionruleversion for "IngestionRuleVersion"
        /// </summary>
        [EnumMember(Value = "IngestionRuleVersion")]
        Ingestionruleversion
    }
    /// <summary>
    /// Type of the Identifier
    /// </summary>
    /// <value>Type of the Identifier</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationRecipientAdditionalIdentifier" /> class.
    /// </summary>
    public ConversationRecipientAdditionalIdentifier()
    {

    }





    /// <summary>
    /// The Identifier value.
    /// </summary>
    /// <value>The Identifier value.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationRecipientAdditionalIdentifier {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as ConversationRecipientAdditionalIdentifier);
    }

    /// <summary>
    /// Returns true if ConversationRecipientAdditionalIdentifier instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationRecipientAdditionalIdentifier to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationRecipientAdditionalIdentifier other)
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
