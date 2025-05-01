using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserScheduleContainer
/// </summary>
[DataContract]
public partial class UserScheduleContainer : IEquatable<UserScheduleContainer>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserScheduleContainer" /> class.
    /// </summary>
    /// <param name="ManagementUnitTimeZone">The reference time zone used for the management unit.</param>
    /// <param name="PublishedSchedules">References to all published week schedules overlapping the start/end date query parameters.</param>
    /// <param name="UserSchedules">Map of user id to user schedule.</param>
    public UserScheduleContainer(string ManagementUnitTimeZone = null, List<WeekScheduleReference> PublishedSchedules = null, Dictionary<string, UserSchedule> UserSchedules = null)
    {
        this.ManagementUnitTimeZone = ManagementUnitTimeZone;
        this.PublishedSchedules = PublishedSchedules;
        this.UserSchedules = UserSchedules;

    }



    /// <summary>
    /// The reference time zone used for the management unit
    /// </summary>
    /// <value>The reference time zone used for the management unit</value>
    [DataMember(Name = "managementUnitTimeZone", EmitDefaultValue = false)]
    public string ManagementUnitTimeZone { get; set; }



    /// <summary>
    /// References to all published week schedules overlapping the start/end date query parameters
    /// </summary>
    /// <value>References to all published week schedules overlapping the start/end date query parameters</value>
    [DataMember(Name = "publishedSchedules", EmitDefaultValue = false)]
    public List<WeekScheduleReference> PublishedSchedules { get; set; }



    /// <summary>
    /// Map of user id to user schedule
    /// </summary>
    /// <value>Map of user id to user schedule</value>
    [DataMember(Name = "userSchedules", EmitDefaultValue = false)]
    public Dictionary<string, UserSchedule> UserSchedules { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserScheduleContainer {\n");

        sb.Append("  ManagementUnitTimeZone: ").Append(ManagementUnitTimeZone).Append("\n");
        sb.Append("  PublishedSchedules: ").Append(PublishedSchedules).Append("\n");
        sb.Append("  UserSchedules: ").Append(UserSchedules).Append("\n");
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
        return Equals(obj as UserScheduleContainer);
    }

    /// <summary>
    /// Returns true if UserScheduleContainer instances are equal
    /// </summary>
    /// <param name="other">Instance of UserScheduleContainer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserScheduleContainer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ManagementUnitTimeZone == other.ManagementUnitTimeZone ||
                ManagementUnitTimeZone != null &&
                ManagementUnitTimeZone.Equals(other.ManagementUnitTimeZone)
            ) &&
            (
                PublishedSchedules == other.PublishedSchedules ||
                PublishedSchedules != null &&
                PublishedSchedules.SequenceEqual(other.PublishedSchedules)
            ) &&
            (
                UserSchedules == other.UserSchedules ||
                UserSchedules != null &&
                UserSchedules.SequenceEqual(other.UserSchedules)
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
            if (ManagementUnitTimeZone != null)
            {
                hash = hash * 59 + ManagementUnitTimeZone.GetHashCode();
            }

            if (PublishedSchedules != null)
            {
                hash = hash * 59 + PublishedSchedules.GetHashCode();
            }

            if (UserSchedules != null)
            {
                hash = hash * 59 + UserSchedules.GetHashCode();
            }

            return hash;
        }
    }
}
