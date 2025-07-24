using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SiteSearchCriteria
{
    /// <summary>
    /// How to apply this search criteria against other criteria
    /// </summary>
    /// <value>How to apply this search criteria against other criteria</value>
    public SiteSearchCriteriaOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Search Type
    /// </summary>
    /// <value>Search Type</value>
    public SiteSearchCriteriaTypeEnum? Type { get; set; }

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
    /// Groups multiple conditions
    /// </summary>
    /// <value>Groups multiple conditions</value>
    public IEnumerable<SiteSearchCriteria> Group { get; set; }

    /// <summary>
    /// Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX.
    /// </summary>
    /// <value>Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX.</value>
    public string DateFormat { get; set; }

    /// <summary>
    /// Field names to search against
    /// </summary>
    /// <value>Field names to search against</value>
    public IEnumerable<string> Fields { get; set; }
}
