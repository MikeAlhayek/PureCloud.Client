using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CursorNoteListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<Note> Entities { get; set; }

    /// <summary>
    /// Gets or Sets NextUri
    /// </summary>
    public string NextUri { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }

    /// <summary>
    /// Gets or Sets PreviousUri
    /// </summary>
    public string PreviousUri { get; set; }

    /// <summary>
    /// The cursor that points to the next set of entities being returned.
    /// </summary>
    /// <value>The cursor that points to the next set of entities being returned.</value>
    public Cursors Cursors { get; set; }
}
