using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerCampaignRuleConfigChangeCampaignRule
/// </summary>

public partial class DialerCampaignRuleConfigChangeCampaignRule : IEquatable<DialerCampaignRuleConfigChangeCampaignRule>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCampaignRuleConfigChangeCampaignRule" /> class.
    /// </summary>
    /// <param name="CampaignRuleEntities">CampaignRuleEntities.</param>
    /// <param name="CampaignRuleConditions">The list of conditions that will trigger this Campaign Rule.</param>
    /// <param name="CampaignRuleActions">The list of actions that will be taken when this Campaign Rule&#39;s conditions are met.</param>
    /// <param name="MatchAnyConditions">Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL).</param>
    /// <param name="Enabled">Whether this campaign rule is enabled.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerCampaignRuleConfigChangeCampaignRule(DialerCampaignRuleConfigChangeCampaignRuleEntities CampaignRuleEntities = null, List<DialerCampaignRuleConfigChangeCampaignRuleCondition> CampaignRuleConditions = null, List<DialerCampaignRuleConfigChangeCampaignRuleAction> CampaignRuleActions = null, bool? MatchAnyConditions = null, bool? Enabled = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
        this.CampaignRuleEntities = CampaignRuleEntities;
        this.CampaignRuleConditions = CampaignRuleConditions;
        this.CampaignRuleActions = CampaignRuleActions;
        this.MatchAnyConditions = MatchAnyConditions;
        this.Enabled = Enabled;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets CampaignRuleEntities
    /// </summary>
    [JsonPropertyName("campaignRuleEntities")]
    public DialerCampaignRuleConfigChangeCampaignRuleEntities CampaignRuleEntities { get; set; }



    /// <summary>
    /// The list of conditions that will trigger this Campaign Rule
    /// </summary>
    /// <value>The list of conditions that will trigger this Campaign Rule</value>
    [JsonPropertyName("campaignRuleConditions")]
    public List<DialerCampaignRuleConfigChangeCampaignRuleCondition> CampaignRuleConditions { get; set; }



    /// <summary>
    /// The list of actions that will be taken when this Campaign Rule&#39;s conditions are met
    /// </summary>
    /// <value>The list of actions that will be taken when this Campaign Rule&#39;s conditions are met</value>
    [JsonPropertyName("campaignRuleActions")]
    public List<DialerCampaignRuleConfigChangeCampaignRuleAction> CampaignRuleActions { get; set; }



    /// <summary>
    /// Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL)
    /// </summary>
    /// <value>Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL)</value>
    [JsonPropertyName("matchAnyConditions")]
    public bool? MatchAnyConditions { get; set; }



    /// <summary>
    /// Whether this campaign rule is enabled
    /// </summary>
    /// <value>Whether this campaign rule is enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerCampaignRuleConfigChangeCampaignRule {\n");

        sb.Append("  CampaignRuleEntities: ").Append(CampaignRuleEntities).Append("\n");
        sb.Append("  CampaignRuleConditions: ").Append(CampaignRuleConditions).Append("\n");
        sb.Append("  CampaignRuleActions: ").Append(CampaignRuleActions).Append("\n");
        sb.Append("  MatchAnyConditions: ").Append(MatchAnyConditions).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerCampaignRuleConfigChangeCampaignRule);
    }

    /// <summary>
    /// Returns true if DialerCampaignRuleConfigChangeCampaignRule instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCampaignRuleConfigChangeCampaignRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCampaignRuleConfigChangeCampaignRule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CampaignRuleEntities == other.CampaignRuleEntities ||
                CampaignRuleEntities != null &&
                CampaignRuleEntities.Equals(other.CampaignRuleEntities)
            ) &&
            (
                CampaignRuleConditions == other.CampaignRuleConditions ||
                CampaignRuleConditions != null &&
                CampaignRuleConditions.SequenceEqual(other.CampaignRuleConditions)
            ) &&
            (
                CampaignRuleActions == other.CampaignRuleActions ||
                CampaignRuleActions != null &&
                CampaignRuleActions.SequenceEqual(other.CampaignRuleActions)
            ) &&
            (
                MatchAnyConditions == other.MatchAnyConditions ||
                MatchAnyConditions != null &&
                MatchAnyConditions.Equals(other.MatchAnyConditions)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (CampaignRuleEntities != null)
            {
                hash = hash * 59 + CampaignRuleEntities.GetHashCode();
            }

            if (CampaignRuleConditions != null)
            {
                hash = hash * 59 + CampaignRuleConditions.GetHashCode();
            }

            if (CampaignRuleActions != null)
            {
                hash = hash * 59 + CampaignRuleActions.GetHashCode();
            }

            if (MatchAnyConditions != null)
            {
                hash = hash * 59 + MatchAnyConditions.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
