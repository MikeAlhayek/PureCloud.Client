using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeAggregationView
/// </summary>

public partial class KnowledgeAggregationView : IEquatable<KnowledgeAggregationView>
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
        /// Enum Ndistinctknowledgesessions for "nDistinctKnowledgeSessions"
        /// </summary>
        [EnumMember(Value = "nDistinctKnowledgeSessions")]
        Ndistinctknowledgesessions,

        /// <summary>
        /// Enum Nknowledgedocumentcopied for "nKnowledgeDocumentCopied"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentCopied")]
        Nknowledgedocumentcopied,

        /// <summary>
        /// Enum Nknowledgedocumentfeedback for "nKnowledgeDocumentFeedback"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentFeedback")]
        Nknowledgedocumentfeedback,

        /// <summary>
        /// Enum Nknowledgedocumentpresented for "nKnowledgeDocumentPresented"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentPresented")]
        Nknowledgedocumentpresented,

        /// <summary>
        /// Enum Nknowledgedocumentsurfaced for "nKnowledgeDocumentSurfaced"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentSurfaced")]
        Nknowledgedocumentsurfaced,

        /// <summary>
        /// Enum Nknowledgedocumentviewed for "nKnowledgeDocumentViewed"
        /// </summary>
        [EnumMember(Value = "nKnowledgeDocumentViewed")]
        Nknowledgedocumentviewed,

        /// <summary>
        /// Enum Nknowledgesearch for "nKnowledgeSearch"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearch")]
        Nknowledgesearch,

        /// <summary>
        /// Enum Nknowledgesearchanswered for "nKnowledgeSearchAnswered"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearchAnswered")]
        Nknowledgesearchanswered,

        /// <summary>
        /// Enum Nknowledgesearchfeedback for "nKnowledgeSearchFeedback"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearchFeedback")]
        Nknowledgesearchfeedback,

        /// <summary>
        /// Enum Nknowledgesearchunanswered for "nKnowledgeSearchUnanswered"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSearchUnanswered")]
        Nknowledgesearchunanswered,

        /// <summary>
        /// Enum Nknowledgesessions for "nKnowledgeSessions"
        /// </summary>
        [EnumMember(Value = "nKnowledgeSessions")]
        Nknowledgesessions,

        /// <summary>
        /// Enum Oknowledgedocumentquery for "oKnowledgeDocumentQuery"
        /// </summary>
        [EnumMember(Value = "oKnowledgeDocumentQuery")]
        Oknowledgedocumentquery,

        /// <summary>
        /// Enum Oknowledgedocumentqueryselfserved for "oKnowledgeDocumentQuerySelfServed"
        /// </summary>
        [EnumMember(Value = "oKnowledgeDocumentQuerySelfServed")]
        Oknowledgedocumentqueryselfserved,

        /// <summary>
        /// Enum Oknowledgesearch for "oKnowledgeSearch"
        /// </summary>
        [EnumMember(Value = "oKnowledgeSearch")]
        Oknowledgesearch
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
    /// Initializes a new instance of the <see cref="KnowledgeAggregationView" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeAggregationView() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeAggregationView" /> class.
    /// </summary>
    /// <param name="Target">Target metric name (required).</param>
    /// <param name="Name">A unique name for this view. Must be distinct from other views and built-in metric names. (required).</param>
    /// <param name="Function">Type of view you wish to create (required).</param>
    /// <param name="Range">Range of numbers for slicing up data.</param>
    public KnowledgeAggregationView(TargetEnum? Target = null, string Name = null, FunctionEnum? Function = null, AggregationRange Range = null)
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
        sb.Append("class KnowledgeAggregationView {\n");

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
        return Equals(obj as KnowledgeAggregationView);
    }

    /// <summary>
    /// Returns true if KnowledgeAggregationView instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeAggregationView to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeAggregationView other)
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
