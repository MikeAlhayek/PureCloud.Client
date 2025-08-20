namespace PureCloud.Client.Models;

public sealed class EstimatedWaitTimePredictions
{
    /// <summary>
    /// Returned upon a successful estimated wait time request.
    /// </summary>
    public IEnumerable<PredictionResults> Results { get; set; }
}
