using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValidateAddressResponse
/// </summary>

public partial class ValidateAddressResponse : IEquatable<ValidateAddressResponse>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ValidateAddressResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ValidateAddressResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidateAddressResponse" /> class.
    /// </summary>
    /// <param name="Valid">Was the passed in address valid (required).</param>
    /// <param name="Response">Subscriber schema.</param>
    public ValidateAddressResponse(bool? Valid = null, SubscriberResponse Response = null)
    {
        this.Valid = Valid;
        this.Response = Response;

    }



    /// <summary>
    /// Was the passed in address valid
    /// </summary>
    /// <value>Was the passed in address valid</value>
    [JsonPropertyName("valid")]
    public bool? Valid { get; set; }



    /// <summary>
    /// Subscriber schema
    /// </summary>
    /// <value>Subscriber schema</value>
    [JsonPropertyName("response")]
    public SubscriberResponse Response { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValidateAddressResponse {\n");

        sb.Append("  Valid: ").Append(Valid).Append("\n");
        sb.Append("  Response: ").Append(Response).Append("\n");
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
        return Equals(obj as ValidateAddressResponse);
    }

    /// <summary>
    /// Returns true if ValidateAddressResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ValidateAddressResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValidateAddressResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Valid == other.Valid ||
                Valid != null &&
                Valid.Equals(other.Valid)
            ) &&
            (
                Response == other.Response ||
                Response != null &&
                Response.Equals(other.Response)
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
            if (Valid != null)
            {
                hash = hash * 59 + Valid.GetHashCode();
            }

            if (Response != null)
            {
                hash = hash * 59 + Response.GetHashCode();
            }

            return hash;
        }
    }
}
