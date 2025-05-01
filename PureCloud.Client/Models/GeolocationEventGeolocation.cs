using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GeolocationEventGeolocation
/// </summary>
[DataContract]
public partial class GeolocationEventGeolocation : IEquatable<GeolocationEventGeolocation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeolocationEventGeolocation" /> class.
    /// </summary>
    /// <param name="UserId">UserId.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Country">Country.</param>
    /// <param name="Region">Region.</param>
    /// <param name="City">City.</param>
    public GeolocationEventGeolocation(string UserId = null, string Type = null, string Country = null, string Region = null, string City = null)
    {
        this.UserId = UserId;
        this.Type = Type;
        this.Country = Country;
        this.Region = Region;
        this.City = City;

    }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name = "country", EmitDefaultValue = false)]
    public string Country { get; set; }



    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    [DataMember(Name = "region", EmitDefaultValue = false)]
    public string Region { get; set; }



    /// <summary>
    /// Gets or Sets City
    /// </summary>
    [DataMember(Name = "city", EmitDefaultValue = false)]
    public string City { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GeolocationEventGeolocation {\n");

        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Country: ").Append(Country).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
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
        return Equals(obj as GeolocationEventGeolocation);
    }

    /// <summary>
    /// Returns true if GeolocationEventGeolocation instances are equal
    /// </summary>
    /// <param name="other">Instance of GeolocationEventGeolocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GeolocationEventGeolocation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Country == other.Country ||
                Country != null &&
                Country.Equals(other.Country)
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
            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Country != null)
            {
                hash = hash * 59 + Country.GetHashCode();
            }

            if (Region != null)
            {
                hash = hash * 59 + Region.GetHashCode();
            }

            if (City != null)
            {
                hash = hash * 59 + City.GetHashCode();
            }

            return hash;
        }
    }
}
