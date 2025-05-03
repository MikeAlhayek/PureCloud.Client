using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EscalationTarget
/// </summary>

public partial class EscalationTarget : IEquatable<EscalationTarget>
{
    /// <summary>
    /// Defines the target that the message will be escalated to.
    /// </summary>
    /// <value>Defines the target that the message will be escalated to.</value>
    
    public enum TargetTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Conversation for "Conversation"
        /// </summary>
        [EnumMember(Value = "Conversation")]
        Conversation
    }
    /// <summary>
    /// Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source.
    /// </summary>
    /// <value>Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source.</value>
    
    public enum DestinationEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sourceintegration for "SourceIntegration"
        /// </summary>
        [EnumMember(Value = "SourceIntegration")]
        Sourceintegration,

        /// <summary>
        /// Enum Overrideintegration for "OverrideIntegration"
        /// </summary>
        [EnumMember(Value = "OverrideIntegration")]
        Overrideintegration
    }
    /// <summary>
    /// Defines the target that the message will be escalated to.
    /// </summary>
    /// <value>Defines the target that the message will be escalated to.</value>
    [JsonPropertyName("targetType")]
    public TargetTypeEnum? TargetType { get; set; }
    /// <summary>
    /// Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source.
    /// </summary>
    /// <value>Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source.</value>
    [JsonPropertyName("destination")]
    public DestinationEnum? Destination { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EscalationTarget" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EscalationTarget() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EscalationTarget" /> class.
    /// </summary>
    /// <param name="TargetType">Defines the target that the message will be escalated to. (required).</param>
    /// <param name="Destination">Defines the destination of the escalation.SourceIntegration means use the SocialMedia Source Integration as the destination.OverrideIntegration means the set integration will be used regardless of the source. (required).</param>
    /// <param name="Override">Set the integration ID.Only valid when type is OverrideIntegration..</param>
    public EscalationTarget(TargetTypeEnum? TargetType = null, DestinationEnum? Destination = null, OverrideEscalationTarget Override = null)
    {
        this.TargetType = TargetType;
        this.Destination = Destination;
        this.Override = Override;

    }







    /// <summary>
    /// Set the integration ID.Only valid when type is OverrideIntegration.
    /// </summary>
    /// <value>Set the integration ID.Only valid when type is OverrideIntegration.</value>
    [JsonPropertyName("override")]
    public OverrideEscalationTarget Override { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EscalationTarget {\n");

        sb.Append("  TargetType: ").Append(TargetType).Append("\n");
        sb.Append("  Destination: ").Append(Destination).Append("\n");
        sb.Append("  Override: ").Append(Override).Append("\n");
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
        return Equals(obj as EscalationTarget);
    }

    /// <summary>
    /// Returns true if EscalationTarget instances are equal
    /// </summary>
    /// <param name="other">Instance of EscalationTarget to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EscalationTarget other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TargetType == other.TargetType ||
                TargetType != null &&
                TargetType.Equals(other.TargetType)
            ) &&
            (
                Destination == other.Destination ||
                Destination != null &&
                Destination.Equals(other.Destination)
            ) &&
            (
                Override == other.Override ||
                Override != null &&
                Override.Equals(other.Override)
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
            if (TargetType != null)
            {
                hash = hash * 59 + TargetType.GetHashCode();
            }

            if (Destination != null)
            {
                hash = hash * 59 + Destination.GetHashCode();
            }

            if (Override != null)
            {
                hash = hash * 59 + Override.GetHashCode();
            }

            return hash;
        }
    }
}
