using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DynamicGroupDefinition
{
    /// <summary>
    /// The group the dynamic group definition belongs to
    /// </summary>
    /// <value>The group the dynamic group definition belongs to</value>
    public AddressableEntityRef Group { get; set; }

    /// <summary>
    /// Last modified date/time of the dynamic group definition. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date/time of the dynamic group definition. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Properties used for building a dynamic groups query
    /// </summary>
    /// <value>Properties used for building a dynamic groups query</value>
    public DynamicGroupQuery Query { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
