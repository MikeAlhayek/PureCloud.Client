using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsAddressProvision
/// </summary>

public partial class SmsAddressProvision : IEquatable<SmsAddressProvision>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SmsAddressProvision" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SmsAddressProvision() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsAddressProvision" /> class.
    /// </summary>
    /// <param name="Name">Name associated with this address (required).</param>
    /// <param name="Street">The number and street address where this address is located. (required).</param>
    /// <param name="City">The city in which this address is in (required).</param>
    /// <param name="Region">The state or region this address is in (required).</param>
    /// <param name="PostalCode">The postal code this address is in (required).</param>
    /// <param name="CountryCode">The ISO country code of this address (required).</param>
    /// <param name="AutoCorrectAddress">This is used when the address is created. If the value is not set or true, then the system will, if necessary, auto-correct the address you provide. Set this value to false if the system should not auto-correct the address..</param>
    public SmsAddressProvision(string Name = null, string Street = null, string City = null, string Region = null, string PostalCode = null, string CountryCode = null, bool? AutoCorrectAddress = null)
    {
        this.Name = Name;
        this.Street = Street;
        this.City = City;
        this.Region = Region;
        this.PostalCode = PostalCode;
        this.CountryCode = CountryCode;
        this.AutoCorrectAddress = AutoCorrectAddress;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Name associated with this address
    /// </summary>
    /// <value>Name associated with this address</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The number and street address where this address is located.
    /// </summary>
    /// <value>The number and street address where this address is located.</value>
    [JsonPropertyName("street")]
    public string Street { get; set; }



    /// <summary>
    /// The city in which this address is in
    /// </summary>
    /// <value>The city in which this address is in</value>
    [JsonPropertyName("city")]
    public string City { get; set; }



    /// <summary>
    /// The state or region this address is in
    /// </summary>
    /// <value>The state or region this address is in</value>
    [JsonPropertyName("region")]
    public string Region { get; set; }



    /// <summary>
    /// The postal code this address is in
    /// </summary>
    /// <value>The postal code this address is in</value>
    [JsonPropertyName("postalCode")]
    public string PostalCode { get; set; }



    /// <summary>
    /// The ISO country code of this address
    /// </summary>
    /// <value>The ISO country code of this address</value>
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }



    /// <summary>
    /// This is used when the address is created. If the value is not set or true, then the system will, if necessary, auto-correct the address you provide. Set this value to false if the system should not auto-correct the address.
    /// </summary>
    /// <value>This is used when the address is created. If the value is not set or true, then the system will, if necessary, auto-correct the address you provide. Set this value to false if the system should not auto-correct the address.</value>
    [JsonPropertyName("autoCorrectAddress")]
    public bool? AutoCorrectAddress { get; set; }



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
        sb.Append("class SmsAddressProvision {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Street: ").Append(Street).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  AutoCorrectAddress: ").Append(AutoCorrectAddress).Append("\n");
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
        return Equals(obj as SmsAddressProvision);
    }

    /// <summary>
    /// Returns true if SmsAddressProvision instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsAddressProvision to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsAddressProvision other)
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
                Street == other.Street ||
                Street != null &&
                Street.Equals(other.Street)
            ) &&
            (
                City == other.City ||
                City != null &&
                City.Equals(other.City)
            ) &&
            (
                Region == other.Region ||
                Region != null &&
                Region.Equals(other.Region)
            ) &&
            (
                PostalCode == other.PostalCode ||
                PostalCode != null &&
                PostalCode.Equals(other.PostalCode)
            ) &&
            (
                CountryCode == other.CountryCode ||
                CountryCode != null &&
                CountryCode.Equals(other.CountryCode)
            ) &&
            (
                AutoCorrectAddress == other.AutoCorrectAddress ||
                AutoCorrectAddress != null &&
                AutoCorrectAddress.Equals(other.AutoCorrectAddress)
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

            if (Street != null)
            {
                hash = hash * 59 + Street.GetHashCode();
            }

            if (City != null)
            {
                hash = hash * 59 + City.GetHashCode();
            }

            if (Region != null)
            {
                hash = hash * 59 + Region.GetHashCode();
            }

            if (PostalCode != null)
            {
                hash = hash * 59 + PostalCode.GetHashCode();
            }

            if (CountryCode != null)
            {
                hash = hash * 59 + CountryCode.GetHashCode();
            }

            if (AutoCorrectAddress != null)
            {
                hash = hash * 59 + AutoCorrectAddress.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
