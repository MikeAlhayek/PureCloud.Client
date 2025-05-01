using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

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
        return this.Equals(obj as DialerContact);
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
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.ContactListId == other.ContactListId ||
                this.ContactListId != null &&
                this.ContactListId.Equals(other.ContactListId)
            ) &&
            (
                this.Data == other.Data ||
                this.Data != null &&
                this.Data.SequenceEqual(other.Data)
            ) &&
            (
                this.CallRecords == other.CallRecords ||
                this.CallRecords != null &&
                this.CallRecords.SequenceEqual(other.CallRecords)
            ) &&
            (
                this.LatestSmsEvaluations == other.LatestSmsEvaluations ||
                this.LatestSmsEvaluations != null &&
                this.LatestSmsEvaluations.SequenceEqual(other.LatestSmsEvaluations)
            ) &&
            (
                this.LatestEmailEvaluations == other.LatestEmailEvaluations ||
                this.LatestEmailEvaluations != null &&
                this.LatestEmailEvaluations.SequenceEqual(other.LatestEmailEvaluations)
            ) &&
            (
                this.LatestWhatsAppEvaluations == other.LatestWhatsAppEvaluations ||
                this.LatestWhatsAppEvaluations != null &&
                this.LatestWhatsAppEvaluations.SequenceEqual(other.LatestWhatsAppEvaluations)
            ) &&
            (
                this.Callable == other.Callable ||
                this.Callable != null &&
                this.Callable.Equals(other.Callable)
            ) &&
            (
                this.PhoneNumberStatus == other.PhoneNumberStatus ||
                this.PhoneNumberStatus != null &&
                this.PhoneNumberStatus.SequenceEqual(other.PhoneNumberStatus)
            ) &&
            (
                this.ContactableStatus == other.ContactableStatus ||
                this.ContactableStatus != null &&
                this.ContactableStatus.SequenceEqual(other.ContactableStatus)
            ) &&
            (
                this.ContactColumnTimeZones == other.ContactColumnTimeZones ||
                this.ContactColumnTimeZones != null &&
                this.ContactColumnTimeZones.SequenceEqual(other.ContactColumnTimeZones)
            ) &&
            (
                this.ConfigurationOverrides == other.ConfigurationOverrides ||
                this.ConfigurationOverrides != null &&
                this.ConfigurationOverrides.Equals(other.ConfigurationOverrides)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.ContactListId != null)
            {
                hash = hash * 59 + this.ContactListId.GetHashCode();
            }

            if (this.Data != null)
            {
                hash = hash * 59 + this.Data.GetHashCode();
            }

            if (this.CallRecords != null)
            {
                hash = hash * 59 + this.CallRecords.GetHashCode();
            }

            if (this.LatestSmsEvaluations != null)
            {
                hash = hash * 59 + this.LatestSmsEvaluations.GetHashCode();
            }

            if (this.LatestEmailEvaluations != null)
            {
                hash = hash * 59 + this.LatestEmailEvaluations.GetHashCode();
            }

            if (this.LatestWhatsAppEvaluations != null)
            {
                hash = hash * 59 + this.LatestWhatsAppEvaluations.GetHashCode();
            }

            if (this.Callable != null)
            {
                hash = hash * 59 + this.Callable.GetHashCode();
            }

            if (this.PhoneNumberStatus != null)
            {
                hash = hash * 59 + this.PhoneNumberStatus.GetHashCode();
            }

            if (this.ContactableStatus != null)
            {
                hash = hash * 59 + this.ContactableStatus.GetHashCode();
            }

            if (this.ContactColumnTimeZones != null)
            {
                hash = hash * 59 + this.ContactColumnTimeZones.GetHashCode();
            }

            if (this.ConfigurationOverrides != null)
            {
                hash = hash * 59 + this.ConfigurationOverrides.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
