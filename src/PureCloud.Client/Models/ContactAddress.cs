using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactAddress
/// </summary>

public partial class ContactAddress : IEquatable<ContactAddress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactAddress" /> class.
    /// </summary>
    /// <param name="Address1">Address1.</param>
    /// <param name="Address2">Address2.</param>
    /// <param name="City">City.</param>
    /// <param name="State">State.</param>
    /// <param name="PostalCode">PostalCode.</param>
    /// <param name="CountryCode">CountryCode.</param>
    public ContactAddress(string Address1 = null, string Address2 = null, string City = null, string State = null, string PostalCode = null, string CountryCode = null)
    {
        this.Address1 = Address1;
        this.Address2 = Address2;
        this.City = City;
        this.State = State;
        this.PostalCode = PostalCode;
        this.CountryCode = CountryCode;

    }



    /// <summary>
    /// Gets or Sets Address1
    /// </summary>
    [JsonPropertyName("address1")]
    public string Address1 { get; set; }



    /// <summary>
    /// Gets or Sets Address2
    /// </summary>
    [JsonPropertyName("address2")]
    public string Address2 { get; set; }



    /// <summary>
    /// Gets or Sets City
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }



    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }



    /// <summary>
    /// Gets or Sets PostalCode
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string PostalCode { get; set; }



    /// <summary>
    /// Gets or Sets CountryCode
    /// </summary>
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactAddress {\n");

        sb.Append("  Address1: ").Append(Address1).Append("\n");
        sb.Append("  Address2: ").Append(Address2).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
        return Equals(obj as ContactAddress);
    }

    /// <summary>
    /// Returns true if ContactAddress instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactAddress other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Address1 == other.Address1 ||
                Address1 != null &&
                Address1.Equals(other.Address1)
            ) &&
            (
                Address2 == other.Address2 ||
                Address2 != null &&
                Address2.Equals(other.Address2)
            ) &&
            (
                City == other.City ||
                City != null &&
                City.Equals(other.City)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
            if (Address1 != null)
            {
                hash = hash * 59 + Address1.GetHashCode();
            }

            if (Address2 != null)
            {
                hash = hash * 59 + Address2.GetHashCode();
            }

            if (City != null)
            {
                hash = hash * 59 + City.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (PostalCode != null)
            {
                hash = hash * 59 + PostalCode.GetHashCode();
            }

            if (CountryCode != null)
            {
                hash = hash * 59 + CountryCode.GetHashCode();
            }

            return hash;
        }
    }
}
