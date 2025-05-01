using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Chat
/// </summary>
[DataContract]
public partial class Chat : IEquatable<Chat>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Chat" /> class.
    /// </summary>
    /// <param name="JabberId">JabberId.</param>
    public Chat(string JabberId = null)
    {
        this.JabberId = JabberId;

    }



    /// <summary>
    /// Gets or Sets JabberId
    /// </summary>
    [DataMember(Name = "jabberId", EmitDefaultValue = false)]
    public string JabberId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Chat {\n");

        sb.Append("  JabberId: ").Append(JabberId).Append("\n");
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
        return Equals(obj as Chat);
    }

    /// <summary>
    /// Returns true if Chat instances are equal
    /// </summary>
    /// <param name="other">Instance of Chat to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Chat other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                JabberId == other.JabberId ||
                JabberId != null &&
                JabberId.Equals(other.JabberId)
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
            if (JabberId != null)
            {
                hash = hash * 59 + JabberId.GetHashCode();
            }

            return hash;
        }
    }
}
