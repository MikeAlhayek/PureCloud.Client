using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AttendanceStatusListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<AttendanceStatus> Entities { get; set; }
}
