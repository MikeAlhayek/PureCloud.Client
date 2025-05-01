using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsAddress
/// </summary>
[DataContract]
public partial class SmsAddress : IEquatable<SmsAddress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsAddress" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Street">The number and street address where this address is located..</param>
    /// <param name="City">The city in which this address is in.</param>
    /// <param name="Region">The state or region this address is in.</param>
    /// <param name="PostalCode">The postal code this address is in.</param>
    /// <param name="CountryCode">The ISO country code of this address.</param>
    public SmsAddress(string Name = null, string Street = null, string City = null, string Region = null, string PostalCode = null, string CountryCode = null)
    {
        this.Name = Name;
        this.Street = Street;
        this.City = City;
        this.Region = Region;
        this.PostalCode = PostalCode;
        this.CountryCode = CountryCode;

    }



    /// <summary>
    /// The id of this address.
    /// </summary>
    /// <value>The id of this address.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The number and street address where this address is located.
    /// </summary>
    /// <value>The number and street address where this address is located.</value>
    [DataMember(Name = "street", EmitDefaultValue = false)]
    public string Street { get; set; }



    /// <summary>
    /// The city in which this address is in
    /// </summary>
    /// <value>The city in which this address is in</value>
    [DataMember(Name = "city", EmitDefaultValue = false)]
    public string City { get; set; }



    /// <summary>
    /// The state or region this address is in
    /// </summary>
    /// <value>The state or region this address is in</value>
    [DataMember(Name = "region", EmitDefaultValue = false)]
    public string Region { get; set; }



    /// <summary>
    /// The postal code this address is in
    /// </summary>
    /// <value>The postal code this address is in</value>
    [DataMember(Name = "postalCode", EmitDefaultValue = false)]
    public string PostalCode { get; set; }



    /// <summary>
    /// The ISO country code of this address
    /// </summary>
    /// <value>The ISO country code of this address</value>
    [DataMember(Name = "countryCode", EmitDefaultValue = false)]
    public string CountryCode { get; set; }



    /// <summary>
    /// In some countries, addresses are validated to comply with local regulation. In those countries, if the address you provide does not pass validation, it will not be accepted as an Address. This value will be true if the Address has been validated, or false for countries that don&#39;t require validation or if the Address is non-compliant.
    /// </summary>
    /// <value>In some countries, addresses are validated to comply with local regulation. In those countries, if the address you provide does not pass validation, it will not be accepted as an Address. This value will be true if the Address has been validated, or false for countries that don&#39;t require validation or if the Address is non-compliant.</value>
    [DataMember(Name = "validated", EmitDefaultValue = false)]
    public bool? Validated { get; private set; }



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
        sb.Append("class SmsAddress {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Street: ").Append(Street).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
        sb.Append("  Validated: ").Append(Validated).Append("\n");
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
        return Equals(obj as SmsAddress);
    }

    /// <summary>
    /// Returns true if SmsAddress instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsAddress other)
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
                Validated == other.Validated ||
                Validated != null &&
                Validated.Equals(other.Validated)
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

            if (Validated != null)
            {
                hash = hash * 59 + Validated.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
