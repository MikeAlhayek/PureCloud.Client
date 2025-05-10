namespace PureCloud.Client.Models.Analytics;

public sealed class AnalyticsProperty
{
    /// <summary>
    /// Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match
    /// </summary>
    /// <value>Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match</value>
    public AnalyticsPropertyType? PropertyType { get; set; }

    /// <summary>
    /// User-defined rather than intrinsic system-observed values. These are tagged onto segments by other components within PureCloudEnvironment or by API users directly.  This is the name of the user-defined property.
    /// </summary>
    /// <value>User-defined rather than intrinsic system-observed values. These are tagged onto segments by other components within PureCloudEnvironment or by API users directly.  This is the name of the user-defined property.</value>
    public string Property { get; set; }

    /// <summary>
    /// What property value to match against
    /// </summary>
    /// <value>What property value to match against</value>
    public string Value { get; set; }
}
