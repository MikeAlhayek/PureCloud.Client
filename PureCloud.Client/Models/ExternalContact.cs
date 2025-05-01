using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContact
/// </summary>
[DataContract]
public partial class ExternalContact : IEquatable<ExternalContact>
{
    /// <summary>
    /// The type of contact
    /// </summary>
    /// <value>The type of contact</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ephemeral for "Ephemeral"
        /// </summary>
        [EnumMember(Value = "Ephemeral")]
        Ephemeral,

        /// <summary>
        /// Enum Identified for "Identified"
        /// </summary>
        [EnumMember(Value = "Identified")]
        Identified,

        /// <summary>
        /// Enum Curated for "Curated"
        /// </summary>
        [EnumMember(Value = "Curated")]
        Curated
    }
    /// <summary>
    /// The type of contact
    /// </summary>
    /// <value>The type of contact</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContact" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="FirstName">The first name of the contact..</param>
    /// <param name="MiddleName">MiddleName.</param>
    /// <param name="LastName">The last name of the contact..</param>
    /// <param name="Salutation">Salutation.</param>
    /// <param name="Title">Title.</param>
    /// <param name="WorkPhone">WorkPhone.</param>
    /// <param name="CellPhone">CellPhone.</param>
    /// <param name="HomePhone">HomePhone.</param>
    /// <param name="OtherPhone">OtherPhone.</param>
    /// <param name="WorkEmail">WorkEmail.</param>
    /// <param name="PersonalEmail">PersonalEmail.</param>
    /// <param name="OtherEmail">OtherEmail.</param>
    /// <param name="Address">Address.</param>
    /// <param name="TwitterId">TwitterId.</param>
    /// <param name="LineId">LineId.</param>
    /// <param name="WhatsAppId">WhatsAppId.</param>
    /// <param name="FacebookId">FacebookId.</param>
    /// <param name="ExternalIds">A list of external identifiers that identify this contact in an external system.</param>
    /// <param name="Identifiers">Identifiers claimed by this contact.</param>
    /// <param name="ModifyDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreateDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExternalOrganization">ExternalOrganization.</param>
    /// <param name="SurveyOptOut">SurveyOptOut.</param>
    /// <param name="ExternalSystemUrl">A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace..</param>
    /// <param name="Schema">The schema defining custom fields for this contact.</param>
    /// <param name="CustomFields">Custom fields defined in the schema referenced by schemaId and schemaVersion..</param>
    public ExternalContact(string Id = null, WritableStarrableDivision Division = null, string FirstName = null, string MiddleName = null, string LastName = null, string Salutation = null, string Title = null, PhoneNumber WorkPhone = null, PhoneNumber CellPhone = null, PhoneNumber HomePhone = null, PhoneNumber OtherPhone = null, string WorkEmail = null, string PersonalEmail = null, string OtherEmail = null, ContactAddress Address = null, TwitterId TwitterId = null, LineId LineId = null, WhatsAppId WhatsAppId = null, FacebookId FacebookId = null, List<ExternalId> ExternalIds = null, List<ContactIdentifier> Identifiers = null, DateTime? ModifyDate = null, DateTime? CreateDate = null, ExternalOrganization ExternalOrganization = null, bool? SurveyOptOut = null, string ExternalSystemUrl = null, DataSchema Schema = null, Dictionary<string, object> CustomFields = null)
    {
        this.Id = Id;
        this.Division = Division;
        this.FirstName = FirstName;
        this.MiddleName = MiddleName;
        this.LastName = LastName;
        this.Salutation = Salutation;
        this.Title = Title;
        this.WorkPhone = WorkPhone;
        this.CellPhone = CellPhone;
        this.HomePhone = HomePhone;
        this.OtherPhone = OtherPhone;
        this.WorkEmail = WorkEmail;
        this.PersonalEmail = PersonalEmail;
        this.OtherEmail = OtherEmail;
        this.Address = Address;
        this.TwitterId = TwitterId;
        this.LineId = LineId;
        this.WhatsAppId = WhatsAppId;
        this.FacebookId = FacebookId;
        this.ExternalIds = ExternalIds;
        this.Identifiers = Identifiers;
        this.ModifyDate = ModifyDate;
        this.CreateDate = CreateDate;
        this.ExternalOrganization = ExternalOrganization;
        this.SurveyOptOut = SurveyOptOut;
        this.ExternalSystemUrl = ExternalSystemUrl;
        this.Schema = Schema;
        this.CustomFields = CustomFields;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public WritableStarrableDivision Division { get; set; }



    /// <summary>
    /// The first name of the contact.
    /// </summary>
    /// <value>The first name of the contact.</value>
    [DataMember(Name = "firstName", EmitDefaultValue = false)]
    public string FirstName { get; set; }



    /// <summary>
    /// Gets or Sets MiddleName
    /// </summary>
    [DataMember(Name = "middleName", EmitDefaultValue = false)]
    public string MiddleName { get; set; }



    /// <summary>
    /// The last name of the contact.
    /// </summary>
    /// <value>The last name of the contact.</value>
    [DataMember(Name = "lastName", EmitDefaultValue = false)]
    public string LastName { get; set; }



    /// <summary>
    /// Gets or Sets Salutation
    /// </summary>
    [DataMember(Name = "salutation", EmitDefaultValue = false)]
    public string Salutation { get; set; }



    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// Gets or Sets WorkPhone
    /// </summary>
    [DataMember(Name = "workPhone", EmitDefaultValue = false)]
    public PhoneNumber WorkPhone { get; set; }



    /// <summary>
    /// Gets or Sets CellPhone
    /// </summary>
    [DataMember(Name = "cellPhone", EmitDefaultValue = false)]
    public PhoneNumber CellPhone { get; set; }



    /// <summary>
    /// Gets or Sets HomePhone
    /// </summary>
    [DataMember(Name = "homePhone", EmitDefaultValue = false)]
    public PhoneNumber HomePhone { get; set; }



    /// <summary>
    /// Gets or Sets OtherPhone
    /// </summary>
    [DataMember(Name = "otherPhone", EmitDefaultValue = false)]
    public PhoneNumber OtherPhone { get; set; }



    /// <summary>
    /// Gets or Sets WorkEmail
    /// </summary>
    [DataMember(Name = "workEmail", EmitDefaultValue = false)]
    public string WorkEmail { get; set; }



    /// <summary>
    /// Gets or Sets PersonalEmail
    /// </summary>
    [DataMember(Name = "personalEmail", EmitDefaultValue = false)]
    public string PersonalEmail { get; set; }



    /// <summary>
    /// Gets or Sets OtherEmail
    /// </summary>
    [DataMember(Name = "otherEmail", EmitDefaultValue = false)]
    public string OtherEmail { get; set; }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public ContactAddress Address { get; set; }



    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    [DataMember(Name = "twitterId", EmitDefaultValue = false)]
    public TwitterId TwitterId { get; set; }



    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name = "lineId", EmitDefaultValue = false)]
    public LineId LineId { get; set; }



    /// <summary>
    /// Gets or Sets WhatsAppId
    /// </summary>
    [DataMember(Name = "whatsAppId", EmitDefaultValue = false)]
    public WhatsAppId WhatsAppId { get; set; }



    /// <summary>
    /// Gets or Sets FacebookId
    /// </summary>
    [DataMember(Name = "facebookId", EmitDefaultValue = false)]
    public FacebookId FacebookId { get; set; }



    /// <summary>
    /// A list of external identifiers that identify this contact in an external system
    /// </summary>
    /// <value>A list of external identifiers that identify this contact in an external system</value>
    [DataMember(Name = "externalIds", EmitDefaultValue = false)]
    public List<ExternalId> ExternalIds { get; set; }



    /// <summary>
    /// Identifiers claimed by this contact
    /// </summary>
    /// <value>Identifiers claimed by this contact</value>
    [DataMember(Name = "identifiers", EmitDefaultValue = false)]
    public List<ContactIdentifier> Identifiers { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifyDate", EmitDefaultValue = false)]
    public DateTime? ModifyDate { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createDate", EmitDefaultValue = false)]
    public DateTime? CreateDate { get; set; }



    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    [DataMember(Name = "externalOrganization", EmitDefaultValue = false)]
    public ExternalOrganization ExternalOrganization { get; set; }



    /// <summary>
    /// Gets or Sets SurveyOptOut
    /// </summary>
    [DataMember(Name = "surveyOptOut", EmitDefaultValue = false)]
    public bool? SurveyOptOut { get; set; }



    /// <summary>
    /// A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.
    /// </summary>
    /// <value>A string that identifies an external system-of-record resource that may have more detailed information on the contact. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.</value>
    [DataMember(Name = "externalSystemUrl", EmitDefaultValue = false)]
    public string ExternalSystemUrl { get; set; }



    /// <summary>
    /// The schema defining custom fields for this contact
    /// </summary>
    /// <value>The schema defining custom fields for this contact</value>
    [DataMember(Name = "schema", EmitDefaultValue = false)]
    public DataSchema Schema { get; set; }



    /// <summary>
    /// Custom fields defined in the schema referenced by schemaId and schemaVersion.
    /// </summary>
    /// <value>Custom fields defined in the schema referenced by schemaId and schemaVersion.</value>
    [DataMember(Name = "customFields", EmitDefaultValue = false)]
    public Dictionary<string, object> CustomFields { get; set; }



    /// <summary>
    /// Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.
    /// </summary>
    /// <value>Links to the sources of data (e.g. one source might be a CRM) that contributed data to this record.  Read-only, and only populated when requested via expand param.</value>
    [DataMember(Name = "externalDataSources", EmitDefaultValue = false)]
    public List<ExternalDataSource> ExternalDataSources { get; private set; }





    /// <summary>
    /// The contact at the head of the merge tree. If null, this contact is not a part of any merge.
    /// </summary>
    /// <value>The contact at the head of the merge tree. If null, this contact is not a part of any merge.</value>
    [DataMember(Name = "canonicalContact", EmitDefaultValue = false)]
    public ContactAddressableEntityRef CanonicalContact { get; private set; }



    /// <summary>
    /// The set of all contacts that are a part of the merge tree. If null, this contact is not a part of any merge.
    /// </summary>
    /// <value>The set of all contacts that are a part of the merge tree. If null, this contact is not a part of any merge.</value>
    [DataMember(Name = "mergeSet", EmitDefaultValue = false)]
    public List<ContactAddressableEntityRef> MergeSet { get; private set; }



    /// <summary>
    /// Information about the merge history of this contact. If null, this contact is not a part of any merge.
    /// </summary>
    /// <value>Information about the merge history of this contact. If null, this contact is not a part of any merge.</value>
    [DataMember(Name = "mergeOperation", EmitDefaultValue = false)]
    public MergeOperation MergeOperation { get; private set; }



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
        sb.Append("class ExternalContact {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  FirstName: ").Append(FirstName).Append("\n");
        sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
        sb.Append("  LastName: ").Append(LastName).Append("\n");
        sb.Append("  Salutation: ").Append(Salutation).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
        sb.Append("  CellPhone: ").Append(CellPhone).Append("\n");
        sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
        sb.Append("  OtherPhone: ").Append(OtherPhone).Append("\n");
        sb.Append("  WorkEmail: ").Append(WorkEmail).Append("\n");
        sb.Append("  PersonalEmail: ").Append(PersonalEmail).Append("\n");
        sb.Append("  OtherEmail: ").Append(OtherEmail).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
        sb.Append("  LineId: ").Append(LineId).Append("\n");
        sb.Append("  WhatsAppId: ").Append(WhatsAppId).Append("\n");
        sb.Append("  FacebookId: ").Append(FacebookId).Append("\n");
        sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
        sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
        sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
        sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
        sb.Append("  SurveyOptOut: ").Append(SurveyOptOut).Append("\n");
        sb.Append("  ExternalSystemUrl: ").Append(ExternalSystemUrl).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
        sb.Append("  ExternalDataSources: ").Append(ExternalDataSources).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  CanonicalContact: ").Append(CanonicalContact).Append("\n");
        sb.Append("  MergeSet: ").Append(MergeSet).Append("\n");
        sb.Append("  MergeOperation: ").Append(MergeOperation).Append("\n");
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
        return Equals(obj as ExternalContact);
    }

    /// <summary>
    /// Returns true if ExternalContact instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContact to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContact other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                FirstName == other.FirstName ||
                FirstName != null &&
                FirstName.Equals(other.FirstName)
            ) &&
            (
                MiddleName == other.MiddleName ||
                MiddleName != null &&
                MiddleName.Equals(other.MiddleName)
            ) &&
            (
                LastName == other.LastName ||
                LastName != null &&
                LastName.Equals(other.LastName)
            ) &&
            (
                Salutation == other.Salutation ||
                Salutation != null &&
                Salutation.Equals(other.Salutation)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                WorkPhone == other.WorkPhone ||
                WorkPhone != null &&
                WorkPhone.Equals(other.WorkPhone)
            ) &&
            (
                CellPhone == other.CellPhone ||
                CellPhone != null &&
                CellPhone.Equals(other.CellPhone)
            ) &&
            (
                HomePhone == other.HomePhone ||
                HomePhone != null &&
                HomePhone.Equals(other.HomePhone)
            ) &&
            (
                OtherPhone == other.OtherPhone ||
                OtherPhone != null &&
                OtherPhone.Equals(other.OtherPhone)
            ) &&
            (
                WorkEmail == other.WorkEmail ||
                WorkEmail != null &&
                WorkEmail.Equals(other.WorkEmail)
            ) &&
            (
                PersonalEmail == other.PersonalEmail ||
                PersonalEmail != null &&
                PersonalEmail.Equals(other.PersonalEmail)
            ) &&
            (
                OtherEmail == other.OtherEmail ||
                OtherEmail != null &&
                OtherEmail.Equals(other.OtherEmail)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                TwitterId == other.TwitterId ||
                TwitterId != null &&
                TwitterId.Equals(other.TwitterId)
            ) &&
            (
                LineId == other.LineId ||
                LineId != null &&
                LineId.Equals(other.LineId)
            ) &&
            (
                WhatsAppId == other.WhatsAppId ||
                WhatsAppId != null &&
                WhatsAppId.Equals(other.WhatsAppId)
            ) &&
            (
                FacebookId == other.FacebookId ||
                FacebookId != null &&
                FacebookId.Equals(other.FacebookId)
            ) &&
            (
                ExternalIds == other.ExternalIds ||
                ExternalIds != null &&
                ExternalIds.SequenceEqual(other.ExternalIds)
            ) &&
            (
                Identifiers == other.Identifiers ||
                Identifiers != null &&
                Identifiers.SequenceEqual(other.Identifiers)
            ) &&
            (
                ModifyDate == other.ModifyDate ||
                ModifyDate != null &&
                ModifyDate.Equals(other.ModifyDate)
            ) &&
            (
                CreateDate == other.CreateDate ||
                CreateDate != null &&
                CreateDate.Equals(other.CreateDate)
            ) &&
            (
                ExternalOrganization == other.ExternalOrganization ||
                ExternalOrganization != null &&
                ExternalOrganization.Equals(other.ExternalOrganization)
            ) &&
            (
                SurveyOptOut == other.SurveyOptOut ||
                SurveyOptOut != null &&
                SurveyOptOut.Equals(other.SurveyOptOut)
            ) &&
            (
                ExternalSystemUrl == other.ExternalSystemUrl ||
                ExternalSystemUrl != null &&
                ExternalSystemUrl.Equals(other.ExternalSystemUrl)
            ) &&
            (
                Schema == other.Schema ||
                Schema != null &&
                Schema.Equals(other.Schema)
            ) &&
            (
                CustomFields == other.CustomFields ||
                CustomFields != null &&
                CustomFields.SequenceEqual(other.CustomFields)
            ) &&
            (
                ExternalDataSources == other.ExternalDataSources ||
                ExternalDataSources != null &&
                ExternalDataSources.SequenceEqual(other.ExternalDataSources)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                CanonicalContact == other.CanonicalContact ||
                CanonicalContact != null &&
                CanonicalContact.Equals(other.CanonicalContact)
            ) &&
            (
                MergeSet == other.MergeSet ||
                MergeSet != null &&
                MergeSet.SequenceEqual(other.MergeSet)
            ) &&
            (
                MergeOperation == other.MergeOperation ||
                MergeOperation != null &&
                MergeOperation.Equals(other.MergeOperation)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (FirstName != null)
            {
                hash = hash * 59 + FirstName.GetHashCode();
            }

            if (MiddleName != null)
            {
                hash = hash * 59 + MiddleName.GetHashCode();
            }

            if (LastName != null)
            {
                hash = hash * 59 + LastName.GetHashCode();
            }

            if (Salutation != null)
            {
                hash = hash * 59 + Salutation.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (WorkPhone != null)
            {
                hash = hash * 59 + WorkPhone.GetHashCode();
            }

            if (CellPhone != null)
            {
                hash = hash * 59 + CellPhone.GetHashCode();
            }

            if (HomePhone != null)
            {
                hash = hash * 59 + HomePhone.GetHashCode();
            }

            if (OtherPhone != null)
            {
                hash = hash * 59 + OtherPhone.GetHashCode();
            }

            if (WorkEmail != null)
            {
                hash = hash * 59 + WorkEmail.GetHashCode();
            }

            if (PersonalEmail != null)
            {
                hash = hash * 59 + PersonalEmail.GetHashCode();
            }

            if (OtherEmail != null)
            {
                hash = hash * 59 + OtherEmail.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (TwitterId != null)
            {
                hash = hash * 59 + TwitterId.GetHashCode();
            }

            if (LineId != null)
            {
                hash = hash * 59 + LineId.GetHashCode();
            }

            if (WhatsAppId != null)
            {
                hash = hash * 59 + WhatsAppId.GetHashCode();
            }

            if (FacebookId != null)
            {
                hash = hash * 59 + FacebookId.GetHashCode();
            }

            if (ExternalIds != null)
            {
                hash = hash * 59 + ExternalIds.GetHashCode();
            }

            if (Identifiers != null)
            {
                hash = hash * 59 + Identifiers.GetHashCode();
            }

            if (ModifyDate != null)
            {
                hash = hash * 59 + ModifyDate.GetHashCode();
            }

            if (CreateDate != null)
            {
                hash = hash * 59 + CreateDate.GetHashCode();
            }

            if (ExternalOrganization != null)
            {
                hash = hash * 59 + ExternalOrganization.GetHashCode();
            }

            if (SurveyOptOut != null)
            {
                hash = hash * 59 + SurveyOptOut.GetHashCode();
            }

            if (ExternalSystemUrl != null)
            {
                hash = hash * 59 + ExternalSystemUrl.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
            }

            if (ExternalDataSources != null)
            {
                hash = hash * 59 + ExternalDataSources.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (CanonicalContact != null)
            {
                hash = hash * 59 + CanonicalContact.GetHashCode();
            }

            if (MergeSet != null)
            {
                hash = hash * 59 + MergeSet.GetHashCode();
            }

            if (MergeOperation != null)
            {
                hash = hash * 59 + MergeOperation.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
