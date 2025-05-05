using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Location object.
/// </summary>

public partial class ContentLocation : IEquatable<ContentLocation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentLocation" /> class.
    /// </summary>
    /// <param name="Url">URL of the Location..</param>
    /// <param name="Address">Location postal address..</param>
    /// <param name="Text">Location name..</param>
    /// <param name="Latitude">Latitude of the location..</param>
    /// <param name="Longitude">Longitude of the location..</param>
    public ContentLocation(string Url = null, string Address = null, string Text = null, double? Latitude = null, double? Longitude = null)
    {
        this.Url = Url;
        this.Address = Address;
        this.Text = Text;
        this.Latitude = Latitude;
        this.Longitude = Longitude;

    }



    /// <summary>
    /// URL of the Location.
    /// </summary>
    /// <value>URL of the Location.</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Location postal address.
    /// </summary>
    /// <value>Location postal address.</value>
    [JsonPropertyName("address")]
    public string Address { get; set; }



    /// <summary>
    /// Location name.
    /// </summary>
    /// <value>Location name.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Latitude of the location.
    /// </summary>
    /// <value>Latitude of the location.</value>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }



    /// <summary>
    /// Longitude of the location.
    /// </summary>
    /// <value>Longitude of the location.</value>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentLocation {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Latitude: ").Append(Latitude).Append("\n");
        sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
        return Equals(obj as ContentLocation);
    }

    /// <summary>
    /// Returns true if ContentLocation instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentLocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentLocation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Latitude != null)
            {
                hash = hash * 59 + Latitude.GetHashCode();
            }

            if (Longitude != null)
            {
                hash = hash * 59 + Longitude.GetHashCode();
            }

            return hash;
        }
    }
}
