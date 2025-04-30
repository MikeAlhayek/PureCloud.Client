using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// DialerCampaignScheduleConfigChangeCampaignSchedule
    /// </summary>
    [DataContract]
    public partial class DialerCampaignScheduleConfigChangeCampaignSchedule :  IEquatable<DialerCampaignScheduleConfigChangeCampaignSchedule>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignScheduleConfigChangeCampaignSchedule" /> class.
        /// </summary>
        /// <param name="Intervals">a list of start and end times.</param>
        /// <param name="Recurrences">a list of recurrences for a schedule.</param>
        /// <param name="TimeZone">time zone identifier to be applied to the intervals; for example Africa/Abidjan.</param>
        /// <param name="Campaign">Campaign.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Id">The globally unique identifier for the object..</param>
        /// <param name="Name">The UI-visible name of the object.</param>
        /// <param name="DateCreated">Creation time of the entity.</param>
        /// <param name="DateModified">Last modified time of the entity.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        public DialerCampaignScheduleConfigChangeCampaignSchedule(List<DialerCampaignScheduleConfigChangeScheduleInterval> Intervals = null, List<DialerCampaignScheduleConfigChangeScheduleRecurrence> Recurrences = null, string TimeZone = null, DialerCampaignScheduleConfigChangeUriReference Campaign = null, Dictionary<string, Object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
        {
            this.Intervals = Intervals;
            this.Recurrences = Recurrences;
            this.TimeZone = TimeZone;
            this.Campaign = Campaign;
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
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<DialerCampaignScheduleConfigChangeScheduleInterval> Intervals { get; set; }



        /// <summary>
        /// a list of recurrences for a schedule
        /// </summary>
        /// <value>a list of recurrences for a schedule</value>
        [DataMember(Name="recurrences", EmitDefaultValue=false)]
        public List<DialerCampaignScheduleConfigChangeScheduleRecurrence> Recurrences { get; set; }



        /// <summary>
        /// time zone identifier to be applied to the intervals; for example Africa/Abidjan
        /// </summary>
        /// <value>time zone identifier to be applied to the intervals; for example Africa/Abidjan</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }



        /// <summary>
        /// Gets or Sets Campaign
        /// </summary>
        [DataMember(Name="campaign", EmitDefaultValue=false)]
        public DialerCampaignScheduleConfigChangeUriReference Campaign { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }



        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }



        /// <summary>
        /// The UI-visible name of the object
        /// </summary>
        /// <value>The UI-visible name of the object</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity
        /// </summary>
        /// <value>Creation time of the entity</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }



        /// <summary>
        /// Last modified time of the entity
        /// </summary>
        /// <value>Last modified time of the entity</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignScheduleConfigChangeCampaignSchedule {\n");

            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
            sb.Append("  Recurrences: ").Append(Recurrences).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Campaign: ").Append(Campaign).Append("\n");
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
            return this.Equals(obj as DialerCampaignScheduleConfigChangeCampaignSchedule);
        }

        /// <summary>
        /// Returns true if DialerCampaignScheduleConfigChangeCampaignSchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignScheduleConfigChangeCampaignSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignScheduleConfigChangeCampaignSchedule other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Intervals == other.Intervals ||
                    this.Intervals != null &&
                    this.Intervals.SequenceEqual(other.Intervals)
                ) &&
                (
                    this.Recurrences == other.Recurrences ||
                    this.Recurrences != null &&
                    this.Recurrences.SequenceEqual(other.Recurrences)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.Campaign == other.Campaign ||
                    this.Campaign != null &&
                    this.Campaign.Equals(other.Campaign)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Intervals != null)
                    hash = hash * 59 + this.Intervals.GetHashCode();

                if (this.Recurrences != null)
                    hash = hash * 59 + this.Recurrences.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.Campaign != null)
                    hash = hash * 59 + this.Campaign.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                return hash;
            }
        }
    }

}
