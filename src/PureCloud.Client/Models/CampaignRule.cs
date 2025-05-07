using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignRule
/// </summary>

public partial class CampaignRule : IEquatable<CampaignRule>
{
    /// <summary>
    /// CampaignRule processing algorithm
    /// </summary>
    /// <value>CampaignRule processing algorithm</value>
    
    public enum CampaignRuleProcessingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum V2 for "v2"
        /// </summary>
        [EnumMember(Value = "v2")]
        V2
    }
    /// <summary>
    /// CampaignRule processing algorithm
    /// </summary>
    /// <value>CampaignRule processing algorithm</value>
    [JsonPropertyName("campaignRuleProcessing")]
    public CampaignRuleProcessingEnum? CampaignRuleProcessing { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CampaignRule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRule" /> class.
    /// </summary>
    /// <param name="Name">The name of the CampaignRule. (required).</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="CampaignRuleEntities">The list of entities that this CampaignRule monitors. (required).</param>
    /// <param name="CampaignRuleConditions">The list of conditions that are evaluated on the entities. (required).</param>
    /// <param name="CampaignRuleActions">The list of actions that are executed if the conditions are satisfied. (required).</param>
    /// <param name="MatchAnyConditions">MatchAnyConditions.</param>
    /// <param name="Enabled">Whether or not this CampaignRule is currently enabled. Required on updates..</param>
    /// <param name="CampaignRuleProcessing">CampaignRule processing algorithm.</param>
    /// <param name="ConditionGroups">List of condition groups that are evaluated, used only with campaignRuleProcessing&#x3D;\&quot;v2\&quot;.</param>
    /// <param name="ExecutionSettings">CampaignRule execution settings.</param>
    public CampaignRule(string Name = null, int? Version = null, CampaignRuleEntities CampaignRuleEntities = null, List<CampaignRuleCondition> CampaignRuleConditions = null, List<CampaignRuleAction> CampaignRuleActions = null, bool? MatchAnyConditions = null, bool? Enabled = null, CampaignRuleProcessingEnum? CampaignRuleProcessing = null, List<CampaignRuleConditionGroup> ConditionGroups = null, CampaignRuleExecutionSettings ExecutionSettings = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.CampaignRuleEntities = CampaignRuleEntities;
        this.CampaignRuleConditions = CampaignRuleConditions;
        this.CampaignRuleActions = CampaignRuleActions;
        this.MatchAnyConditions = MatchAnyConditions;
        this.Enabled = Enabled;
        this.CampaignRuleProcessing = CampaignRuleProcessing;
        this.ConditionGroups = ConditionGroups;
        this.ExecutionSettings = ExecutionSettings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the CampaignRule.
    /// </summary>
    /// <value>The name of the CampaignRule.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The list of entities that this CampaignRule monitors.
    /// </summary>
    /// <value>The list of entities that this CampaignRule monitors.</value>
    [JsonPropertyName("campaignRuleEntities")]
    public CampaignRuleEntities CampaignRuleEntities { get; set; }



    /// <summary>
    /// The list of conditions that are evaluated on the entities.
    /// </summary>
    /// <value>The list of conditions that are evaluated on the entities.</value>
    [JsonPropertyName("campaignRuleConditions")]
    public List<CampaignRuleCondition> CampaignRuleConditions { get; set; }



    /// <summary>
    /// The list of actions that are executed if the conditions are satisfied.
    /// </summary>
    /// <value>The list of actions that are executed if the conditions are satisfied.</value>
    [JsonPropertyName("campaignRuleActions")]
    public List<CampaignRuleAction> CampaignRuleActions { get; set; }



    /// <summary>
    /// Gets or Sets MatchAnyConditions
    /// </summary>
    [JsonPropertyName("matchAnyConditions")]
    public bool? MatchAnyConditions { get; set; }



    /// <summary>
    /// Whether or not this CampaignRule is currently enabled. Required on updates.
    /// </summary>
    /// <value>Whether or not this CampaignRule is currently enabled. Required on updates.</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }





    /// <summary>
    /// List of condition groups that are evaluated, used only with campaignRuleProcessing&#x3D;\&quot;v2\&quot;
    /// </summary>
    /// <value>List of condition groups that are evaluated, used only with campaignRuleProcessing&#x3D;\&quot;v2\&quot;</value>
    [JsonPropertyName("conditionGroups")]
    public List<CampaignRuleConditionGroup> ConditionGroups { get; set; }



    /// <summary>
    /// CampaignRule execution settings
    /// </summary>
    /// <value>CampaignRule execution settings</value>
    [JsonPropertyName("executionSettings")]
    public CampaignRuleExecutionSettings ExecutionSettings { get; set; }



    /// <summary>
    /// A list of current warning conditions associated with the campaign rule.
    /// </summary>
    /// <value>A list of current warning conditions associated with the campaign rule.</value>
    [JsonPropertyName("warnings")]
    public List<CampaignRuleWarning> Warnings { get; set; }



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
        sb.Append("class CampaignRule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  CampaignRuleEntities: ").Append(CampaignRuleEntities).Append("\n");
        sb.Append("  CampaignRuleConditions: ").Append(CampaignRuleConditions).Append("\n");
        sb.Append("  CampaignRuleActions: ").Append(CampaignRuleActions).Append("\n");
        sb.Append("  MatchAnyConditions: ").Append(MatchAnyConditions).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  CampaignRuleProcessing: ").Append(CampaignRuleProcessing).Append("\n");
        sb.Append("  ConditionGroups: ").Append(ConditionGroups).Append("\n");
        sb.Append("  ExecutionSettings: ").Append(ExecutionSettings).Append("\n");
        sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
        return Equals(obj as CampaignRule);
    }

    /// <summary>
    /// Returns true if CampaignRule instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignRule other)
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
            ) &&
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
                CampaignRuleProcessing == other.CampaignRuleProcessing ||
                CampaignRuleProcessing != null &&
                CampaignRuleProcessing.Equals(other.CampaignRuleProcessing)
            ) &&
            (
                ConditionGroups == other.ConditionGroups ||
                ConditionGroups != null &&
                ConditionGroups.SequenceEqual(other.ConditionGroups)
            ) &&
            (
                ExecutionSettings == other.ExecutionSettings ||
                ExecutionSettings != null &&
                ExecutionSettings.Equals(other.ExecutionSettings)
            ) &&
            (
                Warnings == other.Warnings ||
                Warnings != null &&
                Warnings.SequenceEqual(other.Warnings)
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

            if (CampaignRuleProcessing != null)
            {
                hash = hash * 59 + CampaignRuleProcessing.GetHashCode();
            }

            if (ConditionGroups != null)
            {
                hash = hash * 59 + ConditionGroups.GetHashCode();
            }

            if (ExecutionSettings != null)
            {
                hash = hash * 59 + ExecutionSettings.GetHashCode();
            }

            if (Warnings != null)
            {
                hash = hash * 59 + Warnings.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
