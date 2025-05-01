using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchCallbackResponse
/// </summary>
[DataContract]
public partial class PatchCallbackResponse : IEquatable<PatchCallbackResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchCallbackResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchCallbackResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchCallbackResponse" /> class.
    /// </summary>
    /// <param name="Conversation">The conversation associated with the callback (required).</param>
    /// <param name="CallbackIdentifiers">The list of communication identifiers for the callback participants (required).</param>
    public PatchCallbackResponse(DomainEntityRef Conversation = null, List<CallbackIdentifier> CallbackIdentifiers = null)
    {
        this.Conversation = Conversation;
        this.CallbackIdentifiers = CallbackIdentifiers;

    }



    /// <summary>
    /// The conversation associated with the callback
    /// </summary>
    /// <value>The conversation associated with the callback</value>
    [DataMember(Name = "conversation", EmitDefaultValue = false)]
    public DomainEntityRef Conversation { get; set; }



    /// <summary>
    /// The list of communication identifiers for the callback participants
    /// </summary>
    /// <value>The list of communication identifiers for the callback participants</value>
    [DataMember(Name = "callbackIdentifiers", EmitDefaultValue = false)]
    public List<CallbackIdentifier> CallbackIdentifiers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchCallbackResponse {\n");

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
        return Equals(obj as PatchCallbackResponse);
    }

    /// <summary>
    /// Returns true if PatchCallbackResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchCallbackResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchCallbackResponse other)
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
