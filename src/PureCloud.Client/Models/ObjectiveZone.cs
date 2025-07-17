using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ObjectiveZone
{
    /// <summary>
    /// direction type
    /// </summary>
    /// <value>direction type</value>
    public ObjectiveZoneDirectionTypeEnum? DirectionType { get; set; }

    /// <summary>
    /// zone type
    /// </summary>
    /// <value>zone type</value>
    public ObjectiveZoneZoneTypeEnum? ZoneType { get; set; }

    /// <summary>
    /// label
    /// </summary>
    /// <value>label</value>
    public string Label { get; set; }

    /// <summary>
    /// upper limit points
    /// </summary>
    /// <value>upper limit points</value>
    public int? UpperLimitPoints { get; set; }

    /// <summary>
    /// lower limit points
    /// </summary>
    /// <value>lower limit points</value>
    public int? LowerLimitPoints { get; set; }

    /// <summary>
    /// upper limit value
    /// </summary>
    /// <value>upper limit value</value>
    public int? UpperLimitValue { get; set; }

    /// <summary>
    /// lower limit value
    /// </summary>
    /// <value>lower limit value</value>
    public int? LowerLimitValue { get; set; }
}
