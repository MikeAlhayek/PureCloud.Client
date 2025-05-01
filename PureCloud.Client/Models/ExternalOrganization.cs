using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalOrganization
/// </summary>
[DataContract]
public partial class ExternalOrganization : IEquatable<ExternalOrganization>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalOrganization" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExternalOrganization() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalOrganization" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The name of the company. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="CompanyType">CompanyType.</param>
    /// <param name="Industry">Industry.</param>
    /// <param name="Address">Address.</param>
    /// <param name="PhoneNumber">PhoneNumber.</param>
    /// <param name="FaxNumber">FaxNumber.</param>
    /// <param name="EmployeeCount">EmployeeCount.</param>
    /// <param name="Revenue">Revenue.</param>
    /// <param name="Tags">Tags.</param>
    /// <param name="Websites">Websites.</param>
    /// <param name="Tickers">Tickers.</param>
    /// <param name="TwitterId">TwitterId.</param>
    /// <param name="ExternalSystemUrl">A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace..</param>
    /// <param name="ModifyDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreateDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Trustor">Trustor.</param>
    /// <param name="Schema">The schema defining custom fields for this contact.</param>
    /// <param name="CustomFields">Custom fields defined in the schema referenced by schemaId and schemaVersion..</param>
    public ExternalOrganization(string Id = null, string Name = null, WritableStarrableDivision Division = null, string CompanyType = null, string Industry = null, ContactAddress Address = null, PhoneNumber PhoneNumber = null, PhoneNumber FaxNumber = null, long? EmployeeCount = null, long? Revenue = null, List<string> Tags = null, List<string> Websites = null, List<Ticker> Tickers = null, TwitterId TwitterId = null, string ExternalSystemUrl = null, DateTime? ModifyDate = null, DateTime? CreateDate = null, Trustor Trustor = null, DataSchema Schema = null, Dictionary<string, object> CustomFields = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Division = Division;
        this.CompanyType = CompanyType;
        this.Industry = Industry;
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
        this.ModifyDate = ModifyDate;
        this.CreateDate = CreateDate;
        this.Trustor = Trustor;
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
    /// The name of the company.
    /// </summary>
    /// <value>The name of the company.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public WritableStarrableDivision Division { get; set; }



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
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public ContactAddress Address { get; set; }



    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public PhoneNumber PhoneNumber { get; set; }



    /// <summary>
    /// Gets or Sets FaxNumber
    /// </summary>
    [DataMember(Name = "faxNumber", EmitDefaultValue = false)]
    public PhoneNumber FaxNumber { get; set; }



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
    public List<Ticker> Tickers { get; set; }



    /// <summary>
    /// Gets or Sets TwitterId
    /// </summary>
    [DataMember(Name = "twitterId", EmitDefaultValue = false)]
    public TwitterId TwitterId { get; set; }



    /// <summary>
    /// A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.
    /// </summary>
    /// <value>A string that identifies an external system-of-record resource that may have more detailed information on the organization. It should be a valid URL (including the http/https protocol, port, and path [if any]). The value is automatically trimmed of any leading and trailing whitespace.</value>
    [DataMember(Name = "externalSystemUrl", EmitDefaultValue = false)]
    public string ExternalSystemUrl { get; set; }



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
    /// Gets or Sets Trustor
    /// </summary>
    [DataMember(Name = "trustor", EmitDefaultValue = false)]
    public Trustor Trustor { get; set; }



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
        sb.Append("class ExternalOrganization {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  CompanyType: ").Append(CompanyType).Append("\n");
        sb.Append("  Industry: ").Append(Industry).Append("\n");
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
        sb.Append("  ModifyDate: ").Append(ModifyDate).Append("\n");
        sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
        sb.Append("  Trustor: ").Append(Trustor).Append("\n");
        sb.Append("  Schema: ").Append(Schema).Append("\n");
        sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
        sb.Append("  ExternalDataSources: ").Append(ExternalDataSources).Append("\n");
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
        return Equals(obj as ExternalOrganization);
    }

    /// <summary>
    /// Returns true if ExternalOrganization instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalOrganization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalOrganization other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
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
                Trustor == other.Trustor ||
                Trustor != null &&
                Trustor.Equals(other.Trustor)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (CompanyType != null)
            {
                hash = hash * 59 + CompanyType.GetHashCode();
            }

            if (Industry != null)
            {
                hash = hash * 59 + Industry.GetHashCode();
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

            if (ModifyDate != null)
            {
                hash = hash * 59 + ModifyDate.GetHashCode();
            }

            if (CreateDate != null)
            {
                hash = hash * 59 + CreateDate.GetHashCode();
            }

            if (Trustor != null)
            {
                hash = hash * 59 + Trustor.GetHashCode();
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
