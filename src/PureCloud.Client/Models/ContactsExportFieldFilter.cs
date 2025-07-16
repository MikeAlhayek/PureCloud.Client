using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactsExportFieldFilter
{
    /// <summary>
    /// Field name to apply the filter
    /// </summary>
    /// <value>Field name to apply the filter</value>
    public ContactsExportFieldFilterFieldEnum? Field { get; set; }

    /// <summary>
    /// Value to check field&#39;s value against
    /// </summary>
    /// <value>Value to check field&#39;s value against</value>
    public string Value { get; set; }
}
