using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SkillGroup
{
    /// <summary>
    /// Group's filling status
    /// </summary>
    /// <value>Group's filling status</value>
    public SkillGroupStatusEnum? Status { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The group name.
    /// </summary>
    /// <value>The group name.</value>
    public string Name { get; set; }

    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    public WritableDivision Division { get; set; }

    /// <summary>
    /// Group description
    /// </summary>
    /// <value>Group description</value>
    public string Description { get; set; }

    /// <summary>
    /// Estimated number of members in this group. It can take some time for the count to be updated after expressions are changed.
    /// </summary>
    /// <value>Estimated number of members in this group. It can take some time for the count to be updated after expressions are changed.</value>
    public long? MemberCount { get; set; }

    /// <summary>
    /// Last modified date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Created date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Created date/time of the skill group. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Conditions for this group
    /// </summary>
    /// <value>Conditions for this group</value>
    public IEnumerable<SkillGroupCondition> SkillConditions { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
