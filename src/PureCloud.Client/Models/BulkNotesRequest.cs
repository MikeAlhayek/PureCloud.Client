using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class BulkNotesRequest
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<Note> Entities { get; set; }
}
