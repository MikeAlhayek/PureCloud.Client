using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification
/// </summary>

public partial class ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification : IEquatable<ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification" /> class.
    /// </summary>
    /// <param name="Status">The organization&#39;s new dependency tracking build status.</param>
    /// <param name="User">User.</param>
    /// <param name="Client">Client.</param>
    /// <param name="StartTime">The time the last build started, in ISO 8601 format.</param>
    public ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification(string Status = null, ArchitectDependencyTrackingBuildNotificationUser User = null, ArchitectDependencyTrackingBuildNotificationClient Client = null, DateTime? StartTime = null)
    {
        this.Status = Status;
        this.User = User;
        this.Client = Client;
        this.StartTime = StartTime;

    }



    /// <summary>
    /// The organization&#39;s new dependency tracking build status
    /// </summary>
    /// <value>The organization&#39;s new dependency tracking build status</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public ArchitectDependencyTrackingBuildNotificationUser User { get; set; }



    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    [JsonPropertyName("client")]
    public ArchitectDependencyTrackingBuildNotificationClient Client { get; set; }



    /// <summary>
    /// The time the last build started, in ISO 8601 format
    /// </summary>
    /// <value>The time the last build started, in ISO 8601 format</value>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification {\n");

        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
        return Equals(obj as ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification);
    }

    /// <summary>
    /// Returns true if ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification other)
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
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Client == other.Client ||
                Client != null &&
                Client.Equals(other.Client)
            ) &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Client != null)
            {
                hash = hash * 59 + Client.GetHashCode();
            }

            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            return hash;
        }
    }
}
