using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CopilotFallbackAction
/// </summary>

public partial class CopilotFallbackAction : IEquatable<CopilotFallbackAction>
{
    /// <summary>
    /// Type of action.
    /// </summary>
    /// <value>Type of action.</value>
    
    public enum ActionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Knowledgearticle for "KnowledgeArticle"
        /// </summary>
        [EnumMember(Value = "KnowledgeArticle")]
        Knowledgearticle,

        /// <summary>
        /// Enum Cannedresponse for "CannedResponse"
        /// </summary>
        [EnumMember(Value = "CannedResponse")]
        Cannedresponse,

        /// <summary>
        /// Enum Script for "Script"
        /// </summary>
        [EnumMember(Value = "Script")]
        Script,

        /// <summary>
        /// Enum Knowledgesearch for "KnowledgeSearch"
        /// </summary>
        [EnumMember(Value = "KnowledgeSearch")]
        Knowledgesearch
    }
    /// <summary>
    /// Type of action.
    /// </summary>
    /// <value>Type of action.</value>
    [JsonPropertyName("actionType")]
    public ActionTypeEnum? ActionType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CopilotFallbackAction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CopilotFallbackAction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CopilotFallbackAction" /> class.
    /// </summary>
    /// <param name="ActionType">Type of action. (required).</param>
    /// <param name="Attributes">Action specific attributes, if any. Maximum 100 of string key-value pair allowed..</param>
    public CopilotFallbackAction(ActionTypeEnum? ActionType = null, Dictionary<string, string> Attributes = null)
    {
        this.ActionType = ActionType;
        this.Attributes = Attributes;

    }





    /// <summary>
    /// Action specific attributes, if any. Maximum 100 of string key-value pair allowed.
    /// </summary>
    /// <value>Action specific attributes, if any. Maximum 100 of string key-value pair allowed.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CopilotFallbackAction {\n");

        sb.Append("  ActionType: ").Append(ActionType).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
        return Equals(obj as CopilotFallbackAction);
    }

    /// <summary>
    /// Returns true if CopilotFallbackAction instances are equal
    /// </summary>
    /// <param name="other">Instance of CopilotFallbackAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CopilotFallbackAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActionType == other.ActionType ||
                ActionType != null &&
                ActionType.Equals(other.ActionType)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
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
            if (ActionType != null)
            {
                hash = hash * 59 + ActionType.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            return hash;
        }
    }
}
