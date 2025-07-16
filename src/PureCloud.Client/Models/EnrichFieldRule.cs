using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class EnrichFieldRule
{
    /// <summary>
    /// The behavior for how to combine data from the request body and the database.
    /// </summary>
    /// <value>The behavior for how to combine data from the request body and the database.</value>
    public EnrichFieldRuleActionEnum? Action { get; set; }

    /// <summary>
    /// The behavior for how to combine items in array field from the request body and the database.
    /// </summary>
    /// <value>The behavior for how to combine items in array field from the request body and the database.</value>
    public EnrichFieldRuleArrayActionEnum? ArrayAction { get; set; }

    /// <summary>
    /// A restricted JSONPath naming the specific field this combining behavior should apply to. You may use dot-notation for named fields, and array indexing for lists, but nothing more sophisticated (e.g. wildcards, sublists, filter expressions, etc). For example, to target the &#x60;firstName&#x60; field of a Contact, this should be \&quot;$.firstName\&quot;.
    /// </summary>
    /// <value>A restricted JSONPath naming the specific field this combining behavior should apply to. You may use dot-notation for named fields, and array indexing for lists, but nothing more sophisticated (e.g. wildcards, sublists, filter expressions, etc). For example, to target the &#x60;firstName&#x60; field of a Contact, this should be \&quot;$.firstName\&quot;.</value>
    public string Field { get; set; }
}
