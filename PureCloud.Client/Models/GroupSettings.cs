using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// GroupSettings
/// </summary>
[DataContract]
public partial class GroupSettings : IEquatable<GroupSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GroupSettings" /> class.
    /// </summary>
    /// <param name="MinimumGroupSize">The minimum size of a group for a session.</param>
    /// <param name="MaximumGroupSize">The maximum size of a group for a session.</param>
    /// <param name="MaximumTotalSessions">The maximum total number of sessions.</param>
    /// <param name="MaximumConcurrentSessions">The maximum number of sessions that can be scheduled concurrently.</param>
    public GroupSettings(int? MinimumGroupSize = null, int? MaximumGroupSize = null, int? MaximumTotalSessions = null, int? MaximumConcurrentSessions = null)
    {
        this.MinimumGroupSize = MinimumGroupSize;
        this.MaximumGroupSize = MaximumGroupSize;
        this.MaximumTotalSessions = MaximumTotalSessions;
        this.MaximumConcurrentSessions = MaximumConcurrentSessions;

    }



    /// <summary>
    /// The minimum size of a group for a session
    /// </summary>
    /// <value>The minimum size of a group for a session</value>
    [DataMember(Name = "minimumGroupSize", EmitDefaultValue = false)]
    public int? MinimumGroupSize { get; set; }



    /// <summary>
    /// The maximum size of a group for a session
    /// </summary>
    /// <value>The maximum size of a group for a session</value>
    [DataMember(Name = "maximumGroupSize", EmitDefaultValue = false)]
    public int? MaximumGroupSize { get; set; }



    /// <summary>
    /// The maximum total number of sessions
    /// </summary>
    /// <value>The maximum total number of sessions</value>
    [DataMember(Name = "maximumTotalSessions", EmitDefaultValue = false)]
    public int? MaximumTotalSessions { get; set; }



    /// <summary>
    /// The maximum number of sessions that can be scheduled concurrently
    /// </summary>
    /// <value>The maximum number of sessions that can be scheduled concurrently</value>
    [DataMember(Name = "maximumConcurrentSessions", EmitDefaultValue = false)]
    public int? MaximumConcurrentSessions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GroupSettings {\n");

        sb.Append("  MinimumGroupSize: ").Append(MinimumGroupSize).Append("\n");
        sb.Append("  MaximumGroupSize: ").Append(MaximumGroupSize).Append("\n");
        sb.Append("  MaximumTotalSessions: ").Append(MaximumTotalSessions).Append("\n");
        sb.Append("  MaximumConcurrentSessions: ").Append(MaximumConcurrentSessions).Append("\n");
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
        return Equals(obj as GroupSettings);
    }

    /// <summary>
    /// Returns true if GroupSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of GroupSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GroupSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MinimumGroupSize == other.MinimumGroupSize ||
                MinimumGroupSize != null &&
                MinimumGroupSize.Equals(other.MinimumGroupSize)
            ) &&
            (
                MaximumGroupSize == other.MaximumGroupSize ||
                MaximumGroupSize != null &&
                MaximumGroupSize.Equals(other.MaximumGroupSize)
            ) &&
            (
                MaximumTotalSessions == other.MaximumTotalSessions ||
                MaximumTotalSessions != null &&
                MaximumTotalSessions.Equals(other.MaximumTotalSessions)
            ) &&
            (
                MaximumConcurrentSessions == other.MaximumConcurrentSessions ||
                MaximumConcurrentSessions != null &&
                MaximumConcurrentSessions.Equals(other.MaximumConcurrentSessions)
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
            if (MinimumGroupSize != null)
            {
                hash = hash * 59 + MinimumGroupSize.GetHashCode();
            }

            if (MaximumGroupSize != null)
            {
                hash = hash * 59 + MaximumGroupSize.GetHashCode();
            }

            if (MaximumTotalSessions != null)
            {
                hash = hash * 59 + MaximumTotalSessions.GetHashCode();
            }

            if (MaximumConcurrentSessions != null)
            {
                hash = hash * 59 + MaximumConcurrentSessions.GetHashCode();
            }

            return hash;
        }
    }
}
