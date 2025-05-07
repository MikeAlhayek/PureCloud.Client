namespace PureCloud.Client.Models;

public sealed class MemberGroup
{
    /// <summary>
    /// The group type
    /// </summary>
    /// <value>The group type</value>
    public MemberGroupType? Type { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableDivision Division { get; set; }

    /// <summary>
    /// The number of members in this group
    /// </summary>
    /// <value>The number of members in this group</value>
    public int? MemberCount { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
