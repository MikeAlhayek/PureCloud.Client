using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommonRuleBulkUpdateNotificationsRequest
/// </summary>

public partial class CommonRuleBulkUpdateNotificationsRequest : IEquatable<CommonRuleBulkUpdateNotificationsRequest>
{
    /// <summary>
    /// Gets or Sets TypesToAdd
    /// </summary>
    
    public enum TypesToAddEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sms for "Sms"
        /// </summary>
        [EnumMember(Value = "Sms")]
        Sms,

        /// <summary>
        /// Enum Device for "Device"
        /// </summary>
        [EnumMember(Value = "Device")]
        Device,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Push for "Push"
        /// </summary>
        [EnumMember(Value = "Push")]
        Push
    }
    /// <summary>
    /// Gets or Sets TypesToRemove
    /// </summary>
    
    public enum TypesToRemoveEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sms for "Sms"
        /// </summary>
        [EnumMember(Value = "Sms")]
        Sms,

        /// <summary>
        /// Enum Device for "Device"
        /// </summary>
        [EnumMember(Value = "Device")]
        Device,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Push for "Push"
        /// </summary>
        [EnumMember(Value = "Push")]
        Push
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRuleBulkUpdateNotificationsRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CommonRuleBulkUpdateNotificationsRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommonRuleBulkUpdateNotificationsRequest" /> class.
    /// </summary>
    /// <param name="RuleIds">The user supplied rules ids to be updated (required).</param>
    /// <param name="Properties">The rule properties to be updated.</param>
    /// <param name="TypesToAdd">Collection of alerting notification types to add for all entities in the rules.</param>
    /// <param name="TypesToRemove">Collection of alerting notification types to remove for all entities in the rules.</param>
    public CommonRuleBulkUpdateNotificationsRequest(List<string> RuleIds = null, ModifiableRuleProperties Properties = null, List<TypesToAddEnum> TypesToAdd = null, List<TypesToRemoveEnum> TypesToRemove = null)
    {
        this.RuleIds = RuleIds;
        this.Properties = Properties;
        this.TypesToAdd = TypesToAdd;
        this.TypesToRemove = TypesToRemove;

    }



    /// <summary>
    /// The user supplied rules ids to be updated
    /// </summary>
    /// <value>The user supplied rules ids to be updated</value>
    [JsonPropertyName("ruleIds")]
    public List<string> RuleIds { get; set; }



    /// <summary>
    /// The rule properties to be updated
    /// </summary>
    /// <value>The rule properties to be updated</value>
    [JsonPropertyName("properties")]
    public ModifiableRuleProperties Properties { get; set; }



    /// <summary>
    /// Collection of alerting notification types to add for all entities in the rules
    /// </summary>
    /// <value>Collection of alerting notification types to add for all entities in the rules</value>
    [JsonPropertyName("typesToAdd")]
    public List<TypesToAddEnum> TypesToAdd { get; set; }



    /// <summary>
    /// Collection of alerting notification types to remove for all entities in the rules
    /// </summary>
    /// <value>Collection of alerting notification types to remove for all entities in the rules</value>
    [JsonPropertyName("typesToRemove")]
    public List<TypesToRemoveEnum> TypesToRemove { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CommonRuleBulkUpdateNotificationsRequest {\n");

        sb.Append("  RuleIds: ").Append(RuleIds).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  TypesToAdd: ").Append(TypesToAdd).Append("\n");
        sb.Append("  TypesToRemove: ").Append(TypesToRemove).Append("\n");
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
        return Equals(obj as CommonRuleBulkUpdateNotificationsRequest);
    }

    /// <summary>
    /// Returns true if CommonRuleBulkUpdateNotificationsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CommonRuleBulkUpdateNotificationsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommonRuleBulkUpdateNotificationsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RuleIds == other.RuleIds ||
                RuleIds != null &&
                RuleIds.SequenceEqual(other.RuleIds)
            ) &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.Equals(other.Properties)
            ) &&
            (
                TypesToAdd == other.TypesToAdd ||
                TypesToAdd != null &&
                TypesToAdd.SequenceEqual(other.TypesToAdd)
            ) &&
            (
                TypesToRemove == other.TypesToRemove ||
                TypesToRemove != null &&
                TypesToRemove.SequenceEqual(other.TypesToRemove)
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
            if (RuleIds != null)
            {
                hash = hash * 59 + RuleIds.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (TypesToAdd != null)
            {
                hash = hash * 59 + TypesToAdd.GetHashCode();
            }

            if (TypesToRemove != null)
            {
                hash = hash * 59 + TypesToRemove.GetHashCode();
            }

            return hash;
        }
    }
}
