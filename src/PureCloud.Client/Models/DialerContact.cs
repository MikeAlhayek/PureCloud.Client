using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContact
/// </summary>

public partial class DialerContact : IEquatable<DialerContact>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContact" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DialerContact() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContact" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="ContactListId">The identifier of the contact list containing this contact. (required).</param>
    /// <param name="Data">An ordered map of the contact&#39;s columns and corresponding values. (required).</param>
    /// <param name="LatestWhatsAppEvaluations">A map of whatsapp records for the contact whatsapp columns..</param>
    /// <param name="Callable">Indicates whether or not the contact can be called..</param>
    /// <param name="PhoneNumberStatus">A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not..</param>
    /// <param name="ContactableStatus">A map of media types (Voice, SMS and Email) to ContactableStatus, which indicates if the contact can be contacted using the specified media type..</param>
    public DialerContact(string Name = null, string ContactListId = null, Dictionary<string, string> Data = null, Dictionary<string, MessageEvaluation> LatestWhatsAppEvaluations = null, bool? Callable = null, Dictionary<string, PhoneNumberStatus> PhoneNumberStatus = null, Dictionary<string, ContactableStatus> ContactableStatus = null)
    {
        this.Name = Name;
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
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



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
    /// A map of call records for the contact phone columns.
    /// </summary>
    /// <value>A map of call records for the contact phone columns.</value>
    [JsonPropertyName("callRecords")]
    public Dictionary<string, CallRecord> CallRecords { get; set; }



    /// <summary>
    /// A map of SMS records for the contact phone columns.
    /// </summary>
    /// <value>A map of SMS records for the contact phone columns.</value>
    [JsonPropertyName("latestSmsEvaluations")]
    public Dictionary<string, MessageEvaluation> LatestSmsEvaluations { get; set; }



    /// <summary>
    /// A map of email records for the contact email columns.
    /// </summary>
    /// <value>A map of email records for the contact email columns.</value>
    [JsonPropertyName("latestEmailEvaluations")]
    public Dictionary<string, MessageEvaluation> LatestEmailEvaluations { get; set; }



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
    /// Map containing data about the timezone the contact is mapped to. This will only be populated if the contact list has automatic timezone mapping turned on. The key is the column name. The value is the timezone it mapped to and the type of column: Phone or Zip
    /// </summary>
    /// <value>Map containing data about the timezone the contact is mapped to. This will only be populated if the contact list has automatic timezone mapping turned on. The key is the column name. The value is the timezone it mapped to and the type of column: Phone or Zip</value>
    [JsonPropertyName("contactColumnTimeZones")]
    public Dictionary<string, ContactColumnTimeZone> ContactColumnTimeZones { get; set; }



    /// <summary>
    /// the priority property within ConfigurationOverides indicates whether or not the contact to be placed in front of the queue or at the end of the queue
    /// </summary>
    /// <value>the priority property within ConfigurationOverides indicates whether or not the contact to be placed in front of the queue or at the end of the queue</value>
    [JsonPropertyName("configurationOverrides")]
    public ConfigurationOverrides ConfigurationOverrides { get; set; }



    /// <summary>
    /// Timestamp for when the contact was added. Contacts added prior to 2023 September 1 may be missing this value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp for when the contact was added. Contacts added prior to 2023 September 1 may be missing this value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerContact {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  CallRecords: ").Append(CallRecords).Append("\n");
        sb.Append("  LatestSmsEvaluations: ").Append(LatestSmsEvaluations).Append("\n");
        sb.Append("  LatestEmailEvaluations: ").Append(LatestEmailEvaluations).Append("\n");
        sb.Append("  LatestWhatsAppEvaluations: ").Append(LatestWhatsAppEvaluations).Append("\n");
        sb.Append("  Callable: ").Append(Callable).Append("\n");
        sb.Append("  PhoneNumberStatus: ").Append(PhoneNumberStatus).Append("\n");
        sb.Append("  ContactableStatus: ").Append(ContactableStatus).Append("\n");
        sb.Append("  ContactColumnTimeZones: ").Append(ContactColumnTimeZones).Append("\n");
        sb.Append("  ConfigurationOverrides: ").Append(ConfigurationOverrides).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
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
        return Equals(obj as DialerContact);
    }

    /// <summary>
    /// Returns true if DialerContact instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerContact to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerContact other)
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
                CallRecords == other.CallRecords ||
                CallRecords != null &&
                CallRecords.SequenceEqual(other.CallRecords)
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
                ContactColumnTimeZones == other.ContactColumnTimeZones ||
                ContactColumnTimeZones != null &&
                ContactColumnTimeZones.SequenceEqual(other.ContactColumnTimeZones)
            ) &&
            (
                ConfigurationOverrides == other.ConfigurationOverrides ||
                ConfigurationOverrides != null &&
                ConfigurationOverrides.Equals(other.ConfigurationOverrides)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
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

            if (ContactListId != null)
            {
                hash = hash * 59 + ContactListId.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            if (CallRecords != null)
            {
                hash = hash * 59 + CallRecords.GetHashCode();
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

            if (ContactColumnTimeZones != null)
            {
                hash = hash * 59 + ContactColumnTimeZones.GetHashCode();
            }

            if (ConfigurationOverrides != null)
            {
                hash = hash * 59 + ConfigurationOverrides.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
