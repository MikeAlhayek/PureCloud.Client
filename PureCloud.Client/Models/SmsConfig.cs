using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// SmsConfig
/// </summary>
[DataContract]
public partial class SmsConfig : IEquatable<SmsConfig>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SmsConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SmsConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsConfig" /> class.
    /// </summary>
    /// <param name="MessageColumn">The Contact List column specifying the message to send to the contact. (required).</param>
    /// <param name="PhoneColumn">The Contact List column specifying the phone number to send a message to. (required).</param>
    /// <param name="SenderSmsPhoneNumber">A reference to the SMS Phone Number that will be used as the sender of a message. (required).</param>
    /// <param name="ContentTemplate">The content template used to formulate the message to send to the contact..</param>
    public SmsConfig(string MessageColumn = null, string PhoneColumn = null, SmsPhoneNumberRef SenderSmsPhoneNumber = null, DomainEntityRef ContentTemplate = null)
    {
        this.MessageColumn = MessageColumn;
        this.PhoneColumn = PhoneColumn;
        this.SenderSmsPhoneNumber = SenderSmsPhoneNumber;
        this.ContentTemplate = ContentTemplate;

    }



    /// <summary>
    /// The Contact List column specifying the message to send to the contact.
    /// </summary>
    /// <value>The Contact List column specifying the message to send to the contact.</value>
    [DataMember(Name = "messageColumn", EmitDefaultValue = false)]
    public string MessageColumn { get; set; }



    /// <summary>
    /// The Contact List column specifying the phone number to send a message to.
    /// </summary>
    /// <value>The Contact List column specifying the phone number to send a message to.</value>
    [DataMember(Name = "phoneColumn", EmitDefaultValue = false)]
    public string PhoneColumn { get; set; }



    /// <summary>
    /// A reference to the SMS Phone Number that will be used as the sender of a message.
    /// </summary>
    /// <value>A reference to the SMS Phone Number that will be used as the sender of a message.</value>
    [DataMember(Name = "senderSmsPhoneNumber", EmitDefaultValue = false)]
    public SmsPhoneNumberRef SenderSmsPhoneNumber { get; set; }



    /// <summary>
    /// The content template used to formulate the message to send to the contact.
    /// </summary>
    /// <value>The content template used to formulate the message to send to the contact.</value>
    [DataMember(Name = "contentTemplate", EmitDefaultValue = false)]
    public DomainEntityRef ContentTemplate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SmsConfig {\n");

        sb.Append("  MessageColumn: ").Append(MessageColumn).Append("\n");
        sb.Append("  PhoneColumn: ").Append(PhoneColumn).Append("\n");
        sb.Append("  SenderSmsPhoneNumber: ").Append(SenderSmsPhoneNumber).Append("\n");
        sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
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
        return this.Equals(obj as SmsConfig);
    }

    /// <summary>
    /// Returns true if SmsConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.MessageColumn == other.MessageColumn ||
                this.MessageColumn != null &&
                this.MessageColumn.Equals(other.MessageColumn)
            ) &&
            (
                this.PhoneColumn == other.PhoneColumn ||
                this.PhoneColumn != null &&
                this.PhoneColumn.Equals(other.PhoneColumn)
            ) &&
            (
                this.SenderSmsPhoneNumber == other.SenderSmsPhoneNumber ||
                this.SenderSmsPhoneNumber != null &&
                this.SenderSmsPhoneNumber.Equals(other.SenderSmsPhoneNumber)
            ) &&
            (
                this.ContentTemplate == other.ContentTemplate ||
                this.ContentTemplate != null &&
                this.ContentTemplate.Equals(other.ContentTemplate)
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
            if (this.MessageColumn != null)
            {
                hash = hash * 59 + this.MessageColumn.GetHashCode();
            }

            if (this.PhoneColumn != null)
            {
                hash = hash * 59 + this.PhoneColumn.GetHashCode();
            }

            if (this.SenderSmsPhoneNumber != null)
            {
                hash = hash * 59 + this.SenderSmsPhoneNumber.GetHashCode();
            }

            if (this.ContentTemplate != null)
            {
                hash = hash * 59 + this.ContentTemplate.GetHashCode();
            }

            return hash;
        }
    }
}
