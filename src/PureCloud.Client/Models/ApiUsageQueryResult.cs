using System.Collections.Generic;

namespace PureCloud.Client.Models;

public sealed class ApiUsageQueryResult
{
    public IEnumerable<ApiUsageRow> Results { get; set; }
    public QueryStatusEnum? QueryStatus { get; set; }
    public Cursors Cursors { get; set; }
    public enum QueryStatusEnum { OutdatedSdkVersion, Complete, Failed, Running }
}
