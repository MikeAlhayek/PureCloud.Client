using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// AgentCopilotAggregationView
/// </summary>
[DataContract]
public partial class AgentCopilotAggregationView : IEquatable<AgentCopilotAggregationView>
{
    /// <summary>
    /// Target metric name
    /// </summary>
    /// <value>Target metric name</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Ncannedresponsesuggestions for "nCannedResponseSuggestions"
        /// </summary>
        [EnumMember(Value = "nCannedResponseSuggestions")]
        Ncannedresponsesuggestions,

        /// <summary>
        /// Enum Ndistinctsuggestions for "nDistinctSuggestions"
        /// </summary>
        [EnumMember(Value = "nDistinctSuggestions")]
        Ndistinctsuggestions,

        /// <summary>
        /// Enum Nknowledgearticlesuggestions for "nKnowledgeArticleSuggestions"
        /// </summary>
        [EnumMember(Value = "nKnowledgeArticleSuggestions")]
        Nknowledgearticlesuggestions,

        /// <summary>
        /// Enum Nknowledgesearchsuggestions for "nKnowledgeSearchSuggestions"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearchSuggestions")]
        Nknowledgesearchsuggestions,

        /// <summary>
        /// Enum Nscriptsuggestions for "nScriptSuggestions"
        /// </summary>
        [EnumMember(Value = "nScriptSuggestions")]
        Nscriptsuggestions
    }
    /// <summary>
    /// Type of view you wish to create
    /// </summary>
    /// <value>Type of view you wish to create</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "target", EmitDefaultValue = false)]
    public TargetEnum? Target { get; set; }
    /// <summary>
    /// Type of view you wish to create
    /// </summary>
    /// <value>Type of view you wish to create</value>
    [DataMember(Name = "function", EmitDefaultValue = false)]
    public FunctionEnum? Function { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCopilotAggregationView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentCopilotAggregationView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentCopilotAggregationView" /> class.
    /// </summary>
    /// <param name="Target">Target metric name (required).</param>
    /// <param name="Name">A unique name for this view. Must be distinct from other views and built-in metric names. (required).</param>
    /// <param name="Function">Type of view you wish to create (required).</param>
    /// <param name="Range">Range of numbers for slicing up data.</param>
    public AgentCopilotAggregationView(TargetEnum? Target = null, string Name = null, FunctionEnum? Function = null, AggregationRange Range = null)
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
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }





    /// <summary>
    /// Range of numbers for slicing up data
    /// </summary>
    /// <value>Range of numbers for slicing up data</value>
    [DataMember(Name = "range", EmitDefaultValue = false)]
    public AggregationRange Range { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentCopilotAggregationView {\n");

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
        return this.Equals(obj as AgentCopilotAggregationView);
    }

    /// <summary>
    /// Returns true if AgentCopilotAggregationView instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentCopilotAggregationView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentCopilotAggregationView other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Target == other.Target ||
                this.Target != null &&
                this.Target.Equals(other.Target)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Function == other.Function ||
                this.Function != null &&
                this.Function.Equals(other.Function)
            ) &&
            (
                this.Range == other.Range ||
                this.Range != null &&
                this.Range.Equals(other.Range)
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
            if (this.Target != null)
            {
                hash = hash * 59 + this.Target.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Function != null)
            {
                hash = hash * 59 + this.Function.GetHashCode();
            }

            if (this.Range != null)
            {
                hash = hash * 59 + this.Range.GetHashCode();
            }

            return hash;
        }
    }
}
