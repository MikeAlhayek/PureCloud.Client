using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsAvailablePhoneNumber
/// </summary>

public partial class SmsAvailablePhoneNumber : IEquatable<SmsAvailablePhoneNumber>
{
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
    /// The type of phone number available for provisioning.
    /// </summary>
    /// <value>The type of phone number available for provisioning.</value>
    
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
    /// The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number.
    /// </summary>
    /// <value>The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number.</value>
    
    public enum AddressRequirementEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Enum Any for "any"
        /// </summary>
        [EnumMember(Value = "any")]
        Any,

        /// <summary>
        /// Enum Local for "local"
        /// </summary>
        [EnumMember(Value = "local")]
        Local,

        /// <summary>
        /// Enum Foreign for "foreign"
        /// </summary>
        [EnumMember(Value = "foreign")]
        Foreign
    }
    /// <summary>
    /// The type of phone number available for provisioning.
    /// </summary>
    /// <value>The type of phone number available for provisioning.</value>
    [JsonPropertyName("phoneNumberType")]
    public PhoneNumberTypeEnum? PhoneNumberType { get; set; }
    /// <summary>
    /// The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number.
    /// </summary>
    /// <value>The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number.</value>
    [JsonPropertyName("addressRequirement")]
    public AddressRequirementEnum? AddressRequirement { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsAvailablePhoneNumber" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="PhoneNumber">A phone number available for provisioning in E.164 format. E.g. +13175555555 or +34234234234.</param>
    /// <param name="CountryCode">The ISO 3166-1 alpha-2 country code of the country this phone number is associated with..</param>
    /// <param name="Region">The region/province/state the phone number is associated with..</param>
    /// <param name="City">The city the phone number is associated with..</param>
    /// <param name="Capabilities">The capabilities of the phone number available for provisioning..</param>
    /// <param name="PhoneNumberType">The type of phone number available for provisioning..</param>
    /// <param name="AddressRequirement">The address requirement needed for provisioning this number. If there is a requirement, the address must be the residence or place of business of the individual or entity using the phone number..</param>
    public SmsAvailablePhoneNumber(string Name = null, string PhoneNumber = null, string CountryCode = null, string Region = null, string City = null, List<CapabilitiesEnum> Capabilities = null, PhoneNumberTypeEnum? PhoneNumberType = null, AddressRequirementEnum? AddressRequirement = null)
    {
        this.Name = Name;
        this.PhoneNumber = PhoneNumber;
        this.CountryCode = CountryCode;
        this.Region = Region;
        this.City = City;
        this.Capabilities = Capabilities;
        this.PhoneNumberType = PhoneNumberType;
        this.AddressRequirement = AddressRequirement;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A phone number available for provisioning in E.164 format. E.g. +13175555555 or +34234234234
    /// </summary>
    /// <value>A phone number available for provisioning in E.164 format. E.g. +13175555555 or +34234234234</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
    /// </summary>
    /// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }



    /// <summary>
    /// The region/province/state the phone number is associated with.
    /// </summary>
    /// <value>The region/province/state the phone number is associated with.</value>
    [JsonPropertyName("region")]
    public string Region { get; set; }



    /// <summary>
    /// The city the phone number is associated with.
    /// </summary>
    /// <value>The city the phone number is associated with.</value>
    [JsonPropertyName("city")]
    public string City { get; set; }



    /// <summary>
    /// The capabilities of the phone number available for provisioning.
    /// </summary>
    /// <value>The capabilities of the phone number available for provisioning.</value>
    [JsonPropertyName("capabilities")]
    public List<CapabilitiesEnum> Capabilities { get; set; }







    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SmsAvailablePhoneNumber {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
        sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
        sb.Append("  AddressRequirement: ").Append(AddressRequirement).Append("\n");
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
        return Equals(obj as SmsAvailablePhoneNumber);
    }

    /// <summary>
    /// Returns true if SmsAvailablePhoneNumber instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsAvailablePhoneNumber to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsAvailablePhoneNumber other)
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
                CountryCode == other.CountryCode ||
                CountryCode != null &&
                CountryCode.Equals(other.CountryCode)
            ) &&
            (
                Region == other.Region ||
                Region != null &&
                Region.Equals(other.Region)
            ) &&
            (
                City == other.City ||
                City != null &&
                City.Equals(other.City)
            ) &&
            (
                Capabilities == other.Capabilities ||
                Capabilities != null &&
                Capabilities.SequenceEqual(other.Capabilities)
            ) &&
            (
                PhoneNumberType == other.PhoneNumberType ||
                PhoneNumberType != null &&
                PhoneNumberType.Equals(other.PhoneNumberType)
            ) &&
            (
                AddressRequirement == other.AddressRequirement ||
                AddressRequirement != null &&
                AddressRequirement.Equals(other.AddressRequirement)
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

            if (CountryCode != null)
            {
                hash = hash * 59 + CountryCode.GetHashCode();
            }

            if (Region != null)
            {
                hash = hash * 59 + Region.GetHashCode();
            }

            if (City != null)
            {
                hash = hash * 59 + City.GetHashCode();
            }

            if (Capabilities != null)
            {
                hash = hash * 59 + Capabilities.GetHashCode();
            }

            if (PhoneNumberType != null)
            {
                hash = hash * 59 + PhoneNumberType.GetHashCode();
            }

            if (AddressRequirement != null)
            {
                hash = hash * 59 + AddressRequirement.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
