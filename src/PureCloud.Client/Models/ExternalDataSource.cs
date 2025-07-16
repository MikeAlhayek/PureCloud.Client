using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalDataSource
{
    /// <summary>
    /// The platform that was the source of the data.  Example: a CRM like SALESFORCE.
    /// </summary>
    /// <value>The platform that was the source of the data.  Example: a CRM like SALESFORCE.</value>
    public ExternalDataSourcePlatformEnum? Platform { get; set; }

    /// <summary>
    /// An URL that links to the source record that contributed data to the associated entity.
    /// </summary>
    /// <value>An URL that links to the source record that contributed data to the associated entity.</value>
    public string Url { get; set; }
}
