using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class RecordingNotificationTemplate
{
    public string Id { get; set; }

    /// <summary>   
    /// Template language.
    /// </summary>
    /// <value>Template language.</value>

    public string Language { get; set; }

    /// <summary>
    /// The template header.
    /// </summary>
    /// <value>The template header.</value>

    public RecordingTemplateHeader Header { get; set; }

    /// <summary>
    /// The template body.
    /// </summary>
    /// <value>The template body.</value>

    public RecordingTemplateBody Body { get; set; }

    /// <summary>
    /// Template buttons
    /// </summary>
    /// <value>Template buttons</value>

    public IEnumerable<RecordingTemplateButton> Buttons { get; set; }

    /// <summary>
    /// The template footer.
    /// </summary>
    /// <value>The template footer.</value>

    public RecordingTemplateFooter Footer { get; set; }

}
