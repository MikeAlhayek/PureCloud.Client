using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Program
/// </summary>

public partial class Program : IEquatable<Program>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Program" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Published">Published.</param>
    /// <param name="Topics">Topics.</param>
    /// <param name="Tags">Tags.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="PublishedBy">PublishedBy.</param>
    /// <param name="DatePublished">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="TopicLinksJob">TopicLinksJob.</param>
    public Program(string Name = null, string Description = null, bool? Published = null, List<BaseTopicEntitiy> Topics = null, List<string> Tags = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null, AddressableEntityRef PublishedBy = null, DateTime? DatePublished = null, AddressableEntityRef TopicLinksJob = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Published = Published;
        this.Topics = Topics;
        this.Tags = Tags;
        this.ModifiedBy = ModifiedBy;
        this.DateModified = DateModified;
        this.PublishedBy = PublishedBy;
        this.DatePublished = DatePublished;
        this.TopicLinksJob = TopicLinksJob;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    [JsonPropertyName("published")]
    public bool? Published { get; set; }



    /// <summary>
    /// Gets or Sets Topics
    /// </summary>
    [JsonPropertyName("topics")]
    public List<BaseTopicEntitiy> Topics { get; set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [JsonPropertyName("modifiedBy")]
    public AddressableEntityRef ModifiedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Gets or Sets PublishedBy
    /// </summary>
    [JsonPropertyName("publishedBy")]
    public AddressableEntityRef PublishedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("datePublished")]
    public DateTime? DatePublished { get; set; }



    /// <summary>
    /// Gets or Sets TopicLinksJob
    /// </summary>
    [JsonPropertyName("topicLinksJob")]
    public AddressableEntityRef TopicLinksJob { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Program {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  Topics: ").Append(Topics).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  PublishedBy: ").Append(PublishedBy).Append("\n");
        sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
        sb.Append("  TopicLinksJob: ").Append(TopicLinksJob).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as Program);
    }

    /// <summary>
    /// Returns true if Program instances are equal
    /// </summary>
    /// <param name="other">Instance of Program to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Program other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                Topics == other.Topics ||
                Topics != null &&
                Topics.SequenceEqual(other.Topics)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                PublishedBy == other.PublishedBy ||
                PublishedBy != null &&
                PublishedBy.Equals(other.PublishedBy)
            ) &&
            (
                DatePublished == other.DatePublished ||
                DatePublished != null &&
                DatePublished.Equals(other.DatePublished)
            ) &&
            (
                TopicLinksJob == other.TopicLinksJob ||
                TopicLinksJob != null &&
                TopicLinksJob.Equals(other.TopicLinksJob)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (Topics != null)
            {
                hash = hash * 59 + Topics.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (PublishedBy != null)
            {
                hash = hash * 59 + PublishedBy.GetHashCode();
            }

            if (DatePublished != null)
            {
                hash = hash * 59 + DatePublished.GetHashCode();
            }

            if (TopicLinksJob != null)
            {
                hash = hash * 59 + TopicLinksJob.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
