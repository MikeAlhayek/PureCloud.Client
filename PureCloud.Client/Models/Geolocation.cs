using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Geolocation
/// </summary>
[DataContract]
public partial class Geolocation : IEquatable<Geolocation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Geolocation" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">A string used to describe the type of client the geolocation is being updated from e.g. ios, android, web, etc..</param>
    /// <param name="Primary">A boolean used to tell whether or not to set this geolocation client as the primary on a PATCH.</param>
    /// <param name="Latitude">Latitude.</param>
    /// <param name="Longitude">Longitude.</param>
    /// <param name="Country">Country.</param>
    /// <param name="Region">Region.</param>
    /// <param name="City">City.</param>
    /// <param name="Locations">Locations.</param>
    public Geolocation(string Name = null, string Type = null, bool? Primary = null, double? Latitude = null, double? Longitude = null, string Country = null, string Region = null, string City = null, List<LocationDefinition> Locations = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Primary = Primary;
        this.Latitude = Latitude;
        this.Longitude = Longitude;
        this.Country = Country;
        this.Region = Region;
        this.City = City;
        this.Locations = Locations;

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
    /// A string used to describe the type of client the geolocation is being updated from e.g. ios, android, web, etc.
    /// </summary>
    /// <value>A string used to describe the type of client the geolocation is being updated from e.g. ios, android, web, etc.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// A boolean used to tell whether or not to set this geolocation client as the primary on a PATCH
    /// </summary>
    /// <value>A boolean used to tell whether or not to set this geolocation client as the primary on a PATCH</value>
    [DataMember(Name = "primary", EmitDefaultValue = false)]
    public bool? Primary { get; set; }



    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    [DataMember(Name = "latitude", EmitDefaultValue = false)]
    public double? Latitude { get; set; }



    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    [DataMember(Name = "longitude", EmitDefaultValue = false)]
    public double? Longitude { get; set; }



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
    /// Gets or Sets Locations
    /// </summary>
    [DataMember(Name = "locations", EmitDefaultValue = false)]
    public List<LocationDefinition> Locations { get; set; }



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
        sb.Append("class Geolocation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
        sb.Append("  Latitude: ").Append(Latitude).Append("\n");
        sb.Append("  Longitude: ").Append(Longitude).Append("\n");
        sb.Append("  Country: ").Append(Country).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  Locations: ").Append(Locations).Append("\n");
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
        return Equals(obj as Geolocation);
    }

    /// <summary>
    /// Returns true if Geolocation instances are equal
    /// </summary>
    /// <param name="other">Instance of Geolocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Geolocation other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Primary == other.Primary ||
                Primary != null &&
                Primary.Equals(other.Primary)
            ) &&
            (
                Latitude == other.Latitude ||
                Latitude != null &&
                Latitude.Equals(other.Latitude)
            ) &&
            (
                Longitude == other.Longitude ||
                Longitude != null &&
                Longitude.Equals(other.Longitude)
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
            ) &&
            (
                Locations == other.Locations ||
                Locations != null &&
                Locations.SequenceEqual(other.Locations)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Primary != null)
            {
                hash = hash * 59 + Primary.GetHashCode();
            }

            if (Latitude != null)
            {
                hash = hash * 59 + Latitude.GetHashCode();
            }

            if (Longitude != null)
            {
                hash = hash * 59 + Longitude.GetHashCode();
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

            if (Locations != null)
            {
                hash = hash * 59 + Locations.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
