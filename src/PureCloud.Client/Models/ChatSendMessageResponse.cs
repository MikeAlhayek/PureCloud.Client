using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatSendMessageResponse
/// </summary>

public partial class ChatSendMessageResponse : IEquatable<ChatSendMessageResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatSendMessageResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChatSendMessageResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatSendMessageResponse" /> class.
    /// </summary>
    /// <param name="Id">The id of the created message (required).</param>
    public ChatSendMessageResponse(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The id of the created message
    /// </summary>
    /// <value>The id of the created message</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatSendMessageResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as ChatSendMessageResponse);
    }

    /// <summary>
    /// Returns true if ChatSendMessageResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatSendMessageResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatSendMessageResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
