using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CrossPlatformMediaPolicies
/// </summary>
[DataContract]
public partial class CrossPlatformMediaPolicies : IEquatable<CrossPlatformMediaPolicies>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CrossPlatformMediaPolicies" /> class.
    /// </summary>
    /// <param name="CallPolicy">Conditions and actions for calls.</param>
    /// <param name="ChatPolicy">Conditions and actions for chats.</param>
    /// <param name="EmailPolicy">Conditions and actions for emails.</param>
    /// <param name="MessagePolicy">Conditions and actions for messages.</param>
    public CrossPlatformMediaPolicies(CrossPlatformCallMediaPolicy CallPolicy = null, CrossPlatformChatMediaPolicy ChatPolicy = null, CrossPlatformEmailMediaPolicy EmailPolicy = null, CrossPlatformMessageMediaPolicy MessagePolicy = null)
    {
        this.CallPolicy = CallPolicy;
        this.ChatPolicy = ChatPolicy;
        this.EmailPolicy = EmailPolicy;
        this.MessagePolicy = MessagePolicy;

    }



    /// <summary>
    /// Conditions and actions for calls
    /// </summary>
    /// <value>Conditions and actions for calls</value>
    [DataMember(Name = "callPolicy", EmitDefaultValue = false)]
    public CrossPlatformCallMediaPolicy CallPolicy { get; set; }



    /// <summary>
    /// Conditions and actions for chats
    /// </summary>
    /// <value>Conditions and actions for chats</value>
    [DataMember(Name = "chatPolicy", EmitDefaultValue = false)]
    public CrossPlatformChatMediaPolicy ChatPolicy { get; set; }



    /// <summary>
    /// Conditions and actions for emails
    /// </summary>
    /// <value>Conditions and actions for emails</value>
    [DataMember(Name = "emailPolicy", EmitDefaultValue = false)]
    public CrossPlatformEmailMediaPolicy EmailPolicy { get; set; }



    /// <summary>
    /// Conditions and actions for messages
    /// </summary>
    /// <value>Conditions and actions for messages</value>
    [DataMember(Name = "messagePolicy", EmitDefaultValue = false)]
    public CrossPlatformMessageMediaPolicy MessagePolicy { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CrossPlatformMediaPolicies {\n");

        sb.Append("  CallPolicy: ").Append(CallPolicy).Append("\n");
        sb.Append("  ChatPolicy: ").Append(ChatPolicy).Append("\n");
        sb.Append("  EmailPolicy: ").Append(EmailPolicy).Append("\n");
        sb.Append("  MessagePolicy: ").Append(MessagePolicy).Append("\n");
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
        return Equals(obj as CrossPlatformMediaPolicies);
    }

    /// <summary>
    /// Returns true if CrossPlatformMediaPolicies instances are equal
    /// </summary>
    /// <param name="other">Instance of CrossPlatformMediaPolicies to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CrossPlatformMediaPolicies other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CallPolicy == other.CallPolicy ||
                CallPolicy != null &&
                CallPolicy.Equals(other.CallPolicy)
            ) &&
            (
                ChatPolicy == other.ChatPolicy ||
                ChatPolicy != null &&
                ChatPolicy.Equals(other.ChatPolicy)
            ) &&
            (
                EmailPolicy == other.EmailPolicy ||
                EmailPolicy != null &&
                EmailPolicy.Equals(other.EmailPolicy)
            ) &&
            (
                MessagePolicy == other.MessagePolicy ||
                MessagePolicy != null &&
                MessagePolicy.Equals(other.MessagePolicy)
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
            if (CallPolicy != null)
            {
                hash = hash * 59 + CallPolicy.GetHashCode();
            }

            if (ChatPolicy != null)
            {
                hash = hash * 59 + ChatPolicy.GetHashCode();
            }

            if (EmailPolicy != null)
            {
                hash = hash * 59 + EmailPolicy.GetHashCode();
            }

            if (MessagePolicy != null)
            {
                hash = hash * 59 + MessagePolicy.GetHashCode();
            }

            return hash;
        }
    }
}
