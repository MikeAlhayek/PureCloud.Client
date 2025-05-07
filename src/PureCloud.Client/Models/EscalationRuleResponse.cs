using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EscalationRuleResponse
/// </summary>

public partial class EscalationRuleResponse : IEquatable<EscalationRuleResponse>
{
    /// <summary>
    /// The status of the escalation rule.
    /// </summary>
    /// <value>The status of the escalation rule.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Paused for "Paused"
        /// </summary>
        [EnumMember(Value = "Paused")]
        Paused
    }
    /// <summary>
    /// The status of the escalation rule.
    /// </summary>
    /// <value>The status of the escalation rule.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EscalationRuleResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EscalationRuleResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EscalationRuleResponse" /> class.
    /// </summary>
    /// <param name="Id">ID of the escalation rule..</param>
    /// <param name="Name">The name of the escalation rule..</param>
    /// <param name="MatchCriteria">The criteria that defines when a social media message should be escalated. (required).</param>
    /// <param name="Priority">The priority of the escalation rule..</param>
    /// <param name="DivisionId">The ID of the division the social escalation rule belongs to. (required).</param>
    /// <param name="Description">A description of the social escalation rule..</param>
    /// <param name="DateCreated">Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Status">The status of the escalation rule..</param>
    /// <param name="OpenEscalation">The target integration configuration used for an open social media message if the match criteria returns true..</param>
    /// <param name="FacebookEscalation">The target integration configuration used for a Facebook social media message if the match criteria returns true..</param>
    /// <param name="InstagramEscalation">The target integration configuration used for an Instagram social media message if the match criteria returns true..</param>
    /// <param name="TwitterEscalation">The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true..</param>
    public EscalationRuleResponse(string Id = null, string Name = null, string MatchCriteria = null, int? Priority = null, string DivisionId = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, StatusEnum? Status = null, EscalationTarget OpenEscalation = null, EscalationTarget FacebookEscalation = null, EscalationTarget InstagramEscalation = null, EscalationTarget TwitterEscalation = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.MatchCriteria = MatchCriteria;
        this.Priority = Priority;
        this.DivisionId = DivisionId;
        this.Description = Description;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Status = Status;
        this.OpenEscalation = OpenEscalation;
        this.FacebookEscalation = FacebookEscalation;
        this.InstagramEscalation = InstagramEscalation;
        this.TwitterEscalation = TwitterEscalation;

    }



    /// <summary>
    /// ID of the escalation rule.
    /// </summary>
    /// <value>ID of the escalation rule.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the escalation rule.
    /// </summary>
    /// <value>The name of the escalation rule.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The criteria that defines when a social media message should be escalated.
    /// </summary>
    /// <value>The criteria that defines when a social media message should be escalated.</value>
    [JsonPropertyName("matchCriteria")]
    public string MatchCriteria { get; set; }



    /// <summary>
    /// The priority of the escalation rule.
    /// </summary>
    /// <value>The priority of the escalation rule.</value>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }



    /// <summary>
    /// The ID of the division the social escalation rule belongs to.
    /// </summary>
    /// <value>The ID of the division the social escalation rule belongs to.</value>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }



    /// <summary>
    /// A description of the social escalation rule.
    /// </summary>
    /// <value>A description of the social escalation rule.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the escalation rule was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the escalation rule was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }





    /// <summary>
    /// The target integration configuration used for an open social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for an open social media message if the match criteria returns true.</value>
    [JsonPropertyName("openEscalation")]
    public EscalationTarget OpenEscalation { get; set; }



    /// <summary>
    /// The target integration configuration used for a Facebook social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for a Facebook social media message if the match criteria returns true.</value>
    [JsonPropertyName("facebookEscalation")]
    public EscalationTarget FacebookEscalation { get; set; }



    /// <summary>
    /// The target integration configuration used for an Instagram social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for an Instagram social media message if the match criteria returns true.</value>
    [JsonPropertyName("instagramEscalation")]
    public EscalationTarget InstagramEscalation { get; set; }



    /// <summary>
    /// The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true.</value>
    [JsonPropertyName("twitterEscalation")]
    public EscalationTarget TwitterEscalation { get; set; }



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
        sb.Append("class EscalationRuleResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MatchCriteria: ").Append(MatchCriteria).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  OpenEscalation: ").Append(OpenEscalation).Append("\n");
        sb.Append("  FacebookEscalation: ").Append(FacebookEscalation).Append("\n");
        sb.Append("  InstagramEscalation: ").Append(InstagramEscalation).Append("\n");
        sb.Append("  TwitterEscalation: ").Append(TwitterEscalation).Append("\n");
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
        return Equals(obj as EscalationRuleResponse);
    }

    /// <summary>
    /// Returns true if EscalationRuleResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of EscalationRuleResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EscalationRuleResponse other)
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
                MatchCriteria == other.MatchCriteria ||
                MatchCriteria != null &&
                MatchCriteria.Equals(other.MatchCriteria)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                OpenEscalation == other.OpenEscalation ||
                OpenEscalation != null &&
                OpenEscalation.Equals(other.OpenEscalation)
            ) &&
            (
                FacebookEscalation == other.FacebookEscalation ||
                FacebookEscalation != null &&
                FacebookEscalation.Equals(other.FacebookEscalation)
            ) &&
            (
                InstagramEscalation == other.InstagramEscalation ||
                InstagramEscalation != null &&
                InstagramEscalation.Equals(other.InstagramEscalation)
            ) &&
            (
                TwitterEscalation == other.TwitterEscalation ||
                TwitterEscalation != null &&
                TwitterEscalation.Equals(other.TwitterEscalation)
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

            if (MatchCriteria != null)
            {
                hash = hash * 59 + MatchCriteria.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (OpenEscalation != null)
            {
                hash = hash * 59 + OpenEscalation.GetHashCode();
            }

            if (FacebookEscalation != null)
            {
                hash = hash * 59 + FacebookEscalation.GetHashCode();
            }

            if (InstagramEscalation != null)
            {
                hash = hash * 59 + InstagramEscalation.GetHashCode();
            }

            if (TwitterEscalation != null)
            {
                hash = hash * 59 + TwitterEscalation.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
