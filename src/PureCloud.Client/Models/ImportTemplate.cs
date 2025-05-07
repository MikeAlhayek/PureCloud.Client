using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ImportTemplate
/// </summary>

public partial class ImportTemplate : IEquatable<ImportTemplate>
{
    /// <summary>
    /// The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required.
    /// </summary>
    /// <value>The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required.</value>
    
    public enum ListNameFormatEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Listnameprefix for "ListNamePrefix"
        /// </summary>
        [EnumMember(Value = "ListNamePrefix")]
        Listnameprefix,

        /// <summary>
        /// Enum Listnameprefixmonthdayyear for "ListNamePrefixMonthDayYear"
        /// </summary>
        [EnumMember(Value = "ListNamePrefixMonthDayYear")]
        Listnameprefixmonthdayyear,

        /// <summary>
        /// Enum Listnameprefixmonthdayyearhourminutesecond for "ListNamePrefixMonthDayYearHourMinuteSecond"
        /// </summary>
        [EnumMember(Value = "ListNamePrefixMonthDayYearHourMinuteSecond")]
        Listnameprefixmonthdayyearhourminutesecond,

        /// <summary>
        /// Enum Listnameprefixpart for "ListNamePrefixPart"
        /// </summary>
        [EnumMember(Value = "ListNamePrefixPart")]
        Listnameprefixpart,

        /// <summary>
        /// Enum Listnameprefixmonthdayyearpart for "ListNamePrefixMonthDayYearPart"
        /// </summary>
        [EnumMember(Value = "ListNamePrefixMonthDayYearPart")]
        Listnameprefixmonthdayyearpart,

        /// <summary>
        /// Enum Listnameprefixmonthdayyearhourminutesecondpart for "ListNamePrefixMonthDayYearHourMinuteSecondPart"
        /// </summary>
        [EnumMember(Value = "ListNamePrefixMonthDayYearHourMinuteSecondPart")]
        Listnameprefixmonthdayyearhourminutesecondpart,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom
    }
    /// <summary>
    /// The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required.
    /// </summary>
    /// <value>The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required.</value>
    [JsonPropertyName("listNameFormat")]
    public ListNameFormatEnum? ListNameFormat { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ImportTemplate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ImportTemplate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ImportTemplate" /> class.
    /// </summary>
    /// <param name="Name">The name of the import template..</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="ContactListTemplate">ContactListTemplate for this ImportTemplate. (required).</param>
    /// <param name="ContactListFilter">ContactListFilter for this ImportTemplate..</param>
    /// <param name="UseSplittingCriteria">Whether or not to use splitting criteria. Default is false..</param>
    /// <param name="SplittingInformation">How to split contact records, required if useSplittingCriteria is true..</param>
    /// <param name="ListNameFormat">The list name format for target ContactLists. When Custom is provided, customListNameFormatValue is required..</param>
    /// <param name="CustomListNameFormatValue">Custom value for the list name format, at least %N is required. Any character other than the specified tokens will be used as is. Available tokens: %N: ListNamePrefix; %P: Part number; %F: Filter name; %C: Column value; YYYY: year; MM: month; DD: day; hh: hour; mm: minute; ss: second..</param>
    public ImportTemplate(string Name = null, int? Version = null, DomainEntityRef ContactListTemplate = null, DomainEntityRef ContactListFilter = null, bool? UseSplittingCriteria = null, SplittingInformation SplittingInformation = null, ListNameFormatEnum? ListNameFormat = null, string CustomListNameFormatValue = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.ContactListTemplate = ContactListTemplate;
        this.ContactListFilter = ContactListFilter;
        this.UseSplittingCriteria = UseSplittingCriteria;
        this.SplittingInformation = SplittingInformation;
        this.ListNameFormat = ListNameFormat;
        this.CustomListNameFormatValue = CustomListNameFormatValue;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the import template.
    /// </summary>
    /// <value>The name of the import template.</value>
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
    /// ContactListTemplate for this ImportTemplate.
    /// </summary>
    /// <value>ContactListTemplate for this ImportTemplate.</value>
    [JsonPropertyName("contactListTemplate")]
    public DomainEntityRef ContactListTemplate { get; set; }



    /// <summary>
    /// ContactListFilter for this ImportTemplate.
    /// </summary>
    /// <value>ContactListFilter for this ImportTemplate.</value>
    [JsonPropertyName("contactListFilter")]
    public DomainEntityRef ContactListFilter { get; set; }



    /// <summary>
    /// Whether or not to use splitting criteria. Default is false.
    /// </summary>
    /// <value>Whether or not to use splitting criteria. Default is false.</value>
    [JsonPropertyName("useSplittingCriteria")]
    public bool? UseSplittingCriteria { get; set; }



    /// <summary>
    /// How to split contact records, required if useSplittingCriteria is true.
    /// </summary>
    /// <value>How to split contact records, required if useSplittingCriteria is true.</value>
    [JsonPropertyName("splittingInformation")]
    public SplittingInformation SplittingInformation { get; set; }





    /// <summary>
    /// Custom value for the list name format, at least %N is required. Any character other than the specified tokens will be used as is. Available tokens: %N: ListNamePrefix; %P: Part number; %F: Filter name; %C: Column value; YYYY: year; MM: month; DD: day; hh: hour; mm: minute; ss: second.
    /// </summary>
    /// <value>Custom value for the list name format, at least %N is required. Any character other than the specified tokens will be used as is. Available tokens: %N: ListNamePrefix; %P: Part number; %F: Filter name; %C: Column value; YYYY: year; MM: month; DD: day; hh: hour; mm: minute; ss: second.</value>
    [JsonPropertyName("customListNameFormatValue")]
    public string CustomListNameFormatValue { get; set; }



    /// <summary>
    /// The status of the import process.
    /// </summary>
    /// <value>The status of the import process.</value>
    [JsonPropertyName("importStatus")]
    public ImportStatus ImportStatus { get; set; }



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
        sb.Append("class ImportTemplate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ContactListTemplate: ").Append(ContactListTemplate).Append("\n");
        sb.Append("  ContactListFilter: ").Append(ContactListFilter).Append("\n");
        sb.Append("  UseSplittingCriteria: ").Append(UseSplittingCriteria).Append("\n");
        sb.Append("  SplittingInformation: ").Append(SplittingInformation).Append("\n");
        sb.Append("  ListNameFormat: ").Append(ListNameFormat).Append("\n");
        sb.Append("  CustomListNameFormatValue: ").Append(CustomListNameFormatValue).Append("\n");
        sb.Append("  ImportStatus: ").Append(ImportStatus).Append("\n");
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
        return Equals(obj as ImportTemplate);
    }

    /// <summary>
    /// Returns true if ImportTemplate instances are equal
    /// </summary>
    /// <param name="other">Instance of ImportTemplate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ImportTemplate other)
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
                ContactListTemplate == other.ContactListTemplate ||
                ContactListTemplate != null &&
                ContactListTemplate.Equals(other.ContactListTemplate)
            ) &&
            (
                ContactListFilter == other.ContactListFilter ||
                ContactListFilter != null &&
                ContactListFilter.Equals(other.ContactListFilter)
            ) &&
            (
                UseSplittingCriteria == other.UseSplittingCriteria ||
                UseSplittingCriteria != null &&
                UseSplittingCriteria.Equals(other.UseSplittingCriteria)
            ) &&
            (
                SplittingInformation == other.SplittingInformation ||
                SplittingInformation != null &&
                SplittingInformation.Equals(other.SplittingInformation)
            ) &&
            (
                ListNameFormat == other.ListNameFormat ||
                ListNameFormat != null &&
                ListNameFormat.Equals(other.ListNameFormat)
            ) &&
            (
                CustomListNameFormatValue == other.CustomListNameFormatValue ||
                CustomListNameFormatValue != null &&
                CustomListNameFormatValue.Equals(other.CustomListNameFormatValue)
            ) &&
            (
                ImportStatus == other.ImportStatus ||
                ImportStatus != null &&
                ImportStatus.Equals(other.ImportStatus)
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

            if (ContactListTemplate != null)
            {
                hash = hash * 59 + ContactListTemplate.GetHashCode();
            }

            if (ContactListFilter != null)
            {
                hash = hash * 59 + ContactListFilter.GetHashCode();
            }

            if (UseSplittingCriteria != null)
            {
                hash = hash * 59 + UseSplittingCriteria.GetHashCode();
            }

            if (SplittingInformation != null)
            {
                hash = hash * 59 + SplittingInformation.GetHashCode();
            }

            if (ListNameFormat != null)
            {
                hash = hash * 59 + ListNameFormat.GetHashCode();
            }

            if (CustomListNameFormatValue != null)
            {
                hash = hash * 59 + CustomListNameFormatValue.GetHashCode();
            }

            if (ImportStatus != null)
            {
                hash = hash * 59 + ImportStatus.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
