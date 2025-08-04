namespace PureCloud.Client.Models;

public sealed class Predictor
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? DateCreated { get; set; }
    public string? DateModified { get; set; }
    public string? State { get; set; }
    public IEnumerable<string>? QueueIds { get; set; } = [];
    public string? SelfUri { get; set; }
}
