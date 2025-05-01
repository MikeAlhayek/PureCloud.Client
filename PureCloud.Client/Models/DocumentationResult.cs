using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentationResult
/// </summary>
[DataContract]
public partial class DocumentationResult : IEquatable<DocumentationResult>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentationResult" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentationResult() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentationResult" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object. (required).</param>
    /// <param name="Categories">The category of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="Description">The description of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="Content">The text or html content for the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="Excerpt">The excerpt of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="Link">URL link for the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="Modified">The modified date for the documentation entity. Will be returned in responses for certain entities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Name">The name of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="Service">The service of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="Slug">The slug of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="Title">The title of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="GetType">The search type. Will be returned in responses for certain entities..</param>
    /// <param name="FacetFeature">The facet feature of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="FacetRole">The facet role of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="FacetService">The facet service of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="FaqCategories">The faq categories of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="ReleasenoteCategory">The releasenote category of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="ReleasenoteTag">The releasenote tag of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="ServiceArea">The service area of the documentation entity. Will be returned in responses for certain entities..</param>
    /// <param name="VideoCategories">The video categories of the documentation entity. Will be returned in responses for certain entities..</param>
    public DocumentationResult(int? Id = null, List<int?> Categories = null, string Description = null, string Content = null, string Excerpt = null, string Link = null, DateTime? Modified = null, string Name = null, List<int?> Service = null, string Slug = null, string Title = null, string GetType = null, List<int?> FacetFeature = null, List<int?> FacetRole = null, List<int?> FacetService = null, List<int?> FaqCategories = null, List<int?> ReleasenoteCategory = null, List<int?> ReleasenoteTag = null, List<int?> ServiceArea = null, List<int?> VideoCategories = null)
    {
        this.Id = Id;
        this.Categories = Categories;
        this.Description = Description;
        this.Content = Content;
        this.Excerpt = Excerpt;
        this.Link = Link;
        this.Modified = Modified;
        this.Name = Name;
        this.Service = Service;
        this.Slug = Slug;
        this.Title = Title;
        GetTheType = GetType;
        this.FacetFeature = FacetFeature;
        this.FacetRole = FacetRole;
        this.FacetService = FacetService;
        this.FaqCategories = FaqCategories;
        this.ReleasenoteCategory = ReleasenoteCategory;
        this.ReleasenoteTag = ReleasenoteTag;
        this.ServiceArea = ServiceArea;
        this.VideoCategories = VideoCategories;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public int? Id { get; set; }



    /// <summary>
    /// The category of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The category of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "categories", EmitDefaultValue = false)]
    public List<int?> Categories { get; set; }



    /// <summary>
    /// The description of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The description of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The text or html content for the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The text or html content for the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "content", EmitDefaultValue = false)]
    public string Content { get; set; }



    /// <summary>
    /// The excerpt of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The excerpt of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "excerpt", EmitDefaultValue = false)]
    public string Excerpt { get; set; }



    /// <summary>
    /// URL link for the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>URL link for the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "link", EmitDefaultValue = false)]
    public string Link { get; set; }



    /// <summary>
    /// The modified date for the documentation entity. Will be returned in responses for certain entities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The modified date for the documentation entity. Will be returned in responses for certain entities. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modified", EmitDefaultValue = false)]
    public DateTime? Modified { get; set; }



    /// <summary>
    /// The name of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The name of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The service of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The service of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "service", EmitDefaultValue = false)]
    public List<int?> Service { get; set; }



    /// <summary>
    /// The slug of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The slug of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "slug", EmitDefaultValue = false)]
    public string Slug { get; set; }



    /// <summary>
    /// The title of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The title of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// The search type. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The search type. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "get_type", EmitDefaultValue = false)]
    public string GetTheType { get; set; }



    /// <summary>
    /// The facet feature of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The facet feature of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "facet_feature", EmitDefaultValue = false)]
    public List<int?> FacetFeature { get; set; }



    /// <summary>
    /// The facet role of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The facet role of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "facet_role", EmitDefaultValue = false)]
    public List<int?> FacetRole { get; set; }



    /// <summary>
    /// The facet service of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The facet service of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "facet_service", EmitDefaultValue = false)]
    public List<int?> FacetService { get; set; }



    /// <summary>
    /// The faq categories of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The faq categories of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "faq_categories", EmitDefaultValue = false)]
    public List<int?> FaqCategories { get; set; }



    /// <summary>
    /// The releasenote category of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The releasenote category of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "releasenote_category", EmitDefaultValue = false)]
    public List<int?> ReleasenoteCategory { get; set; }



    /// <summary>
    /// The releasenote tag of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The releasenote tag of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "releasenote_tag", EmitDefaultValue = false)]
    public List<int?> ReleasenoteTag { get; set; }



    /// <summary>
    /// The service area of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The service area of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "service-area", EmitDefaultValue = false)]
    public List<int?> ServiceArea { get; set; }



    /// <summary>
    /// The video categories of the documentation entity. Will be returned in responses for certain entities.
    /// </summary>
    /// <value>The video categories of the documentation entity. Will be returned in responses for certain entities.</value>
    [DataMember(Name = "video_categories", EmitDefaultValue = false)]
    public List<int?> VideoCategories { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentationResult {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Excerpt: ").Append(Excerpt).Append("\n");
        sb.Append("  Link: ").Append(Link).Append("\n");
        sb.Append("  Modified: ").Append(Modified).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Service: ").Append(Service).Append("\n");
        sb.Append("  Slug: ").Append(Slug).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  GetType: ").Append(GetTheType).Append("\n");
        sb.Append("  FacetFeature: ").Append(FacetFeature).Append("\n");
        sb.Append("  FacetRole: ").Append(FacetRole).Append("\n");
        sb.Append("  FacetService: ").Append(FacetService).Append("\n");
        sb.Append("  FaqCategories: ").Append(FaqCategories).Append("\n");
        sb.Append("  ReleasenoteCategory: ").Append(ReleasenoteCategory).Append("\n");
        sb.Append("  ReleasenoteTag: ").Append(ReleasenoteTag).Append("\n");
        sb.Append("  ServiceArea: ").Append(ServiceArea).Append("\n");
        sb.Append("  VideoCategories: ").Append(VideoCategories).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as DocumentationResult);
    }

    /// <summary>
    /// Returns true if DocumentationResult instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentationResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentationResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Categories == other.Categories ||
                Categories != null &&
                Categories.SequenceEqual(other.Categories)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Content == other.Content ||
                Content != null &&
                Content.Equals(other.Content)
            ) &&
            (
                Excerpt == other.Excerpt ||
                Excerpt != null &&
                Excerpt.Equals(other.Excerpt)
            ) &&
            (
                Link == other.Link ||
                Link != null &&
                Link.Equals(other.Link)
            ) &&
            (
                Modified == other.Modified ||
                Modified != null &&
                Modified.Equals(other.Modified)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Service == other.Service ||
                Service != null &&
                Service.SequenceEqual(other.Service)
            ) &&
            (
                Slug == other.Slug ||
                Slug != null &&
                Slug.Equals(other.Slug)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                GetTheType == other.GetTheType ||
                GetTheType != null &&
                GetTheType.Equals(other.GetTheType)
            ) &&
            (
                FacetFeature == other.FacetFeature ||
                FacetFeature != null &&
                FacetFeature.SequenceEqual(other.FacetFeature)
            ) &&
            (
                FacetRole == other.FacetRole ||
                FacetRole != null &&
                FacetRole.SequenceEqual(other.FacetRole)
            ) &&
            (
                FacetService == other.FacetService ||
                FacetService != null &&
                FacetService.SequenceEqual(other.FacetService)
            ) &&
            (
                FaqCategories == other.FaqCategories ||
                FaqCategories != null &&
                FaqCategories.SequenceEqual(other.FaqCategories)
            ) &&
            (
                ReleasenoteCategory == other.ReleasenoteCategory ||
                ReleasenoteCategory != null &&
                ReleasenoteCategory.SequenceEqual(other.ReleasenoteCategory)
            ) &&
            (
                ReleasenoteTag == other.ReleasenoteTag ||
                ReleasenoteTag != null &&
                ReleasenoteTag.SequenceEqual(other.ReleasenoteTag)
            ) &&
            (
                ServiceArea == other.ServiceArea ||
                ServiceArea != null &&
                ServiceArea.SequenceEqual(other.ServiceArea)
            ) &&
            (
                VideoCategories == other.VideoCategories ||
                VideoCategories != null &&
                VideoCategories.SequenceEqual(other.VideoCategories)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Categories != null)
            {
                hash = hash * 59 + Categories.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (Excerpt != null)
            {
                hash = hash * 59 + Excerpt.GetHashCode();
            }

            if (Link != null)
            {
                hash = hash * 59 + Link.GetHashCode();
            }

            if (Modified != null)
            {
                hash = hash * 59 + Modified.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Service != null)
            {
                hash = hash * 59 + Service.GetHashCode();
            }

            if (Slug != null)
            {
                hash = hash * 59 + Slug.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (GetTheType != null)
            {
                hash = hash * 59 + GetTheType.GetHashCode();
            }

            if (FacetFeature != null)
            {
                hash = hash * 59 + FacetFeature.GetHashCode();
            }

            if (FacetRole != null)
            {
                hash = hash * 59 + FacetRole.GetHashCode();
            }

            if (FacetService != null)
            {
                hash = hash * 59 + FacetService.GetHashCode();
            }

            if (FaqCategories != null)
            {
                hash = hash * 59 + FaqCategories.GetHashCode();
            }

            if (ReleasenoteCategory != null)
            {
                hash = hash * 59 + ReleasenoteCategory.GetHashCode();
            }

            if (ReleasenoteTag != null)
            {
                hash = hash * 59 + ReleasenoteTag.GetHashCode();
            }

            if (ServiceArea != null)
            {
                hash = hash * 59 + ServiceArea.GetHashCode();
            }

            if (VideoCategories != null)
            {
                hash = hash * 59 + VideoCategories.GetHashCode();
            }

            return hash;
        }
    }
}
