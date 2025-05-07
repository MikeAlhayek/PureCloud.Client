using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActivityCode
/// </summary>

public partial class ActivityCode : IEquatable<ActivityCode>
{
    /// <summary>
    /// The activity code's category.
    /// </summary>
    /// <value>The activity code's category.</value>
    
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
    /// The activity code's category.
    /// </summary>
    /// <value>The activity code's category.</value>
    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityCode" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActivityCode() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityCode" /> class.
    /// </summary>
    /// <param name="Name">The name of the activity code. Default activity codes will be created with an empty name.</param>
    /// <param name="IsActive">Whether this activity code is active or has been deleted.</param>
    /// <param name="IsDefault">Whether this is a default activity code.</param>
    /// <param name="Category">The activity code&#39;s category..</param>
    /// <param name="LengthInMinutes">The default length of the activity in minutes.</param>
    /// <param name="CountsAsPaidTime">Whether an agent is paid while performing this activity.</param>
    /// <param name="CountsAsWorkTime">Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints.</param>
    /// <param name="AgentTimeOffSelectable">Whether an agent can select this activity code when creating or editing a time off request. Null if the activity&#39;s category is not time off..</param>
    /// <param name="Metadata">Version metadata for the associated management unit&#39;s list of activity codes (required).</param>
    public ActivityCode(string Name = null, bool? IsActive = null, bool? IsDefault = null, CategoryEnum? Category = null, int? LengthInMinutes = null, bool? CountsAsPaidTime = null, bool? CountsAsWorkTime = null, bool? AgentTimeOffSelectable = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Name = Name;
        this.IsActive = IsActive;
        this.IsDefault = IsDefault;
        this.Category = Category;
        this.LengthInMinutes = LengthInMinutes;
        this.CountsAsPaidTime = CountsAsPaidTime;
        this.CountsAsWorkTime = CountsAsWorkTime;
        this.AgentTimeOffSelectable = AgentTimeOffSelectable;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// The name of the activity code. Default activity codes will be created with an empty name
    /// </summary>
    /// <value>The name of the activity code. Default activity codes will be created with an empty name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Whether this activity code is active or has been deleted
    /// </summary>
    /// <value>Whether this activity code is active or has been deleted</value>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }



    /// <summary>
    /// Whether this is a default activity code
    /// </summary>
    /// <value>Whether this is a default activity code</value>
    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }





    /// <summary>
    /// The default length of the activity in minutes
    /// </summary>
    /// <value>The default length of the activity in minutes</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// Whether an agent is paid while performing this activity
    /// </summary>
    /// <value>Whether an agent is paid while performing this activity</value>
    [JsonPropertyName("countsAsPaidTime")]
    public bool? CountsAsPaidTime { get; set; }



    /// <summary>
    /// Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints
    /// </summary>
    /// <value>Indicates whether or not the activity should be counted as contiguous work time for calculating daily constraints</value>
    [JsonPropertyName("countsAsWorkTime")]
    public bool? CountsAsWorkTime { get; set; }



    /// <summary>
    /// Whether an agent can select this activity code when creating or editing a time off request. Null if the activity&#39;s category is not time off.
    /// </summary>
    /// <value>Whether an agent can select this activity code when creating or editing a time off request. Null if the activity&#39;s category is not time off.</value>
    [JsonPropertyName("agentTimeOffSelectable")]
    public bool? AgentTimeOffSelectable { get; set; }



    /// <summary>
    /// Version metadata for the associated management unit&#39;s list of activity codes
    /// </summary>
    /// <value>Version metadata for the associated management unit&#39;s list of activity codes</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActivityCode {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  CountsAsPaidTime: ").Append(CountsAsPaidTime).Append("\n");
        sb.Append("  CountsAsWorkTime: ").Append(CountsAsWorkTime).Append("\n");
        sb.Append("  AgentTimeOffSelectable: ").Append(AgentTimeOffSelectable).Append("\n");
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
        return Equals(obj as ActivityCode);
    }

    /// <summary>
    /// Returns true if ActivityCode instances are equal
    /// </summary>
    /// <param name="other">Instance of ActivityCode to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActivityCode other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                IsActive == other.IsActive ||
                IsActive != null &&
                IsActive.Equals(other.IsActive)
            ) &&
            (
                IsDefault == other.IsDefault ||
                IsDefault != null &&
                IsDefault.Equals(other.IsDefault)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (IsActive != null)
            {
                hash = hash * 59 + IsActive.GetHashCode();
            }

            if (IsDefault != null)
            {
                hash = hash * 59 + IsDefault.GetHashCode();
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

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
