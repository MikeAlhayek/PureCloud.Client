using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeAttributionAsyncResponse
/// </summary>

public partial class OutcomeAttributionAsyncResponse : IEquatable<OutcomeAttributionAsyncResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeAttributionAsyncResponse" /> class.
    /// </summary>
    /// <param name="PercentFailedThreshold">Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100..</param>
    public OutcomeAttributionAsyncResponse(int? PercentFailedThreshold = null)
    {
        this.PercentFailedThreshold = PercentFailedThreshold;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.
    /// </summary>
    /// <value>Optional percent failed threshold for validation errors; if reached will halt the job. Default is 5 percent, allowed values 0 to 100.</value>
    [JsonPropertyName("percentFailedThreshold")]
    public int? PercentFailedThreshold { get; set; }



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
        sb.Append("class OutcomeAttributionAsyncResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PercentFailedThreshold: ").Append(PercentFailedThreshold).Append("\n");
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
        return Equals(obj as OutcomeAttributionAsyncResponse);
    }

    /// <summary>
    /// Returns true if OutcomeAttributionAsyncResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeAttributionAsyncResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeAttributionAsyncResponse other)
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
                PercentFailedThreshold == other.PercentFailedThreshold ||
                PercentFailedThreshold != null &&
                PercentFailedThreshold.Equals(other.PercentFailedThreshold)
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

            if (PercentFailedThreshold != null)
            {
                hash = hash * 59 + PercentFailedThreshold.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
