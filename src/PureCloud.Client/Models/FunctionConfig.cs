using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FunctionConfig
{
    /// <summary>
    /// Action identifier.
    /// </summary>
    /// <value>Action identifier.</value>
    public string Id { get; set; }

    /// <summary>
    /// Function configuration.
    /// </summary>
    /// <value>Function configuration.</value>
    public Function Function { get; set; }

    /// <summary>
    /// Zip file configuration and state.
    /// </summary>
    /// <value>Zip file configuration and state.</value>
    public FunctionZipConfig Zip { get; set; }

    /// <summary>
    /// History of failed zip upload file configuration including their state and error messages. Contains no more than last ten failures.
    /// </summary>
    /// <value>History of failed zip upload file configuration including their state and error messages. Contains no more than last ten failures.</value>
    public IEnumerable<FunctionZipConfig> UploadExceptionHistory { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
