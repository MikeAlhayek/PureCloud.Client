using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CalendarUrlResponse
/// </summary>

public partial class CalendarUrlResponse : IEquatable<CalendarUrlResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CalendarUrlResponse" /> class.
    /// </summary>
    /// <param name="CalendarUrl">The calendar url for the user to subscribe with supported clients.</param>
    public CalendarUrlResponse(string CalendarUrl = null)
    {
        this.CalendarUrl = CalendarUrl;

    }



    /// <summary>
    /// The calendar url for the user to subscribe with supported clients
    /// </summary>
    /// <value>The calendar url for the user to subscribe with supported clients</value>
    [JsonPropertyName("calendarUrl")]
    public string CalendarUrl { get; set; }



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
        sb.Append("class CalendarUrlResponse {\n");

        sb.Append("  CalendarUrl: ").Append(CalendarUrl).Append("\n");
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
        return Equals(obj as CalendarUrlResponse);
    }

    /// <summary>
    /// Returns true if CalendarUrlResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CalendarUrlResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CalendarUrlResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CalendarUrl == other.CalendarUrl ||
                CalendarUrl != null &&
                CalendarUrl.Equals(other.CalendarUrl)
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
            if (CalendarUrl != null)
            {
                hash = hash * 59 + CalendarUrl.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
