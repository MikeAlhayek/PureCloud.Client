namespace PureCloud.Client.Models;

public sealed class FieldConfig
{
    public EntityType? EntityType { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public IEnumerable<Section> Sections { get; set; }
    public string Version { get; set; }
    public string SchemaVersion { get; set; }
    public string SelfUri { get; set; }
}
