using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ActionAggregationView
{
    /// <summary>
    /// Target metric name
    /// </summary>
    /// <value>Target metric name</value>
    public ActionAggregationViewTargetEnum? Target { get; set; }

    /// <summary>
    /// Type of view you wish to create
    /// </summary>
    /// <value>Type of view you wish to create</value>
    public ActionAggregationViewFunctionEnum? Function { get; set; }

    /// <summary>
    /// A unique name for this view. Must be distinct from other views and built-in metric names.
    /// </summary>
    /// <value>A unique name for this view. Must be distinct from other views and built-in metric names.</value>
    public string Name { get; set; }

    /// <summary>
    /// Range of numbers for slicing up data
    /// </summary>
    /// <value>Range of numbers for slicing up data</value>
    public AggregationRange Range { get; set; }
}
