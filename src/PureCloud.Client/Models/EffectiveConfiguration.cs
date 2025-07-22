using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EffectiveConfiguration
{
    /// <summary>
    /// Key-value configuration settings described by the schema in the propertiesSchemaUri field.
    /// </summary>
    /// <value>Key-value configuration settings described by the schema in the propertiesSchemaUri field.</value>
    public Dictionary<string, object> Properties { get; set; }

    /// <summary>
    /// Advanced configuration described by the schema in the advancedSchemaUri field.
    /// </summary>
    /// <value>Advanced configuration described by the schema in the advancedSchemaUri field.</value>
    public Dictionary<string, object> Advanced { get; set; }

    /// <summary>
    /// The name of the integration, used to distinguish this integration from others of the same type.
    /// </summary>
    /// <value>The name of the integration, used to distinguish this integration from others of the same type.</value>
    public string Name { get; set; }

    /// <summary>
    /// Notes about the integration.
    /// </summary>
    /// <value>Notes about the integration.</value>
    public string Notes { get; set; }

    /// <summary>
    /// Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type
    /// </summary>
    /// <value>Credentials required by the integration. The required keys are indicated in the credentials property of the Integration Type</value>
    public Dictionary<string, CredentialInfo> Credentials { get; set; }
}
