using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkCallbackDisconnectRequest
/// </summary>

public partial class BulkCallbackDisconnectRequest : IEquatable<BulkCallbackDisconnectRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BulkCallbackDisconnectRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BulkCallbackDisconnectRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkCallbackDisconnectRequest" /> class.
    /// </summary>
    /// <param name="CallbackDisconnectIdentifiers">The list of requests to disconnect callbacks in bulk (required).</param>
    public BulkCallbackDisconnectRequest(List<CallbackDisconnectIdentifier> CallbackDisconnectIdentifiers = null)
    {
        this.CallbackDisconnectIdentifiers = CallbackDisconnectIdentifiers;

    }



    /// <summary>
    /// The list of requests to disconnect callbacks in bulk
    /// </summary>
    /// <value>The list of requests to disconnect callbacks in bulk</value>
    [JsonPropertyName("callbackDisconnectIdentifiers")]
    public List<CallbackDisconnectIdentifier> CallbackDisconnectIdentifiers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkCallbackDisconnectRequest {\n");

        sb.Append("  CallbackDisconnectIdentifiers: ").Append(CallbackDisconnectIdentifiers).Append("\n");
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
        return Equals(obj as BulkCallbackDisconnectRequest);
    }

    /// <summary>
    /// Returns true if BulkCallbackDisconnectRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkCallbackDisconnectRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkCallbackDisconnectRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CallbackDisconnectIdentifiers == other.CallbackDisconnectIdentifiers ||
                CallbackDisconnectIdentifiers != null &&
                CallbackDisconnectIdentifiers.SequenceEqual(other.CallbackDisconnectIdentifiers)
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
            if (CallbackDisconnectIdentifiers != null)
            {
                hash = hash * 59 + CallbackDisconnectIdentifiers.GetHashCode();
            }

            return hash;
        }
    }
}
