using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Cursors
{
    /// <summary>
    /// Gets or Sets Before
    /// </summary>
    public string Before { get; set; }

    /// <summary>
    /// Gets or Sets After
    /// </summary>
    public string After { get; set; }
}
