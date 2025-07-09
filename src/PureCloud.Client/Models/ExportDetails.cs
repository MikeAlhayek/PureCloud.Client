using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExportDetails
{
    /// <summary>
    /// The export type for the flow. Default: 'Yaml'.
    /// </summary>
    /// <value>The export type for the flow. Default: 'Yaml'.</value>
    public ExportDetailsExportTypeEnum? ExportType { get; set; }

    /// <summary>
    /// The flow to export. If you do not provide the flow ID, you must provide both the name and type.
    /// </summary>
    /// <value>The flow to export. If you do not provide the flow ID, you must provide both the name and type.</value>
    public ArchitectFlowReference Flow { get; set; }

    /// <summary>
    /// Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens.
    /// </summary>
    /// <value>Name to assign to the file after download. The extension will be automatically appended based on desired export type. Must contain only alphanumeric characters, underscores, or hyphens.</value>
    public string FileName { get; set; }
}
