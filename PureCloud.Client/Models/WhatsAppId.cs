using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// User information for a WhatsApp account
/// </summary>
[DataContract]
public partial class WhatsAppId : IEquatable<WhatsAppId>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppId" /> class.
    /// </summary>
    /// <param name="PhoneNumber">The phone number associated with this WhatsApp account.</param>
    /// <param name="DisplayName">The displayName of this person&#39;s account in WhatsApp.</param>
    public WhatsAppId(PhoneNumber PhoneNumber = null, string DisplayName = null)
    {
        this.PhoneNumber = PhoneNumber;
        this.DisplayName = DisplayName;

    }



    /// <summary>
    /// The phone number associated with this WhatsApp account
    /// </summary>
    /// <value>The phone number associated with this WhatsApp account</value>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public PhoneNumber PhoneNumber { get; set; }



    /// <summary>
    /// The displayName of this person&#39;s account in WhatsApp
    /// </summary>
    /// <value>The displayName of this person&#39;s account in WhatsApp</value>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WhatsAppId {\n");

        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
        return Equals(obj as WhatsAppId);
    }

    /// <summary>
    /// Returns true if WhatsAppId instances are equal
    /// </summary>
    /// <param name="other">Instance of WhatsAppId to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WhatsAppId other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
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
            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            return hash;
        }
    }
}
