using System;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResponseAssetStatus
/// </summary>
public sealed class ResponseAssetStatus
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets PercentProgress
    /// </summary>
    public int? PercentProgress { get; set; }

    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    public DomainEntityRef User { get; set; }

    /// <summary>
    /// Gets or Sets ResponseAsset
    /// </summary>
    public ResponseAsset ResponseAsset { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }
}
