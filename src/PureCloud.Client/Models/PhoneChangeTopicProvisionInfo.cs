using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneChangeTopicProvisionInfo
/// </summary>

public partial class PhoneChangeTopicProvisionInfo : IEquatable<PhoneChangeTopicProvisionInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneChangeTopicProvisionInfo" /> class.
    /// </summary>
    /// <param name="Time">Time.</param>
    /// <param name="Source">Source.</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    public PhoneChangeTopicProvisionInfo(DateTime? Time = null, string Source = null, string ErrorInfo = null)
    {
        this.Time = Time;
        this.Source = Source;
        this.ErrorInfo = ErrorInfo;

    }



    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [JsonPropertyName("time")]
    public DateTime? Time { get; set; }



    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [JsonPropertyName("errorInfo")]
    public string ErrorInfo { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneChangeTopicProvisionInfo {\n");

        sb.Append("  Time: ").Append(Time).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
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
        return Equals(obj as PhoneChangeTopicProvisionInfo);
    }

    /// <summary>
    /// Returns true if PhoneChangeTopicProvisionInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneChangeTopicProvisionInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneChangeTopicProvisionInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Time == other.Time ||
                Time != null &&
                Time.Equals(other.Time)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
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
            if (Time != null)
            {
                hash = hash * 59 + Time.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
