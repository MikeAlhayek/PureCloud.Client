using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignRuleAction
/// </summary>
[DataContract]
public partial class CampaignRuleAction : IEquatable<CampaignRuleAction>
{
    /// <summary>
    /// The action to take on the campaignRuleActionEntities.
    /// </summary>
    /// <value>The action to take on the campaignRuleActionEntities.</value>
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
        Recyclecampaign,

        /// <summary>
        /// Enum Setcampaigndialingmode for "setCampaignDialingMode"
        /// </summary>
        [EnumMember(Value = "setCampaignDialingMode")]
        Setcampaigndialingmode,

        /// <summary>
        /// Enum Setcampaignabandonrate for "setCampaignAbandonRate"
        /// </summary>
        [EnumMember(Value = "setCampaignAbandonRate")]
        Setcampaignabandonrate,

        /// <summary>
        /// Enum Setcampaignnumberoflines for "setCampaignNumberOfLines"
        /// </summary>
        [EnumMember(Value = "setCampaignNumberOfLines")]
        Setcampaignnumberoflines,

        /// <summary>
        /// Enum Setcampaignweight for "setCampaignWeight"
        /// </summary>
        [EnumMember(Value = "setCampaignWeight")]
        Setcampaignweight,

        /// <summary>
        /// Enum Setcampaignmaxcallsperagent for "setCampaignMaxCallsPerAgent"
        /// </summary>
        [EnumMember(Value = "setCampaignMaxCallsPerAgent")]
        Setcampaignmaxcallsperagent,

        /// <summary>
        /// Enum Setcampaignmessagesperminute for "setCampaignMessagesPerMinute"
        /// </summary>
        [EnumMember(Value = "setCampaignMessagesPerMinute")]
        Setcampaignmessagesperminute,

        /// <summary>
        /// Enum Changecampaignqueue for "changeCampaignQueue"
        /// </summary>
        [EnumMember(Value = "changeCampaignQueue")]
        Changecampaignqueue,

        /// <summary>
        /// Enum Changecampaigntemplate for "changeCampaignTemplate"
        /// </summary>
        [EnumMember(Value = "changeCampaignTemplate")]
        Changecampaigntemplate
    }
    /// <summary>
    /// The action to take on the campaignRuleActionEntities.
    /// </summary>
    /// <value>The action to take on the campaignRuleActionEntities.</value>
    [DataMember(Name = "actionType", EmitDefaultValue = false)]
    public ActionTypeEnum? ActionType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRuleAction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CampaignRuleAction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRuleAction" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Parameters">The parameters for the CampaignRuleAction. Required for certain actionTypes..</param>
    /// <param name="ActionType">The action to take on the campaignRuleActionEntities. (required).</param>
    /// <param name="CampaignRuleActionEntities">The list of entities that this action will apply to. (required).</param>
    public CampaignRuleAction(string Id = null, CampaignRuleParameters Parameters = null, ActionTypeEnum? ActionType = null, CampaignRuleActionEntities CampaignRuleActionEntities = null)
    {
        this.Id = Id;
        this.Parameters = Parameters;
        this.ActionType = ActionType;
        this.CampaignRuleActionEntities = CampaignRuleActionEntities;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The parameters for the CampaignRuleAction. Required for certain actionTypes.
    /// </summary>
    /// <value>The parameters for the CampaignRuleAction. Required for certain actionTypes.</value>
    [DataMember(Name = "parameters", EmitDefaultValue = false)]
    public CampaignRuleParameters Parameters { get; set; }





    /// <summary>
    /// The list of entities that this action will apply to.
    /// </summary>
    /// <value>The list of entities that this action will apply to.</value>
    [DataMember(Name = "campaignRuleActionEntities", EmitDefaultValue = false)]
    public CampaignRuleActionEntities CampaignRuleActionEntities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignRuleAction {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Parameters: ").Append(Parameters).Append("\n");
        sb.Append("  ActionType: ").Append(ActionType).Append("\n");
        sb.Append("  CampaignRuleActionEntities: ").Append(CampaignRuleActionEntities).Append("\n");
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
        return Equals(obj as CampaignRuleAction);
    }

    /// <summary>
    /// Returns true if CampaignRuleAction instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignRuleAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignRuleAction other)
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
                Parameters.Equals(other.Parameters)
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

            return hash;
        }
    }
}
