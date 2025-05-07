using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsPhoneNumber
/// </summary>

public partial class SmsPhoneNumber : IEquatable<SmsPhoneNumber>
{
    /// <summary>
    /// Type of the phone number provisioned.
    /// </summary>
    /// <value>Type of the phone number provisioned.</value>
    
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
    [JsonPropertyName("phoneNumberType")]
    public PhoneNumberTypeEnum? PhoneNumberType { get; set; }
    /// <summary>
    /// Status of the provisioned phone number.
    /// </summary>
    /// <value>Status of the provisioned phone number.</value>
    [JsonPropertyName("phoneNumberStatus")]
    public PhoneNumberStatusEnum? PhoneNumberStatus { get; set; }
    /// <summary>
    /// Renewal time period of this phone number, if the phoneNumberType is shortcode.
    /// </summary>
    /// <value>Renewal time period of this phone number, if the phoneNumberType is shortcode.</value>
    [JsonPropertyName("autoRenewable")]
    public AutoRenewableEnum? AutoRenewable { get; set; }
    /// <summary>
    /// BillingType of this phone number, if the phoneNumberType is shortcode.
    /// </summary>
    /// <value>BillingType of this phone number, if the phoneNumberType is shortcode.</value>
    [JsonPropertyName("shortCodeBillingType")]
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
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A phone number provisioned for SMS communications.
    /// </summary>
    /// <value>A phone number provisioned for SMS communications.</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }





    /// <summary>
    /// Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud
    /// </summary>
    /// <value>Is set to false, if the phone number is provisioned through a SMS provider, outside of PureCloud</value>
    [JsonPropertyName("provisionedThroughPureCloud")]
    public bool? ProvisionedThroughPureCloudEnvironment { get; set; }





    /// <summary>
    /// The capabilities of the phone number available for provisioning.
    /// </summary>
    /// <value>The capabilities of the phone number available for provisioning.</value>
    [JsonPropertyName("capabilities")]
    public List<CapabilitiesEnum> Capabilities { get; set; }



    /// <summary>
    /// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
    /// </summary>
    /// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }



    /// <summary>
    /// Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this phone number was provisioned. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this phone number was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// User that provisioned this phone number
    /// </summary>
    /// <value>User that provisioned this phone number</value>
    [JsonPropertyName("createdBy")]
    public User CreatedBy { get; set; }



    /// <summary>
    /// User that last modified this phone number
    /// </summary>
    /// <value>User that last modified this phone number</value>
    [JsonPropertyName("modifiedBy")]
    public User ModifiedBy { get; set; }



    /// <summary>
    /// Version number required for updates.
    /// </summary>
    /// <value>Version number required for updates.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this phone number was purchased, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("purchaseDate")]
    public DateTime? PurchaseDate { get; set; }



    /// <summary>
    /// Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Contract end date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("cancellationDate")]
    public DateTime? CancellationDate { get; set; }



    /// <summary>
    /// Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Contract renewal date of this phone number, if the phoneNumberType is shortcode. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("renewalDate")]
    public DateTime? RenewalDate { get; set; }





    /// <summary>
    /// The id of an address attached to this phone number.
    /// </summary>
    /// <value>The id of an address attached to this phone number.</value>
    [JsonPropertyName("addressId")]
    public SmsAddress AddressId { get; set; }





    /// <summary>
    /// Status of latest asynchronous provisioning action
    /// </summary>
    /// <value>Status of latest asynchronous provisioning action</value>
    [JsonPropertyName("provisioningStatus")]
    public SmsProvisioningStatus ProvisioningStatus { get; set; }



    /// <summary>
    /// Localized country name for the country code this phone number belongs too
    /// </summary>
    /// <value>Localized country name for the country code this phone number belongs too</value>
    [JsonPropertyName("country")]
    public string Country { get; set; }



    /// <summary>
    /// Set to true if this phone number has the capability to support SMS
    /// </summary>
    /// <value>Set to true if this phone number has the capability to support SMS</value>
    [JsonPropertyName("supportsSms")]
    public bool? SupportsSms { get; set; }



    /// <summary>
    /// Set to true if this phone number has the capability to support MMS
    /// </summary>
    /// <value>Set to true if this phone number has the capability to support MMS</value>
    [JsonPropertyName("supportsMms")]
    public bool? SupportsMms { get; set; }



    /// <summary>
    /// Set to true if this phone number has the capability to support voice
    /// </summary>
    /// <value>Set to true if this phone number has the capability to support voice</value>
    [JsonPropertyName("supportsVoice")]
    public bool? SupportsVoice { get; set; }



    /// <summary>
    /// The Genesys Cloud integration this phone number belongs to.
    /// </summary>
    /// <value>The Genesys Cloud integration this phone number belongs to.</value>
    [JsonPropertyName("integration")]
    public DomainEntityRef Integration { get; set; }



    /// <summary>
    /// Compliance configuration for short codes, including help, stop and opt in.
    /// </summary>
    /// <value>Compliance configuration for short codes, including help, stop and opt in.</value>
    [JsonPropertyName("compliance")]
    public Compliance Compliance { get; set; }



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
        return Equals(obj as SmsPhoneNumber);
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
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                PhoneNumberType == other.PhoneNumberType ||
                PhoneNumberType != null &&
                PhoneNumberType.Equals(other.PhoneNumberType)
            ) &&
            (
                ProvisionedThroughPureCloudEnvironment == other.ProvisionedThroughPureCloudEnvironment ||
                ProvisionedThroughPureCloudEnvironment != null &&
                ProvisionedThroughPureCloudEnvironment.Equals(other.ProvisionedThroughPureCloudEnvironment)
            ) &&
            (
                PhoneNumberStatus == other.PhoneNumberStatus ||
                PhoneNumberStatus != null &&
                PhoneNumberStatus.Equals(other.PhoneNumberStatus)
            ) &&
            (
                Capabilities == other.Capabilities ||
                Capabilities != null &&
                Capabilities.SequenceEqual(other.Capabilities)
            ) &&
            (
                CountryCode == other.CountryCode ||
                CountryCode != null &&
                CountryCode.Equals(other.CountryCode)
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
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                PurchaseDate == other.PurchaseDate ||
                PurchaseDate != null &&
                PurchaseDate.Equals(other.PurchaseDate)
            ) &&
            (
                CancellationDate == other.CancellationDate ||
                CancellationDate != null &&
                CancellationDate.Equals(other.CancellationDate)
            ) &&
            (
                RenewalDate == other.RenewalDate ||
                RenewalDate != null &&
                RenewalDate.Equals(other.RenewalDate)
            ) &&
            (
                AutoRenewable == other.AutoRenewable ||
                AutoRenewable != null &&
                AutoRenewable.Equals(other.AutoRenewable)
            ) &&
            (
                AddressId == other.AddressId ||
                AddressId != null &&
                AddressId.Equals(other.AddressId)
            ) &&
            (
                ShortCodeBillingType == other.ShortCodeBillingType ||
                ShortCodeBillingType != null &&
                ShortCodeBillingType.Equals(other.ShortCodeBillingType)
            ) &&
            (
                ProvisioningStatus == other.ProvisioningStatus ||
                ProvisioningStatus != null &&
                ProvisioningStatus.Equals(other.ProvisioningStatus)
            ) &&
            (
                Country == other.Country ||
                Country != null &&
                Country.Equals(other.Country)
            ) &&
            (
                SupportsSms == other.SupportsSms ||
                SupportsSms != null &&
                SupportsSms.Equals(other.SupportsSms)
            ) &&
            (
                SupportsMms == other.SupportsMms ||
                SupportsMms != null &&
                SupportsMms.Equals(other.SupportsMms)
            ) &&
            (
                SupportsVoice == other.SupportsVoice ||
                SupportsVoice != null &&
                SupportsVoice.Equals(other.SupportsVoice)
            ) &&
            (
                Integration == other.Integration ||
                Integration != null &&
                Integration.Equals(other.Integration)
            ) &&
            (
                Compliance == other.Compliance ||
                Compliance != null &&
                Compliance.Equals(other.Compliance)
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

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (PhoneNumberType != null)
            {
                hash = hash * 59 + PhoneNumberType.GetHashCode();
            }

            if (ProvisionedThroughPureCloudEnvironment != null)
            {
                hash = hash * 59 + ProvisionedThroughPureCloudEnvironment.GetHashCode();
            }

            if (PhoneNumberStatus != null)
            {
                hash = hash * 59 + PhoneNumberStatus.GetHashCode();
            }

            if (Capabilities != null)
            {
                hash = hash * 59 + Capabilities.GetHashCode();
            }

            if (CountryCode != null)
            {
                hash = hash * 59 + CountryCode.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (PurchaseDate != null)
            {
                hash = hash * 59 + PurchaseDate.GetHashCode();
            }

            if (CancellationDate != null)
            {
                hash = hash * 59 + CancellationDate.GetHashCode();
            }

            if (RenewalDate != null)
            {
                hash = hash * 59 + RenewalDate.GetHashCode();
            }

            if (AutoRenewable != null)
            {
                hash = hash * 59 + AutoRenewable.GetHashCode();
            }

            if (AddressId != null)
            {
                hash = hash * 59 + AddressId.GetHashCode();
            }

            if (ShortCodeBillingType != null)
            {
                hash = hash * 59 + ShortCodeBillingType.GetHashCode();
            }

            if (ProvisioningStatus != null)
            {
                hash = hash * 59 + ProvisioningStatus.GetHashCode();
            }

            if (Country != null)
            {
                hash = hash * 59 + Country.GetHashCode();
            }

            if (SupportsSms != null)
            {
                hash = hash * 59 + SupportsSms.GetHashCode();
            }

            if (SupportsMms != null)
            {
                hash = hash * 59 + SupportsMms.GetHashCode();
            }

            if (SupportsVoice != null)
            {
                hash = hash * 59 + SupportsVoice.GetHashCode();
            }

            if (Integration != null)
            {
                hash = hash * 59 + Integration.GetHashCode();
            }

            if (Compliance != null)
            {
                hash = hash * 59 + Compliance.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
