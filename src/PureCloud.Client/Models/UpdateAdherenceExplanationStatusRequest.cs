using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateAdherenceExplanationStatusRequest
/// </summary>

public partial class UpdateAdherenceExplanationStatusRequest : IEquatable<UpdateAdherenceExplanationStatusRequest>
{
    /// <summary>
    /// The status of the adherence explanation
    /// </summary>
    /// <value>The status of the adherence explanation</value>
    
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
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,

        /// <summary>
        /// Enum Denied for "Denied"
        /// </summary>
        [EnumMember(Value = "Denied")]
        Denied
    }
    /// <summary>
    /// The status of the adherence explanation
    /// </summary>
    /// <value>The status of the adherence explanation</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateAdherenceExplanationStatusRequest" /> class.
    /// </summary>
    /// <param name="Status">The status of the adherence explanation.</param>
    public UpdateAdherenceExplanationStatusRequest(StatusEnum? Status = null)
    {
        this.Status = Status;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateAdherenceExplanationStatusRequest {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as UpdateAdherenceExplanationStatusRequest);
    }

    /// <summary>
    /// Returns true if UpdateAdherenceExplanationStatusRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateAdherenceExplanationStatusRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateAdherenceExplanationStatusRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
