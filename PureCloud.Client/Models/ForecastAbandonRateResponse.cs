using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ForecastAbandonRateResponse
/// </summary>
[DataContract]
public partial class ForecastAbandonRateResponse : IEquatable<ForecastAbandonRateResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForecastAbandonRateResponse" /> class.
    /// </summary>
    /// <param name="Percent">The target percent abandon rate goal.</param>
    public ForecastAbandonRateResponse(int? Percent = null)
    {
        this.Percent = Percent;

    }



    /// <summary>
    /// The target percent abandon rate goal
    /// </summary>
    /// <value>The target percent abandon rate goal</value>
    [DataMember(Name = "percent", EmitDefaultValue = false)]
    public int? Percent { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ForecastAbandonRateResponse {\n");

        sb.Append("  Percent: ").Append(Percent).Append("\n");
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
        return Equals(obj as ForecastAbandonRateResponse);
    }

    /// <summary>
    /// Returns true if ForecastAbandonRateResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ForecastAbandonRateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ForecastAbandonRateResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Percent == other.Percent ||
                Percent != null &&
                Percent.Equals(other.Percent)
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
            if (Percent != null)
            {
                hash = hash * 59 + Percent.GetHashCode();
            }

            return hash;
        }
    }
}
