using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecipientRequest
/// </summary>

public partial class RecipientRequest : IEquatable<RecipientRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecipientRequest" /> class.
    /// </summary>
    /// <param name="Flow">An automate flow object which defines the set of actions to be taken, when a message is received by this recipient..</param>
    public RecipientRequest(RecipientFlow Flow = null)
    {
        this.Flow = Flow;

    }



    /// <summary>
    /// An automate flow object which defines the set of actions to be taken, when a message is received by this recipient.
    /// </summary>
    /// <value>An automate flow object which defines the set of actions to be taken, when a message is received by this recipient.</value>
    [JsonPropertyName("flow")]
    public RecipientFlow Flow { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecipientRequest {\n");

        sb.Append("  Flow: ").Append(Flow).Append("\n");
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
        return Equals(obj as RecipientRequest);
    }

    /// <summary>
    /// Returns true if RecipientRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of RecipientRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecipientRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
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
            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            return hash;
        }
    }
}
