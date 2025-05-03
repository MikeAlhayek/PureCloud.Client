using System.Text;
using System.Text.Json.Serialization;


namespace PureCloud.Client.Models;

/// <summary>
/// ActionMap
/// </summary>

public partial class ActionMap : IEquatable<ActionMap>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionMap" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActionMap() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionMap" /> class.
    /// </summary>
    /// <param name="Version">The version of the action map..</param>
    /// <param name="IsActive">Whether the action map is active..</param>
    /// <param name="DisplayName">Display name of the action map. (required).</param>
    /// <param name="TriggerWithSegments">Trigger action map if any segment in the list is assigned to a given customer. (required).</param>
    /// <param name="TriggerWithEventConditions">List of event conditions that must be satisfied to trigger the action map..</param>
    /// <param name="TriggerWithOutcomeProbabilityConditions">(deprecated - use triggerWithOutcomeQuantileConditions instead) Probability conditions for outcomes that must be satisfied to trigger the action map..</param>
    /// <param name="TriggerWithOutcomePercentileConditions">(deprecated - use triggerWithOutcomeQuantileConditions instead) Percentile conditions for outcomes that must be satisfied to trigger the action map..</param>
    /// <param name="TriggerWithOutcomeQuantileConditions">Quantile conditions for outcomes that must be satisfied to trigger the action map..</param>
    /// <param name="PageUrlConditions">URL conditions that a page must match for web actions to be displayable. (required).</param>
    /// <param name="Activation">Type of activation..</param>
    /// <param name="Weight">Weight of the action map with higher number denoting higher weight..</param>
    /// <param name="Action">The action that will be executed if this action map is triggered..</param>
    /// <param name="ActionMapScheduleGroups">The action map&#39;s associated schedule groups..</param>
    /// <param name="IgnoreFrequencyCap">Override organization-level frequency cap and always offer web engagements from this action map..</param>
    /// <param name="CreatedDate">Timestamp indicating when the action map was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedDate">Timestamp indicating when the action map was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="StartDate">Timestamp at which the action map is scheduled to start firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDate">Timestamp at which the action map is scheduled to stop firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ActionMap(int? Version = null, bool? IsActive = null, string DisplayName = null, List<string> TriggerWithSegments = null, List<EventCondition> TriggerWithEventConditions = null, List<OutcomeProbabilityCondition> TriggerWithOutcomeProbabilityConditions = null, List<OutcomePercentileCondition> TriggerWithOutcomePercentileConditions = null, List<OutcomeQuantileCondition> TriggerWithOutcomeQuantileConditions = null, List<UrlCondition> PageUrlConditions = null, Activation Activation = null, int? Weight = null, ActionMapAction Action = null, ActionMapScheduleGroups ActionMapScheduleGroups = null, bool? IgnoreFrequencyCap = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null, DateTime? StartDate = null, DateTime? EndDate = null)
    {
        this.Version = Version;
        this.IsActive = IsActive;
        this.DisplayName = DisplayName;
        this.TriggerWithSegments = TriggerWithSegments;
        this.TriggerWithEventConditions = TriggerWithEventConditions;
        this.TriggerWithOutcomeProbabilityConditions = TriggerWithOutcomeProbabilityConditions;
        this.TriggerWithOutcomePercentileConditions = TriggerWithOutcomePercentileConditions;
        this.TriggerWithOutcomeQuantileConditions = TriggerWithOutcomeQuantileConditions;
        this.PageUrlConditions = PageUrlConditions;
        this.Activation = Activation;
        this.Weight = Weight;
        this.Action = Action;
        this.ActionMapScheduleGroups = ActionMapScheduleGroups;
        this.IgnoreFrequencyCap = IgnoreFrequencyCap;
        this.CreatedDate = CreatedDate;
        this.ModifiedDate = ModifiedDate;
        this.StartDate = StartDate;
        this.EndDate = EndDate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The version of the action map.
    /// </summary>
    /// <value>The version of the action map.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Whether the action map is active.
    /// </summary>
    /// <value>Whether the action map is active.</value>
    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }



    /// <summary>
    /// Display name of the action map.
    /// </summary>
    /// <value>Display name of the action map.</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }



    /// <summary>
    /// Trigger action map if any segment in the list is assigned to a given customer.
    /// </summary>
    /// <value>Trigger action map if any segment in the list is assigned to a given customer.</value>
    [JsonPropertyName("triggerWithSegments")]
    public List<string> TriggerWithSegments { get; set; }



    /// <summary>
    /// List of event conditions that must be satisfied to trigger the action map.
    /// </summary>
    /// <value>List of event conditions that must be satisfied to trigger the action map.</value>
    [JsonPropertyName("triggerWithEventConditions")]
    public List<EventCondition> TriggerWithEventConditions { get; set; }



    /// <summary>
    /// (deprecated - use triggerWithOutcomeQuantileConditions instead) Probability conditions for outcomes that must be satisfied to trigger the action map.
    /// </summary>
    /// <value>(deprecated - use triggerWithOutcomeQuantileConditions instead) Probability conditions for outcomes that must be satisfied to trigger the action map.</value>
    [JsonPropertyName("triggerWithOutcomeProbabilityConditions")]
    public List<OutcomeProbabilityCondition> TriggerWithOutcomeProbabilityConditions { get; set; }



    /// <summary>
    /// (deprecated - use triggerWithOutcomeQuantileConditions instead) Percentile conditions for outcomes that must be satisfied to trigger the action map.
    /// </summary>
    /// <value>(deprecated - use triggerWithOutcomeQuantileConditions instead) Percentile conditions for outcomes that must be satisfied to trigger the action map.</value>
    [JsonPropertyName("triggerWithOutcomePercentileConditions")]
    public List<OutcomePercentileCondition> TriggerWithOutcomePercentileConditions { get; set; }



    /// <summary>
    /// Quantile conditions for outcomes that must be satisfied to trigger the action map.
    /// </summary>
    /// <value>Quantile conditions for outcomes that must be satisfied to trigger the action map.</value>
    [JsonPropertyName("triggerWithOutcomeQuantileConditions")]
    public List<OutcomeQuantileCondition> TriggerWithOutcomeQuantileConditions { get; set; }



    /// <summary>
    /// URL conditions that a page must match for web actions to be displayable.
    /// </summary>
    /// <value>URL conditions that a page must match for web actions to be displayable.</value>
    [JsonPropertyName("pageUrlConditions")]
    public List<UrlCondition> PageUrlConditions { get; set; }



    /// <summary>
    /// Type of activation.
    /// </summary>
    /// <value>Type of activation.</value>
    [JsonPropertyName("activation")]
    public Activation Activation { get; set; }



    /// <summary>
    /// Weight of the action map with higher number denoting higher weight.
    /// </summary>
    /// <value>Weight of the action map with higher number denoting higher weight.</value>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }



    /// <summary>
    /// The action that will be executed if this action map is triggered.
    /// </summary>
    /// <value>The action that will be executed if this action map is triggered.</value>
    [JsonPropertyName("action")]
    public ActionMapAction Action { get; set; }



    /// <summary>
    /// The action map&#39;s associated schedule groups.
    /// </summary>
    /// <value>The action map&#39;s associated schedule groups.</value>
    [JsonPropertyName("actionMapScheduleGroups")]
    public ActionMapScheduleGroups ActionMapScheduleGroups { get; set; }



    /// <summary>
    /// Override organization-level frequency cap and always offer web engagements from this action map.
    /// </summary>
    /// <value>Override organization-level frequency cap and always offer web engagements from this action map.</value>
    [JsonPropertyName("ignoreFrequencyCap")]
    public bool? IgnoreFrequencyCap { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }



    /// <summary>
    /// Timestamp indicating when the action map was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the action map was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Timestamp indicating when the action map was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the action map was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// Timestamp at which the action map is scheduled to start firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp at which the action map is scheduled to start firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Timestamp at which the action map is scheduled to stop firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp at which the action map is scheduled to stop firing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionMap {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  IsActive: ").Append(IsActive).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  TriggerWithSegments: ").Append(TriggerWithSegments).Append("\n");
        sb.Append("  TriggerWithEventConditions: ").Append(TriggerWithEventConditions).Append("\n");
        sb.Append("  TriggerWithOutcomeProbabilityConditions: ").Append(TriggerWithOutcomeProbabilityConditions).Append("\n");
        sb.Append("  TriggerWithOutcomePercentileConditions: ").Append(TriggerWithOutcomePercentileConditions).Append("\n");
        sb.Append("  TriggerWithOutcomeQuantileConditions: ").Append(TriggerWithOutcomeQuantileConditions).Append("\n");
        sb.Append("  PageUrlConditions: ").Append(PageUrlConditions).Append("\n");
        sb.Append("  Activation: ").Append(Activation).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  ActionMapScheduleGroups: ").Append(ActionMapScheduleGroups).Append("\n");
        sb.Append("  IgnoreFrequencyCap: ").Append(IgnoreFrequencyCap).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
        return Equals(obj as ActionMap);
    }

    /// <summary>
    /// Returns true if ActionMap instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionMap to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionMap other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                IsActive == other.IsActive ||
                IsActive != null &&
                IsActive.Equals(other.IsActive)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                TriggerWithSegments == other.TriggerWithSegments ||
                TriggerWithSegments != null &&
                TriggerWithSegments.SequenceEqual(other.TriggerWithSegments)
            ) &&
            (
                TriggerWithEventConditions == other.TriggerWithEventConditions ||
                TriggerWithEventConditions != null &&
                TriggerWithEventConditions.SequenceEqual(other.TriggerWithEventConditions)
            ) &&
            (
                TriggerWithOutcomeProbabilityConditions == other.TriggerWithOutcomeProbabilityConditions ||
                TriggerWithOutcomeProbabilityConditions != null &&
                TriggerWithOutcomeProbabilityConditions.SequenceEqual(other.TriggerWithOutcomeProbabilityConditions)
            ) &&
            (
                TriggerWithOutcomePercentileConditions == other.TriggerWithOutcomePercentileConditions ||
                TriggerWithOutcomePercentileConditions != null &&
                TriggerWithOutcomePercentileConditions.SequenceEqual(other.TriggerWithOutcomePercentileConditions)
            ) &&
            (
                TriggerWithOutcomeQuantileConditions == other.TriggerWithOutcomeQuantileConditions ||
                TriggerWithOutcomeQuantileConditions != null &&
                TriggerWithOutcomeQuantileConditions.SequenceEqual(other.TriggerWithOutcomeQuantileConditions)
            ) &&
            (
                PageUrlConditions == other.PageUrlConditions ||
                PageUrlConditions != null &&
                PageUrlConditions.SequenceEqual(other.PageUrlConditions)
            ) &&
            (
                Activation == other.Activation ||
                Activation != null &&
                Activation.Equals(other.Activation)
            ) &&
            (
                Weight == other.Weight ||
                Weight != null &&
                Weight.Equals(other.Weight)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                ActionMapScheduleGroups == other.ActionMapScheduleGroups ||
                ActionMapScheduleGroups != null &&
                ActionMapScheduleGroups.Equals(other.ActionMapScheduleGroups)
            ) &&
            (
                IgnoreFrequencyCap == other.IgnoreFrequencyCap ||
                IgnoreFrequencyCap != null &&
                IgnoreFrequencyCap.Equals(other.IgnoreFrequencyCap)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (IsActive != null)
            {
                hash = hash * 59 + IsActive.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (TriggerWithSegments != null)
            {
                hash = hash * 59 + TriggerWithSegments.GetHashCode();
            }

            if (TriggerWithEventConditions != null)
            {
                hash = hash * 59 + TriggerWithEventConditions.GetHashCode();
            }

            if (TriggerWithOutcomeProbabilityConditions != null)
            {
                hash = hash * 59 + TriggerWithOutcomeProbabilityConditions.GetHashCode();
            }

            if (TriggerWithOutcomePercentileConditions != null)
            {
                hash = hash * 59 + TriggerWithOutcomePercentileConditions.GetHashCode();
            }

            if (TriggerWithOutcomeQuantileConditions != null)
            {
                hash = hash * 59 + TriggerWithOutcomeQuantileConditions.GetHashCode();
            }

            if (PageUrlConditions != null)
            {
                hash = hash * 59 + PageUrlConditions.GetHashCode();
            }

            if (Activation != null)
            {
                hash = hash * 59 + Activation.GetHashCode();
            }

            if (Weight != null)
            {
                hash = hash * 59 + Weight.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (ActionMapScheduleGroups != null)
            {
                hash = hash * 59 + ActionMapScheduleGroups.GetHashCode();
            }

            if (IgnoreFrequencyCap != null)
            {
                hash = hash * 59 + IgnoreFrequencyCap.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            return hash;
        }
    }
}
