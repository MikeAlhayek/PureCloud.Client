using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class RecordingTemplateBody
{
    /// <summary>
    /// Template parameters for placeholders in template.
    /// </summary>
    /// <value>Template parameters for placeholders in template.</value>
    public string Text { get; set; }
}
