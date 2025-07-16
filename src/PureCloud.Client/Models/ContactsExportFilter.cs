using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactsExportFilter
{
    /// <summary>
    /// Filtered field should have the same value
    /// </summary>
    /// <value>Filtered field should have the same value</value>
    public ContactsExportFieldFilter Eq { get; set; }

    /// <summary>
    /// Filtered field should match one of the listed values
    /// </summary>
    /// <value>Filtered field should match one of the listed values</value>
    public ContactsExportFieldListFilter In { get; set; }

    /// <summary>
    /// Boolean AND combination of filters
    /// </summary>
    /// <value>Boolean AND combination of filters</value>
    public IEnumerable<ContactsExportFilter> And { get; set; }

    /// <summary>
    /// Boolean OR combination of filters
    /// </summary>
    /// <value>Boolean OR combination of filters</value>
    public IEnumerable<ContactsExportFilter> Or { get; set; }

    /// <summary>
    /// Boolean negation of filters
    /// </summary>
    /// <value>Boolean negation of filters</value>
    public ContactsExportFilter Not { get; set; }
}
