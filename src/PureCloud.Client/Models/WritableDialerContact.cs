using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WritableDialerContact
/// </summary>

public partial class WritableDialerContact : IEquatable<WritableDialerContact>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WritableDialerContact" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WritableDialerContact() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WritableDialerContact" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="ContactListId">The identifier of the contact list containing this contact. (required).</param>
    /// <param name="Data">An ordered map of the contact&#39;s columns and corresponding values. (required).</param>
    /// <param name="LatestWhatsAppEvaluations">A map of whatsapp records for the contact whatsapp columns..</param>
    /// <param name="Callable">Indicates whether or not the contact can be called..</param>
    /// <param name="PhoneNumberStatus">A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not..</param>
    /// <param name="ContactableStatus">A map of media types (Voice, SMS and Email) to ContactableStatus, which indicates if the contact can be contacted using the specified media type..</param>
    public WritableDialerContact(string Id = null, string ContactListId = null, Dictionary<string, string> Data = null, Dictionary<string, MessageEvaluation> LatestWhatsAppEvaluations = null, bool? Callable = null, Dictionary<string, PhoneNumberStatus> PhoneNumberStatus = null, Dictionary<string, ContactableStatus> ContactableStatus = null)
    {
        this.Id = Id;
        this.ContactListId = ContactListId;
        this.Data = Data;
        this.LatestWhatsAppEvaluations = LatestWhatsAppEvaluations;
        this.Callable = Callable;
        this.PhoneNumberStatus = PhoneNumberStatus;
        this.ContactableStatus = ContactableStatus;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The identifier of the contact list containing this contact.
    /// </summary>
    /// <value>The identifier of the contact list containing this contact.</value>
    [JsonPropertyName("contactListId")]
    public string ContactListId { get; set; }



    /// <summary>
    /// An ordered map of the contact&#39;s columns and corresponding values.
    /// </summary>
    /// <value>An ordered map of the contact&#39;s columns and corresponding values.</value>
    [JsonPropertyName("data")]
    public Dictionary<string, string> Data { get; set; }



    /// <summary>
    /// A map of SMS records for the contact phone columns.
    /// </summary>
    /// <value>A map of SMS records for the contact phone columns.</value>
    [JsonPropertyName("latestSmsEvaluations")]
    public Dictionary<string, MessageEvaluation> LatestSmsEvaluations { get; private set; }



    /// <summary>
    /// A map of email records for the contact email columns.
    /// </summary>
    /// <value>A map of email records for the contact email columns.</value>
    [JsonPropertyName("latestEmailEvaluations")]
    public Dictionary<string, MessageEvaluation> LatestEmailEvaluations { get; private set; }



    /// <summary>
    /// A map of whatsapp records for the contact whatsapp columns.
    /// </summary>
    /// <value>A map of whatsapp records for the contact whatsapp columns.</value>
    [JsonPropertyName("latestWhatsAppEvaluations")]
    public Dictionary<string, MessageEvaluation> LatestWhatsAppEvaluations { get; set; }



    /// <summary>
    /// Indicates whether or not the contact can be called.
    /// </summary>
    /// <value>Indicates whether or not the contact can be called.</value>
    [JsonPropertyName("callable")]
    public bool? Callable { get; set; }



    /// <summary>
    /// A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not.
    /// </summary>
    /// <value>A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not.</value>
    [JsonPropertyName("phoneNumberStatus")]
    public Dictionary<string, PhoneNumberStatus> PhoneNumberStatus { get; set; }



    /// <summary>
    /// A map of media types (Voice, SMS and Email) to ContactableStatus, which indicates if the contact can be contacted using the specified media type.
    /// </summary>
    /// <value>A map of media types (Voice, SMS and Email) to ContactableStatus, which indicates if the contact can be contacted using the specified media type.</value>
    [JsonPropertyName("contactableStatus")]
    public Dictionary<string, ContactableStatus> ContactableStatus { get; set; }



    /// <summary>
    /// Timestamp for when the contact was added. Contacts added prior to 2023 September 1 may be missing this value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp for when the contact was added. Contacts added prior to 2023 September 1 may be missing this value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WritableDialerContact {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  LatestSmsEvaluations: ").Append(LatestSmsEvaluations).Append("\n");
        sb.Append("  LatestEmailEvaluations: ").Append(LatestEmailEvaluations).Append("\n");
        sb.Append("  LatestWhatsAppEvaluations: ").Append(LatestWhatsAppEvaluations).Append("\n");
        sb.Append("  Callable: ").Append(Callable).Append("\n");
        sb.Append("  PhoneNumberStatus: ").Append(PhoneNumberStatus).Append("\n");
        sb.Append("  ContactableStatus: ").Append(ContactableStatus).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
        return Equals(obj as WritableDialerContact);
    }

    /// <summary>
    /// Returns true if WritableDialerContact instances are equal
    /// </summary>
    /// <param name="other">Instance of WritableDialerContact to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WritableDialerContact other)
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
                ContactListId == other.ContactListId ||
                ContactListId != null &&
                ContactListId.Equals(other.ContactListId)
            ) &&
            (
                Data == other.Data ||
                Data != null &&
                Data.SequenceEqual(other.Data)
            ) &&
            (
                LatestSmsEvaluations == other.LatestSmsEvaluations ||
                LatestSmsEvaluations != null &&
                LatestSmsEvaluations.SequenceEqual(other.LatestSmsEvaluations)
            ) &&
            (
                LatestEmailEvaluations == other.LatestEmailEvaluations ||
                LatestEmailEvaluations != null &&
                LatestEmailEvaluations.SequenceEqual(other.LatestEmailEvaluations)
            ) &&
            (
                LatestWhatsAppEvaluations == other.LatestWhatsAppEvaluations ||
                LatestWhatsAppEvaluations != null &&
                LatestWhatsAppEvaluations.SequenceEqual(other.LatestWhatsAppEvaluations)
            ) &&
            (
                Callable == other.Callable ||
                Callable != null &&
                Callable.Equals(other.Callable)
            ) &&
            (
                PhoneNumberStatus == other.PhoneNumberStatus ||
                PhoneNumberStatus != null &&
                PhoneNumberStatus.SequenceEqual(other.PhoneNumberStatus)
            ) &&
            (
                ContactableStatus == other.ContactableStatus ||
                ContactableStatus != null &&
                ContactableStatus.SequenceEqual(other.ContactableStatus)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
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

            if (ContactListId != null)
            {
                hash = hash * 59 + ContactListId.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            if (LatestSmsEvaluations != null)
            {
                hash = hash * 59 + LatestSmsEvaluations.GetHashCode();
            }

            if (LatestEmailEvaluations != null)
            {
                hash = hash * 59 + LatestEmailEvaluations.GetHashCode();
            }

            if (LatestWhatsAppEvaluations != null)
            {
                hash = hash * 59 + LatestWhatsAppEvaluations.GetHashCode();
            }

            if (Callable != null)
            {
                hash = hash * 59 + Callable.GetHashCode();
            }

            if (PhoneNumberStatus != null)
            {
                hash = hash * 59 + PhoneNumberStatus.GetHashCode();
            }

            if (ContactableStatus != null)
            {
                hash = hash * 59 + ContactableStatus.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            return hash;
        }
    }
}
