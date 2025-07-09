using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RegisterArchitectExportJob
{
    /// <summary>
    /// A list of the flows to be exported.
    /// </summary>
    /// <value>A list of the flows to be exported.</value>
    public IEnumerable<ExportDetails> Flows { get; set; }
}
