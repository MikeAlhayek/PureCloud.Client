using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyGeolocation
/// </summary>
[DataContract]
public partial class JourneyGeolocation : IEquatable<JourneyGeolocation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyGeolocation" /> class.
    /// </summary>
    /// <param name="Country">Geolocation&#39;s ISO 3166-1 alpha-2 country code..</param>
    /// <param name="CountryName">Geolocation&#39;s country name..</param>
    /// <param name="Latitude">Geolocation&#39;s latitude..</param>
    /// <param name="Longitude">Geolocation&#39;s longitude..</param>
    /// <param name="Locality">Geolocation&#39;s locality or city..</param>
    /// <param name="PostalCode">Geolocation&#39;s postal code or ZIP code..</param>
    /// <param name="Region">Geolocation&#39;s ISO-3166-2 region code..</param>
    /// <param name="RegionName">Geolocation&#39;s region name..</param>
    /// <param name="Source">The source that was used to determine the geolocation information..</param>
    /// <param name="Timezone">Geolocation&#39;s timezone..</param>
    public JourneyGeolocation(string Country = null, string CountryName = null, double? Latitude = null, double? Longitude = null, string Locality = null, string PostalCode = null, string Region = null, string RegionName = null, string Source = null, string Timezone = null)
    {
        this.Country = Country;
        this.CountryName = CountryName;
        this.Latitude = Latitude;
        this.Longitude = Longitude;
        this.Locality = Locality;
        this.PostalCode = PostalCode;
        this.Region = Region;
        this.RegionName = RegionName;
        this.Source = Source;
        this.Timezone = Timezone;

    }



    /// <summary>
    /// Geolocation&#39;s ISO 3166-1 alpha-2 country code.
    /// </summary>
    /// <value>Geolocation&#39;s ISO 3166-1 alpha-2 country code.</value>
    [DataMember(Name = "country", EmitDefaultValue = false)]
    public string Country { get; set; }



    /// <summary>
    /// Geolocation&#39;s country name.
    /// </summary>
    /// <value>Geolocation&#39;s country name.</value>
    [DataMember(Name = "countryName", EmitDefaultValue = false)]
    public string CountryName { get; set; }



    /// <summary>
    /// Geolocation&#39;s latitude.
    /// </summary>
    /// <value>Geolocation&#39;s latitude.</value>
    [DataMember(Name = "latitude", EmitDefaultValue = false)]
    public double? Latitude { get; set; }



    /// <summary>
    /// Geolocation&#39;s longitude.
    /// </summary>
    /// <value>Geolocation&#39;s longitude.</value>
    [DataMember(Name = "longitude", EmitDefaultValue = false)]
    public double? Longitude { get; set; }



    /// <summary>
    /// Geolocation&#39;s locality or city.
    /// </summary>
    /// <value>Geolocation&#39;s locality or city.</value>
    [DataMember(Name = "locality", EmitDefaultValue = false)]
    public string Locality { get; set; }



    /// <summary>
    /// Geolocation&#39;s postal code or ZIP code.
    /// </summary>
    /// <value>Geolocation&#39;s postal code or ZIP code.</value>
    [DataMember(Name = "postalCode", EmitDefaultValue = false)]
    public string PostalCode { get; set; }



    /// <summary>
    /// Geolocation&#39;s ISO-3166-2 region code.
    /// </summary>
    /// <value>Geolocation&#39;s ISO-3166-2 region code.</value>
    [DataMember(Name = "region", EmitDefaultValue = false)]
    public string Region { get; set; }



    /// <summary>
    /// Geolocation&#39;s region name.
    /// </summary>
    /// <value>Geolocation&#39;s region name.</value>
    [DataMember(Name = "regionName", EmitDefaultValue = false)]
    public string RegionName { get; set; }



    /// <summary>
    /// The source that was used to determine the geolocation information.
    /// </summary>
    /// <value>The source that was used to determine the geolocation information.</value>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public string Source { get; set; }



    /// <summary>
    /// Geolocation&#39;s timezone.
    /// </summary>
    /// <value>Geolocation&#39;s timezone.</value>
    [DataMember(Name = "timezone", EmitDefaultValue = false)]
    public string Timezone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyGeolocation {\n");

        sb.Append("  Country: ").Append(Country).Append("\n");
        sb.Append("  CountryName: ").Append(CountryName).Append("\n");
        sb.Append("  Latitude: ").Append(Latitude).Append("\n");
        sb.Append("  Longitude: ").Append(Longitude).Append("\n");
        sb.Append("  Locality: ").Append(Locality).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  RegionName: ").Append(RegionName).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
        return Equals(obj as JourneyGeolocation);
    }

    /// <summary>
    /// Returns true if JourneyGeolocation instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyGeolocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyGeolocation other)
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
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                Timezone == other.Timezone ||
                Timezone != null &&
                Timezone.Equals(other.Timezone)
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

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (Timezone != null)
            {
                hash = hash * 59 + Timezone.GetHashCode();
            }

            return hash;
        }
    }
}
