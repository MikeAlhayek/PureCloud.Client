using System.Collections.Generic;
using System.Text;

namespace PureCloud.Client.Models.Locations;

/// <summary>
/// LocationSearchCriteria
/// </summary>
public sealed class LocationSearchCriteria
{
    /// <summary>
    /// The end value of the range. This field is used for range search types.
    /// </summary>
    /// <value>The end value of the range. This field is used for range search types.</value>
    public string EndValue { get; set; }

    /// <summary>
    /// A list of values for the search to match against
    /// </summary>
    /// <value>A list of values for the search to match against</value>
    public IEnumerable<string> Values { get; set; }

    /// <summary>
    /// The start value of the range. This field is used for range search types.
    /// </summary>
    /// <value>The start value of the range. This field is used for range search types.</value>
    public string StartValue { get; set; }

    /// <summary>
    /// A value for the search to match against
    /// </summary>
    /// <value>A value for the search to match against</value>
    public string Value { get; set; }

    /// <summary>
    /// How to apply this search criteria against other criteria
    /// </summary>
    /// <value>How to apply this search criteria against other criteria</value>
    public string Operator { get; set; }

    /// <summary>
    /// Groups multiple conditions
    /// </summary>
    /// <value>Groups multiple conditions</value>
    public IEnumerable<LocationSearchCriteria> Group { get; set; }

    /// <summary>
    /// Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX.
    /// </summary>
    /// <value>Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX.</value>
    public string DateFormat { get; set; }

    /// <summary>
    /// Search Type
    /// </summary>
    /// <value>Search Type</value>
    public string Type { get; set; }

    /// <summary>
    /// Field names to search against
    /// </summary>
    /// <value>Field names to search against</value>
    public IEnumerable<string> Fields { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LocationSearchCriteria {\n");

        sb.Append("  EndValue: ").Append(EndValue).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  StartValue: ").Append(StartValue).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Fields: ").Append(Fields).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}
