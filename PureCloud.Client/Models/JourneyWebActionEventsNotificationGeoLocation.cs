using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyWebActionEventsNotificationGeoLocation
/// </summary>
[DataContract]
public partial class JourneyWebActionEventsNotificationGeoLocation : IEquatable<JourneyWebActionEventsNotificationGeoLocation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebActionEventsNotificationGeoLocation" /> class.
    /// </summary>
    /// <param name="Country">Country.</param>
    /// <param name="CountryName">CountryName.</param>
    /// <param name="Latitude">Latitude.</param>
    /// <param name="Longitude">Longitude.</param>
    /// <param name="Locality">Locality.</param>
    /// <param name="PostalCode">PostalCode.</param>
    /// <param name="Region">Region.</param>
    /// <param name="RegionName">RegionName.</param>
    /// <param name="Timezone">Timezone.</param>
    /// <param name="Source">Source.</param>
    public JourneyWebActionEventsNotificationGeoLocation(string Country = null, string CountryName = null, double? Latitude = null, double? Longitude = null, string Locality = null, string PostalCode = null, string Region = null, string RegionName = null, string Timezone = null, string Source = null)
    {
        this.Country = Country;
        this.CountryName = CountryName;
        this.Latitude = Latitude;
        this.Longitude = Longitude;
        this.Locality = Locality;
        this.PostalCode = PostalCode;
        this.Region = Region;
        this.RegionName = RegionName;
        this.Timezone = Timezone;
        this.Source = Source;

    }



    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name = "country", EmitDefaultValue = false)]
    public string Country { get; set; }



    /// <summary>
    /// Gets or Sets CountryName
    /// </summary>
    [DataMember(Name = "countryName", EmitDefaultValue = false)]
    public string CountryName { get; set; }



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
    /// Gets or Sets Locality
    /// </summary>
    [DataMember(Name = "locality", EmitDefaultValue = false)]
    public string Locality { get; set; }



    /// <summary>
    /// Gets or Sets PostalCode
    /// </summary>
    [DataMember(Name = "postalCode", EmitDefaultValue = false)]
    public string PostalCode { get; set; }



    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    [DataMember(Name = "region", EmitDefaultValue = false)]
    public string Region { get; set; }



    /// <summary>
    /// Gets or Sets RegionName
    /// </summary>
    [DataMember(Name = "regionName", EmitDefaultValue = false)]
    public string RegionName { get; set; }



    /// <summary>
    /// Gets or Sets Timezone
    /// </summary>
    [DataMember(Name = "timezone", EmitDefaultValue = false)]
    public string Timezone { get; set; }



    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public string Source { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebActionEventsNotificationGeoLocation {\n");

        sb.Append("  Country: ").Append(Country).Append("\n");
        sb.Append("  CountryName: ").Append(CountryName).Append("\n");
        sb.Append("  Latitude: ").Append(Latitude).Append("\n");
        sb.Append("  Longitude: ").Append(Longitude).Append("\n");
        sb.Append("  Locality: ").Append(Locality).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  RegionName: ").Append(RegionName).Append("\n");
        sb.Append("  Timezone: ").Append(Timezone).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
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
        return Equals(obj as JourneyWebActionEventsNotificationGeoLocation);
    }

    /// <summary>
    /// Returns true if JourneyWebActionEventsNotificationGeoLocation instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebActionEventsNotificationGeoLocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebActionEventsNotificationGeoLocation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Country == other.Country ||
                Country != null &&
                Country.Equals(other.Country)
            ) &&
            (
                CountryName == other.CountryName ||
                CountryName != null &&
                CountryName.Equals(other.CountryName)
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
                Locality == other.Locality ||
                Locality != null &&
                Locality.Equals(other.Locality)
            ) &&
            (
                PostalCode == other.PostalCode ||
                PostalCode != null &&
                PostalCode.Equals(other.PostalCode)
            ) &&
            (
                Region == other.Region ||
                Region != null &&
                Region.Equals(other.Region)
            ) &&
            (
                RegionName == other.RegionName ||
                RegionName != null &&
                RegionName.Equals(other.RegionName)
            ) &&
            (
                Timezone == other.Timezone ||
                Timezone != null &&
                Timezone.Equals(other.Timezone)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
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
            if (Country != null)
            {
                hash = hash * 59 + Country.GetHashCode();
            }

            if (CountryName != null)
            {
                hash = hash * 59 + CountryName.GetHashCode();
            }

            if (Latitude != null)
            {
                hash = hash * 59 + Latitude.GetHashCode();
            }

            if (Longitude != null)
            {
                hash = hash * 59 + Longitude.GetHashCode();
            }

            if (Locality != null)
            {
                hash = hash * 59 + Locality.GetHashCode();
            }

            if (PostalCode != null)
            {
                hash = hash * 59 + PostalCode.GetHashCode();
            }

            if (Region != null)
            {
                hash = hash * 59 + Region.GetHashCode();
            }

            if (RegionName != null)
            {
                hash = hash * 59 + RegionName.GetHashCode();
            }

            if (Timezone != null)
            {
                hash = hash * 59 + Timezone.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            return hash;
        }
    }
}
