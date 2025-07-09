using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DataTableImportEntityListing
{
    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<DataTableImportJob> Entities { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    public int? PageCount { get; set; }
}
