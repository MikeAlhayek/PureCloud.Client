using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LogCaptureUserConfiguration
/// </summary>

public partial class LogCaptureUserConfiguration : IEquatable<LogCaptureUserConfiguration>
{
    /// <summary>
    /// Indicates the method by which the logs were captured.
    /// </summary>
    /// <value>Indicates the method by which the logs were captured.</value>
    
    public enum CaptureMethodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ondemand for "OnDemand"
        /// </summary>
        [EnumMember(Value = "OnDemand")]
        Ondemand,

        /// <summary>
        /// Enum Scheduled for "Scheduled"
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled
    }
    /// <summary>
    /// Indicates the method by which the logs were captured.
    /// </summary>
    /// <value>Indicates the method by which the logs were captured.</value>
    [JsonPropertyName("captureMethod")]
    public CaptureMethodEnum? CaptureMethod { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LogCaptureUserConfiguration" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LogCaptureUserConfiguration() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LogCaptureUserConfiguration" /> class.
    /// </summary>
    /// <param name="DateExpired">Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public LogCaptureUserConfiguration(DateTime? DateExpired = null)
    {
        this.DateExpired = DateExpired;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Indicates when log capture was enabled for the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Indicates when log capture was enabled for the user. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStarted")]
    public DateTime? DateStarted { get; set; }



    /// <summary>
    /// Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Indicates when log capture will be turned off for the user. (Must be within 24 hours). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateExpired")]
    public DateTime? DateExpired { get; set; }





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
        sb.Append("class LogCaptureUserConfiguration {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DateStarted: ").Append(DateStarted).Append("\n");
        sb.Append("  DateExpired: ").Append(DateExpired).Append("\n");
        sb.Append("  CaptureMethod: ").Append(CaptureMethod).Append("\n");
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
        return Equals(obj as LogCaptureUserConfiguration);
    }

    /// <summary>
    /// Returns true if LogCaptureUserConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of LogCaptureUserConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LogCaptureUserConfiguration other)
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
                DateStarted == other.DateStarted ||
                DateStarted != null &&
                DateStarted.Equals(other.DateStarted)
            ) &&
            (
                DateExpired == other.DateExpired ||
                DateExpired != null &&
                DateExpired.Equals(other.DateExpired)
            ) &&
            (
                CaptureMethod == other.CaptureMethod ||
                CaptureMethod != null &&
                CaptureMethod.Equals(other.CaptureMethod)
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

            if (DateStarted != null)
            {
                hash = hash * 59 + DateStarted.GetHashCode();
            }

            if (DateExpired != null)
            {
                hash = hash * 59 + DateExpired.GetHashCode();
            }

            if (CaptureMethod != null)
            {
                hash = hash * 59 + CaptureMethod.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
