using System.Collections.Generic;

namespace PureCloud.Client.Models;

public sealed class JourneyViewResult
{
    public IEnumerable<JourneyViewResultElement> Elements { get; set; }
}
