using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentTimeOffRequestPatch
/// </summary>

public partial class AgentTimeOffRequestPatch : IEquatable<AgentTimeOffRequestPatch>
{
    /// <summary>
    /// The status of this time off request. Can only be canceled if the requested date has not already passed
    /// </summary>
    /// <value>The status of this time off request. Can only be canceled if the requested date has not already passed</value>
    
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
        /// Enum Canceled for "CANCELED"
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        Canceled
    }
    /// <summary>
    /// The status of this time off request. Can only be canceled if the requested date has not already passed
    /// </summary>
    /// <value>The status of this time off request. Can only be canceled if the requested date has not already passed</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentTimeOffRequestPatch" /> class.
    /// </summary>
    /// <param name="MarkedAsRead">Whether this request has been read by the agent.</param>
    /// <param name="Status">The status of this time off request. Can only be canceled if the requested date has not already passed.</param>
    /// <param name="Notes">Notes about the time off request. Can only be edited while the request is still pending.</param>
    public AgentTimeOffRequestPatch(bool? MarkedAsRead = null, StatusEnum? Status = null, string Notes = null)
    {
        this.MarkedAsRead = MarkedAsRead;
        this.Status = Status;
        this.Notes = Notes;

    }



    /// <summary>
    /// Whether this request has been read by the agent
    /// </summary>
    /// <value>Whether this request has been read by the agent</value>
    [JsonPropertyName("markedAsRead")]
    public bool? MarkedAsRead { get; set; }





    /// <summary>
    /// Notes about the time off request. Can only be edited while the request is still pending
    /// </summary>
    /// <value>Notes about the time off request. Can only be edited while the request is still pending</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentTimeOffRequestPatch {\n");

        sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
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
        return Equals(obj as AgentTimeOffRequestPatch);
    }

    /// <summary>
    /// Returns true if AgentTimeOffRequestPatch instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentTimeOffRequestPatch to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentTimeOffRequestPatch other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MarkedAsRead == other.MarkedAsRead ||
                MarkedAsRead != null &&
                MarkedAsRead.Equals(other.MarkedAsRead)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
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
            if (MarkedAsRead != null)
            {
                hash = hash * 59 + MarkedAsRead.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            return hash;
        }
    }
}
