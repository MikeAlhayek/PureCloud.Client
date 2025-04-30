using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// the campaign/sequence entities that this action acts on
    /// </summary>
    [DataContract]
    public partial class DialerCampaignRuleConfigChangeCampaignRuleActionEntities :  IEquatable<DialerCampaignRuleConfigChangeCampaignRuleActionEntities>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerCampaignRuleConfigChangeCampaignRuleActionEntities" /> class.
        /// </summary>
        /// <param name="UseTriggeringEntity">Whether this action should act on the entity that triggered it.</param>
        /// <param name="AdditionalProperties">AdditionalProperties.</param>
        /// <param name="Campaigns">A list of campaignIds to act on.</param>
        /// <param name="Sequences">A list of sequenceIds to act on.</param>
        public DialerCampaignRuleConfigChangeCampaignRuleActionEntities(bool? UseTriggeringEntity = null, Dictionary<string, Object> AdditionalProperties = null, List<DialerCampaignRuleConfigChangeUriReference> Campaigns = null, List<DialerCampaignRuleConfigChangeUriReference> Sequences = null)
        {
            this.UseTriggeringEntity = UseTriggeringEntity;
            this.AdditionalProperties = AdditionalProperties;
            this.Campaigns = Campaigns;
            this.Sequences = Sequences;
            
        }
        


        /// <summary>
        /// Whether this action should act on the entity that triggered it
        /// </summary>
        /// <value>Whether this action should act on the entity that triggered it</value>
        [DataMember(Name="useTriggeringEntity", EmitDefaultValue=false)]
        public bool? UseTriggeringEntity { get; set; }



        /// <summary>
        /// Gets or Sets AdditionalProperties
        /// </summary>
        [DataMember(Name="additionalProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdditionalProperties { get; set; }



        /// <summary>
        /// A list of campaignIds to act on
        /// </summary>
        /// <value>A list of campaignIds to act on</value>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public List<DialerCampaignRuleConfigChangeUriReference> Campaigns { get; set; }



        /// <summary>
        /// A list of sequenceIds to act on
        /// </summary>
        /// <value>A list of sequenceIds to act on</value>
        [DataMember(Name="sequences", EmitDefaultValue=false)]
        public List<DialerCampaignRuleConfigChangeUriReference> Sequences { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerCampaignRuleConfigChangeCampaignRuleActionEntities {\n");

            sb.Append("  UseTriggeringEntity: ").Append(UseTriggeringEntity).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  Sequences: ").Append(Sequences).Append("\n");
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
            return this.Equals(obj as DialerCampaignRuleConfigChangeCampaignRuleActionEntities);
        }

        /// <summary>
        /// Returns true if DialerCampaignRuleConfigChangeCampaignRuleActionEntities instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerCampaignRuleConfigChangeCampaignRuleActionEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerCampaignRuleConfigChangeCampaignRuleActionEntities other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UseTriggeringEntity == other.UseTriggeringEntity ||
                    this.UseTriggeringEntity != null &&
                    this.UseTriggeringEntity.Equals(other.UseTriggeringEntity)
                ) &&
                (
                    this.AdditionalProperties == other.AdditionalProperties ||
                    this.AdditionalProperties != null &&
                    this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
                ) &&
                (
                    this.Campaigns == other.Campaigns ||
                    this.Campaigns != null &&
                    this.Campaigns.SequenceEqual(other.Campaigns)
                ) &&
                (
                    this.Sequences == other.Sequences ||
                    this.Sequences != null &&
                    this.Sequences.SequenceEqual(other.Sequences)
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
                if (this.UseTriggeringEntity != null)
                    hash = hash * 59 + this.UseTriggeringEntity.GetHashCode();

                if (this.AdditionalProperties != null)
                    hash = hash * 59 + this.AdditionalProperties.GetHashCode();

                if (this.Campaigns != null)
                    hash = hash * 59 + this.Campaigns.GetHashCode();

                if (this.Sequences != null)
                    hash = hash * 59 + this.Sequences.GetHashCode();

                return hash;
            }
        }
    }

}
