using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAggregationView
/// </summary>

public partial class JourneyAggregationView : IEquatable<JourneyAggregationView>
{
    /// <summary>
    /// Target metric name
    /// </summary>
    /// <value>Target metric name</value>
    
    public enum TargetEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ndistinctjourneyactions for "nDistinctJourneyActions"
        /// </summary>
        [EnumMember(Value = "nDistinctJourneyActions")]
        Ndistinctjourneyactions,

        /// <summary>
        /// Enum Ndistinctjourneysessions for "nDistinctJourneySessions"
        /// </summary>
        [EnumMember(Value = "nDistinctJourneySessions")]
        Ndistinctjourneysessions,

        /// <summary>
        /// Enum Njourneyactionsblocked for "nJourneyActionsBlocked"
        /// </summary>
        [EnumMember(Value = "nJourneyActionsBlocked")]
        Njourneyactionsblocked,

        /// <summary>
        /// Enum Njourneyoutcomesachieved for "nJourneyOutcomesAchieved"
        /// </summary>
        [EnumMember(Value = "nJourneyOutcomesAchieved")]
        Njourneyoutcomesachieved,

        /// <summary>
        /// Enum Njourneyoutcomesattributed for "nJourneyOutcomesAttributed"
        /// </summary>
        [EnumMember(Value = "nJourneyOutcomesAttributed")]
        Njourneyoutcomesattributed,

        /// <summary>
        /// Enum Njourneysegmentsassigned for "nJourneySegmentsAssigned"
        /// </summary>
        [EnumMember(Value = "nJourneySegmentsAssigned")]
        Njourneysegmentsassigned,

        /// <summary>
        /// Enum Njourneysessions for "nJourneySessions"
        /// </summary>
        [EnumMember(Value = "nJourneySessions")]
        Njourneysessions,

        /// <summary>
        /// Enum Nwebactionsabandoned for "nWebActionsAbandoned"
        /// </summary>
        [EnumMember(Value = "nWebActionsAbandoned")]
        Nwebactionsabandoned,

        /// <summary>
        /// Enum Nwebactionsaccepted for "nWebActionsAccepted"
        /// </summary>
        [EnumMember(Value = "nWebActionsAccepted")]
        Nwebactionsaccepted,

        /// <summary>
        /// Enum Nwebactionsengaged for "nWebActionsEngaged"
        /// </summary>
        [EnumMember(Value = "nWebActionsEngaged")]
        Nwebactionsengaged,

        /// <summary>
        /// Enum Nwebactionserrored for "nWebActionsErrored"
        /// </summary>
        [EnumMember(Value = "nWebActionsErrored")]
        Nwebactionserrored,

        /// <summary>
        /// Enum Nwebactionsfrequencycapreached for "nWebActionsFrequencyCapReached"
        /// </summary>
        [EnumMember(Value = "nWebActionsFrequencyCapReached")]
        Nwebactionsfrequencycapreached,

        /// <summary>
        /// Enum Nwebactionsignored for "nWebActionsIgnored"
        /// </summary>
        [EnumMember(Value = "nWebActionsIgnored")]
        Nwebactionsignored,

        /// <summary>
        /// Enum Nwebactionsoffered for "nWebActionsOffered"
        /// </summary>
        [EnumMember(Value = "nWebActionsOffered")]
        Nwebactionsoffered,

        /// <summary>
        /// Enum Nwebactionsofferedoutsideschedule for "nWebActionsOfferedOutsideSchedule"
        /// </summary>
        [EnumMember(Value = "nWebActionsOfferedOutsideSchedule")]
        Nwebactionsofferedoutsideschedule,

        /// <summary>
        /// Enum Nwebactionsqualified for "nWebActionsQualified"
        /// </summary>
        [EnumMember(Value = "nWebActionsQualified")]
        Nwebactionsqualified,

        /// <summary>
        /// Enum Nwebactionsqualifiedoutsideschedule for "nWebActionsQualifiedOutsideSchedule"
        /// </summary>
        [EnumMember(Value = "nWebActionsQualifiedOutsideSchedule")]
        Nwebactionsqualifiedoutsideschedule,

        /// <summary>
        /// Enum Nwebactionsrejected for "nWebActionsRejected"
        /// </summary>
        [EnumMember(Value = "nWebActionsRejected")]
        Nwebactionsrejected,

        /// <summary>
        /// Enum Nwebactionsstarted for "nWebActionsStarted"
        /// </summary>
        [EnumMember(Value = "nWebActionsStarted")]
        Nwebactionsstarted,

        /// <summary>
        /// Enum Nwebactionstimedout for "nWebActionsTimedout"
        /// </summary>
        [EnumMember(Value = "nWebActionsTimedout")]
        Nwebactionstimedout,

        /// <summary>
        /// Enum Ojourneyoutcometouchpointvalue for "oJourneyOutcomeTouchpointValue"
        /// </summary>
        [EnumMember(Value = "oJourneyOutcomeTouchpointValue")]
        Ojourneyoutcometouchpointvalue,

        /// <summary>
        /// Enum Ojourneyoutcomevalue for "oJourneyOutcomeValue"
        /// </summary>
        [EnumMember(Value = "oJourneyOutcomeValue")]
        Ojourneyoutcomevalue
    }
    /// <summary>
    /// Type of view you wish to create
    /// </summary>
    /// <value>Type of view you wish to create</value>
    
    public enum FunctionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Rangebound for "rangeBound"
        /// </summary>
        [EnumMember(Value = "rangeBound")]
        Rangebound
    }
    /// <summary>
    /// Target metric name
    /// </summary>
    /// <value>Target metric name</value>
    [JsonPropertyName("target")]
    public TargetEnum? Target { get; set; }
    /// <summary>
    /// Type of view you wish to create
    /// </summary>
    /// <value>Type of view you wish to create</value>
    [JsonPropertyName("function")]
    public FunctionEnum? Function { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAggregationView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyAggregationView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAggregationView" /> class.
    /// </summary>
    /// <param name="Target">Target metric name (required).</param>
    /// <param name="Name">A unique name for this view. Must be distinct from other views and built-in metric names. (required).</param>
    /// <param name="Function">Type of view you wish to create (required).</param>
    /// <param name="Range">Range of numbers for slicing up data.</param>
    public JourneyAggregationView(TargetEnum? Target = null, string Name = null, FunctionEnum? Function = null, AggregationRange Range = null)
    {
        this.Target = Target;
        this.Name = Name;
        this.Function = Function;
        this.Range = Range;

    }





    /// <summary>
    /// A unique name for this view. Must be distinct from other views and built-in metric names.
    /// </summary>
    /// <value>A unique name for this view. Must be distinct from other views and built-in metric names.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// Range of numbers for slicing up data
    /// </summary>
    /// <value>Range of numbers for slicing up data</value>
    [JsonPropertyName("range")]
    public AggregationRange Range { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAggregationView {\n");

        sb.Append("  Target: ").Append(Target).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Function: ").Append(Function).Append("\n");
        sb.Append("  Range: ").Append(Range).Append("\n");
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
        return Equals(obj as JourneyAggregationView);
    }

    /// <summary>
    /// Returns true if JourneyAggregationView instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAggregationView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAggregationView other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Target == other.Target ||
                Target != null &&
                Target.Equals(other.Target)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Function == other.Function ||
                Function != null &&
                Function.Equals(other.Function)
            ) &&
            (
                Range == other.Range ||
                Range != null &&
                Range.Equals(other.Range)
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
            if (Target != null)
            {
                hash = hash * 59 + Target.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Function != null)
            {
                hash = hash * 59 + Function.GetHashCode();
            }

            if (Range != null)
            {
                hash = hash * 59 + Range.GetHashCode();
            }

            return hash;
        }
    }
}
