using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TaskManagementAggregationView
/// </summary>

public partial class TaskManagementAggregationView : IEquatable<TaskManagementAggregationView>
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
        /// Enum Nworkitemsacdcancelled for "nWorkitemsAcdCancelled"
        /// </summary>
        [EnumMember(Value = "nWorkitemsAcdCancelled")]
        Nworkitemsacdcancelled,

        /// <summary>
        /// Enum Nworkitemsacdexpired for "nWorkitemsAcdExpired"
        /// </summary>
        [EnumMember(Value = "nWorkitemsAcdExpired")]
        Nworkitemsacdexpired,

        /// <summary>
        /// Enum Nworkitemsacdstarted for "nWorkitemsAcdStarted"
        /// </summary>
        [EnumMember(Value = "nWorkitemsAcdStarted")]
        Nworkitemsacdstarted,

        /// <summary>
        /// Enum Nworkitemsagenttransferred for "nWorkitemsAgentTransferred"
        /// </summary>
        [EnumMember(Value = "nWorkitemsAgentTransferred")]
        Nworkitemsagenttransferred,

        /// <summary>
        /// Enum Nworkitemscreated for "nWorkitemsCreated"
        /// </summary>
        [EnumMember(Value = "nWorkitemsCreated")]
        Nworkitemscreated,

        /// <summary>
        /// Enum Nworkitemsdeclined for "nWorkitemsDeclined"
        /// </summary>
        [EnumMember(Value = "nWorkitemsDeclined")]
        Nworkitemsdeclined,

        /// <summary>
        /// Enum Nworkitemsdeleted for "nWorkitemsDeleted"
        /// </summary>
        [EnumMember(Value = "nWorkitemsDeleted")]
        Nworkitemsdeleted,

        /// <summary>
        /// Enum Nworkitemsdisconnected for "nWorkitemsDisconnected"
        /// </summary>
        [EnumMember(Value = "nWorkitemsDisconnected")]
        Nworkitemsdisconnected,

        /// <summary>
        /// Enum Nworkitemsoffered for "nWorkitemsOffered"
        /// </summary>
        [EnumMember(Value = "nWorkitemsOffered")]
        Nworkitemsoffered,

        /// <summary>
        /// Enum Nworkitemsoversla for "nWorkitemsOverSla"
        /// </summary>
        [EnumMember(Value = "nWorkitemsOverSla")]
        Nworkitemsoversla,

        /// <summary>
        /// Enum Nworkitemspurged for "nWorkitemsPurged"
        /// </summary>
        [EnumMember(Value = "nWorkitemsPurged")]
        Nworkitemspurged,

        /// <summary>
        /// Enum Nworkitemsqueuetransferred for "nWorkitemsQueueTransferred"
        /// </summary>
        [EnumMember(Value = "nWorkitemsQueueTransferred")]
        Nworkitemsqueuetransferred,

        /// <summary>
        /// Enum Nworkitemsstatuschanged for "nWorkitemsStatusChanged"
        /// </summary>
        [EnumMember(Value = "nWorkitemsStatusChanged")]
        Nworkitemsstatuschanged,

        /// <summary>
        /// Enum Nworkitemsterminated for "nWorkitemsTerminated"
        /// </summary>
        [EnumMember(Value = "nWorkitemsTerminated")]
        Nworkitemsterminated,

        /// <summary>
        /// Enum Nworkitemstimedout for "nWorkitemsTimedout"
        /// </summary>
        [EnumMember(Value = "nWorkitemsTimedout")]
        Nworkitemstimedout,

        /// <summary>
        /// Enum Nworkitemstransferred for "nWorkitemsTransferred"
        /// </summary>
        [EnumMember(Value = "nWorkitemsTransferred")]
        Nworkitemstransferred,

        /// <summary>
        /// Enum Nworkitemswrapupadded for "nWorkitemsWrapupAdded"
        /// </summary>
        [EnumMember(Value = "nWorkitemsWrapupAdded")]
        Nworkitemswrapupadded,

        /// <summary>
        /// Enum Nworkitemswrapupremoved for "nWorkitemsWrapupRemoved"
        /// </summary>
        [EnumMember(Value = "nWorkitemsWrapupRemoved")]
        Nworkitemswrapupremoved,

        /// <summary>
        /// Enum Oworkitemsservicelevel for "oWorkitemsServiceLevel"
        /// </summary>
        [EnumMember(Value = "oWorkitemsServiceLevel")]
        Oworkitemsservicelevel,

        /// <summary>
        /// Enum Tworkitemsagentfocuscomplete for "tWorkitemsAgentFocusComplete"
        /// </summary>
        [EnumMember(Value = "tWorkitemsAgentFocusComplete")]
        Tworkitemsagentfocuscomplete,

        /// <summary>
        /// Enum Tworkitemsalert for "tWorkitemsAlert"
        /// </summary>
        [EnumMember(Value = "tWorkitemsAlert")]
        Tworkitemsalert,

        /// <summary>
        /// Enum Tworkitemsanswered for "tWorkitemsAnswered"
        /// </summary>
        [EnumMember(Value = "tWorkitemsAnswered")]
        Tworkitemsanswered,

        /// <summary>
        /// Enum Tworkitemsdirectanswered for "tWorkitemsDirectAnswered"
        /// </summary>
        [EnumMember(Value = "tWorkitemsDirectAnswered")]
        Tworkitemsdirectanswered,

        /// <summary>
        /// Enum Tworkitemsfocus for "tWorkitemsFocus"
        /// </summary>
        [EnumMember(Value = "tWorkitemsFocus")]
        Tworkitemsfocus,

        /// <summary>
        /// Enum Tworkitemsfocuscomplete for "tWorkitemsFocusComplete"
        /// </summary>
        [EnumMember(Value = "tWorkitemsFocusComplete")]
        Tworkitemsfocuscomplete,

        /// <summary>
        /// Enum Tworkitemshandled for "tWorkitemsHandled"
        /// </summary>
        [EnumMember(Value = "tWorkitemsHandled")]
        Tworkitemshandled,

        /// <summary>
        /// Enum Tworkitemsheld for "tWorkitemsHeld"
        /// </summary>
        [EnumMember(Value = "tWorkitemsHeld")]
        Tworkitemsheld,

        /// <summary>
        /// Enum Tworkitemsheldcomplete for "tWorkitemsHeldComplete"
        /// </summary>
        [EnumMember(Value = "tWorkitemsHeldComplete")]
        Tworkitemsheldcomplete,

        /// <summary>
        /// Enum Tworkitemsnotresponding for "tWorkitemsNotResponding"
        /// </summary>
        [EnumMember(Value = "tWorkitemsNotResponding")]
        Tworkitemsnotresponding,

        /// <summary>
        /// Enum Tworkitemsparked for "tWorkitemsParked"
        /// </summary>
        [EnumMember(Value = "tWorkitemsParked")]
        Tworkitemsparked,

        /// <summary>
        /// Enum Tworkitemsqueueanswered for "tWorkitemsQueueAnswered"
        /// </summary>
        [EnumMember(Value = "tWorkitemsQueueAnswered")]
        Tworkitemsqueueanswered,

        /// <summary>
        /// Enum Tworkitemsstatus for "tWorkitemsStatus"
        /// </summary>
        [EnumMember(Value = "tWorkitemsStatus")]
        Tworkitemsstatus
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
    /// Initializes a new instance of the <see cref="TaskManagementAggregationView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TaskManagementAggregationView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TaskManagementAggregationView" /> class.
    /// </summary>
    /// <param name="Target">Target metric name (required).</param>
    /// <param name="Name">A unique name for this view. Must be distinct from other views and built-in metric names. (required).</param>
    /// <param name="Function">Type of view you wish to create (required).</param>
    /// <param name="Range">Range of numbers for slicing up data.</param>
    public TaskManagementAggregationView(TargetEnum? Target = null, string Name = null, FunctionEnum? Function = null, AggregationRange Range = null)
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
        sb.Append("class TaskManagementAggregationView {\n");

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
        return Equals(obj as TaskManagementAggregationView);
    }

    /// <summary>
    /// Returns true if TaskManagementAggregationView instances are equal
    /// </summary>
    /// <param name="other">Instance of TaskManagementAggregationView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TaskManagementAggregationView other)
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
