using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GraphApiSettings
/// </summary>

public partial class GraphApiSettings : IEquatable<GraphApiSettings>
{
    /// <summary>
    /// Graph API Server Status
    /// </summary>
    /// <value>Graph API Server Status</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,

        /// <summary>
        /// Enum Integrationdeleted for "IntegrationDeleted"
        /// </summary>
        [EnumMember(Value = "IntegrationDeleted")]
        Integrationdeleted,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Graph API Server Status
    /// </summary>
    /// <value>Graph API Server Status</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="GraphApiSettings" /> class.
    /// </summary>
    /// <param name="Integration">The Graph API server integration to use for emails..</param>
    public GraphApiSettings(DomainEntityRef Integration = null)
    {
        this.Integration = Integration;

    }



    /// <summary>
    /// The Graph API server integration to use for emails.
    /// </summary>
    /// <value>The Graph API server integration to use for emails.</value>
    [JsonPropertyName("integration")]
    public DomainEntityRef Integration { get; set; }





    /// <summary>
    /// Additional Graph API Server error information
    /// </summary>
    /// <value>Additional Graph API Server error information</value>
    [JsonPropertyName("errorInfo")]
    public EmailErrorInfo ErrorInfo { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GraphApiSettings {\n");

        sb.Append("  Integration: ").Append(Integration).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as GraphApiSettings);
    }

    /// <summary>
    /// Returns true if GraphApiSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of GraphApiSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GraphApiSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Integration == other.Integration ||
                Integration != null &&
                Integration.Equals(other.Integration)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (Integration != null)
            {
                hash = hash * 59 + Integration.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            return hash;
        }
    }
}
