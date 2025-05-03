using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WhatsAppEmbeddedSignupIntegrationActivationRequest
/// </summary>

public partial class WhatsAppEmbeddedSignupIntegrationActivationRequest : IEquatable<WhatsAppEmbeddedSignupIntegrationActivationRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppEmbeddedSignupIntegrationActivationRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WhatsAppEmbeddedSignupIntegrationActivationRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WhatsAppEmbeddedSignupIntegrationActivationRequest" /> class.
    /// </summary>
    /// <param name="PhoneNumber">Phone number to associate with the WhatsApp integration (required).</param>
    /// <param name="Pin">Specify the two-step verification PIN for that phone number (required).</param>
    public WhatsAppEmbeddedSignupIntegrationActivationRequest(string PhoneNumber = null, string Pin = null)
    {
        this.PhoneNumber = PhoneNumber;
        this.Pin = Pin;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// WhatsApp Integration name
    /// </summary>
    /// <value>WhatsApp Integration name</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// Phone number to associate with the WhatsApp integration
    /// </summary>
    /// <value>Phone number to associate with the WhatsApp integration</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// Specify the two-step verification PIN for that phone number
    /// </summary>
    /// <value>Specify the two-step verification PIN for that phone number</value>
    [JsonPropertyName("pin")]
    public string Pin { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WhatsAppEmbeddedSignupIntegrationActivationRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  Pin: ").Append(Pin).Append("\n");
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
        return Equals(obj as WhatsAppEmbeddedSignupIntegrationActivationRequest);
    }

    /// <summary>
    /// Returns true if WhatsAppEmbeddedSignupIntegrationActivationRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WhatsAppEmbeddedSignupIntegrationActivationRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WhatsAppEmbeddedSignupIntegrationActivationRequest other)
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
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                Pin == other.Pin ||
                Pin != null &&
                Pin.Equals(other.Pin)
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

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (Pin != null)
            {
                hash = hash * 59 + Pin.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
