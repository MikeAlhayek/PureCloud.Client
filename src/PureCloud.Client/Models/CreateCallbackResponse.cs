using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateCallbackResponse
/// </summary>

public partial class CreateCallbackResponse : IEquatable<CreateCallbackResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateCallbackResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateCallbackResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateCallbackResponse" /> class.
    /// </summary>
    /// <param name="Conversation">The conversation associated with the callback (required).</param>
    /// <param name="CallbackIdentifiers">The list of communication identifiers for the callback participants (required).</param>
    public CreateCallbackResponse(DomainEntityRef Conversation = null, List<CallbackIdentifier> CallbackIdentifiers = null)
    {
        this.Conversation = Conversation;
        this.CallbackIdentifiers = CallbackIdentifiers;

    }



    /// <summary>
    /// The conversation associated with the callback
    /// </summary>
    /// <value>The conversation associated with the callback</value>
    [JsonPropertyName("conversation")]
    public DomainEntityRef Conversation { get; set; }



    /// <summary>
    /// The list of communication identifiers for the callback participants
    /// </summary>
    /// <value>The list of communication identifiers for the callback participants</value>
    [JsonPropertyName("callbackIdentifiers")]
    public List<CallbackIdentifier> CallbackIdentifiers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateCallbackResponse {\n");

        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  CallbackIdentifiers: ").Append(CallbackIdentifiers).Append("\n");
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
        return Equals(obj as CreateCallbackResponse);
    }

    /// <summary>
    /// Returns true if CreateCallbackResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateCallbackResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateCallbackResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                CallbackIdentifiers == other.CallbackIdentifiers ||
                CallbackIdentifiers != null &&
                CallbackIdentifiers.SequenceEqual(other.CallbackIdentifiers)
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
            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (CallbackIdentifiers != null)
            {
                hash = hash * 59 + CallbackIdentifiers.GetHashCode();
            }

            return hash;
        }
    }
}
