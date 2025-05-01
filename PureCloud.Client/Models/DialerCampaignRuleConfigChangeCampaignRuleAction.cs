using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerCampaignRuleConfigChangeCampaignRuleAction
/// </summary>
[DataContract]
public partial class DialerCampaignRuleConfigChangeCampaignRuleAction : IEquatable<DialerCampaignRuleConfigChangeCampaignRuleAction>
{
    /// <summary>
    /// The type of this action
    /// </summary>
    /// <value>The type of this action</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Turnoncampaign for "turnOnCampaign"
        /// </summary>
        [EnumMember(Value = "turnOnCampaign")]
        Turnoncampaign,

        /// <summary>
        /// Enum Turnoffcampaign for "turnOffCampaign"
        /// </summary>
        [EnumMember(Value = "turnOffCampaign")]
        Turnoffcampaign,

        /// <summary>
        /// Enum Turnonsequence for "turnOnSequence"
        /// </summary>
        [EnumMember(Value = "turnOnSequence")]
        Turnonsequence,

        /// <summary>
        /// Enum Turnoffsequence for "turnOffSequence"
        /// </summary>
        [EnumMember(Value = "turnOffSequence")]
        Turnoffsequence,

        /// <summary>
        /// Enum Setcampaignpriority for "setCampaignPriority"
        /// </summary>
        [EnumMember(Value = "setCampaignPriority")]
        Setcampaignpriority,

        /// <summary>
        /// Enum Recyclecampaign for "recycleCampaign"
        /// </summary>
        [EnumMember(Value = "recycleCampaign")]
        Recyclecampaign
    }
    /// <summary>
    /// The type of this action
    /// </summary>
    /// <value>The type of this action</value>
    [DataMember(Name = "actionType", EmitDefaultValue = false)]
    public ActionTypeEnum? ActionType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCampaignRuleConfigChangeCampaignRuleAction" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the action.</param>
    /// <param name="Parameters">The parameters to match this action.</param>
    /// <param name="ActionType">The type of this action.</param>
    /// <param name="CampaignRuleActionEntities">CampaignRuleActionEntities.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerCampaignRuleConfigChangeCampaignRuleAction(string Id = null, Dictionary<string, string> Parameters = null, ActionTypeEnum? ActionType = null, DialerCampaignRuleConfigChangeCampaignRuleActionEntities CampaignRuleActionEntities = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Id = Id;
        this.Parameters = Parameters;
        this.ActionType = ActionType;
        this.CampaignRuleActionEntities = CampaignRuleActionEntities;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// The globally unique identifier for the action
    /// </summary>
    /// <value>The globally unique identifier for the action</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The parameters to match this action
    /// </summary>
    /// <value>The parameters to match this action</value>
    [DataMember(Name = "parameters", EmitDefaultValue = false)]
    public Dictionary<string, string> Parameters { get; set; }





    /// <summary>
    /// Gets or Sets CampaignRuleActionEntities
    /// </summary>
    [DataMember(Name = "campaignRuleActionEntities", EmitDefaultValue = false)]
    public DialerCampaignRuleConfigChangeCampaignRuleActionEntities CampaignRuleActionEntities { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerCampaignRuleConfigChangeCampaignRuleAction {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Parameters: ").Append(Parameters).Append("\n");
        sb.Append("  ActionType: ").Append(ActionType).Append("\n");
        sb.Append("  CampaignRuleActionEntities: ").Append(CampaignRuleActionEntities).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as DialerCampaignRuleConfigChangeCampaignRuleAction);
    }

    /// <summary>
    /// Returns true if DialerCampaignRuleConfigChangeCampaignRuleAction instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCampaignRuleConfigChangeCampaignRuleAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCampaignRuleConfigChangeCampaignRuleAction other)
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
                Parameters == other.Parameters ||
                Parameters != null &&
                Parameters.SequenceEqual(other.Parameters)
            ) &&
            (
                ActionType == other.ActionType ||
                ActionType != null &&
                ActionType.Equals(other.ActionType)
            ) &&
            (
                CampaignRuleActionEntities == other.CampaignRuleActionEntities ||
                CampaignRuleActionEntities != null &&
                CampaignRuleActionEntities.Equals(other.CampaignRuleActionEntities)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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

            if (Parameters != null)
            {
                hash = hash * 59 + Parameters.GetHashCode();
            }

            if (ActionType != null)
            {
                hash = hash * 59 + ActionType.GetHashCode();
            }

            if (CampaignRuleActionEntities != null)
            {
                hash = hash * 59 + CampaignRuleActionEntities.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
