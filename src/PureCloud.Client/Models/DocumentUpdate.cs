using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DocumentUpdate
{
    /// <summary>
    /// Gets or Sets ChangeNumber
    /// </summary>
    public int? ChangeNumber { get; set; }

    /// <summary>
    /// The name of the document
    /// </summary>
    /// <value>The name of the document</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    public bool? Read { get; set; }

    /// <summary>
    /// Gets or Sets AddTags
    public IEnumerable<string> AddTags { get; set; }

    /// <summary>
    /// Gets or Sets RemoveTags
    /// </summary>
    public IEnumerable<string> RemoveTags { get; set; }

    /// <summary>
    /// Gets or Sets AddTagIds
    /// </summary>
    public IEnumerable<string> AddTagIds { get; set; }

    /// <summary>
    /// Gets or Sets RemoveTagIds
    /// </summary>
    public IEnumerable<string> RemoveTagIds { get; set; }

    /// <summary>
    /// Gets or Sets UpdateAttributes
    /// </summary>
    public IEnumerable<DocumentAttribute> UpdateAttributes { get; set; }

    /// <summary>
    /// Gets or Sets RemoveAttributes
    /// </summary>
    public IEnumerable<string> RemoveAttributes { get; set; }
}
