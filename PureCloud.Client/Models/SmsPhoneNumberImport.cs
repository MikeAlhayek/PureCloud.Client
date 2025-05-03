using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsPhoneNumberImport
/// </summary>

public partial class SmsPhoneNumberImport : IEquatable<SmsPhoneNumberImport>
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
        Shortcode
    }
    /// <summary>
    /// Type of the phone number provisioned.
    /// </summary>
    /// <value>Type of the phone number provisioned.</value>
    [JsonPropertyName("phoneNumberType")]
    public PhoneNumberTypeEnum? PhoneNumberType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmsPhoneNumberImport" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SmsPhoneNumberImport() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsPhoneNumberImport" /> class.
    /// </summary>
    /// <param name="PhoneNumber">A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234 (required).</param>
    /// <param name="PhoneNumberType">Type of the phone number provisioned. (required).</param>
    /// <param name="CountryCode">The ISO 3166-1 alpha-2 country code of the country this phone number is associated with. (required).</param>
    /// <param name="IntegrationId">The id of the Genesys Cloud integration this phone number belongs to. (required).</param>
    /// <param name="Compliance">Compliance configuration for short codes, including help, stop and opt in..</param>
    public SmsPhoneNumberImport(string PhoneNumber = null, PhoneNumberTypeEnum? PhoneNumberType = null, string CountryCode = null, string IntegrationId = null, Compliance Compliance = null)
    {
        this.PhoneNumber = PhoneNumber;
        this.PhoneNumberType = PhoneNumberType;
        this.CountryCode = CountryCode;
        this.IntegrationId = IntegrationId;
        this.Compliance = Compliance;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234
    /// </summary>
    /// <value>A phone number to be used for SMS communications. E.g. +13175555555 or +34234234234</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }





    /// <summary>
    /// The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.
    /// </summary>
    /// <value>The ISO 3166-1 alpha-2 country code of the country this phone number is associated with.</value>
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }



    /// <summary>
    /// The id of the Genesys Cloud integration this phone number belongs to.
    /// </summary>
    /// <value>The id of the Genesys Cloud integration this phone number belongs to.</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }



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
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SmsPhoneNumberImport {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
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
        return Equals(obj as SmsPhoneNumberImport);
    }

    /// <summary>
    /// Returns true if SmsPhoneNumberImport instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsPhoneNumberImport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsPhoneNumberImport other)
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
                CountryCode == other.CountryCode ||
                CountryCode != null &&
                CountryCode.Equals(other.CountryCode)
            ) &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
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

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (PhoneNumberType != null)
            {
                hash = hash * 59 + PhoneNumberType.GetHashCode();
            }

            if (CountryCode != null)
            {
                hash = hash * 59 + CountryCode.GetHashCode();
            }

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
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
