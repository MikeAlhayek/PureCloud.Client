using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EscalationRuleRequest
/// </summary>
[DataContract]
public partial class EscalationRuleRequest : IEquatable<EscalationRuleRequest>
{
    /// <summary>
    /// The status of the escalation rule.
    /// </summary>
    /// <value>The status of the escalation rule.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EscalationRuleRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EscalationRuleRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EscalationRuleRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the escalation rule. (required).</param>
    /// <param name="MatchCriteria">The criteria that defines when a social media message should be escalated. (required).</param>
    /// <param name="Priority">The priority of the escalation rule. The lower the number the higer the priority. Once a rule is matched others are skipped. (required).</param>
    /// <param name="DivisionId">The ID of the division the social escalation rule belongs to. (required).</param>
    /// <param name="Description">A description of the social escalation rule..</param>
    /// <param name="Status">The status of the escalation rule..</param>
    /// <param name="OpenEscalation">The target integration configuration used for an open social media message if the match criteria returns true..</param>
    /// <param name="FacebookEscalation">The target integration configuration used for a Facebook social media message if the match criteria returns true..</param>
    /// <param name="InstagramEscalation">The target integration configuration used for an Instagram social media message if the match criteria returns true..</param>
    /// <param name="TwitterEscalation">The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true..</param>
    public EscalationRuleRequest(string Name = null, string MatchCriteria = null, int? Priority = null, string DivisionId = null, string Description = null, StatusEnum? Status = null, EscalationTarget OpenEscalation = null, EscalationTarget FacebookEscalation = null, EscalationTarget InstagramEscalation = null, EscalationTarget TwitterEscalation = null)
    {
        this.Name = Name;
        this.MatchCriteria = MatchCriteria;
        this.Priority = Priority;
        this.DivisionId = DivisionId;
        this.Description = Description;
        this.Status = Status;
        this.OpenEscalation = OpenEscalation;
        this.FacebookEscalation = FacebookEscalation;
        this.InstagramEscalation = InstagramEscalation;
        this.TwitterEscalation = TwitterEscalation;

    }



    /// <summary>
    /// The name of the escalation rule.
    /// </summary>
    /// <value>The name of the escalation rule.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The criteria that defines when a social media message should be escalated.
    /// </summary>
    /// <value>The criteria that defines when a social media message should be escalated.</value>
    [DataMember(Name = "matchCriteria", EmitDefaultValue = false)]
    public string MatchCriteria { get; set; }



    /// <summary>
    /// The priority of the escalation rule. The lower the number the higer the priority. Once a rule is matched others are skipped.
    /// </summary>
    /// <value>The priority of the escalation rule. The lower the number the higer the priority. Once a rule is matched others are skipped.</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public int? Priority { get; set; }



    /// <summary>
    /// The ID of the division the social escalation rule belongs to.
    /// </summary>
    /// <value>The ID of the division the social escalation rule belongs to.</value>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }



    /// <summary>
    /// A description of the social escalation rule.
    /// </summary>
    /// <value>A description of the social escalation rule.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }





    /// <summary>
    /// The target integration configuration used for an open social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for an open social media message if the match criteria returns true.</value>
    [DataMember(Name = "openEscalation", EmitDefaultValue = false)]
    public EscalationTarget OpenEscalation { get; set; }



    /// <summary>
    /// The target integration configuration used for a Facebook social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for a Facebook social media message if the match criteria returns true.</value>
    [DataMember(Name = "facebookEscalation", EmitDefaultValue = false)]
    public EscalationTarget FacebookEscalation { get; set; }



    /// <summary>
    /// The target integration configuration used for an Instagram social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for an Instagram social media message if the match criteria returns true.</value>
    [DataMember(Name = "instagramEscalation", EmitDefaultValue = false)]
    public EscalationTarget InstagramEscalation { get; set; }



    /// <summary>
    /// The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true.
    /// </summary>
    /// <value>The target integration configuration used for a X (formerly Twitter) social media message if the match criteria returns true.</value>
    [DataMember(Name = "twitterEscalation", EmitDefaultValue = false)]
    public EscalationTarget TwitterEscalation { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EscalationRuleRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MatchCriteria: ").Append(MatchCriteria).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  OpenEscalation: ").Append(OpenEscalation).Append("\n");
        sb.Append("  FacebookEscalation: ").Append(FacebookEscalation).Append("\n");
        sb.Append("  InstagramEscalation: ").Append(InstagramEscalation).Append("\n");
        sb.Append("  TwitterEscalation: ").Append(TwitterEscalation).Append("\n");
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
        return Equals(obj as EscalationRuleRequest);
    }

    /// <summary>
    /// Returns true if EscalationRuleRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of EscalationRuleRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EscalationRuleRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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

            return hash;
        }
    }
}
