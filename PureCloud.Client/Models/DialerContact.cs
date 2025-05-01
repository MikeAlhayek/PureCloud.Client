using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContact
/// </summary>
[DataContract]
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The identifier of the contact list containing this contact.
    /// </summary>
    /// <value>The identifier of the contact list containing this contact.</value>
    [DataMember(Name = "contactListId", EmitDefaultValue = false)]
    public string ContactListId { get; set; }



    /// <summary>
    /// An ordered map of the contact&#39;s columns and corresponding values.
    /// </summary>
    /// <value>An ordered map of the contact&#39;s columns and corresponding values.</value>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public Dictionary<string, string> Data { get; set; }



    /// <summary>
    /// A map of call records for the contact phone columns.
    /// </summary>
    /// <value>A map of call records for the contact phone columns.</value>
    [DataMember(Name = "callRecords", EmitDefaultValue = false)]
    public Dictionary<string, CallRecord> CallRecords { get; private set; }



    /// <summary>
    /// A map of SMS records for the contact phone columns.
    /// </summary>
    /// <value>A map of SMS records for the contact phone columns.</value>
    [DataMember(Name = "latestSmsEvaluations", EmitDefaultValue = false)]
    public Dictionary<string, MessageEvaluation> LatestSmsEvaluations { get; private set; }



    /// <summary>
    /// A map of email records for the contact email columns.
    /// </summary>
    /// <value>A map of email records for the contact email columns.</value>
    [DataMember(Name = "latestEmailEvaluations", EmitDefaultValue = false)]
    public Dictionary<string, MessageEvaluation> LatestEmailEvaluations { get; private set; }



    /// <summary>
    /// A map of whatsapp records for the contact whatsapp columns.
    /// </summary>
    /// <value>A map of whatsapp records for the contact whatsapp columns.</value>
    [DataMember(Name = "latestWhatsAppEvaluations", EmitDefaultValue = false)]
    public Dictionary<string, MessageEvaluation> LatestWhatsAppEvaluations { get; set; }



    /// <summary>
    /// Indicates whether or not the contact can be called.
    /// </summary>
    /// <value>Indicates whether or not the contact can be called.</value>
    [DataMember(Name = "callable", EmitDefaultValue = false)]
    public bool? Callable { get; set; }



    /// <summary>
    /// A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not.
    /// </summary>
    /// <value>A map of phone number columns to PhoneNumberStatuses, which indicate if the phone number is callable or not.</value>
    [DataMember(Name = "phoneNumberStatus", EmitDefaultValue = false)]
    public Dictionary<string, PhoneNumberStatus> PhoneNumberStatus { get; set; }



    /// <summary>
    /// A map of media types (Voice, SMS and Email) to ContactableStatus, which indicates if the contact can be contacted using the specified media type.
    /// </summary>
    /// <value>A map of media types (Voice, SMS and Email) to ContactableStatus, which indicates if the contact can be contacted using the specified media type.</value>
    [DataMember(Name = "contactableStatus", EmitDefaultValue = false)]
    public Dictionary<string, ContactableStatus> ContactableStatus { get; set; }



    /// <summary>
    /// Map containing data about the timezone the contact is mapped to. This will only be populated if the contact list has automatic timezone mapping turned on. The key is the column name. The value is the timezone it mapped to and the type of column: Phone or Zip
    /// </summary>
    /// <value>Map containing data about the timezone the contact is mapped to. This will only be populated if the contact list has automatic timezone mapping turned on. The key is the column name. The value is the timezone it mapped to and the type of column: Phone or Zip</value>
    [DataMember(Name = "contactColumnTimeZones", EmitDefaultValue = false)]
    public Dictionary<string, ContactColumnTimeZone> ContactColumnTimeZones { get; private set; }



    /// <summary>
    /// the priority property within ConfigurationOverides indicates whether or not the contact to be placed in front of the queue or at the end of the queue
    /// </summary>
    /// <value>the priority property within ConfigurationOverides indicates whether or not the contact to be placed in front of the queue or at the end of the queue</value>
    [DataMember(Name = "configurationOverrides", EmitDefaultValue = false)]
    public ConfigurationOverrides ConfigurationOverrides { get; private set; }



    /// <summary>
    /// Timestamp for when the contact was added. Contacts added prior to 2023 September 1 may be missing this value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp for when the contact was added. Contacts added prior to 2023 September 1 may be missing this value. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



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
