using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerContactlistConfigChangeContactPhoneNumberColumn
{
    /// <summary>
    /// name of the phone column
    /// </summary>
    /// <value>name of the phone column</value>
    public string ColumnName { get; set; }

    /// <summary>
    /// type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;
    /// </summary>
    /// <value>type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;</value>
    public string Type { get; set; }

    /// <summary>
    /// name of the column indicating the timezone to be considered for determining callable times
    /// </summary>
    /// <value>name of the column indicating the timezone to be considered for determining callable times</value>
    public string CallableTimeColumn { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
