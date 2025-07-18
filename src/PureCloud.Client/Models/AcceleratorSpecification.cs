using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AcceleratorSpecification
{
    /// <summary>
    /// where the accelerator originated
    /// </summary>
    /// <value>where the accelerator originated</value>
    public AcceleratorSpecificationOriginEnum? Origin { get; set; }

    /// <summary>
    /// type of the artifact
    /// </summary>
    /// <value>type of the artifact</value>
    public AcceleratorSpecificationTypeEnum? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// name of this accelerator
    /// </summary>
    /// <value>name of this accelerator</value>
    public string Name { get; set; }

    /// <summary>
    /// a description of the general purpose of this accelerator
    /// </summary>
    /// <value>a description of the general purpose of this accelerator</value>
    public string Description { get; set; }

    /// <summary>
    /// architectural classification into which the accelerator belongs
    /// </summary>
    /// <value>architectural classification into which the accelerator belongs</value>
    public string Classification { get; set; }

    /// <summary>
    /// tags
    /// </summary>
    /// <value>tags</value>
    public IEnumerable<string> Tags { get; set; }

    /// <summary>
    /// Genesys Cloud permissions required to install the accelerator
    /// </summary>
    /// <value>Genesys Cloud permissions required to install the accelerator</value>
    public IEnumerable<string> Permissions { get; set; }

    /// <summary>
    /// Genesys Cloud products required to install the accelerator
    /// </summary>
    /// <value>Genesys Cloud products required to install the accelerator</value>
    public IEnumerable<string> Products { get; set; }

    /// <summary>
    /// additional documentation about the artifact
    /// </summary>
    /// <value>additional documentation about the artifact</value>
    public IEnumerable<MetadataDocumentation> Documentation { get; set; }

    /// <summary>
    /// presentation of data fields to be gathered for the accelerator
    /// </summary>
    /// <value>presentation of data fields to be gathered for the accelerator</value>
    public IEnumerable<MetadataPresentation> Presentation { get; set; }

    /// <summary>
    /// resources created or modified as a result of running the accelerator
    /// </summary>
    /// <value>resources created or modified as a result of running the accelerator</value>
    public MetadataResults Results { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
