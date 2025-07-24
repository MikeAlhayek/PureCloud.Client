using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RecordingTemplateHeader
{
    /// <summary>
    /// Template header type.
    /// </summary>
    /// <value>Template header type.</value>
    public RecordingTemplateHeaderTypeEnum? Type { get; set; }

    /// <summary>
    /// Header text.
    /// </summary>
    /// <value>Header text.</value>
    public string Text { get; set; }

    /// <summary>
    /// Media template header image.
    /// </summary>
    /// <value>Media template header image.</value>
    public RecordingAttachment Media { get; set; }
}
