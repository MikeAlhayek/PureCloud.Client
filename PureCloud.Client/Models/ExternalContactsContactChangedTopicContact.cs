using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsContactChangedTopicContact
/// </summary>
[DataContract]
public partial class ExternalContactsContactChangedTopicContact : IEquatable<ExternalContactsContactChangedTopicContact>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
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
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsContactChangedTopicContact" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Division">Division.</param>
    /// <param name="ExternalOrganization">ExternalOrganization.</param>
    /// <param name="Type">Type.</param>
    /// <param name="FirstName">FirstName.</param>
    /// <param name="MiddleName">MiddleName.</param>
    /// <param name="LastName">LastName.</param>
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
    /// <param name="SurveyOptOut">SurveyOptOut.</param>
    /// <param name="ExternalSystemUrl">ExternalSystemUrl.</param>
    /// <param name="TwitterId">TwitterId.</param>
    /// <param name="LineId">LineId.</param>
    /// <param name="WhatsAppId">WhatsAppId.</param>
    /// <param name="FacebookId">FacebookId.</param>
    /// <param name="InstagramId">InstagramId.</param>
    /// <param name="ExternalIds">ExternalIds.</param>
    /// <param name="CanonicalContactId">CanonicalContactId.</param>
    /// <param name="Schema">Schema.</param>
    /// <param name="CustomFields">CustomFields.</param>
    /// <param name="MergeSet">MergeSet.</param>
    /// <param name="MergedFrom">MergedFrom.</param>
    /// <param name="MergedTo">MergedTo.</param>
    /// <param name="MergeOperation">MergeOperation.</param>
    /// <param name="CreateDate">CreateDate.</param>
    /// <param name="ModifyDate">ModifyDate.</param>
    public ExternalContactsContactChangedTopicContact(string Id = null, ExternalContactsContactChangedTopicDivision Division = null, ExternalContactsContactChangedTopicExternalOrganization ExternalOrganization = null, TypeEnum? Type = null, string FirstName = null, string MiddleName = null, string LastName = null, string Salutation = null, string Title = null, ExternalContactsContactChangedTopicPhoneNumber WorkPhone = null, ExternalContactsContactChangedTopicPhoneNumber CellPhone = null, ExternalContactsContactChangedTopicPhoneNumber HomePhone = null, ExternalContactsContactChangedTopicPhoneNumber OtherPhone = null, string WorkEmail = null, string PersonalEmail = null, string OtherEmail = null, ExternalContactsContactChangedTopicContactAddress Address = null, bool? SurveyOptOut = null, string ExternalSystemUrl = null, ExternalContactsContactChangedTopicTwitterId TwitterId = null, ExternalContactsContactChangedTopicLineId LineId = null, ExternalContactsContactChangedTopicWhatsAppId WhatsAppId = null, ExternalContactsContactChangedTopicFacebookId FacebookId = null, ExternalContactsContactChangedTopicInstagramId InstagramId = null, List<ExternalContactsContactChangedTopicExternalId> ExternalIds = null, string CanonicalContactId = null, ExternalContactsContactChangedTopicDataSchema Schema = null, Dictionary<string, object> CustomFields = null, List<string> MergeSet = null, List<string> MergedFrom = null, string MergedTo = null, ExternalContactsContactChangedTopicMergeOperation MergeOperation = null, DateTime? CreateDate = null, DateTime? ModifyDate = null)
    {
        this.Id = Id;
        this.Division = Division;
        this.ExternalOrganization = ExternalOrganization;
        this.Type = Type;
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
        this.SurveyOptOut = SurveyOptOut;
        this.ExternalSystemUrl = ExternalSystemUrl;
        this.TwitterId = TwitterId;
        this.LineId = LineId;
        this.WhatsAppId = WhatsAppId;
        this.FacebookId = FacebookId;
        this.InstagramId = InstagramId;
        this.ExternalIds = ExternalIds;
        this.CanonicalContactId = CanonicalContactId;
        this.Schema = Schema;
        this.CustomFields = CustomFields;
        this.MergeSet = MergeSet;
        this.MergedFrom = MergedFrom;
        this.MergedTo = MergedTo;
        this.MergeOperation = MergeOperation;
        this.CreateDate = CreateDate;
        this.ModifyDate = ModifyDate;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicDivision Division { get; set; }



    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    [DataMember(Name = "externalOrganization", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicExternalOrganization ExternalOrganization { get; set; }





    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name = "firstName", EmitDefaultValue = false)]
    public string FirstName { get; set; }



    /// <summary>
    /// Gets or Sets MiddleName
    /// </summary>
    [DataMember(Name = "middleName", EmitDefaultValue = false)]
    public string MiddleName { get; set; }



    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
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
    public ExternalContactsContactChangedTopicPhoneNumber WorkPhone { get; set; }



    /// <summary>
    /// Gets or Sets CellPhone
    /// </summary>
    [DataMember(Name = "cellPhone", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicPhoneNumber CellPhone { get; set; }



    /// <summary>
    /// Gets or Sets HomePhone
    /// </summary>
    [DataMember(Name = "homePhone", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicPhoneNumber HomePhone { get; set; }



    /// <summary>
    /// Gets or Sets OtherPhone
    /// </summary>
    [DataMember(Name = "otherPhone", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicPhoneNumber OtherPhone { get; set; }



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
    public ExternalContactsContactChangedTopicContactAddress Address { get; set; }



    /// <summary>
    /// Gets or Sets SurveyOptOut
    /// </summary>
    [DataMember(Name = "surveyOptOut", EmitDefaultValue = false)]
    public bool? SurveyOptOut { get; set; }



    /// <summary>
    /// Gets or Sets ExternalSystemUrl
    /// </summary>
    [DataMember(Name = "externalSystemUrl", EmitDefaultValue = false)]
    public string ExternalSystemUrl { get; set; }



    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    [DataMember(Name = "twitterId", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicTwitterId TwitterId { get; set; }



    /// <summary>
    /// Gets or Sets LineId
    /// </summary>
    [DataMember(Name = "lineId", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicLineId LineId { get; set; }



    /// <summary>
    /// Gets or Sets WhatsAppId
    /// </summary>
    [DataMember(Name = "whatsAppId", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicWhatsAppId WhatsAppId { get; set; }



    /// <summary>
    /// Gets or Sets FacebookId
    /// </summary>
    [DataMember(Name = "facebookId", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicFacebookId FacebookId { get; set; }



    /// <summary>
    /// Gets or Sets InstagramId
    /// </summary>
    [DataMember(Name = "instagramId", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicInstagramId InstagramId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalIds
    /// </summary>
    [DataMember(Name = "externalIds", EmitDefaultValue = false)]
    public List<ExternalContactsContactChangedTopicExternalId> ExternalIds { get; set; }



    /// <summary>
    /// Gets or Sets CanonicalContactId
    /// </summary>
    [DataMember(Name = "canonicalContactId", EmitDefaultValue = false)]
    public string CanonicalContactId { get; set; }



    /// <summary>
    /// Gets or Sets Schema
    /// </summary>
    [DataMember(Name = "schema", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicDataSchema Schema { get; set; }



    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name = "customFields", EmitDefaultValue = false)]
    public Dictionary<string, object> CustomFields { get; set; }



    /// <summary>
    /// Gets or Sets MergeSet
    /// </summary>
    [DataMember(Name = "mergeSet", EmitDefaultValue = false)]
    public List<string> MergeSet { get; set; }



    /// <summary>
    /// Gets or Sets MergedFrom
    /// </summary>
    [DataMember(Name = "mergedFrom", EmitDefaultValue = false)]
    public List<string> MergedFrom { get; set; }



    /// <summary>
    /// Gets or Sets MergedTo
    /// </summary>
    [DataMember(Name = "mergedTo", EmitDefaultValue = false)]
    public string MergedTo { get; set; }



    /// <summary>
    /// Gets or Sets MergeOperation
    /// </summary>
    [DataMember(Name = "mergeOperation", EmitDefaultValue = false)]
    public ExternalContactsContactChangedTopicMergeOperation MergeOperation { get; set; }



    /// <summary>
    /// Gets or Sets CreateDate
    /// </summary>
    [DataMember(Name = "createDate", EmitDefaultValue = false)]
    public DateTime? CreateDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    [DataMember(Name = "modifyDate", EmitDefaultValue = false)]
    public DateTime? ModifyDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsContactChangedTopicContact {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        sb.Append("  SurveyOptOut: ").Append(SurveyOptOut).Append("\n");
        sb.Append("  ExternalSystemUrl: ").Append(ExternalSystemUrl).Append("\n");
        sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
        sb.Append("  LineId: ").Append(LineId).Append("\n");
        sb.Append("  WhatsAppId: ").Append(WhatsAppId).Append("\n");
        sb.Append("  FacebookId: ").Append(FacebookId).Append("\n");
        sb.Append("  InstagramId: ").Append(InstagramId).Append("\n");
        sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
        sb.Append("  CanonicalContactId: ").Append(CanonicalContactId).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
        sb.Append("  MergeSet: ").Append(MergeSet).Append("\n");
        sb.Append("  MergedFrom: ").Append(MergedFrom).Append("\n");
        sb.Append("  MergedTo: ").Append(MergedTo).Append("\n");
        sb.Append("  MergeOperation: ").Append(MergeOperation).Append("\n");
        sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
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
        return Equals(obj as ExternalContactsContactChangedTopicContact);
    }

    /// <summary>
    /// Returns true if ExternalContactsContactChangedTopicContact instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsContactChangedTopicContact to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsContactChangedTopicContact other)
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
                ExternalOrganization == other.ExternalOrganization ||
                ExternalOrganization != null &&
                ExternalOrganization.Equals(other.ExternalOrganization)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
                InstagramId == other.InstagramId ||
                InstagramId != null &&
                InstagramId.Equals(other.InstagramId)
            ) &&
            (
                ExternalIds == other.ExternalIds ||
                ExternalIds != null &&
                ExternalIds.SequenceEqual(other.ExternalIds)
            ) &&
            (
                CanonicalContactId == other.CanonicalContactId ||
                CanonicalContactId != null &&
                CanonicalContactId.Equals(other.CanonicalContactId)
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
                MergeSet == other.MergeSet ||
                MergeSet != null &&
                MergeSet.SequenceEqual(other.MergeSet)
            ) &&
            (
                MergedFrom == other.MergedFrom ||
                MergedFrom != null &&
                MergedFrom.SequenceEqual(other.MergedFrom)
            ) &&
            (
                MergedTo == other.MergedTo ||
                MergedTo != null &&
                MergedTo.Equals(other.MergedTo)
            ) &&
            (
                MergeOperation == other.MergeOperation ||
                MergeOperation != null &&
                MergeOperation.Equals(other.MergeOperation)
            ) &&
            (
                CreateDate == other.CreateDate ||
                CreateDate != null &&
                CreateDate.Equals(other.CreateDate)
            ) &&
            (
                ModifyDate == other.ModifyDate ||
                ModifyDate != null &&
                ModifyDate.Equals(other.ModifyDate)
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

            if (ExternalOrganization != null)
            {
                hash = hash * 59 + ExternalOrganization.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
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

            if (SurveyOptOut != null)
            {
                hash = hash * 59 + SurveyOptOut.GetHashCode();
            }

            if (ExternalSystemUrl != null)
            {
                hash = hash * 59 + ExternalSystemUrl.GetHashCode();
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

            if (InstagramId != null)
            {
                hash = hash * 59 + InstagramId.GetHashCode();
            }

            if (ExternalIds != null)
            {
                hash = hash * 59 + ExternalIds.GetHashCode();
            }

            if (CanonicalContactId != null)
            {
                hash = hash * 59 + CanonicalContactId.GetHashCode();
            }

            if (Schema != null)
            {
                hash = hash * 59 + Schema.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
            }

            if (MergeSet != null)
            {
                hash = hash * 59 + MergeSet.GetHashCode();
            }

            if (MergedFrom != null)
            {
                hash = hash * 59 + MergedFrom.GetHashCode();
            }

            if (MergedTo != null)
            {
                hash = hash * 59 + MergedTo.GetHashCode();
            }

            if (MergeOperation != null)
            {
                hash = hash * 59 + MergeOperation.GetHashCode();
            }

            if (CreateDate != null)
            {
                hash = hash * 59 + CreateDate.GetHashCode();
            }

            if (ModifyDate != null)
            {
                hash = hash * 59 + ModifyDate.GetHashCode();
            }

            return hash;
        }
    }
}
