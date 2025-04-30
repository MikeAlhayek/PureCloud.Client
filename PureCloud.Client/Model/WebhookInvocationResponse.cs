using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// WebhookInvocationResponse
/// </summary>
[DataContract]
public partial class WebhookInvocationResponse : IEquatable<WebhookInvocationResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WebhookInvocationResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebhookInvocationResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebhookInvocationResponse" /> class.
    /// </summary>
    /// <param name="InvocationId">The id of the Webhook Invocation (required).</param>
    public WebhookInvocationResponse(string InvocationId = null)
    {
        this.InvocationId = InvocationId;

    }



    /// <summary>
    /// The id of the Webhook Invocation
    /// </summary>
    /// <value>The id of the Webhook Invocation</value>
    [DataMember(Name = "invocationId", EmitDefaultValue = false)]
    public string InvocationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebhookInvocationResponse {\n");

        sb.Append("  InvocationId: ").Append(InvocationId).Append("\n");
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
        return this.Equals(obj as WebhookInvocationResponse);
    }

    /// <summary>
    /// Returns true if WebhookInvocationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of WebhookInvocationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebhookInvocationResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.InvocationId == other.InvocationId ||
                this.InvocationId != null &&
                this.InvocationId.Equals(other.InvocationId)
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
            if (this.InvocationId != null)
            {
                hash = hash * 59 + this.InvocationId.GetHashCode();
            }

            return hash;
        }
    }
}
