using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsPhoneNumber
/// </summary>
[DataContract]
public partial class SmsPhoneNumber : IEquatable<SmsPhoneNumber>
{
    /// <summary>
    /// Type of the phone number provisioned.
    /// </summary>
    /// <value>Type of the phone number provisioned.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneNumberTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Local for "local"
        /// </summary>
        [EnumMember(Value = "local")]
        Local,

        /// <summary>
        /// Enum Mobile for "mobile"
        /// </summary>
        [EnumMember(Value = "mobile")]
        Mobile,

        /// <summary>
        /// Enum Tollfree for "tollfree"
        /// </summary>
        [EnumMember(Value = "tollfree")]
        Tollfree,

        /// <summary>
        /// Enum Shortcode for "shortcode"
        /// </summary>
        [EnumMember(Value = "shortcode")]
        Shortcode,

        /// <summary>
        /// Enum Alphanumeric for "alphanumeric"
        /// </summary>
        [EnumMember(Value = "alphanumeric")]
        Alphanumeric
    }
    /// <summary>
    /// Status of the provisioned phone number.
    /// </summary>
    /// <value>Status of the provisioned phone number.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PhoneNumberStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Invalid for "INVALID"
        /// </summary>
        [EnumMember(Value = "INVALID")]
        Invalid,

        /// <summary>
        /// Enum Active for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Enum Porting for "PORTING"
        /// </summary>
        [EnumMember(Value = "PORTING")]
        Porting,

        /// <summary>
        /// Enum Pending for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Enum PendingCancellation for "PENDING_CANCELLATION"
        /// </summary>
        [EnumMember(Value = "PENDING_CANCELLATION")]
        PendingCancellation,

        /// <summary>
        /// Enum Initiated for "INITIATED"
        /// </summary>
        [EnumMember(Value = "INITIATED")]
        Initiated
    }
    /// <summary>
    /// Gets or Sets Capabilities
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CapabilitiesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sms for "sms"
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,

        /// <summary>
        /// Enum Mms for "mms"
        /// </summary>
        [EnumMember(Value = "mms")]
        Mms,

        /// <summary>
        /// Enum Voice for "voice"
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice
    }
    /// <summary>
    /// Renewal time period of this phone number, if the phoneNumberType is shortcode.
    /// </summary>
    /// <value>Renewal time period of this phone number, if the phoneNumberType is shortcode.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AutoRenewableEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Quarterly for "Quarterly"
        /// </summary>
        [EnumMember(Value = "Quarterly")]
        Quarterly
    }
    /// <summary>
    /// BillingType of this phone number, if the phoneNumberType is shortcode.
    /// </summary>
    /// <value>BillingType of this phone number, if the phoneNumberType is shortcode.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ShortCodeBillingTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Basic for "Basic"
        /// </summary>
        [EnumMember(Value = "Basic")]
        Basic,

        /// <summary>
        /// Enum Vanity for "Vanity"
        /// </summary>
        [EnumMember(Value = "Vanity")]
        Vanity
    }
    /// <summary>
    /// Type of the phone number provisioned.
    /// </summary>
    /// <value>Type of the phone number provisioned.</value>
    [DataMember(Name = "phoneNumberType", EmitDefaultValue = false)]
    public PhoneNumberTypeEnum? PhoneNumberType { get; private set; }
    /// <summary>
    /// Status of the provisioned phone number.
    /// </summary>
    /// <value>Status of the provisioned phone number.</value>
    [DataMember(Name = "phoneNumberStatus", EmitDefaultValue = false)]
    public PhoneNumberStatusEnum? PhoneNumberStatus { get; set; }
    /// <summary>
    /// Renewal time period of this phone number, if the phoneNumberType is shortcode.
    /// </summary>
    /// <value>Renewal time period of this phone number, if the phoneNumberType is shortcode.</value>
    [DataMember(Name = "autoRenewable", EmitDefaultValue = false)]
    public AutoRenewableEnum? AutoRenewable { get; set; }
    /// <summary>
    /// BillingType of this phone number, if the phoneNumberType is shortcode.
    /// </summary>
    /// <value>BillingType of this phone number, if the phoneNumberType is shortcode.</value>
    [DataMember(Name = "shortCodeBillingType", EmitDefaultValue = false)]
    public ShortCodeBillingTypeEnum? ShortCodeBillingType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmsPhoneNumber" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SmsPhoneNumber() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsPhoneNumber" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="PhoneNumber">A phone number provisioned for SMS communications. (required).</param>
    /// <param name="ProvisionedThroughPureCloud">Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud.</param>
    /// <param name="PhoneNumberStatus">Status of the provisioned phone number..</param>
    /// <param name="CountryCode">The ISO 3166-1 alpha-2 country code of the country this phone number is associated with..</param>
    /// <param name="DateCreated">Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">User that provisioned this phone number.</param>
    /// <param name="ModifiedBy">User that last modified this phone number.</param>
    /// <param name="Version">Version number required for updates. (required).</param>
    /// <param name="PurchaseDate">Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CancellationDate">Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="RenewalDate">Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AutoRenewable">Renewal time period of this phone number, if the phoneNumberType is shortcode..</param>
    /// <param name="AddressId">The id of an address attached to this phone number..</param>
    /// <param name="ShortCodeBillingType">BillingType of this phone number, if the phoneNumberType is shortcode..</param>
    /// <param name="ProvisioningStatus">Status of latest asynchronous provisioning action.</param>
    /// <param name="Country">Localized country name for the country code this phone number belongs too.</param>
    /// <param name="SupportsSms">Set to true if this phone number has the capability to support SMS.</param>
    /// <param name="SupportsMms">Set to true if this phone number has the capability to support MMS.</param>
    /// <param name="SupportsVoice">Set to true if this phone number has the capability to support voice.</param>
    /// <param name="Integration">The Genesys Cloud integration this phone number belongs to..</param>
    /// <param name="Compliance">Compliance configuration for short codes, including help, stop and opt in..</param>
    public SmsPhoneNumber(string Name = null, string PhoneNumber = null, bool? ProvisionedThroughPureCloudEnvironment = null, PhoneNumberStatusEnum? PhoneNumberStatus = null, string CountryCode = null, DateTime? DateCreated = null, DateTime? DateModified = null, User CreatedBy = null, User ModifiedBy = null, int? Version = null, DateTime? PurchaseDate = null, DateTime? CancellationDate = null, DateTime? RenewalDate = null, AutoRenewableEnum? AutoRenewable = null, SmsAddress AddressId = null, ShortCodeBillingTypeEnum? ShortCodeBillingType = null, SmsProvisioningStatus ProvisioningStatus = null, string Country = null, bool? SupportsSms = null, bool? SupportsMms = null, bool? SupportsVoice = null, DomainEntityRef Integration = null, Compliance Compliance = null)
    {
        this.Name = Name;
        this.PhoneNumber = PhoneNumber;
        this.ProvisionedThroughPureCloudEnvironment = ProvisionedThroughPureCloudEnvironment;
        this.PhoneNumberStatus = PhoneNumberStatus;
        this.CountryCode = CountryCode;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.CreatedBy = CreatedBy;
        this.ModifiedBy = ModifiedBy;
        this.Version = Version;
        this.PurchaseDate = PurchaseDate;
        this.CancellationDate = CancellationDate;
        this.RenewalDate = RenewalDate;
        this.AutoRenewable = AutoRenewable;
        this.AddressId = AddressId;
        this.ShortCodeBillingType = ShortCodeBillingType;
        this.ProvisioningStatus = ProvisioningStatus;
        this.Country = Country;
        this.SupportsSms = SupportsSms;
        this.SupportsMms = SupportsMms;
        this.SupportsVoice = SupportsVoice;
        this.Integration = Integration;
        this.Compliance = Compliance;

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
    /// A phone number provisioned for SMS communications.
    /// </summary>
    /// <value>A phone number provisioned for SMS communications.</value>
    [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
    public string PhoneNumber { get; set; }





    /// <summary>
    /// Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud
    /// </summary>
    /// <value>Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud</value>
    [DataMember(Name = "provisionedThroughPureCloud", EmitDefaultValue = false)]
    public bool? ProvisionedThroughPureCloudEnvironment { get; set; }





    /// <summary>
    /// The capabilities of the phone number available for provisioning.
    /// </summary>
    /// <value>The capabilities of the phone number available for provisioning.</value>
    [DataMember(Name = "capabilities", EmitDefaultValue = false)]
    public List<CapabilitiesEnum> Capabilities { get; private set; }



    /// <summary>
    /// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
    /// </summary>
    /// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
    [DataMember(Name = "countryCode", EmitDefaultValue = false)]
    public string CountryCode { get; set; }



    /// <summary>
    /// Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// User that provisioned this phone number
    /// </summary>
    /// <value>User that provisioned this phone number</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public User CreatedBy { get; set; }



    /// <summary>
    /// User that last modified this phone number
    /// </summary>
    /// <value>User that last modified this phone number</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public User ModifiedBy { get; set; }



    /// <summary>
    /// Version number required for updates.
    /// </summary>
    /// <value>Version number required for updates.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "purchaseDate", EmitDefaultValue = false)]
    public DateTime? PurchaseDate { get; set; }



    /// <summary>
    /// Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "cancellationDate", EmitDefaultValue = false)]
    public DateTime? CancellationDate { get; set; }



    /// <summary>
    /// Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "renewalDate", EmitDefaultValue = false)]
    public DateTime? RenewalDate { get; set; }





    /// <summary>
    /// The id of an address attached to this phone number.
    /// </summary>
    /// <value>The id of an address attached to this phone number.</value>
    [DataMember(Name = "addressId", EmitDefaultValue = false)]
    public SmsAddress AddressId { get; set; }





    /// <summary>
    /// Status of latest asynchronous provisioning action
    /// </summary>
    /// <value>Status of latest asynchronous provisioning action</value>
    [DataMember(Name = "provisioningStatus", EmitDefaultValue = false)]
    public SmsProvisioningStatus ProvisioningStatus { get; set; }



    /// <summary>
    /// Localized country name for the country code this phone number belongs too
    /// </summary>
    /// <value>Localized country name for the country code this phone number belongs too</value>
    [DataMember(Name = "country", EmitDefaultValue = false)]
    public string Country { get; set; }



    /// <summary>
    /// Set to true if this phone number has the capability to support SMS
    /// </summary>
    /// <value>Set to true if this phone number has the capability to support SMS</value>
    [DataMember(Name = "supportsSms", EmitDefaultValue = false)]
    public bool? SupportsSms { get; set; }



    /// <summary>
    /// Set to true if this phone number has the capability to support MMS
    /// </summary>
    /// <value>Set to true if this phone number has the capability to support MMS</value>
    [DataMember(Name = "supportsMms", EmitDefaultValue = false)]
    public bool? SupportsMms { get; set; }



    /// <summary>
    /// Set to true if this phone number has the capability to support voice
    /// </summary>
    /// <value>Set to true if this phone number has the capability to support voice</value>
    [DataMember(Name = "supportsVoice", EmitDefaultValue = false)]
    public bool? SupportsVoice { get; set; }



    /// <summary>
    /// The Genesys Cloud integration this phone number belongs to.
    /// </summary>
    /// <value>The Genesys Cloud integration this phone number belongs to.</value>
    [DataMember(Name = "integration", EmitDefaultValue = false)]
    public DomainEntityRef Integration { get; set; }



    /// <summary>
    /// Compliance configuration for short codes, including help, stop and opt in.
    /// </summary>
    /// <value>Compliance configuration for short codes, including help, stop and opt in.</value>
    [DataMember(Name = "compliance", EmitDefaultValue = false)]
    public Compliance Compliance { get; set; }



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
        sb.Append("class SmsPhoneNumber {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
        sb.Append("  ProvisionedThroughPureCloud: ").Append(ProvisionedThroughPureCloudEnvironment).Append("\n");
        sb.Append("  PhoneNumberStatus: ").Append(PhoneNumberStatus).Append("\n");
        sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
        sb.Append("  CancellationDate: ").Append(CancellationDate).Append("\n");
        sb.Append("  RenewalDate: ").Append(RenewalDate).Append("\n");
        sb.Append("  AutoRenewable: ").Append(AutoRenewable).Append("\n");
        sb.Append("  AddressId: ").Append(AddressId).Append("\n");
        sb.Append("  ShortCodeBillingType: ").Append(ShortCodeBillingType).Append("\n");
        sb.Append("  ProvisioningStatus: ").Append(ProvisioningStatus).Append("\n");
        sb.Append("  Country: ").Append(Country).Append("\n");
        sb.Append("  SupportsSms: ").Append(SupportsSms).Append("\n");
        sb.Append("  SupportsMms: ").Append(SupportsMms).Append("\n");
        sb.Append("  SupportsVoice: ").Append(SupportsVoice).Append("\n");
        sb.Append("  Integration: ").Append(Integration).Append("\n");
        sb.Append("  Compliance: ").Append(Compliance).Append("\n");
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
        return this.Equals(obj as SmsPhoneNumber);
    }

    /// <summary>
    /// Returns true if SmsPhoneNumber instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsPhoneNumber to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsPhoneNumber other)
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
                this.PhoneNumber == other.PhoneNumber ||
                this.PhoneNumber != null &&
                this.PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                this.PhoneNumberType == other.PhoneNumberType ||
                this.PhoneNumberType != null &&
                this.PhoneNumberType.Equals(other.PhoneNumberType)
            ) &&
            (
                this.ProvisionedThroughPureCloudEnvironment == other.ProvisionedThroughPureCloudEnvironment ||
                this.ProvisionedThroughPureCloudEnvironment != null &&
                this.ProvisionedThroughPureCloudEnvironment.Equals(other.ProvisionedThroughPureCloudEnvironment)
            ) &&
            (
                this.PhoneNumberStatus == other.PhoneNumberStatus ||
                this.PhoneNumberStatus != null &&
                this.PhoneNumberStatus.Equals(other.PhoneNumberStatus)
            ) &&
            (
                this.Capabilities == other.Capabilities ||
                this.Capabilities != null &&
                this.Capabilities.SequenceEqual(other.Capabilities)
            ) &&
            (
                this.CountryCode == other.CountryCode ||
                this.CountryCode != null &&
                this.CountryCode.Equals(other.CountryCode)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.DateModified == other.DateModified ||
                this.DateModified != null &&
                this.DateModified.Equals(other.DateModified)
            ) &&
            (
                this.CreatedBy == other.CreatedBy ||
                this.CreatedBy != null &&
                this.CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                this.ModifiedBy == other.ModifiedBy ||
                this.ModifiedBy != null &&
                this.ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                this.Version == other.Version ||
                this.Version != null &&
                this.Version.Equals(other.Version)
            ) &&
            (
                this.PurchaseDate == other.PurchaseDate ||
                this.PurchaseDate != null &&
                this.PurchaseDate.Equals(other.PurchaseDate)
            ) &&
            (
                this.CancellationDate == other.CancellationDate ||
                this.CancellationDate != null &&
                this.CancellationDate.Equals(other.CancellationDate)
            ) &&
            (
                this.RenewalDate == other.RenewalDate ||
                this.RenewalDate != null &&
                this.RenewalDate.Equals(other.RenewalDate)
            ) &&
            (
                this.AutoRenewable == other.AutoRenewable ||
                this.AutoRenewable != null &&
                this.AutoRenewable.Equals(other.AutoRenewable)
            ) &&
            (
                this.AddressId == other.AddressId ||
                this.AddressId != null &&
                this.AddressId.Equals(other.AddressId)
            ) &&
            (
                this.ShortCodeBillingType == other.ShortCodeBillingType ||
                this.ShortCodeBillingType != null &&
                this.ShortCodeBillingType.Equals(other.ShortCodeBillingType)
            ) &&
            (
                this.ProvisioningStatus == other.ProvisioningStatus ||
                this.ProvisioningStatus != null &&
                this.ProvisioningStatus.Equals(other.ProvisioningStatus)
            ) &&
            (
                this.Country == other.Country ||
                this.Country != null &&
                this.Country.Equals(other.Country)
            ) &&
            (
                this.SupportsSms == other.SupportsSms ||
                this.SupportsSms != null &&
                this.SupportsSms.Equals(other.SupportsSms)
            ) &&
            (
                this.SupportsMms == other.SupportsMms ||
                this.SupportsMms != null &&
                this.SupportsMms.Equals(other.SupportsMms)
            ) &&
            (
                this.SupportsVoice == other.SupportsVoice ||
                this.SupportsVoice != null &&
                this.SupportsVoice.Equals(other.SupportsVoice)
            ) &&
            (
                this.Integration == other.Integration ||
                this.Integration != null &&
                this.Integration.Equals(other.Integration)
            ) &&
            (
                this.Compliance == other.Compliance ||
                this.Compliance != null &&
                this.Compliance.Equals(other.Compliance)
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

            if (this.PhoneNumber != null)
            {
                hash = hash * 59 + this.PhoneNumber.GetHashCode();
            }

            if (this.PhoneNumberType != null)
            {
                hash = hash * 59 + this.PhoneNumberType.GetHashCode();
            }

            if (this.ProvisionedThroughPureCloudEnvironment != null)
            {
                hash = hash * 59 + this.ProvisionedThroughPureCloudEnvironment.GetHashCode();
            }

            if (this.PhoneNumberStatus != null)
            {
                hash = hash * 59 + this.PhoneNumberStatus.GetHashCode();
            }

            if (this.Capabilities != null)
            {
                hash = hash * 59 + this.Capabilities.GetHashCode();
            }

            if (this.CountryCode != null)
            {
                hash = hash * 59 + this.CountryCode.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.DateModified != null)
            {
                hash = hash * 59 + this.DateModified.GetHashCode();
            }

            if (this.CreatedBy != null)
            {
                hash = hash * 59 + this.CreatedBy.GetHashCode();
            }

            if (this.ModifiedBy != null)
            {
                hash = hash * 59 + this.ModifiedBy.GetHashCode();
            }

            if (this.Version != null)
            {
                hash = hash * 59 + this.Version.GetHashCode();
            }

            if (this.PurchaseDate != null)
            {
                hash = hash * 59 + this.PurchaseDate.GetHashCode();
            }

            if (this.CancellationDate != null)
            {
                hash = hash * 59 + this.CancellationDate.GetHashCode();
            }

            if (this.RenewalDate != null)
            {
                hash = hash * 59 + this.RenewalDate.GetHashCode();
            }

            if (this.AutoRenewable != null)
            {
                hash = hash * 59 + this.AutoRenewable.GetHashCode();
            }

            if (this.AddressId != null)
            {
                hash = hash * 59 + this.AddressId.GetHashCode();
            }

            if (this.ShortCodeBillingType != null)
            {
                hash = hash * 59 + this.ShortCodeBillingType.GetHashCode();
            }

            if (this.ProvisioningStatus != null)
            {
                hash = hash * 59 + this.ProvisioningStatus.GetHashCode();
            }

            if (this.Country != null)
            {
                hash = hash * 59 + this.Country.GetHashCode();
            }

            if (this.SupportsSms != null)
            {
                hash = hash * 59 + this.SupportsSms.GetHashCode();
            }

            if (this.SupportsMms != null)
            {
                hash = hash * 59 + this.SupportsMms.GetHashCode();
            }

            if (this.SupportsVoice != null)
            {
                hash = hash * 59 + this.SupportsVoice.GetHashCode();
            }

            if (this.Integration != null)
            {
                hash = hash * 59 + this.Integration.GetHashCode();
            }

            if (this.Compliance != null)
            {
                hash = hash * 59 + this.Compliance.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
