using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactListTemplate
/// </summary>
[DataContract]
public partial class ContactListTemplate : IEquatable<ContactListTemplate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactListTemplate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactListTemplate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactListTemplate" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="ColumnNames">The names of the contact data columns. (required).</param>
    /// <param name="PhoneColumns">Indicates which columns are phone numbers..</param>
    /// <param name="EmailColumns">Indicates which columns are email addresses.</param>
    /// <param name="WhatsAppColumns">Indicates which columns are whatsApp contacts.</param>
    /// <param name="PreviewModeColumnName">A column to check if a contact should always be dialed in preview mode..</param>
    /// <param name="PreviewModeAcceptedValues">The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode..</param>
    /// <param name="AttemptLimits">AttemptLimits for this ContactListTemplate..</param>
    /// <param name="AutomaticTimeZoneMapping">Indicates if automatic time zone mapping is to be used for this ContactListTemplate..</param>
    /// <param name="ZipCodeColumnName">The name of ContactListTemplate column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true..</param>
    /// <param name="ColumnDataTypeSpecifications">The settings of the columns selected for dynamic queueing.</param>
    /// <param name="TrimWhitespace">Whether to trim white space when importing a ContactListTemplate csv file, default value &#x3D; true.</param>
    public ContactListTemplate(string Name = null, int? Version = null, List<string> ColumnNames = null, List<ContactPhoneNumberColumn> PhoneColumns = null, List<EmailColumn> EmailColumns = null, List<WhatsAppColumn> WhatsAppColumns = null, string PreviewModeColumnName = null, List<string> PreviewModeAcceptedValues = null, DomainEntityRef AttemptLimits = null, bool? AutomaticTimeZoneMapping = null, string ZipCodeColumnName = null, List<ColumnDataTypeSpecification> ColumnDataTypeSpecifications = null, bool? TrimWhitespace = null)
    {
        this.Name = Name;
        this.Version = Version;
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// The names of the contact data columns.
    /// </summary>
    /// <value>The names of the contact data columns.</value>
    [DataMember(Name = "columnNames", EmitDefaultValue = false)]
    public List<string> ColumnNames { get; set; }



    /// <summary>
    /// Indicates which columns are phone numbers.
    /// </summary>
    /// <value>Indicates which columns are phone numbers.</value>
    [DataMember(Name = "phoneColumns", EmitDefaultValue = false)]
    public List<ContactPhoneNumberColumn> PhoneColumns { get; set; }



    /// <summary>
    /// Indicates which columns are email addresses
    /// </summary>
    /// <value>Indicates which columns are email addresses</value>
    [DataMember(Name = "emailColumns", EmitDefaultValue = false)]
    public List<EmailColumn> EmailColumns { get; set; }



    /// <summary>
    /// Indicates which columns are whatsApp contacts
    /// </summary>
    /// <value>Indicates which columns are whatsApp contacts</value>
    [DataMember(Name = "whatsAppColumns", EmitDefaultValue = false)]
    public List<WhatsAppColumn> WhatsAppColumns { get; set; }



    /// <summary>
    /// A column to check if a contact should always be dialed in preview mode.
    /// </summary>
    /// <value>A column to check if a contact should always be dialed in preview mode.</value>
    [DataMember(Name = "previewModeColumnName", EmitDefaultValue = false)]
    public string PreviewModeColumnName { get; set; }



    /// <summary>
    /// The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode.
    /// </summary>
    /// <value>The values in the previewModeColumnName column that indicate a contact should always be dialed in preview mode.</value>
    [DataMember(Name = "previewModeAcceptedValues", EmitDefaultValue = false)]
    public List<string> PreviewModeAcceptedValues { get; set; }



    /// <summary>
    /// AttemptLimits for this ContactListTemplate.
    /// </summary>
    /// <value>AttemptLimits for this ContactListTemplate.</value>
    [DataMember(Name = "attemptLimits", EmitDefaultValue = false)]
    public DomainEntityRef AttemptLimits { get; set; }



    /// <summary>
    /// Indicates if automatic time zone mapping is to be used for this ContactListTemplate.
    /// </summary>
    /// <value>Indicates if automatic time zone mapping is to be used for this ContactListTemplate.</value>
    [DataMember(Name = "automaticTimeZoneMapping", EmitDefaultValue = false)]
    public bool? AutomaticTimeZoneMapping { get; set; }



    /// <summary>
    /// The name of ContactListTemplate column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true.
    /// </summary>
    /// <value>The name of ContactListTemplate column containing the zip code for use with automatic time zone mapping. Only allowed if &#39;automaticTimeZoneMapping&#39; is set to true.</value>
    [DataMember(Name = "zipCodeColumnName", EmitDefaultValue = false)]
    public string ZipCodeColumnName { get; set; }



    /// <summary>
    /// The settings of the columns selected for dynamic queueing
    /// </summary>
    /// <value>The settings of the columns selected for dynamic queueing</value>
    [DataMember(Name = "columnDataTypeSpecifications", EmitDefaultValue = false)]
    public List<ColumnDataTypeSpecification> ColumnDataTypeSpecifications { get; set; }



    /// <summary>
    /// Whether to trim white space when importing a ContactListTemplate csv file, default value &#x3D; true
    /// </summary>
    /// <value>Whether to trim white space when importing a ContactListTemplate csv file, default value &#x3D; true</value>
    [DataMember(Name = "trimWhitespace", EmitDefaultValue = false)]
    public bool? TrimWhitespace { get; set; }



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
        sb.Append("class ContactListTemplate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
        sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
        sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
        sb.Append("  WhatsAppColumns: ").Append(WhatsAppColumns).Append("\n");
        sb.Append("  PreviewModeColumnName: ").Append(PreviewModeColumnName).Append("\n");
        sb.Append("  PreviewModeAcceptedValues: ").Append(PreviewModeAcceptedValues).Append("\n");
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
        return Equals(obj as ContactListTemplate);
    }

    /// <summary>
    /// Returns true if ContactListTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactListTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactListTemplate other)
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

            if (PreviewModeColumnName != null)
            {
                hash = hash * 59 + PreviewModeColumnName.GetHashCode();
            }

            if (PreviewModeAcceptedValues != null)
            {
                hash = hash * 59 + PreviewModeAcceptedValues.GetHashCode();
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
