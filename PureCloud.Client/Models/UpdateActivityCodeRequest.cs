using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateActivityCodeRequest
/// </summary>
[DataContract]
public partial class UpdateActivityCodeRequest : IEquatable<UpdateActivityCodeRequest>
{
    /// <summary>
    /// The activity code's category. Attempting to change the category of a default activity code will return an error
    /// </summary>
    /// <value>The activity code's category. Attempting to change the category of a default activity code will return an error</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Onqueuework for "OnQueueWork"
        /// </summary>
        [EnumMember(Value = "OnQueueWork")]
        Onqueuework,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Offqueuework for "OffQueueWork"
        /// </summary>
        [EnumMember(Value = "OffQueueWork")]
        Offqueuework,

        /// <summary>
        /// Enum Timeoff for "TimeOff"
        /// </summary>
        [EnumMember(Value = "TimeOff")]
        Timeoff,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,

        /// <summary>
        /// Enum Unscheduled for "Unscheduled"
        /// </summary>
        [EnumMember(Value = "Unscheduled")]
        Unscheduled
    }
    /// <summary>
    /// The activity code's category. Attempting to change the category of a default activity code will return an error
    /// </summary>
    /// <value>The activity code's category. Attempting to change the category of a default activity code will return an error</value>
    [DataMember(Name = "category", EmitDefaultValue = false)]
    public CategoryEnum? Category { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateActivityCodeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateActivityCodeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateActivityCodeRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the activity code.</param>
    /// <param name="Category">The activity code&#39;s category. Attempting to change the category of a default activity code will return an error.</param>
    /// <param name="LengthInMinutes">The default length of the activity in minutes.</param>
    /// <param name="CountsAsPaidTime">Whether an agent is paid while performing this activity.</param>
    /// <param name="CountsAsWorkTime">Indicates whether or not the activity should be counted as work time.</param>
    /// <param name="AgentTimeOffSelectable">Whether an agent can select this activity code when creating or editing a time off request.</param>
    /// <param name="CountsTowardShrinkage">Whether or not this activity code counts toward shrinkage calculations.</param>
    /// <param name="PlannedShrinkage">Whether this activity code is considered planned or unplanned shrinkage.</param>
    /// <param name="Interruptible">Whether this activity code is considered interruptible.</param>
    /// <param name="SecondaryPresences">The secondary presences of this activity code.</param>
    /// <param name="Metadata">Version metadata for the associated business unit&#39;s list of activity codes (required).</param>
    public UpdateActivityCodeRequest(string Name = null, CategoryEnum? Category = null, int? LengthInMinutes = null, bool? CountsAsPaidTime = null, bool? CountsAsWorkTime = null, bool? AgentTimeOffSelectable = null, bool? CountsTowardShrinkage = null, bool? PlannedShrinkage = null, bool? Interruptible = null, ListWrapperSecondaryPresence SecondaryPresences = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.Category = Category;
        this.LengthInMinutes = LengthInMinutes;
        this.CountsAsPaidTime = CountsAsPaidTime;
        this.CountsAsWorkTime = CountsAsWorkTime;
        this.AgentTimeOffSelectable = AgentTimeOffSelectable;
        this.CountsTowardShrinkage = CountsTowardShrinkage;
        this.PlannedShrinkage = PlannedShrinkage;
        this.Interruptible = Interruptible;
        this.SecondaryPresences = SecondaryPresences;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The name of the activity code
    /// </summary>
    /// <value>The name of the activity code</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }





    /// <summary>
    /// The default length of the activity in minutes
    /// </summary>
    /// <value>The default length of the activity in minutes</value>
    [DataMember(Name = "lengthInMinutes", EmitDefaultValue = false)]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// Whether an agent is paid while performing this activity
    /// </summary>
    /// <value>Whether an agent is paid while performing this activity</value>
    [DataMember(Name = "countsAsPaidTime", EmitDefaultValue = false)]
    public bool? CountsAsPaidTime { get; set; }



    /// <summary>
    /// Indicates whether or not the activity should be counted as work time
    /// </summary>
    /// <value>Indicates whether or not the activity should be counted as work time</value>
    [DataMember(Name = "countsAsWorkTime", EmitDefaultValue = false)]
    public bool? CountsAsWorkTime { get; set; }



    /// <summary>
    /// Whether an agent can select this activity code when creating or editing a time off request
    /// </summary>
    /// <value>Whether an agent can select this activity code when creating or editing a time off request</value>
    [DataMember(Name = "agentTimeOffSelectable", EmitDefaultValue = false)]
    public bool? AgentTimeOffSelectable { get; set; }



    /// <summary>
    /// Whether or not this activity code counts toward shrinkage calculations
    /// </summary>
    /// <value>Whether or not this activity code counts toward shrinkage calculations</value>
    [DataMember(Name = "countsTowardShrinkage", EmitDefaultValue = false)]
    public bool? CountsTowardShrinkage { get; set; }



    /// <summary>
    /// Whether this activity code is considered planned or unplanned shrinkage
    /// </summary>
    /// <value>Whether this activity code is considered planned or unplanned shrinkage</value>
    [DataMember(Name = "plannedShrinkage", EmitDefaultValue = false)]
    public bool? PlannedShrinkage { get; set; }



    /// <summary>
    /// Whether this activity code is considered interruptible
    /// </summary>
    /// <value>Whether this activity code is considered interruptible</value>
    [DataMember(Name = "interruptible", EmitDefaultValue = false)]
    public bool? Interruptible { get; set; }



    /// <summary>
    /// The secondary presences of this activity code
    /// </summary>
    /// <value>The secondary presences of this activity code</value>
    [DataMember(Name = "secondaryPresences", EmitDefaultValue = false)]
    public ListWrapperSecondaryPresence SecondaryPresences { get; set; }



    /// <summary>
    /// Version metadata for the associated business unit&#39;s list of activity codes
    /// </summary>
    /// <value>Version metadata for the associated business unit&#39;s list of activity codes</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateActivityCodeRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
        sb.Append("  CountsAsWorkTime: ").Append(CountsAsWorkTime).Append("\n");
        sb.Append("  AgentTimeOffSelectable: ").Append(AgentTimeOffSelectable).Append("\n");
        sb.Append("  CountsTowardShrinkage: ").Append(CountsTowardShrinkage).Append("\n");
        sb.Append("  PlannedShrinkage: ").Append(PlannedShrinkage).Append("\n");
        sb.Append("  Interruptible: ").Append(Interruptible).Append("\n");
        sb.Append("  SecondaryPresences: ").Append(SecondaryPresences).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as UpdateActivityCodeRequest);
    }

    /// <summary>
    /// Returns true if UpdateActivityCodeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateActivityCodeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateActivityCodeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                CountsAsPaidTime == other.CountsAsPaidTime ||
                CountsAsPaidTime != null &&
                CountsAsPaidTime.Equals(other.CountsAsPaidTime)
            ) &&
            (
                CountsAsWorkTime == other.CountsAsWorkTime ||
                CountsAsWorkTime != null &&
                CountsAsWorkTime.Equals(other.CountsAsWorkTime)
            ) &&
            (
                AgentTimeOffSelectable == other.AgentTimeOffSelectable ||
                AgentTimeOffSelectable != null &&
                AgentTimeOffSelectable.Equals(other.AgentTimeOffSelectable)
            ) &&
            (
                CountsTowardShrinkage == other.CountsTowardShrinkage ||
                CountsTowardShrinkage != null &&
                CountsTowardShrinkage.Equals(other.CountsTowardShrinkage)
            ) &&
            (
                PlannedShrinkage == other.PlannedShrinkage ||
                PlannedShrinkage != null &&
                PlannedShrinkage.Equals(other.PlannedShrinkage)
            ) &&
            (
                Interruptible == other.Interruptible ||
                Interruptible != null &&
                Interruptible.Equals(other.Interruptible)
            ) &&
            (
                SecondaryPresences == other.SecondaryPresences ||
                SecondaryPresences != null &&
                SecondaryPresences.Equals(other.SecondaryPresences)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (CountsAsPaidTime != null)
            {
                hash = hash * 59 + CountsAsPaidTime.GetHashCode();
            }

            if (CountsAsWorkTime != null)
            {
                hash = hash * 59 + CountsAsWorkTime.GetHashCode();
            }

            if (AgentTimeOffSelectable != null)
            {
                hash = hash * 59 + AgentTimeOffSelectable.GetHashCode();
            }

            if (CountsTowardShrinkage != null)
            {
                hash = hash * 59 + CountsTowardShrinkage.GetHashCode();
            }

            if (PlannedShrinkage != null)
            {
                hash = hash * 59 + PlannedShrinkage.GetHashCode();
            }

            if (Interruptible != null)
            {
                hash = hash * 59 + Interruptible.GetHashCode();
            }

            if (SecondaryPresences != null)
            {
                hash = hash * 59 + SecondaryPresences.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
