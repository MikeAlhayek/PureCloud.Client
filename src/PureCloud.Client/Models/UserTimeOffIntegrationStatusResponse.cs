using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserTimeOffIntegrationStatusResponse
/// </summary>

public partial class UserTimeOffIntegrationStatusResponse : IEquatable<UserTimeOffIntegrationStatusResponse>
{
    /// <summary>
    /// The value of integration status for the time off request
    /// </summary>
    /// <value>The value of integration status for the time off request</value>
    
    public enum IntegrationStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Automaticallycomplete for "AutomaticallyComplete"
        /// </summary>
        [EnumMember(Value = "AutomaticallyComplete")]
        Automaticallycomplete,

        /// <summary>
        /// Enum Manuallycomplete for "ManuallyComplete"
        /// </summary>
        [EnumMember(Value = "ManuallyComplete")]
        Manuallycomplete
    }
    /// <summary>
    /// The value of integration status for the time off request
    /// </summary>
    /// <value>The value of integration status for the time off request</value>
    [JsonPropertyName("integrationStatus")]
    public IntegrationStatusEnum? IntegrationStatus { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserTimeOffIntegrationStatusResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserTimeOffIntegrationStatusResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserTimeOffIntegrationStatusResponse" /> class.
    /// </summary>
    /// <param name="TimeOffRequest">The time off request associated with this integration status (required).</param>
    /// <param name="IntegrationStatus">The value of integration status for the time off request (required).</param>
    /// <param name="User">The user to whom the time off request belongs (required).</param>
    public UserTimeOffIntegrationStatusResponse(TimeOffRequestReference TimeOffRequest = null, IntegrationStatusEnum? IntegrationStatus = null, UserReference User = null)
    {
        this.TimeOffRequest = TimeOffRequest;
        this.IntegrationStatus = IntegrationStatus;
        this.User = User;

    }



    /// <summary>
    /// The time off request associated with this integration status
    /// </summary>
    /// <value>The time off request associated with this integration status</value>
    [JsonPropertyName("timeOffRequest")]
    public TimeOffRequestReference TimeOffRequest { get; set; }





    /// <summary>
    /// The user to whom the time off request belongs
    /// </summary>
    /// <value>The user to whom the time off request belongs</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserTimeOffIntegrationStatusResponse {\n");

        sb.Append("  TimeOffRequest: ").Append(TimeOffRequest).Append("\n");
        sb.Append("  IntegrationStatus: ").Append(IntegrationStatus).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as UserTimeOffIntegrationStatusResponse);
    }

    /// <summary>
    /// Returns true if UserTimeOffIntegrationStatusResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of UserTimeOffIntegrationStatusResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserTimeOffIntegrationStatusResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffRequest == other.TimeOffRequest ||
                TimeOffRequest != null &&
                TimeOffRequest.Equals(other.TimeOffRequest)
            ) &&
            (
                IntegrationStatus == other.IntegrationStatus ||
                IntegrationStatus != null &&
                IntegrationStatus.Equals(other.IntegrationStatus)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
            if (TimeOffRequest != null)
            {
                hash = hash * 59 + TimeOffRequest.GetHashCode();
            }

            if (IntegrationStatus != null)
            {
                hash = hash * 59 + IntegrationStatus.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
