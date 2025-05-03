using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerRulesetConfigChangeAction
/// </summary>

public partial class DialerRulesetConfigChangeAction : IEquatable<DialerRulesetConfigChangeAction>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeAction" /> class.
    /// </summary>
    /// <param name="Type">Type of the action.</param>
    /// <param name="ActionTypeName">Identifier of the action.</param>
    /// <param name="UpdateOption">Indicator of the type of update action (applicable only to certain types of actions).</param>
    /// <param name="Properties">Map of key-value pairs pertinent to the action (different actions require different properties).</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerRulesetConfigChangeAction(string Type = null, string ActionTypeName = null, string UpdateOption = null, Dictionary<string, string> Properties = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Type = Type;
        this.ActionTypeName = ActionTypeName;
        this.UpdateOption = UpdateOption;
        this.Properties = Properties;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// Type of the action
    /// </summary>
    /// <value>Type of the action</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Identifier of the action
    /// </summary>
    /// <value>Identifier of the action</value>
    [JsonPropertyName("actionTypeName")]
    public string ActionTypeName { get; set; }



    /// <summary>
    /// Indicator of the type of update action (applicable only to certain types of actions)
    /// </summary>
    /// <value>Indicator of the type of update action (applicable only to certain types of actions)</value>
    [JsonPropertyName("updateOption")]
    public string UpdateOption { get; set; }



    /// <summary>
    /// Map of key-value pairs pertinent to the action (different actions require different properties)
    /// </summary>
    /// <value>Map of key-value pairs pertinent to the action (different actions require different properties)</value>
    [JsonPropertyName("properties")]
    public Dictionary<string, string> Properties { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerRulesetConfigChangeAction {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ActionTypeName: ").Append(ActionTypeName).Append("\n");
        sb.Append("  UpdateOption: ").Append(UpdateOption).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as DialerRulesetConfigChangeAction);
    }

    /// <summary>
    /// Returns true if DialerRulesetConfigChangeAction instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerRulesetConfigChangeAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerRulesetConfigChangeAction other)
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
                ActionTypeName == other.ActionTypeName ||
                ActionTypeName != null &&
                ActionTypeName.Equals(other.ActionTypeName)
            ) &&
            (
                UpdateOption == other.UpdateOption ||
                UpdateOption != null &&
                UpdateOption.Equals(other.UpdateOption)
            ) &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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

            if (ActionTypeName != null)
            {
                hash = hash * 59 + ActionTypeName.GetHashCode();
            }

            if (UpdateOption != null)
            {
                hash = hash * 59 + UpdateOption.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
