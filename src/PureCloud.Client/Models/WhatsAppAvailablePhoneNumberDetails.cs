using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WhatsAppAvailablePhoneNumberDetails
/// </summary>

public partial class WhatsAppAvailablePhoneNumberDetails : IEquatable<WhatsAppAvailablePhoneNumberDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppAvailablePhoneNumberDetails" /> class.
    /// </summary>
    public WhatsAppAvailablePhoneNumberDetails()
    {

    }



    /// <summary>
    /// The verified name associated with this phone number.
    /// </summary>
    /// <value>The verified name associated with this phone number.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The display name associated with this phone number. It&#39;s typically the E.164 representation of the number.
    /// </summary>
    /// <value>The display name associated with this phone number. It&#39;s typically the E.164 representation of the number.</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// The status of this phone number.
    /// </summary>
    /// <value>The status of this phone number.</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WhatsAppAvailablePhoneNumberDetails {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as WhatsAppAvailablePhoneNumberDetails);
    }

    /// <summary>
    /// Returns true if WhatsAppAvailablePhoneNumberDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of WhatsAppAvailablePhoneNumberDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WhatsAppAvailablePhoneNumberDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
