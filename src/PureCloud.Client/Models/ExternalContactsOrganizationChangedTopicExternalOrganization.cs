using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsOrganizationChangedTopicExternalOrganization
/// </summary>

public partial class ExternalContactsOrganizationChangedTopicExternalOrganization : IEquatable<ExternalContactsOrganizationChangedTopicExternalOrganization>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsOrganizationChangedTopicExternalOrganization" /> class.
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
    public ExternalContactsOrganizationChangedTopicExternalOrganization(string Id = null, ExternalContactsOrganizationChangedTopicDivision Division = null, string Name = null, string CompanyType = null, string Industry = null, string PrimaryContactId = null, ExternalContactsOrganizationChangedTopicContactAddress Address = null, ExternalContactsOrganizationChangedTopicPhoneNumber PhoneNumber = null, ExternalContactsOrganizationChangedTopicPhoneNumber FaxNumber = null, long? EmployeeCount = null, long? Revenue = null, List<string> Tags = null, List<string> Websites = null, List<ExternalContactsOrganizationChangedTopicTicker> Tickers = null, ExternalContactsOrganizationChangedTopicTwitterId TwitterId = null, string ExternalSystemUrl = null, Dictionary<string, object> CustomFields = null, DateTime? CreateDate = null, DateTime? ModifyDate = null)
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
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Division
    /// </summary>
    [JsonPropertyName("division")]
    public ExternalContactsOrganizationChangedTopicDivision Division { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets CompanyType
    /// </summary>
    [JsonPropertyName("companyType")]
    public string CompanyType { get; set; }



    /// <summary>
    /// Gets or Sets Industry
    /// </summary>
    [JsonPropertyName("industry")]
    public string Industry { get; set; }



    /// <summary>
    /// Gets or Sets PrimaryContactId
    /// </summary>
    [JsonPropertyName("primaryContactId")]
    public string PrimaryContactId { get; set; }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [JsonPropertyName("address")]
    public ExternalContactsOrganizationChangedTopicContactAddress Address { get; set; }



    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public ExternalContactsOrganizationChangedTopicPhoneNumber PhoneNumber { get; set; }



    /// <summary>
    /// Gets or Sets FaxNumber
    /// </summary>
    [JsonPropertyName("faxNumber")]
    public ExternalContactsOrganizationChangedTopicPhoneNumber FaxNumber { get; set; }



    /// <summary>
    /// Gets or Sets EmployeeCount
    /// </summary>
    [JsonPropertyName("employeeCount")]
    public long? EmployeeCount { get; set; }



    /// <summary>
    /// Gets or Sets Revenue
    /// </summary>
    [JsonPropertyName("revenue")]
    public long? Revenue { get; set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }



    /// <summary>
    /// Gets or Sets Websites
    /// </summary>
    [JsonPropertyName("websites")]
    public List<string> Websites { get; set; }



    /// <summary>
    /// Gets or Sets Tickers
    /// </summary>
    [JsonPropertyName("tickers")]
    public List<ExternalContactsOrganizationChangedTopicTicker> Tickers { get; set; }



    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    [JsonPropertyName("twitterId")]
    public ExternalContactsOrganizationChangedTopicTwitterId TwitterId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalSystemUrl
    /// </summary>
    [JsonPropertyName("externalSystemUrl")]
    public string ExternalSystemUrl { get; set; }



    /// <summary>
    /// Gets or Sets CustomFields
    /// </summary>
    [JsonPropertyName("customFields")]
    public Dictionary<string, object> CustomFields { get; set; }



    /// <summary>
    /// Gets or Sets CreateDate
    /// </summary>
    [JsonPropertyName("createDate")]
    public DateTime? CreateDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifyDate
    /// </summary>
    [JsonPropertyName("modifyDate")]
    public DateTime? ModifyDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsOrganizationChangedTopicExternalOrganization {\n");

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
        return Equals(obj as ExternalContactsOrganizationChangedTopicExternalOrganization);
    }

    /// <summary>
    /// Returns true if ExternalContactsOrganizationChangedTopicExternalOrganization instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsOrganizationChangedTopicExternalOrganization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsOrganizationChangedTopicExternalOrganization other)
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
