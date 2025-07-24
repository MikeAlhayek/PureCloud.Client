namespace PureCloud.Client.Models;

/// <summary>
/// ProgramRequest
/// </summary>
public sealed class ProgramRequest
{
    /// <summary>
    /// The program name
    /// </summary>
    /// <value>The program name</value>
    public string Name { get; set; }

    /// <summary>
    /// The program description
    /// </summary>
    /// <value>The program description</value>
    public string Description { get; set; }

    /// <summary>
    /// The ids of topics associated to the program
    /// </summary>
    /// <value>The ids of topics associated to the program</value>
    public IEnumerable<string> TopicIds { get; set; }

    /// <summary>
    /// The program tags
    /// </summary>
    /// <value>The program tags</value>
    public IEnumerable<string> Tags { get; set; }
}