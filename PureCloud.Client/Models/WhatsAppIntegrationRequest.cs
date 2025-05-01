using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WhatsAppIntegrationRequest
/// </summary>
[DataContract]
public partial class WhatsAppIntegrationRequest : IEquatable<WhatsAppIntegrationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppIntegrationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WhatsAppIntegrationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppIntegrationRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the WhatsApp Integration (required).</param>
    /// <param name="SupportedContent">Defines the SupportedContent profile configured for an integration.</param>
    /// <param name="MessagingSetting">Defines the message settings to be applied for this integration.</param>
    /// <param name="PhoneNumber">The phone number associated to the whatsApp integration (required).</param>
    /// <param name="WabaCertificate">The waba(WhatsApp Business Manager) certificate associated to the WhatsApp integration phone number (required).</param>
    public WhatsAppIntegrationRequest(string Name = null, SupportedContentReference SupportedContent = null, MessagingSettingRequestReference MessagingSetting = null, string PhoneNumber = null, string WabaCertificate = null)
    {
        this.Name = Name;
        this.SupportedContent = SupportedContent;
        this.MessagingSetting = MessagingSetting;
        this.PhoneNumber = PhoneNumber;
        this.WabaCertificate = WabaCertificate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the WhatsApp Integration
    /// </summary>
    /// <value>The name of the WhatsApp Integration</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Defines the SupportedContent profile configured for an integration
    /// </summary>
    /// <value>Defines the SupportedContent profile configured for an integration</value>
    [DataMember(Name = "supportedContent", EmitDefaultValue = false)]
    public SupportedContentReference SupportedContent { get; set; }



    /// <summary>
    /// Defines the message settings to be applied for this integration
    /// </summary>
    /// <value>Defines the message settings to be applied for this integration</value>
    [DataMember(Name = "messagingSetting", EmitDefaultValue = false)]
    public MessagingSettingRequestReference MessagingSetting { get; set; }



    /// <summary>
    /// The phone number associated to the whatsApp integration
    /// </summary>
    /// <value>The phone number associated to the whatsApp integration</value>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// The waba(WhatsApp Business Manager) certificate associated to the WhatsApp integration phone number
    /// </summary>
    /// <value>The waba(WhatsApp Business Manager) certificate associated to the WhatsApp integration phone number</value>
    [DataMember(Name = "wabaCertificate", EmitDefaultValue = false)]
    public string WabaCertificate { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WhatsAppIntegrationRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SupportedContent: ").Append(SupportedContent).Append("\n");
        sb.Append("  MessagingSetting: ").Append(MessagingSetting).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  WabaCertificate: ").Append(WabaCertificate).Append("\n");
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
        return Equals(obj as WhatsAppIntegrationRequest);
    }

    /// <summary>
    /// Returns true if WhatsAppIntegrationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WhatsAppIntegrationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WhatsAppIntegrationRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                SupportedContent == other.SupportedContent ||
                SupportedContent != null &&
                SupportedContent.Equals(other.SupportedContent)
            ) &&
            (
                MessagingSetting == other.MessagingSetting ||
                MessagingSetting != null &&
                MessagingSetting.Equals(other.MessagingSetting)
            ) &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                WabaCertificate == other.WabaCertificate ||
                WabaCertificate != null &&
                WabaCertificate.Equals(other.WabaCertificate)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (SupportedContent != null)
            {
                hash = hash * 59 + SupportedContent.GetHashCode();
            }

            if (MessagingSetting != null)
            {
                hash = hash * 59 + MessagingSetting.GetHashCode();
            }

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (WabaCertificate != null)
            {
                hash = hash * 59 + WabaCertificate.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
