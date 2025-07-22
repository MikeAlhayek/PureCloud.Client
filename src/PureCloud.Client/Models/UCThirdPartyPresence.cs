using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UCThirdPartyPresence
{
    /// <summary>
    /// Primary Email address of the associated Genesys Cloud user.
    /// </summary>
    /// <value>Primary Email address of the associated Genesys Cloud user.</value>
    public string Email { get; set; }

    /// <summary>
    /// Integration presence value.
    /// </summary>
    /// <value>Integration presence value.</value>
    public string Presence { get; set; }

    /// <summary>
    /// Integration presence message.
    /// </summary>
    /// <value>Integration presence message.</value>
    public string Message { get; set; }

    /// <summary>
    /// ISO 8601 timestamp of presence value change.
    /// </summary>
    /// <value>ISO 8601 timestamp of presence value change.</value>
    public DateTime? DateModified { get; set; }
}
