using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A Video event.
/// </summary>

public partial class ConversationEventVideo : IEquatable<ConversationEventVideo>
{
    /// <summary>
    /// Describes the type of Video event.
    /// </summary>
    /// <value>Describes the type of Video event.</value>
    
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
    /// Describes the type of Video event.
    /// </summary>
    /// <value>Describes the type of Video event.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventVideo" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationEventVideo() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationEventVideo" /> class.
    /// </summary>
    /// <param name="Type">Describes the type of Video event. (required).</param>
    /// <param name="OfferingId">The Video offering ID..</param>
    /// <param name="Jwt">The Video offering JWT token..</param>
    public ConversationEventVideo(TypeEnum? Type = null, string OfferingId = null, string Jwt = null)
    {
        this.Type = Type;
        this.OfferingId = OfferingId;
        this.Jwt = Jwt;

    }





    /// <summary>
    /// The Video offering ID.
    /// </summary>
    /// <value>The Video offering ID.</value>
    [JsonPropertyName("offeringId")]
    public string OfferingId { get; set; }



    /// <summary>
    /// The Video offering JWT token.
    /// </summary>
    /// <value>The Video offering JWT token.</value>
    [JsonPropertyName("jwt")]
    public string Jwt { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationEventVideo {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  OfferingId: ").Append(OfferingId).Append("\n");
        sb.Append("  Jwt: ").Append(Jwt).Append("\n");
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
        return Equals(obj as ConversationEventVideo);
    }

    /// <summary>
    /// Returns true if ConversationEventVideo instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationEventVideo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationEventVideo other)
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
                OfferingId == other.OfferingId ||
                OfferingId != null &&
                OfferingId.Equals(other.OfferingId)
            ) &&
            (
                Jwt == other.Jwt ||
                Jwt != null &&
                Jwt.Equals(other.Jwt)
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

            if (OfferingId != null)
            {
                hash = hash * 59 + OfferingId.GetHashCode();
            }

            if (Jwt != null)
            {
                hash = hash * 59 + Jwt.GetHashCode();
            }

            return hash;
        }
    }
}
