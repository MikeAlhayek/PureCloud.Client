using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeGuestSearchClientApplication
/// </summary>

public partial class KnowledgeGuestSearchClientApplication : IEquatable<KnowledgeGuestSearchClientApplication>
{
    /// <summary>
    /// Application type.
    /// </summary>
    /// <value>Application type.</value>
    
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
        /// Enum Assistant for "Assistant"
        /// </summary>
        [EnumMember(Value = "Assistant")]
        Assistant,

        /// <summary>
        /// Enum Botflow for "BotFlow"
        /// </summary>
        [EnumMember(Value = "BotFlow")]
        Botflow,

        /// <summary>
        /// Enum Messengerknowledgeapp for "MessengerKnowledgeApp"
        /// </summary>
        [EnumMember(Value = "MessengerKnowledgeApp")]
        Messengerknowledgeapp,

        /// <summary>
        /// Enum Smartadvisor for "SmartAdvisor"
        /// </summary>
        [EnumMember(Value = "SmartAdvisor")]
        Smartadvisor,

        /// <summary>
        /// Enum Supportcenter for "SupportCenter"
        /// </summary>
        [EnumMember(Value = "SupportCenter")]
        Supportcenter
    }
    /// <summary>
    /// Application type.
    /// </summary>
    /// <value>Application type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSearchClientApplication" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeGuestSearchClientApplication() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSearchClientApplication" /> class.
    /// </summary>
    /// <param name="Type">Application type. (required).</param>
    /// <param name="Deployment">Application details when type is MessengerKnowledgeApp or SupportCenter..</param>
    /// <param name="BotFlow">Application details when type is BotFlow..</param>
    /// <param name="Assistant">Application details when type is Assistant..</param>
    public KnowledgeGuestSearchClientApplication(TypeEnum? Type = null, EntityReference Deployment = null, EntityReference BotFlow = null, EntityReference Assistant = null)
    {
        this.Type = Type;
        this.Deployment = Deployment;
        this.BotFlow = BotFlow;
        this.Assistant = Assistant;

    }





    /// <summary>
    /// Application details when type is MessengerKnowledgeApp or SupportCenter.
    /// </summary>
    /// <value>Application details when type is MessengerKnowledgeApp or SupportCenter.</value>
    [JsonPropertyName("deployment")]
    public EntityReference Deployment { get; set; }



    /// <summary>
    /// Application details when type is BotFlow.
    /// </summary>
    /// <value>Application details when type is BotFlow.</value>
    [JsonPropertyName("botFlow")]
    public EntityReference BotFlow { get; set; }



    /// <summary>
    /// Application details when type is Assistant.
    /// </summary>
    /// <value>Application details when type is Assistant.</value>
    [JsonPropertyName("assistant")]
    public EntityReference Assistant { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeGuestSearchClientApplication {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Deployment: ").Append(Deployment).Append("\n");
        sb.Append("  BotFlow: ").Append(BotFlow).Append("\n");
        sb.Append("  Assistant: ").Append(Assistant).Append("\n");
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
        return Equals(obj as KnowledgeGuestSearchClientApplication);
    }

    /// <summary>
    /// Returns true if KnowledgeGuestSearchClientApplication instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeGuestSearchClientApplication to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeGuestSearchClientApplication other)
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
                Deployment == other.Deployment ||
                Deployment != null &&
                Deployment.Equals(other.Deployment)
            ) &&
            (
                BotFlow == other.BotFlow ||
                BotFlow != null &&
                BotFlow.Equals(other.BotFlow)
            ) &&
            (
                Assistant == other.Assistant ||
                Assistant != null &&
                Assistant.Equals(other.Assistant)
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

            if (Deployment != null)
            {
                hash = hash * 59 + Deployment.GetHashCode();
            }

            if (BotFlow != null)
            {
                hash = hash * 59 + BotFlow.GetHashCode();
            }

            if (Assistant != null)
            {
                hash = hash * 59 + Assistant.GetHashCode();
            }

            return hash;
        }
    }
}
