using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactList
/// </summary>

public partial class ContactList : IEquatable<ContactList>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactList" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactList() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactList" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="Division">The division this entity belongs to..</param>
    /// <param name="ColumnNames">The names of the contact data columns. (required).</param>
    /// <param name="PhoneColumns">Indicates which columns are phone numbers..</param>
    /// <param name="EmailColumns">Indicates which columns are email addresses.</param>
    /// <param name="WhatsAppColumns">Indicates which columns are whatsApp contacts.</param>
    /// <param name="PreviewModeColumnName">A column to check if a contact should always be dialed in preview mode..</param>
    /// <param name="PreviewModeAcceptedValues">The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode..</param>
    /// <param name="AttemptLimits">AttemptLimits for this ContactList..</param>
    /// <param name="AutomaticTimeZoneMapping">Indicates if automatic time zone mapping is to be used for this ContactList..</param>
    /// <param name="ZipCodeColumnName">The name of contact list column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true..</param>
    /// <param name="ColumnDataTypeSpecifications">The settings of the columns selected for dynamic queueing.</param>
    /// <param name="TrimWhitespace">Whether to trim white space when importing a contactlist csv file, default value &#x3D; true.</param>
    public ContactList(string Name = null, int? Version = null, DomainEntityRef Division = null, List<string> ColumnNames = null, List<ContactPhoneNumberColumn> PhoneColumns = null, List<EmailColumn> EmailColumns = null, List<WhatsAppColumn> WhatsAppColumns = null, string PreviewModeColumnName = null, List<string> PreviewModeAcceptedValues = null, DomainEntityRef AttemptLimits = null, bool? AutomaticTimeZoneMapping = null, string ZipCodeColumnName = null, List<ColumnDataTypeSpecification> ColumnDataTypeSpecifications = null, bool? TrimWhitespace = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.Division = Division;
        this.ColumnNames = ColumnNames;
        this.PhoneColumns = PhoneColumns;
        this.EmailColumns = EmailColumns;
        this.WhatsAppColumns = WhatsAppColumns;
        this.PreviewModeColumnName = PreviewModeColumnName;
        this.PreviewModeAcceptedValues = PreviewModeAcceptedValues;
        this.AttemptLimits = AttemptLimits;
        this.AutomaticTimeZoneMapping = AutomaticTimeZoneMapping;
        this.ZipCodeColumnName = ZipCodeColumnName;
        this.ColumnDataTypeSpecifications = ColumnDataTypeSpecifications;
        this.TrimWhitespace = TrimWhitespace;

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
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The division this entity belongs to.
    /// </summary>
    /// <value>The division this entity belongs to.</value>
    [JsonPropertyName("division")]
    public DomainEntityRef Division { get; set; }



    /// <summary>
    /// The names of the contact data columns.
    /// </summary>
    /// <value>The names of the contact data columns.</value>
    [JsonPropertyName("columnNames")]
    public List<string> ColumnNames { get; set; }



    /// <summary>
    /// Indicates which columns are phone numbers.
    /// </summary>
    /// <value>Indicates which columns are phone numbers.</value>
    [JsonPropertyName("phoneColumns")]
    public List<ContactPhoneNumberColumn> PhoneColumns { get; set; }



    /// <summary>
    /// Indicates which columns are email addresses
    /// </summary>
    /// <value>Indicates which columns are email addresses</value>
    [JsonPropertyName("emailColumns")]
    public List<EmailColumn> EmailColumns { get; set; }



    /// <summary>
    /// Indicates which columns are whatsApp contacts
    /// </summary>
    /// <value>Indicates which columns are whatsApp contacts</value>
    [JsonPropertyName("whatsAppColumns")]
    public List<WhatsAppColumn> WhatsAppColumns { get; set; }



    /// <summary>
    /// The status of the import process.
    /// </summary>
    /// <value>The status of the import process.</value>
    [JsonPropertyName("importStatus")]
    public ImportStatus ImportStatus { get; set; }



    /// <summary>
    /// A column to check if a contact should always be dialed in preview mode.
    /// </summary>
    /// <value>A column to check if a contact should always be dialed in preview mode.</value>
    [JsonPropertyName("previewModeColumnName")]
    public string PreviewModeColumnName { get; set; }



    /// <summary>
    /// The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode.
    /// </summary>
    /// <value>The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode.</value>
    [JsonPropertyName("previewModeAcceptedValues")]
    public List<string> PreviewModeAcceptedValues { get; set; }



    /// <summary>
    /// The number of contacts in the ContactList.
    /// </summary>
    /// <value>The number of contacts in the ContactList.</value>
    [JsonPropertyName("size")]
    public long? Size { get; set; }



    /// <summary>
    /// AttemptLimits for this ContactList.
    /// </summary>
    /// <value>AttemptLimits for this ContactList.</value>
    [JsonPropertyName("attemptLimits")]
    public DomainEntityRef AttemptLimits { get; set; }



    /// <summary>
    /// Indicates if automatic time zone mapping is to be used for this ContactList.
    /// </summary>
    /// <value>Indicates if automatic time zone mapping is to be used for this ContactList.</value>
    [JsonPropertyName("automaticTimeZoneMapping")]
    public bool? AutomaticTimeZoneMapping { get; set; }



    /// <summary>
    /// The name of contact list column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true.
    /// </summary>
    /// <value>The name of contact list column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true.</value>
    [JsonPropertyName("zipCodeColumnName")]
    public string ZipCodeColumnName { get; set; }



    /// <summary>
    /// The settings of the columns selected for dynamic queueing
    /// </summary>
    /// <value>The settings of the columns selected for dynamic queueing</value>
    [JsonPropertyName("columnDataTypeSpecifications")]
    public List<ColumnDataTypeSpecification> ColumnDataTypeSpecifications { get; set; }



    /// <summary>
    /// Whether to trim white space when importing a contactlist csv file, default value &#x3D; true
    /// </summary>
    /// <value>Whether to trim white space when importing a contactlist csv file, default value &#x3D; true</value>
    [JsonPropertyName("trimWhitespace")]
    public bool? TrimWhitespace { get; set; }



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
        sb.Append("class ContactList {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
        sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
        sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
        sb.Append("  WhatsAppColumns: ").Append(WhatsAppColumns).Append("\n");
        sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
        sb.Append("  PreviewModeColumnName: ").Append(PreviewModeColumnName).Append("\n");
        sb.Append("  PreviewModeAcceptedValues: ").Append(PreviewModeAcceptedValues).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  AttemptLimits: ").Append(AttemptLimits).Append("\n");
        sb.Append("  AutomaticTimeZoneMapping: ").Append(AutomaticTimeZoneMapping).Append("\n");
        sb.Append("  ZipCodeColumnName: ").Append(ZipCodeColumnName).Append("\n");
        sb.Append("  ColumnDataTypeSpecifications: ").Append(ColumnDataTypeSpecifications).Append("\n");
        sb.Append("  TrimWhitespace: ").Append(TrimWhitespace).Append("\n");
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
        return Equals(obj as ContactList);
    }

    /// <summary>
    /// Returns true if ContactList instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactList other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                ColumnNames == other.ColumnNames ||
                ColumnNames != null &&
                ColumnNames.SequenceEqual(other.ColumnNames)
            ) &&
            (
                PhoneColumns == other.PhoneColumns ||
                PhoneColumns != null &&
                PhoneColumns.SequenceEqual(other.PhoneColumns)
            ) &&
            (
                EmailColumns == other.EmailColumns ||
                EmailColumns != null &&
                EmailColumns.SequenceEqual(other.EmailColumns)
            ) &&
            (
                WhatsAppColumns == other.WhatsAppColumns ||
                WhatsAppColumns != null &&
                WhatsAppColumns.SequenceEqual(other.WhatsAppColumns)
            ) &&
            (
                ImportStatus == other.ImportStatus ||
                ImportStatus != null &&
                ImportStatus.Equals(other.ImportStatus)
            ) &&
            (
                PreviewModeColumnName == other.PreviewModeColumnName ||
                PreviewModeColumnName != null &&
                PreviewModeColumnName.Equals(other.PreviewModeColumnName)
            ) &&
            (
                PreviewModeAcceptedValues == other.PreviewModeAcceptedValues ||
                PreviewModeAcceptedValues != null &&
                PreviewModeAcceptedValues.SequenceEqual(other.PreviewModeAcceptedValues)
            ) &&
            (
                Size == other.Size ||
                Size != null &&
                Size.Equals(other.Size)
            ) &&
            (
                AttemptLimits == other.AttemptLimits ||
                AttemptLimits != null &&
                AttemptLimits.Equals(other.AttemptLimits)
            ) &&
            (
                AutomaticTimeZoneMapping == other.AutomaticTimeZoneMapping ||
                AutomaticTimeZoneMapping != null &&
                AutomaticTimeZoneMapping.Equals(other.AutomaticTimeZoneMapping)
            ) &&
            (
                ZipCodeColumnName == other.ZipCodeColumnName ||
                ZipCodeColumnName != null &&
                ZipCodeColumnName.Equals(other.ZipCodeColumnName)
            ) &&
            (
                ColumnDataTypeSpecifications == other.ColumnDataTypeSpecifications ||
                ColumnDataTypeSpecifications != null &&
                ColumnDataTypeSpecifications.SequenceEqual(other.ColumnDataTypeSpecifications)
            ) &&
            (
                TrimWhitespace == other.TrimWhitespace ||
                TrimWhitespace != null &&
                TrimWhitespace.Equals(other.TrimWhitespace)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (ColumnNames != null)
            {
                hash = hash * 59 + ColumnNames.GetHashCode();
            }

            if (PhoneColumns != null)
            {
                hash = hash * 59 + PhoneColumns.GetHashCode();
            }

            if (EmailColumns != null)
            {
                hash = hash * 59 + EmailColumns.GetHashCode();
            }

            if (WhatsAppColumns != null)
            {
                hash = hash * 59 + WhatsAppColumns.GetHashCode();
            }

            if (ImportStatus != null)
            {
                hash = hash * 59 + ImportStatus.GetHashCode();
            }

            if (PreviewModeColumnName != null)
            {
                hash = hash * 59 + PreviewModeColumnName.GetHashCode();
            }

            if (PreviewModeAcceptedValues != null)
            {
                hash = hash * 59 + PreviewModeAcceptedValues.GetHashCode();
            }

            if (Size != null)
            {
                hash = hash * 59 + Size.GetHashCode();
            }

            if (AttemptLimits != null)
            {
                hash = hash * 59 + AttemptLimits.GetHashCode();
            }

            if (AutomaticTimeZoneMapping != null)
            {
                hash = hash * 59 + AutomaticTimeZoneMapping.GetHashCode();
            }

            if (ZipCodeColumnName != null)
            {
                hash = hash * 59 + ZipCodeColumnName.GetHashCode();
            }

            if (ColumnDataTypeSpecifications != null)
            {
                hash = hash * 59 + ColumnDataTypeSpecifications.GetHashCode();
            }

            if (TrimWhitespace != null)
            {
                hash = hash * 59 + TrimWhitespace.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
