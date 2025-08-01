using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CalibrationEntityListing
{
    public IEnumerable<Calibration> Entities { get; set; }
    public int? PageSize { get; set; }
    public int? PageNumber { get; set; }
    public long? Total { get; set; }
    public string FirstUri { get; set; }
    public string LastUri { get; set; }
    public string SelfUri { get; set; }
    public string NextUri { get; set; }
    public string PreviousUri { get; set; }
    public int? PageCount { get; set; }
}
