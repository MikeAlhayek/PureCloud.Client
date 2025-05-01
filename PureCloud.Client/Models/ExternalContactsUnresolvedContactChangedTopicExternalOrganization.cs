using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsUnresolvedContactChangedTopicExternalOrganization
/// </summary>
[DataContract]
public partial class ExternalContactsUnresolvedContactChangedTopicExternalOrganization : IEquatable<ExternalContactsUnresolvedContactChangedTopicExternalOrganization>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsUnresolvedContactChangedTopicExternalOrganization" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Division">Division.</param>
    /// <param name="Name">Name.</param>
    /// <param name="CompanyType">CompanyType.</param>
    /// <param name="Industry">Industry.</param>
    /// <param name="PrimaryContactId">PrimaryContactId.</param>
    /// <param name="Address">Address.</param>
    /// <param name="PhoneNumber">PhoneNumber.</param>
    /// <param name="FaxNumber">FaxNumber.</param>
    /// <param name="EmployeeCount">EmployeeCount.</param>
    /// <param name="Revenue">Revenue.</param>
    /// <param name="Tags">Tags.</param>
    /// <param name="Websites">Websites.</param>
    /// <param name="Tickers">Tickers.</param>
    /// <param name="TwitterId">TwitterId.</param>
    /// <param name="ExternalSystemUrl">ExternalSystemUrl.</param>
    /// <param name="CustomFields">CustomFields.</param>
    /// <param name="CreateDate">CreateDate.</param>
    /// <param name="ModifyDate">ModifyDate.</param>
    public ExternalContactsUnresolvedContactChangedTopicExternalOrganization(string Id = null, ExternalContactsUnresolvedContactChangedTopicDivision Division = null, string Name = null, string CompanyType = null, string Industry = null, string PrimaryContactId = null, ExternalContactsUnresolvedContactChangedTopicContactAddress Address = null, ExternalContactsUnresolvedContactChangedTopicPhoneNumber PhoneNumber = null, ExternalContactsUnresolvedContactChangedTopicPhoneNumber FaxNumber = null, long? EmployeeCount = null, long? Revenue = null, List<string> Tags = null, List<string> Websites = null, List<ExternalContactsUnresolvedContactChangedTopicTicker> Tickers = null, ExternalContactsUnresolvedContactChangedTopicTwitterId TwitterId = null, string ExternalSystemUrl = null, Dictionary<string, object> CustomFields = null, DateTime? CreateDate = null, DateTime? ModifyDate = null)
    {
        this.Id = Id;
        this.Division = Division;
        this.Name = Name;
        this.CompanyType = CompanyType;
        this.Industry = Industry;
        this.PrimaryContactId = PrimaryContactId;
        this.Address = Address;
        this.PhoneNumber = PhoneNumber;
        this.FaxNumber = FaxNumber;
        this.EmployeeCount = EmployeeCount;
        this.Revenue = Revenue;
        this.Tags = Tags;
        this.Websites = Websites;
        this.Tickers = Tickers;
        this.TwitterId = TwitterId;
        this.ExternalSystemUrl = ExternalSystemUrl;
        this.CustomFields = CustomFields;
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
    public ExternalContactsUnresolvedContactChangedTopicDivision Division { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets CompanyType
    /// </summary>
    [DataMember(Name = "companyType", EmitDefaultValue = false)]
    public string CompanyType { get; set; }



    /// <summary>
    /// Gets or Sets Industry
    /// </summary>
    [DataMember(Name = "industry", EmitDefaultValue = false)]
    public string Industry { get; set; }



    /// <summary>
    /// Gets or Sets PrimaryContactId
    /// </summary>
    [DataMember(Name = "primaryContactId", EmitDefaultValue = false)]
    public string PrimaryContactId { get; set; }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public ExternalContactsUnresolvedContactChangedTopicContactAddress Address { get; set; }



    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public ExternalContactsUnresolvedContactChangedTopicPhoneNumber PhoneNumber { get; set; }



    /// <summary>
    /// Gets or Sets FaxNumber
    /// </summary>
    [DataMember(Name = "faxNumber", EmitDefaultValue = false)]
    public ExternalContactsUnresolvedContactChangedTopicPhoneNumber FaxNumber { get; set; }



    /// <summary>
    /// Gets or Sets EmployeeCount
    /// </summary>
    [DataMember(Name = "employeeCount", EmitDefaultValue = false)]
    public long? EmployeeCount { get; set; }



    /// <summary>
    /// Gets or Sets Revenue
    /// </summary>
    [DataMember(Name = "revenue", EmitDefaultValue = false)]
    public long? Revenue { get; set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    public List<string> Tags { get; set; }



    /// <summary>
    /// Gets or Sets Websites
    /// </summary>
    [DataMember(Name = "websites", EmitDefaultValue = false)]
    public List<string> Websites { get; set; }



    /// <summary>
    /// Gets or Sets Tickers
    /// </summary>
    [DataMember(Name = "tickers", EmitDefaultValue = false)]
    public List<ExternalContactsUnresolvedContactChangedTopicTicker> Tickers { get; set; }



    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    [DataMember(Name = "twitterId", EmitDefaultValue = false)]
    public ExternalContactsUnresolvedContactChangedTopicTwitterId TwitterId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalSystemUrl
    /// </summary>
    [DataMember(Name = "externalSystemUrl", EmitDefaultValue = false)]
    public string ExternalSystemUrl { get; set; }



    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [DataMember(Name = "customFields", EmitDefaultValue = false)]
    public Dictionary<string, object> CustomFields { get; set; }



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
        sb.Append("class ExternalContactsUnresolvedContactChangedTopicExternalOrganization {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  CompanyType: ").Append(CompanyType).Append("\n");
        sb.Append("  Industry: ").Append(Industry).Append("\n");
        sb.Append("  PrimaryContactId: ").Append(PrimaryContactId).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  FaxNumber: ").Append(FaxNumber).Append("\n");
        sb.Append("  EmployeeCount: ").Append(EmployeeCount).Append("\n");
        sb.Append("  Revenue: ").Append(Revenue).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  Websites: ").Append(Websites).Append("\n");
        sb.Append("  Tickers: ").Append(Tickers).Append("\n");
        sb.Append("  TwitterId: ").Append(TwitterId).Append("\n");
        sb.Append("  ExternalSystemUrl: ").Append(ExternalSystemUrl).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
        return Equals(obj as ExternalContactsUnresolvedContactChangedTopicExternalOrganization);
    }

    /// <summary>
    /// Returns true if ExternalContactsUnresolvedContactChangedTopicExternalOrganization instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsUnresolvedContactChangedTopicExternalOrganization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsUnresolvedContactChangedTopicExternalOrganization other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                CompanyType == other.CompanyType ||
                CompanyType != null &&
                CompanyType.Equals(other.CompanyType)
            ) &&
            (
                Industry == other.Industry ||
                Industry != null &&
                Industry.Equals(other.Industry)
            ) &&
            (
                PrimaryContactId == other.PrimaryContactId ||
                PrimaryContactId != null &&
                PrimaryContactId.Equals(other.PrimaryContactId)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                FaxNumber == other.FaxNumber ||
                FaxNumber != null &&
                FaxNumber.Equals(other.FaxNumber)
            ) &&
            (
                EmployeeCount == other.EmployeeCount ||
                EmployeeCount != null &&
                EmployeeCount.Equals(other.EmployeeCount)
            ) &&
            (
                Revenue == other.Revenue ||
                Revenue != null &&
                Revenue.Equals(other.Revenue)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                Websites == other.Websites ||
                Websites != null &&
                Websites.SequenceEqual(other.Websites)
            ) &&
            (
                Tickers == other.Tickers ||
                Tickers != null &&
                Tickers.SequenceEqual(other.Tickers)
            ) &&
            (
                TwitterId == other.TwitterId ||
                TwitterId != null &&
                TwitterId.Equals(other.TwitterId)
            ) &&
            (
                ExternalSystemUrl == other.ExternalSystemUrl ||
                ExternalSystemUrl != null &&
                ExternalSystemUrl.Equals(other.ExternalSystemUrl)
            ) &&
            (
                CustomFields == other.CustomFields ||
                CustomFields != null &&
                CustomFields.SequenceEqual(other.CustomFields)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (CompanyType != null)
            {
                hash = hash * 59 + CompanyType.GetHashCode();
            }

            if (Industry != null)
            {
                hash = hash * 59 + Industry.GetHashCode();
            }

            if (PrimaryContactId != null)
            {
                hash = hash * 59 + PrimaryContactId.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (FaxNumber != null)
            {
                hash = hash * 59 + FaxNumber.GetHashCode();
            }

            if (EmployeeCount != null)
            {
                hash = hash * 59 + EmployeeCount.GetHashCode();
            }

            if (Revenue != null)
            {
                hash = hash * 59 + Revenue.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (Websites != null)
            {
                hash = hash * 59 + Websites.GetHashCode();
            }

            if (Tickers != null)
            {
                hash = hash * 59 + Tickers.GetHashCode();
            }

            if (TwitterId != null)
            {
                hash = hash * 59 + TwitterId.GetHashCode();
            }

            if (ExternalSystemUrl != null)
            {
                hash = hash * 59 + ExternalSystemUrl.GetHashCode();
            }

            if (CustomFields != null)
            {
                hash = hash * 59 + CustomFields.GetHashCode();
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
