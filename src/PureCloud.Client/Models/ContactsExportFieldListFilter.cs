using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactsExportFieldListFilter
{
    /// <summary>
    /// Field name to apply the filter
    /// </summary>
    /// <value>Field name to apply the filter</value>
    public ContactsExportFieldListFilterFieldEnum? Field { get; set; }

    /// <summary>
    /// Values to check field&#39;s value against
    /// </summary>
    /// <value>Values to check field&#39;s value against</value>
    public IEnumerable<string> Values { get; set; }
}
