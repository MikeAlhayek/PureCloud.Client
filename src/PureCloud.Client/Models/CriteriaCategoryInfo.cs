using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CriteriaCategoryInfo
{
    /// <summary>
    /// Gets or Sets CategoryId
    /// </summary>
    public string CategoryId { get; set; }

    /// <summary>
    /// Gets or Sets DisplayOrder
    /// </summary>
    public int? DisplayOrder { get; set; }
}
