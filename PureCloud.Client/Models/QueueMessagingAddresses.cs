using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueMessagingAddresses
/// </summary>
[DataContract]
public partial class QueueMessagingAddresses : IEquatable<QueueMessagingAddresses>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueMessagingAddresses" /> class.
    /// </summary>
    /// <param name="SmsAddress">SmsAddress.</param>
    /// <param name="OpenMessagingRecipient">OpenMessagingRecipient.</param>
    /// <param name="WhatsAppRecipient">WhatsAppRecipient.</param>
    public QueueMessagingAddresses(DomainEntityRef SmsAddress = null, DomainEntityRef OpenMessagingRecipient = null, DomainEntityRef WhatsAppRecipient = null)
    {
        this.SmsAddress = SmsAddress;
        this.OpenMessagingRecipient = OpenMessagingRecipient;
        this.WhatsAppRecipient = WhatsAppRecipient;

    }



    /// <summary>
    /// Gets or Sets SmsAddress
    /// </summary>
    [DataMember(Name = "smsAddress", EmitDefaultValue = false)]
    public DomainEntityRef SmsAddress { get; set; }



    /// <summary>
    /// Gets or Sets OpenMessagingRecipient
    /// </summary>
    [DataMember(Name = "openMessagingRecipient", EmitDefaultValue = false)]
    public DomainEntityRef OpenMessagingRecipient { get; set; }



    /// <summary>
    /// Gets or Sets WhatsAppRecipient
    /// </summary>
    [DataMember(Name = "whatsAppRecipient", EmitDefaultValue = false)]
    public DomainEntityRef WhatsAppRecipient { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueMessagingAddresses {\n");

        sb.Append("  SmsAddress: ").Append(SmsAddress).Append("\n");
        sb.Append("  OpenMessagingRecipient: ").Append(OpenMessagingRecipient).Append("\n");
        sb.Append("  WhatsAppRecipient: ").Append(WhatsAppRecipient).Append("\n");
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
        return this.Equals(obj as QueueMessagingAddresses);
    }

    /// <summary>
    /// Returns true if QueueMessagingAddresses instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueMessagingAddresses to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueMessagingAddresses other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.SmsAddress == other.SmsAddress ||
                this.SmsAddress != null &&
                this.SmsAddress.Equals(other.SmsAddress)
            ) &&
            (
                this.OpenMessagingRecipient == other.OpenMessagingRecipient ||
                this.OpenMessagingRecipient != null &&
                this.OpenMessagingRecipient.Equals(other.OpenMessagingRecipient)
            ) &&
            (
                this.WhatsAppRecipient == other.WhatsAppRecipient ||
                this.WhatsAppRecipient != null &&
                this.WhatsAppRecipient.Equals(other.WhatsAppRecipient)
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
            if (this.SmsAddress != null)
            {
                hash = hash * 59 + this.SmsAddress.GetHashCode();
            }

            if (this.OpenMessagingRecipient != null)
            {
                hash = hash * 59 + this.OpenMessagingRecipient.GetHashCode();
            }

            if (this.WhatsAppRecipient != null)
            {
                hash = hash * 59 + this.WhatsAppRecipient.GetHashCode();
            }

            return hash;
        }
    }
}
