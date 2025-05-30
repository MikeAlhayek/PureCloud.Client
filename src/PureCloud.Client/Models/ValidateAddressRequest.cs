using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValidateAddressRequest
/// </summary>

public partial class ValidateAddressRequest : IEquatable<ValidateAddressRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidateAddressRequest" /> class.
    /// </summary>
    /// <param name="Address">Address schema.</param>
    public ValidateAddressRequest(StreetAddress Address = null)
    {
        this.Address = Address;

    }



    /// <summary>
    /// Address schema
    /// </summary>
    /// <value>Address schema</value>
    [JsonPropertyName("address")]
    public StreetAddress Address { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValidateAddressRequest {\n");

        sb.Append("  Address: ").Append(Address).Append("\n");
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
        return Equals(obj as ValidateAddressRequest);
    }

    /// <summary>
    /// Returns true if ValidateAddressRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ValidateAddressRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValidateAddressRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
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
            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            return hash;
        }
    }
}
