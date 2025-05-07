using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RegisterArchitectExportJobResponse
/// </summary>

public partial class RegisterArchitectExportJobResponse : IEquatable<RegisterArchitectExportJobResponse>
{
    /// <summary>
    /// The status of the export job.
    /// </summary>
    /// <value>The status of the export job.</value>
    
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
        /// Enum Registered for "Registered"
        /// </summary>
        [EnumMember(Value = "Registered")]
        Registered,

        /// <summary>
        /// Enum Started for "Started"
        /// </summary>
        [EnumMember(Value = "Started")]
        Started,

        /// <summary>
        /// Enum Success for "Success"
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// Enum Failure for "Failure"
        /// </summary>
        [EnumMember(Value = "Failure")]
        Failure
    }
    /// <summary>
    /// The status of the export job.
    /// </summary>
    /// <value>The status of the export job.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RegisterArchitectExportJobResponse" /> class.
    /// </summary>
    /// <param name="Status">The status of the export job..</param>
    /// <param name="TotalFlows">The number of flows submitted for export..</param>
    public RegisterArchitectExportJobResponse(StatusEnum? Status = null, int? TotalFlows = null)
    {
        this.Status = Status;
        this.TotalFlows = TotalFlows;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The number of flows submitted for export.
    /// </summary>
    /// <value>The number of flows submitted for export.</value>
    [JsonPropertyName("totalFlows")]
    public int? TotalFlows { get; set; }



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
        sb.Append("class RegisterArchitectExportJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  TotalFlows: ").Append(TotalFlows).Append("\n");
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
        return Equals(obj as RegisterArchitectExportJobResponse);
    }

    /// <summary>
    /// Returns true if RegisterArchitectExportJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of RegisterArchitectExportJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RegisterArchitectExportJobResponse other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                TotalFlows == other.TotalFlows ||
                TotalFlows != null &&
                TotalFlows.Equals(other.TotalFlows)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (TotalFlows != null)
            {
                hash = hash * 59 + TotalFlows.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
