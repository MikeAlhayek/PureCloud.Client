using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete
/// </summary>

public partial class WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete : IEquatable<WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
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
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete" /> class.
    /// </summary>
    /// <param name="Status">Status.</param>
    public WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete(StatusEnum? Status = null)
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
        sb.Append("class WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete {\n");

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
        return Equals(obj as WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete);
    }

    /// <summary>
    /// Returns true if WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete other)
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
