using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerSequenceScheduleConfigChangeSequenceSchedule
/// </summary>
[DataContract]
public partial class DialerSequenceScheduleConfigChangeSequenceSchedule : IEquatable<DialerSequenceScheduleConfigChangeSequenceSchedule>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerSequenceScheduleConfigChangeSequenceSchedule" /> class.
    /// </summary>
    /// <param name="Intervals">a list of start and end times.</param>
    /// <param name="Recurrences">a list of recurrences for a schedule.</param>
    /// <param name="TimeZone">time zone identifier to be applied to the intervals; for example Africa/Abidjan.</param>
    /// <param name="Sequence">Sequence.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerSequenceScheduleConfigChangeSequenceSchedule(List<DialerSequenceScheduleConfigChangeScheduleInterval> Intervals = null, List<DialerSequenceScheduleConfigChangeScheduleRecurrence> Recurrences = null, string TimeZone = null, DialerSequenceScheduleConfigChangeUriReference Sequence = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
        this.Intervals = Intervals;
        this.Recurrences = Recurrences;
        this.TimeZone = TimeZone;
        this.Sequence = Sequence;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// a list of start and end times
    /// </summary>
    /// <value>a list of start and end times</value>
    [DataMember(Name = "intervals", EmitDefaultValue = false)]
    public List<DialerSequenceScheduleConfigChangeScheduleInterval> Intervals { get; set; }



    /// <summary>
    /// a list of recurrences for a schedule
    /// </summary>
    /// <value>a list of recurrences for a schedule</value>
    [DataMember(Name = "recurrences", EmitDefaultValue = false)]
    public List<DialerSequenceScheduleConfigChangeScheduleRecurrence> Recurrences { get; set; }



    /// <summary>
    /// time zone identifier to be applied to the intervals; for example Africa/Abidjan
    /// </summary>
    /// <value>time zone identifier to be applied to the intervals; for example Africa/Abidjan</value>
    [DataMember(Name = "timeZone", EmitDefaultValue = false)]
    public string TimeZone { get; set; }



    /// <summary>
    /// Gets or Sets Sequence
    /// </summary>
    [DataMember(Name = "sequence", EmitDefaultValue = false)]
    public DialerSequenceScheduleConfigChangeUriReference Sequence { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerSequenceScheduleConfigChangeSequenceSchedule {\n");

        sb.Append("  Intervals: ").Append(Intervals).Append("\n");
        sb.Append("  Recurrences: ").Append(Recurrences).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  Sequence: ").Append(Sequence).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerSequenceScheduleConfigChangeSequenceSchedule);
    }

    /// <summary>
    /// Returns true if DialerSequenceScheduleConfigChangeSequenceSchedule instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerSequenceScheduleConfigChangeSequenceSchedule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerSequenceScheduleConfigChangeSequenceSchedule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Intervals == other.Intervals ||
                Intervals != null &&
                Intervals.SequenceEqual(other.Intervals)
            ) &&
            (
                Recurrences == other.Recurrences ||
                Recurrences != null &&
                Recurrences.SequenceEqual(other.Recurrences)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                Sequence == other.Sequence ||
                Sequence != null &&
                Sequence.Equals(other.Sequence)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (Intervals != null)
            {
                hash = hash * 59 + Intervals.GetHashCode();
            }

            if (Recurrences != null)
            {
                hash = hash * 59 + Recurrences.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (Sequence != null)
            {
                hash = hash * 59 + Sequence.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
