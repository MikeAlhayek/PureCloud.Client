using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A CoBrowse event.
/// </summary>

public partial class ConversationEventCoBrowse : IEquatable<ConversationEventCoBrowse>
{
    /// <summary>
    /// Describes the type of CoBrowse event.
    /// </summary>
    /// <value>Describes the type of CoBrowse event.</value>
    
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
        /// Enum Offering for "Offering"
        /// </summary>
        [EnumMember(Value = "Offering")]
        Offering,

        /// <summary>
        /// Enum Offeringexpired for "OfferingExpired"
        /// </summary>
        [EnumMember(Value = "OfferingExpired")]
        Offeringexpired,

        /// <summary>
        /// Enum Offeringaccepted for "OfferingAccepted"
        /// </summary>
        [EnumMember(Value = "OfferingAccepted")]
        Offeringaccepted,

        /// <summary>
        /// Enum Offeringrejected for "OfferingRejected"
        /// </summary>
        [EnumMember(Value = "OfferingRejected")]
        Offeringrejected
    }
    /// <summary>
    /// Describes the type of CoBrowse event.
    /// </summary>
    /// <value>Describes the type of CoBrowse event.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventCoBrowse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationEventCoBrowse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventCoBrowse" /> class.
    /// </summary>
    /// <param name="Type">Describes the type of CoBrowse event. (required).</param>
    /// <param name="SessionId">The CoBrowse session ID..</param>
    /// <param name="SessionJoinToken">The CoBrowse session join token..</param>
    public ConversationEventCoBrowse(TypeEnum? Type = null, string SessionId = null, string SessionJoinToken = null)
    {
        this.Type = Type;
        this.SessionId = SessionId;
        this.SessionJoinToken = SessionJoinToken;

    }





    /// <summary>
    /// The CoBrowse session ID.
    /// </summary>
    /// <value>The CoBrowse session ID.</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// The CoBrowse session join token.
    /// </summary>
    /// <value>The CoBrowse session join token.</value>
    [JsonPropertyName("sessionJoinToken")]
    public string SessionJoinToken { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEventCoBrowse {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  SessionJoinToken: ").Append(SessionJoinToken).Append("\n");
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
        return Equals(obj as ConversationEventCoBrowse);
    }

    /// <summary>
    /// Returns true if ConversationEventCoBrowse instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEventCoBrowse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEventCoBrowse other)
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
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                SessionJoinToken == other.SessionJoinToken ||
                SessionJoinToken != null &&
                SessionJoinToken.Equals(other.SessionJoinToken)
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

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (SessionJoinToken != null)
            {
                hash = hash * 59 + SessionJoinToken.GetHashCode();
            }

            return hash;
        }
    }
}
