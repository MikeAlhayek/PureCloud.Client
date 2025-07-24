using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResponseAssetSearchResults
/// </summary>
public sealed class ResponseAssetSearchResults
{
    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>
    public int? PageCount { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets PageNumber
    /// </summary>
    public int? PageNumber { get; set; }

    /// <summary>
    /// Gets or Sets PreviousPage
    /// </summary>
    public string PreviousPage { get; set; }

    /// <summary>
    /// Gets or Sets CurrentPage
    /// </summary>
    public string CurrentPage { get; set; }

    /// <summary>
    /// Gets or Sets NextPage
    /// </summary>
    public string NextPage { get; set; }

    /// <summary>
    /// Gets or Sets Types
    /// </summary>
    public IEnumerable<string> Types { get; set; }

    /// <summary>
    /// Gets or Sets Results
    /// </summary>
    public IEnumerable<ResponseAsset> Results { get; set; }
}
