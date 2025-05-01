using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// ShortTermForecastingSettings
/// </summary>
[DataContract]
public partial class ShortTermForecastingSettings : IEquatable<ShortTermForecastingSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ShortTermForecastingSettings" /> class.
    /// </summary>
    /// <param name="DefaultHistoryWeeks">The number of weeks to consider by default when generating a volume forecast.</param>
    public ShortTermForecastingSettings(int? DefaultHistoryWeeks = null)
    {
        this.DefaultHistoryWeeks = DefaultHistoryWeeks;

    }



    /// <summary>
    /// The number of weeks to consider by default when generating a volume forecast
    /// </summary>
    /// <value>The number of weeks to consider by default when generating a volume forecast</value>
    [DataMember(Name = "defaultHistoryWeeks", EmitDefaultValue = false)]
    public int? DefaultHistoryWeeks { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShortTermForecastingSettings {\n");

        sb.Append("  DefaultHistoryWeeks: ").Append(DefaultHistoryWeeks).Append("\n");
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
        return Equals(obj as ShortTermForecastingSettings);
    }

    /// <summary>
    /// Returns true if ShortTermForecastingSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ShortTermForecastingSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShortTermForecastingSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DefaultHistoryWeeks == other.DefaultHistoryWeeks ||
                DefaultHistoryWeeks != null &&
                DefaultHistoryWeeks.Equals(other.DefaultHistoryWeeks)
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
            if (DefaultHistoryWeeks != null)
            {
                hash = hash * 59 + DefaultHistoryWeeks.GetHashCode();
            }

            return hash;
        }
    }
}
