using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsPhoneNumberRef
/// </summary>
[DataContract]
public partial class SmsPhoneNumberRef : IEquatable<SmsPhoneNumberRef>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SmsPhoneNumberRef" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SmsPhoneNumberRef() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsPhoneNumberRef" /> class.
    /// </summary>
    /// <param name="PhoneNumber">A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234 (required).</param>
    /// <param name="SelfUri">SelfUri.</param>
    public SmsPhoneNumberRef(string PhoneNumber = null, string SelfUri = null)
    {
        this.PhoneNumber = PhoneNumber;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234
    /// </summary>
    /// <value>A phone number provisioned for SMS communications in E.164 format. E.g. +13175555555 or +34234234234</value>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SmsPhoneNumberRef {\n");

        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as SmsPhoneNumberRef);
    }

    /// <summary>
    /// Returns true if SmsPhoneNumberRef instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsPhoneNumberRef to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsPhoneNumberRef other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
