namespace PureCloud.Client.Models;

public sealed class LimitDocumentation
{
    public string Url { get; set; }
    public IEnumerable<NamespaceDocs> Namespaces { get; set; }
}
