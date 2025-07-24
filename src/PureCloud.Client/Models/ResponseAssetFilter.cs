using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ResponseAssetFilter
{
    /// <summary>
    /// How to apply this search criteria against other criteria. Filter type supported for each field:- name:[STARTS_WITH, TERM], divisionId:[TERM, TERMS], contentLength:[RANGE, GREATER_THAN_EQUAL_TO, LESS_THAN_EQUAL_TO], contentType:[STARTS_WITH, TERM] dateCreated:[DATE_RANGE]
    /// </summary>
    /// <value>How to apply this search criteria against other criteria. Filter type supported for each field:- name:[STARTS_WITH, TERM], divisionId:[TERM, TERMS], contentLength:[RANGE, GREATER_THAN_EQUAL_TO, LESS_THAN_EQUAL_TO], contentType:[STARTS_WITH, TERM] dateCreated:[DATE_RANGE]</value>
    public ResponseAssetFilterTypeEnum? Type { get; set; }

    /// <summary>
    /// The end value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format
    /// </summary>
    /// <value>The end value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format</value>
    public string EndValue { get; set; }

    /// <summary>
    /// A list of values for the search to match against
    /// </summary>
    /// <value>A list of values for the search to match against</value>
    public IEnumerable<string> Values { get; set; }

    /// <summary>
    /// The start value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format
    /// </summary>
    /// <value>The start value of the range. This field is used for range search types. Accepts numbers and date in ISO8601 format</value>
    public string StartValue { get; set; }

    /// <summary>
    /// Field name to search against. Allowed Values: divisionId, name, contentLength, contentType, dateCreated
    /// </summary>
    /// <value>Field name to search against. Allowed Values: divisionId, name, contentLength, contentType, dateCreated</value>
    public IEnumerable<string> Fields { get; set; }

    /// <summary>
    /// A value for the search to match against
    /// </summary>
    /// <value>A value for the search to match against</value>
    public string Value { get; set; }
}
