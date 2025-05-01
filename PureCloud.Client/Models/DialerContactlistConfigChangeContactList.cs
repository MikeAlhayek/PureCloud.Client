using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContactlistConfigChangeContactList
/// </summary>
[DataContract]
public partial class DialerContactlistConfigChangeContactList : IEquatable<DialerContactlistConfigChangeContactList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContactlistConfigChangeContactList" /> class.
    /// </summary>
    /// <param name="ColumnNames">the contact column names.</param>
    /// <param name="PhoneColumns">the columns containing phone numbers.</param>
    /// <param name="EmailColumns">the columns containing email addresses.</param>
    /// <param name="ImportStatus">ImportStatus.</param>
    /// <param name="PreviewModeColumnName">the name of the column that holds the indicators for contacts that are to be dialed in preview mode only.</param>
    /// <param name="PreviewModeAcceptedValues">list of user-defined values indicating the contact is to be dialed in preview mode only.</param>
    /// <param name="Size">the number of contacts in the contact list.</param>
    /// <param name="AttemptLimits">AttemptLimits.</param>
    /// <param name="AutomaticTimeZoneMapping">whether or not automatic time zone mapping is enabled on the list.</param>
    /// <param name="ZipCodeColumnName">zip code column from the contact list to be used optionally with automatic time zone mapping.</param>
    /// <param name="Division">A UriReference for a resource.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerContactlistConfigChangeContactList(List<string> ColumnNames = null, List<DialerContactlistConfigChangeContactPhoneNumberColumn> PhoneColumns = null, List<DialerContactlistConfigChangeEmailColumn> EmailColumns = null, DialerContactlistConfigChangeImportStatus ImportStatus = null, string PreviewModeColumnName = null, List<string> PreviewModeAcceptedValues = null, long? Size = null, DialerContactlistConfigChangeUriReference AttemptLimits = null, bool? AutomaticTimeZoneMapping = null, string ZipCodeColumnName = null, DialerContactlistConfigChangeUriReference Division = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
        this.ColumnNames = ColumnNames;
        this.PhoneColumns = PhoneColumns;
        this.EmailColumns = EmailColumns;
        this.ImportStatus = ImportStatus;
        this.PreviewModeColumnName = PreviewModeColumnName;
        this.PreviewModeAcceptedValues = PreviewModeAcceptedValues;
        this.Size = Size;
        this.AttemptLimits = AttemptLimits;
        this.AutomaticTimeZoneMapping = AutomaticTimeZoneMapping;
        this.ZipCodeColumnName = ZipCodeColumnName;
        this.Division = Division;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// the contact column names
    /// </summary>
    /// <value>the contact column names</value>
    [DataMember(Name = "columnNames", EmitDefaultValue = false)]
    public List<string> ColumnNames { get; set; }



    /// <summary>
    /// the columns containing phone numbers
    /// </summary>
    /// <value>the columns containing phone numbers</value>
    [DataMember(Name = "phoneColumns", EmitDefaultValue = false)]
    public List<DialerContactlistConfigChangeContactPhoneNumberColumn> PhoneColumns { get; set; }



    /// <summary>
    /// the columns containing email addresses
    /// </summary>
    /// <value>the columns containing email addresses</value>
    [DataMember(Name = "emailColumns", EmitDefaultValue = false)]
    public List<DialerContactlistConfigChangeEmailColumn> EmailColumns { get; set; }



    /// <summary>
    /// Gets or Sets ImportStatus
    /// </summary>
    [DataMember(Name = "importStatus", EmitDefaultValue = false)]
    public DialerContactlistConfigChangeImportStatus ImportStatus { get; set; }



    /// <summary>
    /// the name of the column that holds the indicators for contacts that are to be dialed in preview mode only
    /// </summary>
    /// <value>the name of the column that holds the indicators for contacts that are to be dialed in preview mode only</value>
    [DataMember(Name = "previewModeColumnName", EmitDefaultValue = false)]
    public string PreviewModeColumnName { get; set; }



    /// <summary>
    /// list of user-defined values indicating the contact is to be dialed in preview mode only
    /// </summary>
    /// <value>list of user-defined values indicating the contact is to be dialed in preview mode only</value>
    [DataMember(Name = "previewModeAcceptedValues", EmitDefaultValue = false)]
    public List<string> PreviewModeAcceptedValues { get; set; }



    /// <summary>
    /// the number of contacts in the contact list
    /// </summary>
    /// <value>the number of contacts in the contact list</value>
    [DataMember(Name = "size", EmitDefaultValue = false)]
    public long? Size { get; set; }



    /// <summary>
    /// Gets or Sets AttemptLimits
    /// </summary>
    [DataMember(Name = "attemptLimits", EmitDefaultValue = false)]
    public DialerContactlistConfigChangeUriReference AttemptLimits { get; set; }



    /// <summary>
    /// whether or not automatic time zone mapping is enabled on the list
    /// </summary>
    /// <value>whether or not automatic time zone mapping is enabled on the list</value>
    [DataMember(Name = "automaticTimeZoneMapping", EmitDefaultValue = false)]
    public bool? AutomaticTimeZoneMapping { get; set; }



    /// <summary>
    /// zip code column from the contact list to be used optionally with automatic time zone mapping
    /// </summary>
    /// <value>zip code column from the contact list to be used optionally with automatic time zone mapping</value>
    [DataMember(Name = "zipCodeColumnName", EmitDefaultValue = false)]
    public string ZipCodeColumnName { get; set; }



    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    [DataMember(Name = "division", EmitDefaultValue = false)]
    public DialerContactlistConfigChangeUriReference Division { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerContactlistConfigChangeContactList {\n");

        sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
        sb.Append("  PhoneColumns: ").Append(PhoneColumns).Append("\n");
        sb.Append("  EmailColumns: ").Append(EmailColumns).Append("\n");
        sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
        sb.Append("  PreviewModeColumnName: ").Append(PreviewModeColumnName).Append("\n");
        sb.Append("  PreviewModeAcceptedValues: ").Append(PreviewModeAcceptedValues).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  AttemptLimits: ").Append(AttemptLimits).Append("\n");
        sb.Append("  AutomaticTimeZoneMapping: ").Append(AutomaticTimeZoneMapping).Append("\n");
        sb.Append("  ZipCodeColumnName: ").Append(ZipCodeColumnName).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerContactlistConfigChangeContactList);
    }

    /// <summary>
    /// Returns true if DialerContactlistConfigChangeContactList instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerContactlistConfigChangeContactList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerContactlistConfigChangeContactList other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

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

            return hash;
        }
    }
}
