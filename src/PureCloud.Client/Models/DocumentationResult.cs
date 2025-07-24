using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;


public sealed class DocumentationResult
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public int? Id { get; set; }

    /// <summary>
    /// The category of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The category of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> Categories { get; set; }

    /// <summary>
    /// The description of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The description of the documentation entity. Will be returned in responses for certain entities.</value>
    public string Description { get; set; }

    /// <summary>
    /// The text or html content for the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The text or html content for the documentation entity. Will be returned in responses for certain entities.</value>
    public string Content { get; set; }

    /// <summary>
    /// The excerpt of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The excerpt of the documentation entity. Will be returned in responses for certain entities.</value>
    public string Excerpt { get; set; }

    /// <summary>
    /// URL link for the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>URL link for the documentation entity. Will be returned in responses for certain entities.</value>
    public string Link { get; set; }

    /// <summary>
    /// The modified date for the documentation entity. Will be returned in responses for certain entities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The modified date for the documentation entity. Will be returned in responses for certain entities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? Modified { get; set; }

    /// <summary>
    /// The name of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The name of the documentation entity. Will be returned in responses for certain entities.</value>
    public string Name { get; set; }

    /// <summary>
    /// The service of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The service of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> Service { get; set; }

    /// <summary>
    /// The slug of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The slug of the documentation entity. Will be returned in responses for certain entities.</value>
    public string Slug { get; set; }

    /// <summary>
    /// The title of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The title of the documentation entity. Will be returned in responses for certain entities.</value>
    public string Title { get; set; }

    /// <summary>
    /// The search type. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The search type. Will be returned in responses for certain entities.</value>
    public string GetTheType { get; set; }

    /// <summary>
    /// The facet feature of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The facet feature of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> FacetFeature { get; set; }

    /// <summary>
    /// The facet role of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The facet role of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> FacetRole { get; set; }

    /// <summary>
    /// The facet service of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The facet service of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> FacetService { get; set; }

    /// <summary>
    /// The faq categories of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The faq categories of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> FaqCategories { get; set; }

    /// <summary>
    /// The releasenote category of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The releasenote category of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> ReleasenoteCategory { get; set; }

    /// <summary>
    /// The releasenote tag of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The releasenote tag of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> ReleasenoteTag { get; set; }

    /// <summary>
    /// The service area of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The service area of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> ServiceArea { get; set; }

    /// <summary>
    /// The video categories of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The video categories of the documentation entity. Will be returned in responses for certain entities.</value>
    public IEnumerable<int?> VideoCategories { get; set; }
}
