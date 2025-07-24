namespace PureCloud.Client.Models;

/// <summary>
/// Workitem
/// </summary>
public sealed class Workitem
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The name of the Workitem.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    public Division Division { get; set; }

    /// <summary>
    /// The Worktype of the Workitem.
    /// </summary>
    public WorktypeReference Type { get; set; }

    /// <summary>
    /// The description of the Workitem.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The language of the Workitem.
    /// </summary>
    public LanguageReference Language { get; set; }

    /// <summary>
    /// The Category of the current Status of the Workitem.
    /// </summary>
    public WorkitemStatusCategory? StatusCategory { get; set; }

    /// <summary>
    /// The assignment state of the workitem.
    /// </summary>
    public WorkitemAssignmentState? AssignmentState { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    public string SelfUri { get; set; }
}