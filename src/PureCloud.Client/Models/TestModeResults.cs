namespace PureCloud.Client.Models;

public sealed class TestModeResults
{
    public TestSchemaOperation SchemaValidation { get; set; }
    public TestTargetOperation TargetValidation { get; set; }
    public TestMatchesOperation JsonPathValidation { get; set; }
    public bool? TriggerMatches { get; set; }
}
