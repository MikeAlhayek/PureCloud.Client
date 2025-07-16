using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ContactsExportQueryConditions
{
    /// <summary>
    /// Filters to apply on export
    /// </summary>
    /// <value>Filters to apply on export</value>
    public ContactsExportFilter Filters { get; set; }

    /// <summary>
    /// Maximum result count in export, default is 180 000 000
    /// </summary>
    /// <value>Maximum result count in export, default is 180 000 000</value>
    public int? Limit { get; set; }
}
