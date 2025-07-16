using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FacebookId
{
    /// <summary>
    /// The set of scopedIds that this person has. Each scopedId is specific to a page or app that the user interacts with.
    /// </summary>
    /// <value>The set of scopedIds that this person has. Each scopedId is specific to a page or app that the user interacts with.</value>
    public IEnumerable<FacebookScopedId> Ids { get; set; }

    /// <summary>
    /// The displayName of this person&#39;s Facebook account. Roughly translates to user.first_name + &#39; &#39; + user.last_name in the Facebook API.
    /// </summary>
    /// <value>The displayName of this person&#39;s Facebook account. Roughly translates to user.first_name + &#39; &#39; + user.last_name in the Facebook API.</value>
    public string DisplayName { get; set; }
}
