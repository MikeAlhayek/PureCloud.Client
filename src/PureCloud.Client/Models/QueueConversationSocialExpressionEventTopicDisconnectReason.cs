using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationSocialExpressionEventTopicDisconnectReason
/// </summary>

public partial class QueueConversationSocialExpressionEventTopicDisconnectReason : IEquatable<QueueConversationSocialExpressionEventTopicDisconnectReason>
{
    /// <summary>
    /// Disconnect reason protocol type.
    /// </summary>
    /// <value>Disconnect reason protocol type.</value>
    
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
        /// Enum Q850 for "q850"
        /// </summary>
        [EnumMember(Value = "q850")]
        Q850,

        /// <summary>
        /// Enum Sip for "sip"
        /// </summary>
        [EnumMember(Value = "sip")]
        Sip
    }
    /// <summary>
    /// Disconnect reason protocol type.
    /// </summary>
    /// <value>Disconnect reason protocol type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationSocialExpressionEventTopicDisconnectReason" /> class.
    /// </summary>
    /// <param name="Type">Disconnect reason protocol type..</param>
    /// <param name="Code">Protocol specific reason code. See the Q.850 and SIP specs..</param>
    /// <param name="Phrase">Human readable English description of the disconnect reason..</param>
    public QueueConversationSocialExpressionEventTopicDisconnectReason(TypeEnum? Type = null, long? Code = null, string Phrase = null)
    {
        this.Type = Type;
        this.Code = Code;
        this.Phrase = Phrase;

    }





    /// <summary>
    /// Protocol specific reason code. See the Q.850 and SIP specs.
    /// </summary>
    /// <value>Protocol specific reason code. See the Q.850 and SIP specs.</value>
    [JsonPropertyName("code")]
    public long? Code { get; set; }



    /// <summary>
    /// Human readable English description of the disconnect reason.
    /// </summary>
    /// <value>Human readable English description of the disconnect reason.</value>
    [JsonPropertyName("phrase")]
    public string Phrase { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationSocialExpressionEventTopicDisconnectReason {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Phrase: ").Append(Phrase).Append("\n");
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
        return Equals(obj as QueueConversationSocialExpressionEventTopicDisconnectReason);
    }

    /// <summary>
    /// Returns true if QueueConversationSocialExpressionEventTopicDisconnectReason instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationSocialExpressionEventTopicDisconnectReason to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationSocialExpressionEventTopicDisconnectReason other)
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
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Phrase == other.Phrase ||
                Phrase != null &&
                Phrase.Equals(other.Phrase)
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

            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Phrase != null)
            {
                hash = hash * 59 + Phrase.GetHashCode();
            }

            return hash;
        }
    }
}
