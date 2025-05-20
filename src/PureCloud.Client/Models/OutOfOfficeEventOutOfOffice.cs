using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutOfOfficeEventOutOfOffice
{
    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public OutOfOfficeEventUser User { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets Indefinite
    /// </summary>
    public bool? Indefinite { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    public DateTime? EndDate { get; set; }
}
